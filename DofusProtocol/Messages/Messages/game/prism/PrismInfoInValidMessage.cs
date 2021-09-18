// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismInfoInValidMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PrismInfoInValidMessage : Message
	{
		public const uint Id = 5859;
		public override uint MessageId
		{
			get
			{
				return 5859;
			}
		}
		
		public sbyte reason;
		
		public PrismInfoInValidMessage()
		{
		}
		
		public PrismInfoInValidMessage(sbyte reason)
		{
			this.reason = reason;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(reason);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			reason = reader.ReadSByte();
			if ( reason < 0 )
			{
				throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
			}
		}
	}
}
