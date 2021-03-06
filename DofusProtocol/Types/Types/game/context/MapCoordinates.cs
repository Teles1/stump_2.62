// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MapCoordinates.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class MapCoordinates
	{
		public const uint Id = 174;
		public virtual short TypeId
		{
			get
			{
				return 174;
			}
		}
		
		public short worldX;
		public short worldY;
		
		public MapCoordinates()
		{
		}
		
		public MapCoordinates(short worldX, short worldY)
		{
			this.worldX = worldX;
			this.worldY = worldY;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort(worldX);
			writer.WriteShort(worldY);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			worldX = reader.ReadShort();
			if ( worldX < -255 || worldX > 255 )
			{
				throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
			}
			worldY = reader.ReadShort();
			if ( worldY < -255 || worldY > 255 )
			{
				throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
			}
		}
	}
}
