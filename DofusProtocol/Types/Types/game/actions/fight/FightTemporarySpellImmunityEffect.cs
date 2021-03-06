// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FightTemporarySpellImmunityEffect.xml' the '04/04/2012 14:27:36'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class FightTemporarySpellImmunityEffect : AbstractFightDispellableEffect
	{
		public const uint Id = 366;
		public override short TypeId
		{
			get
			{
				return 366;
			}
		}
		
		public int immuneSpellId;
		
		public FightTemporarySpellImmunityEffect()
		{
		}
		
		public FightTemporarySpellImmunityEffect(int uid, int targetId, short turnDuration, sbyte dispelable, short spellId, int parentBoostUid, int immuneSpellId)
			 : base(uid, targetId, turnDuration, dispelable, spellId, parentBoostUid)
		{
			this.immuneSpellId = immuneSpellId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(immuneSpellId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			immuneSpellId = reader.ReadInt();
		}
	}
}
