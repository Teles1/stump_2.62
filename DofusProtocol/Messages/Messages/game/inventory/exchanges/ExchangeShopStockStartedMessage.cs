// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeShopStockStartedMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeShopStockStartedMessage : Message
	{
		public const uint Id = 5910;
		public override uint MessageId
		{
			get
			{
				return 5910;
			}
		}
		
		public IEnumerable<Types.ObjectItemToSell> objectsInfos;
		
		public ExchangeShopStockStartedMessage()
		{
		}
		
		public ExchangeShopStockStartedMessage(IEnumerable<Types.ObjectItemToSell> objectsInfos)
		{
			this.objectsInfos = objectsInfos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)objectsInfos.Count());
			foreach (var entry in objectsInfos)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			objectsInfos = new Types.ObjectItemToSell[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectsInfos as Types.ObjectItemToSell[])[i] = new Types.ObjectItemToSell();
				(objectsInfos as Types.ObjectItemToSell[])[i].Deserialize(reader);
			}
		}
	}
}
