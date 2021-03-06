// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeSellMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeSellMessage : Message
	{
		public const uint Id = 5778;
		public override uint MessageId
		{
			get
			{
				return 5778;
			}
		}
		
		public int objectToSellId;
		public int quantity;
		
		public ExchangeSellMessage()
		{
		}
		
		public ExchangeSellMessage(int objectToSellId, int quantity)
		{
			this.objectToSellId = objectToSellId;
			this.quantity = quantity;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectToSellId);
			writer.WriteInt(quantity);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectToSellId = reader.ReadInt();
			if ( objectToSellId < 0 )
			{
				throw new Exception("Forbidden value on objectToSellId = " + objectToSellId + ", it doesn't respect the following condition : objectToSellId < 0");
			}
			quantity = reader.ReadInt();
			if ( quantity < 0 )
			{
				throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
			}
		}
	}
}
