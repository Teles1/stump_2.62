// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'StorageObjectsUpdateMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class StorageObjectsUpdateMessage : Message
	{
		public const uint Id = 6036;
		public override uint MessageId
		{
			get
			{
				return 6036;
			}
		}
		
		public IEnumerable<Types.ObjectItem> objectList;
		
		public StorageObjectsUpdateMessage()
		{
		}
		
		public StorageObjectsUpdateMessage(IEnumerable<Types.ObjectItem> objectList)
		{
			this.objectList = objectList;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)objectList.Count());
			foreach (var entry in objectList)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			objectList = new Types.ObjectItem[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectList as Types.ObjectItem[])[i] = new Types.ObjectItem();
				(objectList as Types.ObjectItem[])[i].Deserialize(reader);
			}
		}
	}
}
