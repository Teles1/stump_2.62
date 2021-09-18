using System;
using System.Collections.Generic;

namespace Stump.DofusProtocol.D2oClasses
{
	[D2OClass("Monsters")]
	[Serializable]
	public class Monster
	{
		private const String MODULE = "Monsters";
		public int id;
		public uint nameId;
		public uint gfxId;
		public int race;
		public List<MonsterGrade> grades;
		public String look;
		public Boolean useSummonSlot;
		public Boolean useBombSlot;
		public Boolean canPlay;
		public Boolean canTackle;
		public List<AnimFunMonsterData> animFunList;
		public Boolean isBoss;
	}
}
