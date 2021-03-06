// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightTurnListMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class GameFightTurnListMessage : Message
	{
		public const uint Id = 713;
		public override uint MessageId
		{
			get
			{
				return 713;
			}
		}
		
		public IEnumerable<int> ids;
		public IEnumerable<int> deadsIds;
		
		public GameFightTurnListMessage()
		{
		}
		
		public GameFightTurnListMessage(IEnumerable<int> ids, IEnumerable<int> deadsIds)
		{
			this.ids = ids;
			this.deadsIds = deadsIds;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)ids.Count());
			foreach (var entry in ids)
			{
				writer.WriteInt(entry);
			}
			writer.WriteUShort((ushort)deadsIds.Count());
			foreach (var entry in deadsIds)
			{
				writer.WriteInt(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			ids = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(ids as int[])[i] = reader.ReadInt();
			}
			limit = reader.ReadUShort();
			deadsIds = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(deadsIds as int[])[i] = reader.ReadInt();
			}
		}
	}
}
