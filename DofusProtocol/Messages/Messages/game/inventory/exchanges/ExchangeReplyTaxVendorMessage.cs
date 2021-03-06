// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeReplyTaxVendorMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeReplyTaxVendorMessage : Message
	{
		public const uint Id = 5787;
		public override uint MessageId
		{
			get
			{
				return 5787;
			}
		}
		
		public int objectValue;
		public int totalTaxValue;
		
		public ExchangeReplyTaxVendorMessage()
		{
		}
		
		public ExchangeReplyTaxVendorMessage(int objectValue, int totalTaxValue)
		{
			this.objectValue = objectValue;
			this.totalTaxValue = totalTaxValue;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectValue);
			writer.WriteInt(totalTaxValue);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectValue = reader.ReadInt();
			if ( objectValue < 0 )
			{
				throw new Exception("Forbidden value on objectValue = " + objectValue + ", it doesn't respect the following condition : objectValue < 0");
			}
			totalTaxValue = reader.ReadInt();
			if ( totalTaxValue < 0 )
			{
				throw new Exception("Forbidden value on totalTaxValue = " + totalTaxValue + ", it doesn't respect the following condition : totalTaxValue < 0");
			}
		}
	}
}
