// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'NpcDialogCreationMessage.xml' the '04/04/2012 14:27:28'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class NpcDialogCreationMessage : Message
	{
		public const uint Id = 5618;
		public override uint MessageId
		{
			get
			{
				return 5618;
			}
		}
		
		public int mapId;
		public int npcId;
		
		public NpcDialogCreationMessage()
		{
		}
		
		public NpcDialogCreationMessage(int mapId, int npcId)
		{
			this.mapId = mapId;
			this.npcId = npcId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(mapId);
			writer.WriteInt(npcId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mapId = reader.ReadInt();
			npcId = reader.ReadInt();
		}
	}
}
