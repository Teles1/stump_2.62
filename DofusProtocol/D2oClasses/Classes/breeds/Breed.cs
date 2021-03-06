using System;
using System.Collections.Generic;

namespace Stump.DofusProtocol.D2oClasses
{
	[D2OClass("Breeds")]
	[Serializable]
	public class Breed
	{
		private const String MODULE = "Breeds";
		public int id;
		public uint shortNameId;
		public uint longNameId;
		public uint descriptionId;
		public uint gameplayDescriptionId;
		public String maleLook;
		public String femaleLook;
		public uint creatureBonesId;
		public int maleArtwork;
		public int femaleArtwork;
		public List<List<uint>> statsPointsForStrength;
		public List<List<uint>> statsPointsForIntelligence;
		public List<List<uint>> statsPointsForChance;
		public List<List<uint>> statsPointsForAgility;
		public List<List<uint>> statsPointsForVitality;
		public List<List<uint>> statsPointsForWisdom;
		public List<uint> breedSpellsId;
		public List<uint> maleColors;
		public List<uint> femaleColors;
		public List<uint> alternativeMaleSkin;
		public List<uint> alternativeFemaleSkin;
	}
}
