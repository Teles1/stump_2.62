// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightMutantInformations.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class GameFightMutantInformations : GameFightFighterNamedInformations
	{
		public const uint Id = 50;
		public override short TypeId
		{
			get
			{
				return 50;
			}
		}
		
		public sbyte powerLevel;
		
		public GameFightMutantInformations()
		{
		}
		
		public GameFightMutantInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, bool alive, Types.GameFightMinimalStats stats, string name, sbyte powerLevel)
			 : base(contextualId, look, disposition, teamId, alive, stats, name)
		{
			this.powerLevel = powerLevel;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(powerLevel);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			powerLevel = reader.ReadSByte();
			if ( powerLevel < 0 )
			{
				throw new Exception("Forbidden value on powerLevel = " + powerLevel + ", it doesn't respect the following condition : powerLevel < 0");
			}
		}
	}
}
