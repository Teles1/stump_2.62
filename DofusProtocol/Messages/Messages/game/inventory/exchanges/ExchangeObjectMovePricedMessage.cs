// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeObjectMovePricedMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage
	{
		public const uint Id = 5514;
		public override uint MessageId
		{
			get
			{
				return 5514;
			}
		}
		
		public int price;
		
		public ExchangeObjectMovePricedMessage()
		{
		}
		
		public ExchangeObjectMovePricedMessage(int objectUID, int quantity, int price)
			 : base(objectUID, quantity)
		{
			this.price = price;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(price);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			price = reader.ReadInt();
		}
	}
}
