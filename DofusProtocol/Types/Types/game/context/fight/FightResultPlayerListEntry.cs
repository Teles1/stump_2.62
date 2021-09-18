// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FightResultPlayerListEntry.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Types
{
	public class FightResultPlayerListEntry : FightResultFighterListEntry
	{
		public const uint Id = 24;
		public override short TypeId
		{
			get
			{
				return 24;
			}
		}
		
		public byte level;
		public IEnumerable<Types.FightResultAdditionalData> additional;
		
		public FightResultPlayerListEntry()
		{
		}
		
		public FightResultPlayerListEntry(short outcome, Types.FightLoot rewards, int id, bool alive, byte level, IEnumerable<Types.FightResultAdditionalData> additional)
			 : base(outcome, rewards, id, alive)
		{
			this.level = level;
			this.additional = additional;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteByte(level);
			writer.WriteUShort((ushort)additional.Count());
			foreach (var entry in additional)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			level = reader.ReadByte();
			if ( level < 1 || level > 200 )
			{
				throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : level < 1 || level > 200");
			}
			int limit = reader.ReadUShort();
			additional = new Types.FightResultAdditionalData[limit];
			for (int i = 0; i < limit; i++)
			{
				(additional as Types.FightResultAdditionalData[])[i] = ProtocolTypeManager.GetInstance<Types.FightResultAdditionalData>(reader.ReadShort());
				(additional as Types.FightResultAdditionalData[])[i].Deserialize(reader);
			}
		}
	}
}
