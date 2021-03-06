// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeShopStockMultiMovementUpdatedMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeShopStockMultiMovementUpdatedMessage : Message
	{
		public const uint Id = 6038;
		public override uint MessageId
		{
			get
			{
				return 6038;
			}
		}
		
		public IEnumerable<Types.ObjectItemToSell> objectInfoList;
		
		public ExchangeShopStockMultiMovementUpdatedMessage()
		{
		}
		
		public ExchangeShopStockMultiMovementUpdatedMessage(IEnumerable<Types.ObjectItemToSell> objectInfoList)
		{
			this.objectInfoList = objectInfoList;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)objectInfoList.Count());
			foreach (var entry in objectInfoList)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			objectInfoList = new Types.ObjectItemToSell[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectInfoList as Types.ObjectItemToSell[])[i] = new Types.ObjectItemToSell();
				(objectInfoList as Types.ObjectItemToSell[])[i].Deserialize(reader);
			}
		}
	}
}
