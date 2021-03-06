// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightUpdateTeamMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameFightUpdateTeamMessage : Message
	{
		public const uint Id = 5572;
		public override uint MessageId
		{
			get
			{
				return 5572;
			}
		}
		
		public short fightId;
		public Types.FightTeamInformations team;
		
		public GameFightUpdateTeamMessage()
		{
		}
		
		public GameFightUpdateTeamMessage(short fightId, Types.FightTeamInformations team)
		{
			this.fightId = fightId;
			this.team = team;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(fightId);
			team.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadShort();
			if ( fightId < 0 )
			{
				throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
			}
			team = new Types.FightTeamInformations();
			team.Deserialize(reader);
		}
	}
}
