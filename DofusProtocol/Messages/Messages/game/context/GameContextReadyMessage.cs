// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameContextReadyMessage.xml' the '04/04/2012 14:27:23'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameContextReadyMessage : Message
	{
		public const uint Id = 6071;
		public override uint MessageId
		{
			get
			{
				return 6071;
			}
		}
		
		public int mapId;
		
		public GameContextReadyMessage()
		{
		}
		
		public GameContextReadyMessage(int mapId)
		{
			this.mapId = mapId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(mapId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mapId = reader.ReadInt();
			if ( mapId < 0 )
			{
				throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
			}
		}
	}
}
