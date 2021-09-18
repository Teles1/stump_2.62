// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'JobCrafterDirectoryEntryPlayerInfo.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class JobCrafterDirectoryEntryPlayerInfo
	{
		public const uint Id = 194;
		public virtual short TypeId
		{
			get
			{
				return 194;
			}
		}
		
		public int playerId;
		public string playerName;
		public sbyte alignmentSide;
		public sbyte breed;
		public bool sex;
		public bool isInWorkshop;
		public short worldX;
		public short worldY;
		public int mapId;
		public short subAreaId;
		
		public JobCrafterDirectoryEntryPlayerInfo()
		{
		}
		
		public JobCrafterDirectoryEntryPlayerInfo(int playerId, string playerName, sbyte alignmentSide, sbyte breed, bool sex, bool isInWorkshop, short worldX, short worldY, int mapId, short subAreaId)
		{
			this.playerId = playerId;
			this.playerName = playerName;
			this.alignmentSide = alignmentSide;
			this.breed = breed;
			this.sex = sex;
			this.isInWorkshop = isInWorkshop;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(playerId);
			writer.WriteUTF(playerName);
			writer.WriteSByte(alignmentSide);
			writer.WriteSByte(breed);
			writer.WriteBoolean(sex);
			writer.WriteBoolean(isInWorkshop);
			writer.WriteShort(worldX);
			writer.WriteShort(worldY);
			writer.WriteInt(mapId);
			writer.WriteShort(subAreaId);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			playerId = reader.ReadInt();
			if ( playerId < 0 )
			{
				throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
			}
			playerName = reader.ReadUTF();
			alignmentSide = reader.ReadSByte();
			breed = reader.ReadSByte();
			if ( breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Zobal )
			{
				throw new Exception("Forbidden value on breed = " + breed + ", it doesn't respect the following condition : breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Zobal");
			}
			sex = reader.ReadBoolean();
			isInWorkshop = reader.ReadBoolean();
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