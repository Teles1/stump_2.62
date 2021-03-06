// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'TaxCollectorFightersInformation.xml' the '04/04/2012 14:27:38'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Types
{
	public class TaxCollectorFightersInformation
	{
		public const uint Id = 169;
		public virtual short TypeId
		{
			get
			{
				return 169;
			}
		}
		
		public int collectorId;
		public IEnumerable<Types.CharacterMinimalPlusLookInformations> allyCharactersInformations;
		public IEnumerable<Types.CharacterMinimalPlusLookInformations> enemyCharactersInformations;
		
		public TaxCollectorFightersInformation()
		{
		}
		
		public TaxCollectorFightersInformation(int collectorId, IEnumerable<Types.CharacterMinimalPlusLookInformations> allyCharactersInformations, IEnumerable<Types.CharacterMinimalPlusLookInformations> enemyCharactersInformations)
		{
			this.collectorId = collectorId;
			this.allyCharactersInformations = allyCharactersInformations;
			this.enemyCharactersInformations = enemyCharactersInformations;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(collectorId);
			writer.WriteUShort((ushort)allyCharactersInformations.Count());
			foreach (var entry in allyCharactersInformations)
			{
				entry.Serialize(writer);
			}
			writer.WriteUShort((ushort)enemyCharactersInformations.Count());
			foreach (var entry in enemyCharactersInformations)
			{
				entry.Serialize(writer);
			}
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			collectorId = reader.ReadInt();
			int limit = reader.ReadUShort();
			allyCharactersInformations = new Types.CharacterMinimalPlusLookInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(allyCharactersInformations as CharacterMinimalPlusLookInformations[])[i] = new Types.CharacterMinimalPlusLookInformations();
				(allyCharactersInformations as Types.CharacterMinimalPlusLookInformations[])[i].Deserialize(reader);
			}
			limit = reader.ReadUShort();
			enemyCharactersInformations = new Types.CharacterMinimalPlusLookInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(enemyCharactersInformations as CharacterMinimalPlusLookInformations[])[i] = new Types.CharacterMinimalPlusLookInformations();
				(enemyCharactersInformations as Types.CharacterMinimalPlusLookInformations[])[i].Deserialize(reader);
			}
		}
	}
}
