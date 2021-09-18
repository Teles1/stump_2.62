// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectsDeletedMessage.xml' the '04/04/2012 14:27:34'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class ObjectsDeletedMessage : Message
	{
		public const uint Id = 6034;
		public override uint MessageId
		{
			get
			{
				return 6034;
			}
		}
		
		public IEnumerable<int> objectUID;
		
		public ObjectsDeletedMessage()
		{
		}
		
		public ObjectsDeletedMessage(IEnumerable<int> objectUID)
		{
			this.objectUID = objectUID;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)objectUID.Count());
			foreach (var entry in objectUID)
			{
				writer.WriteInt(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			objectUID = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectUID as int[])[i] = reader.ReadInt();
			}
		}
	}
}