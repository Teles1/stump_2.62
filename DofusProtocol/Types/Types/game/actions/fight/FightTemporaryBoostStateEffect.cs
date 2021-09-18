// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FightTemporaryBoostStateEffect.xml' the '04/04/2012 14:27:36'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
	{
		public const uint Id = 214;
		public override short TypeId
		{
			get
			{
				return 214;
			}
		}
		
		public short stateId;
		
		public FightTemporaryBoostStateEffect()
		{
		}
		
		public FightTemporaryBoostStateEffect(int uid, int targetId, short turnDuration, sbyte dispelable, short spellId, int parentBoostUid, short delta, short stateId)
			 : base(uid, targetId, turnDuration, dispelable, spellId, parentBoostUid, delta)
		{
			this.stateId = stateId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(stateId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			stateId = reader.ReadShort();
		}
	}
}