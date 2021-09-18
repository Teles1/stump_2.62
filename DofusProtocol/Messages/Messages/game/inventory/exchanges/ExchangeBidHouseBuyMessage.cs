// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeBidHouseBuyMessage.xml' the '04/04/2012 14:27:32'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeBidHouseBuyMessage : Message
	{
		public const uint Id = 5804;
		public override uint MessageId
		{
			get
			{
				return 5804;
			}
		}
		
		public int uid;
		public int qty;
		public int price;
		
		public ExchangeBidHouseBuyMessage()
		{
		}
		
		public ExchangeBidHouseBuyMessage(int uid, int qty, int price)
		{
			this.uid = uid;
			this.qty = qty;
			this.price = price;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(uid);
			writer.WriteInt(qty);
			writer.WriteInt(price);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			uid = reader.ReadInt();
			if ( uid < 0 )
			{
				throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
			}
			qty = reader.ReadInt();
			if ( qty < 0 )
			{
				throw new Exception("Forbidden value on qty = " + qty + ", it doesn't respect the following condition : qty < 0");
			}
			price = reader.ReadInt();
			if ( price < 0 )
			{
				throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
			}
		}
	}
}
