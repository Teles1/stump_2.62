// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightResumeMessage.xml' the '04/04/2012 14:27:23'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class GameFightResumeMessage : GameFightSpectateMessage
	{
		public const uint Id = 6067;
		public override uint MessageId
		{
			get
			{
				return 6067;
			}
		}
		
		public IEnumerable<Types.GameFightSpellCooldown> spellCooldowns;
		public sbyte summonCount;
		public sbyte bombCount;
		
		public GameFightResumeMessage()
		{
		}
		
		public GameFightResumeMessage(IEnumerable<Types.FightDispellableEffectExtendedInformations> effects, IEnumerable<Types.GameActionMark> marks, short gameTurn, IEnumerable<Types.GameFightSpellCooldown> spellCooldowns, sbyte summonCount, sbyte bombCount)
			 : base(effects, marks, gameTurn)
		{
			this.spellCooldowns = spellCooldowns;
			this.summonCount = summonCount;
			this.bombCount = bombCount;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUShort((ushort)spellCooldowns.Count());
			foreach (var entry in spellCooldowns)
			{
				entry.Serialize(writer);
			}
			writer.WriteSByte(summonCount);
			writer.WriteSByte(bombCount);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			int limit = reader.ReadUShort();
			spellCooldowns = new Types.GameFightSpellCooldown[limit];
			for (int i = 0; i < limit; i++)
			{
				(spellCooldowns as Types.GameFightSpellCooldown[])[i] = new Types.GameFightSpellCooldown();
				(spellCooldowns as Types.GameFightSpellCooldown[])[i].Deserialize(reader);
			}
			summonCount = reader.ReadSByte();
			if ( summonCount < 0 )
			{
				throw new Exception("Forbidden value on summonCount = " + summonCount + ", it doesn't respect the following condition : summonCount < 0");
			}
			bombCount = reader.ReadSByte();
			if ( bombCount < 0 )
			{
				throw new Exception("Forbidden value on bombCount = " + bombCount + ", it doesn't respect the following condition : bombCount < 0");
			}
		}
	}
}