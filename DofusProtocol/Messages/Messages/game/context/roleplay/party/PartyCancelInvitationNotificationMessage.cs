// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PartyCancelInvitationNotificationMessage.xml' the '04/04/2012 14:27:28'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
	{
		public const uint Id = 6251;
		public override uint MessageId
		{
			get
			{
				return 6251;
			}
		}
		
		public int cancelerId;
		public int guestId;
		
		public PartyCancelInvitationNotificationMessage()
		{
		}
		
		public PartyCancelInvitationNotificationMessage(int partyId, int cancelerId, int guestId)
			 : base(partyId)
		{
			this.cancelerId = cancelerId;
			this.guestId = guestId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(cancelerId);
			writer.WriteInt(guestId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			cancelerId = reader.ReadInt();
			if ( cancelerId < 0 )
			{
				throw new Exception("Forbidden value on cancelerId = " + cancelerId + ", it doesn't respect the following condition : cancelerId < 0");
			}
			guestId = reader.ReadInt();
			if ( guestId < 0 )
			{
				throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
			}
		}
	}
}
