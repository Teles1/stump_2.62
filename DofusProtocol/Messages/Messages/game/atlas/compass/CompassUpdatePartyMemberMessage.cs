// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CompassUpdatePartyMemberMessage.xml' the '04/04/2012 14:27:21'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
	{
		public const uint Id = 5589;
		public override uint MessageId
		{
			get
			{
				return 5589;
			}
		}
		
		public int memberId;
		
		public CompassUpdatePartyMemberMessage()
		{
		}
		
		public CompassUpdatePartyMemberMessage(sbyte type, short worldX, short worldY, int memberId)
			 : base(type, worldX, worldY)
		{
			this.memberId = memberId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(memberId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			memberId = reader.ReadInt();
			if ( memberId < 0 )
			{
				throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0");
			}
		}
	}
}
