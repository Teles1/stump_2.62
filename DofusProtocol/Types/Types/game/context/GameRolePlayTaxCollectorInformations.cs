// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayTaxCollectorInformations.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
	{
		public const uint Id = 148;
		public override short TypeId
		{
			get
			{
				return 148;
			}
		}
		
		public short firstNameId;
		public short lastNameId;
		public Types.GuildInformations guildIdentity;
		public byte guildLevel;
		public int taxCollectorAttack;
		
		public GameRolePlayTaxCollectorInformations()
		{
		}
		
		public GameRolePlayTaxCollectorInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, short firstNameId, short lastNameId, Types.GuildInformations guildIdentity, byte guildLevel, int taxCollectorAttack)
			 : base(contextualId, look, disposition)
		{
			this.firstNameId = firstNameId;
			this.lastNameId = lastNameId;
			this.guildIdentity = guildIdentity;
			this.guildLevel = guildLevel;
			this.taxCollectorAttack = taxCollectorAttack;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(firstNameId);
			writer.WriteShort(lastNameId);
			guildIdentity.Serialize(writer);
			writer.WriteByte(guildLevel);
			writer.WriteInt(taxCollectorAttack);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			firstNameId = reader.ReadShort();
			if ( firstNameId < 0 )
			{
				throw new Exception("Forbidden value on firstNameId = " + firstNameId + ", it doesn't respect the following condition : firstNameId < 0");
			}
			lastNameId = reader.ReadShort();
			if ( lastNameId < 0 )
			{
				throw new Exception("Forbidden value on lastNameId = " + lastNameId + ", it doesn't respect the following condition : lastNameId < 0");
			}
			guildIdentity = new Types.GuildInformations();
			guildIdentity.Deserialize(reader);
			guildLevel = reader.ReadByte();
			if ( guildLevel < 0 || guildLevel > 255 )
			{
				throw new Exception("Forbidden value on guildLevel = " + guildLevel + ", it doesn't respect the following condition : guildLevel < 0 || guildLevel > 255");
			}
			taxCollectorAttack = reader.ReadInt();
		}
	}
}
