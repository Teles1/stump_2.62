// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightFighterNamedInformations.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class GameFightFighterNamedInformations : GameFightFighterInformations
	{
		public const uint Id = 158;
		public override short TypeId
		{
			get
			{
				return 158;
			}
		}
		
		public string name;
		
		public GameFightFighterNamedInformations()
		{
		}
		
		public GameFightFighterNamedInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, bool alive, Types.GameFightMinimalStats stats, string name)
			 : base(contextualId, look, disposition, teamId, alive, stats)
		{
			this.name = name;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(name);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			name = reader.ReadUTF();
		}
	}
}
