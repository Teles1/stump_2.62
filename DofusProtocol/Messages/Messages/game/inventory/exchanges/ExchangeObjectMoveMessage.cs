// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeObjectMoveMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeObjectMoveMessage : Message
	{
		public const uint Id = 5518;
		public override uint MessageId
		{
			get
			{
				return 5518;
			}
		}
		
		public int objectUID;
		public int quantity;
		
		public ExchangeObjectMoveMessage()
		{
		}
		
		public ExchangeObjectMoveMessage(int objectUID, int quantity)
		{
			this.objectUID = objectUID;
			this.quantity = quantity;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectUID);
			writer.WriteInt(quantity);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectUID = reader.ReadInt();
			if ( objectUID < 0 )
			{
				throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
			}
			quantity = reader.ReadInt();
		}
	}
}