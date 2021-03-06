// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PartyInvitationDetailsMessage.xml' the '04/04/2012 14:27:29'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class PartyInvitationDetailsMessage : AbstractPartyMessage
	{
		public const uint Id = 6263;
		public override uint MessageId
		{
			get
			{
				return 6263;
			}
		}
		
		public sbyte partyType;
		public int fromId;
		public string fromName;
		public int leaderId;
		public IEnumerable<Types.PartyInvitationMemberInformations> members;
		
		public PartyInvitationDetailsMessage()
		{
		}
		
		public PartyInvitationDetailsMessage(int partyId, sbyte partyType, int fromId, string fromName, int leaderId, IEnumerable<Types.PartyInvitationMemberInformations> members)
			 : base(partyId)
		{
			this.partyType = partyType;
			this.fromId = fromId;
			this.fromName = fromName;
			this.leaderId = leaderId;
			this.members = members;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(partyType);
			writer.WriteInt(fromId);
			writer.WriteUTF(fromName);
			writer.WriteInt(leaderId);
			writer.WriteUShort((ushort)members.Count());
			foreach (var entry in members)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			partyType = reader.ReadSByte();
			if ( partyType < 0 )
			{
				throw new Exception("Forbidden value on partyType = " + partyType + ", it doesn't respect the following condition : partyType < 0");
			}
			fromId = reader.ReadInt();
			if ( fromId < 0 )
			{
				throw new Exception("Forbidden value on fromId = " + fromId + ", it doesn't respect the following condition : fromId < 0");
			}
			fromName = reader.ReadUTF();
			leaderId = reader.ReadInt();
			if ( leaderId < 0 )
			{
				throw new Exception("Forbidden value on leaderId = " + leaderId + ", it doesn't respect the following condition : leaderId < 0");
			}
			int limit = reader.ReadUShort();
			members = new Types.PartyInvitationMemberInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(members as Types.PartyInvitationMemberInformations[])[i] = new Types.PartyInvitationMemberInformations();
				(members as Types.PartyInvitationMemberInformations[])[i].Deserialize(reader);
			}
		}
	}
}
