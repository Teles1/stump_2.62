// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PartyJoinMessage.xml' the '04/04/2012 14:27:29'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class PartyJoinMessage : AbstractPartyMessage
	{
		public const uint Id = 5576;
		public override uint MessageId
		{
			get
			{
				return 5576;
			}
		}
		
		public sbyte partyType;
		public int partyLeaderId;
		public sbyte maxParticipants;
		public IEnumerable<Types.PartyMemberInformations> members;
		public IEnumerable<Types.PartyGuestInformations> guests;
		public bool restricted;
		
		public PartyJoinMessage()
		{
		}
		
		public PartyJoinMessage(int partyId, sbyte partyType, int partyLeaderId, sbyte maxParticipants, IEnumerable<Types.PartyMemberInformations> members, IEnumerable<Types.PartyGuestInformations> guests, bool restricted)
			 : base(partyId)
		{
			this.partyType = partyType;
			this.partyLeaderId = partyLeaderId;
			this.maxParticipants = maxParticipants;
			this.members = members;
			this.guests = guests;
			this.restricted = restricted;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(partyType);
			writer.WriteInt(partyLeaderId);
			writer.WriteSByte(maxParticipants);
			writer.WriteUShort((ushort)members.Count());
			foreach (var entry in members)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
			writer.WriteUShort((ushort)guests.Count());
			foreach (var entry in guests)
			{
				entry.Serialize(writer);
			}
			writer.WriteBoolean(restricted);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			partyType = reader.ReadSByte();
			if ( partyType < 0 )
			{
				throw new Exception("Forbidden value on partyType = " + partyType + ", it doesn't respect the following condition : partyType < 0");
			}
			partyLeaderId = reader.ReadInt();
			if ( partyLeaderId < 0 )
			{
				throw new Exception("Forbidden value on partyLeaderId = " + partyLeaderId + ", it doesn't respect the following condition : partyLeaderId < 0");
			}
			maxParticipants = reader.ReadSByte();
			if ( maxParticipants < 0 )
			{
				throw new Exception("Forbidden value on maxParticipants = " + maxParticipants + ", it doesn't respect the following condition : maxParticipants < 0");
			}
			int limit = reader.ReadUShort();
			members = new Types.PartyMemberInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(members as Types.PartyMemberInformations[])[i] = Types.ProtocolTypeManager.GetInstance<Types.PartyMemberInformations>(reader.ReadShort());
				(members as Types.PartyMemberInformations[])[i].Deserialize(reader);
			}
			limit = reader.ReadUShort();
			guests = new Types.PartyGuestInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(guests as Types.PartyGuestInformations[])[i] = new Types.PartyGuestInformations();
				(guests as Types.PartyGuestInformations[])[i].Deserialize(reader);
			}
			restricted = reader.ReadBoolean();
		}
	}
}
