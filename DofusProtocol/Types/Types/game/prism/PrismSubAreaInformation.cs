// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismSubAreaInformation.xml' the '04/04/2012 14:27:39'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class PrismSubAreaInformation
	{
		public const uint Id = 142;
		public virtual short TypeId
		{
			get
			{
				return 142;
			}
		}
		
		public short worldX;
		public short worldY;
		public int mapId;
		public short subAreaId;
		public sbyte alignment;
		public bool isInFight;
		public bool isFightable;
		
		public PrismSubAreaInformation()
		{
		}
		
		public PrismSubAreaInformation(short worldX, short worldY, int mapId, short subAreaId, sbyte alignment, bool isInFight, bool isFightable)
		{
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
			this.alignment = alignment;
			this.isInFight = isInFight;
			this.isFightable = isFightable;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort(worldX);
			writer.WriteShort(worldY);
			writer.WriteInt(mapId);
			writer.WriteShort(subAreaId);
			writer.WriteSByte(alignment);
			writer.WriteBoolean(isInFight);
			writer.WriteBoolean(isFightable);
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
			mapId = reader.ReadInt();
			subAreaId = reader.ReadShort();
			if ( subAreaId < 0 )
			{
				throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
			}
			alignment = reader.ReadSByte();
			if ( alignment < 0 )
			{
				throw new Exception("Forbidden value on alignment = " + alignment + ", it doesn't respect the following condition : alignment < 0");
			}
			isInFight = reader.ReadBoolean();
			isFightable = reader.ReadBoolean();
		}
	}
}
