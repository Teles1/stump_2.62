// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayNpcInformations.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class GameRolePlayNpcInformations : GameRolePlayActorInformations
	{
		public const uint Id = 156;
		public override short TypeId
		{
			get
			{
				return 156;
			}
		}
		
		public short npcId;
		public bool sex;
		public short specialArtworkId;
		
		public GameRolePlayNpcInformations()
		{
		}
		
		public GameRolePlayNpcInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, short npcId, bool sex, short specialArtworkId)
			 : base(contextualId, look, disposition)
		{
			this.npcId = npcId;
			this.sex = sex;
			this.specialArtworkId = specialArtworkId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(npcId);
			writer.WriteBoolean(sex);
			writer.WriteShort(specialArtworkId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			npcId = reader.ReadShort();
			if ( npcId < 0 )
			{
				throw new Exception("Forbidden value on npcId = " + npcId + ", it doesn't respect the following condition : npcId < 0");
			}
			sex = reader.ReadBoolean();
			specialArtworkId = reader.ReadShort();
			if ( specialArtworkId < 0 )
			{
				throw new Exception("Forbidden value on specialArtworkId = " + specialArtworkId + ", it doesn't respect the following condition : specialArtworkId < 0");
			}
		}
	}
}
