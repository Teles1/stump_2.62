// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeBuyMessage.xml' the '04/04/2012 14:27:32'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeBuyMessage : Message
	{
		public const uint Id = 5774;
		public override uint MessageId
		{
			get
			{
				return 5774;
			}
		}
		
		public int objectToBuyId;
		public int quantity;
		
		public ExchangeBuyMessage()
		{
		}
		
		public ExchangeBuyMessage(int objectToBuyId, int quantity)
		{
			this.objectToBuyId = objectToBuyId;
			this.quantity = quantity;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectToBuyId);
			writer.WriteInt(quantity);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectToBuyId = reader.ReadInt();
			if ( objectToBuyId < 0 )
			{
				throw new Exception("Forbidden value on objectToBuyId = " + objectToBuyId + ", it doesn't respect the following condition : objectToBuyId < 0");
			}
			quantity = reader.ReadInt();
			if ( quantity < 0 )
			{
				throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
			}
		}
	}
}
