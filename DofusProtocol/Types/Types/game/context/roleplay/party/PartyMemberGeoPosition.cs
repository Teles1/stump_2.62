// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PartyMemberGeoPosition.xml' the '04/04/2012 14:27:38'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class PartyMemberGeoPosition
	{
		public const uint Id = 378;
		public virtual short TypeId
		{
			get
			{
				return 378;
			}
		}
		
		public int memberId;
		public short worldX;
		public short worldY;
		public int mapId;
		public short subAreaId;
		
		public PartyMemberGeoPosition()
		{
		}
		
		public PartyMemberGeoPosition(int memberId, short worldX, short worldY, int mapId, short subAreaId)
		{
			this.memberId = memberId;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(memberId);
			writer.WriteShort(worldX);
			writer.WriteShort(worldY);
			writer.WriteInt(mapId);
			writer.WriteShort(subAreaId);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			memberId = reader.ReadInt();
			if ( memberId < 0 )
			{
				throw new Exception("Forbidden value on memberId = " + memberId + ", it doesn't respect the following condition : memberId < 0");
			}
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
		}
	}
}
