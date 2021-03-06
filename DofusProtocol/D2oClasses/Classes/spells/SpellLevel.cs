using System;
using System.Collections.Generic;

namespace Stump.DofusProtocol.D2oClasses
{
	[D2OClass("SpellLevels")]
	[Serializable]
	public class SpellLevel
	{
		private const String MODULE = "SpellLevels";
		public uint id;
		public uint spellId;
		public uint spellBreed;
		public uint apCost;
		public uint minRange;
		public uint range;
		public Boolean castInLine;
		public Boolean castInDiagonal;
		public Boolean castTestLos;
		public uint criticalHitProbability;
		public uint criticalFailureProbability;
		public Boolean needFreeCell;
		public Boolean needTakenCell;
		public Boolean needFreeTrapCell;
		public Boolean rangeCanBeBoosted;
		public int maxStack;
		public uint maxCastPerTurn;
		public uint maxCastPerTarget;
		public uint minCastInterval;
		public uint initialCooldown;
		public int globalCooldown;
		public uint minPlayerLevel;
		public Boolean criticalFailureEndsTurn;
		public Boolean hideEffects;
		public Boolean hidden;
		public List<int> statesRequired;
		public List<int> statesForbidden;
		public List<EffectInstanceDice> effects;
		public List<EffectInstanceDice> criticalEffect;
	}
}
