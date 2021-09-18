// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'StorageObjectsRemoveMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class StorageObjectsRemoveMessage : Message
	{
		public const uint Id = 6035;
		public override uint MessageId
		{
			get
			{
				return 6035;
			}
		}
		
		public IEnumerable<int> objectUIDList;
		
		public StorageObjectsRemoveMessage()
		{
		}
		
		public StorageObjectsRemoveMessage(IEnumerable<int> objectUIDList)
		{
			this.objectUIDList = objectUIDList;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)objectUIDList.Count());
			foreach (var entry in objectUIDList)
			{
				writer.WriteInt(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			objectUIDList = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectUIDList as int[])[i] = reader.ReadInt();
			}
		}
	}
}
