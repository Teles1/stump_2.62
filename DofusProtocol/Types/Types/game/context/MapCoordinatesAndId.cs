// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MapCoordinatesAndId.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class MapCoordinatesAndId : MapCoordinates
	{
		public const uint Id = 392;
		public override short TypeId
		{
			get
			{
				return 392;
			}
		}
		
		public int mapId;
		
		public MapCoordinatesAndId()
		{
		}
		
		public MapCoordinatesAndId(short worldX, short worldY, int mapId)
			 : base(worldX, worldY)
		{
			this.mapId = mapId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(mapId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			mapId = reader.ReadInt();
		}
	}
}
