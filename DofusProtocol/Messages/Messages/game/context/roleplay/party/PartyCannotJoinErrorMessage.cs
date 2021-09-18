// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PartyCannotJoinErrorMessage.xml' the '04/04/2012 14:27:28'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PartyCannotJoinErrorMessage : AbstractPartyMessage
	{
		public const uint Id = 5583;
		public override uint MessageId
		{
			get
			{
				return 5583;
			}
		}
		
		public sbyte reason;
		
		public PartyCannotJoinErrorMessage()
		{
		}
		
		public PartyCannotJoinErrorMessage(int partyId, sbyte reason)
			 : base(partyId)
		{
			this.reason = reason;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(reason);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			reason = reader.ReadSByte();
			if ( reason < 0 )
			{
				throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
			}
		}
	}
}