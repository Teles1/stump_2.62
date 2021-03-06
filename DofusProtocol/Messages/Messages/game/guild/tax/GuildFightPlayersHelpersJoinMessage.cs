// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildFightPlayersHelpersJoinMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildFightPlayersHelpersJoinMessage : Message
	{
		public const uint Id = 5720;
		public override uint MessageId
		{
			get
			{
				return 5720;
			}
		}
		
		public double fightId;
		public Types.CharacterMinimalPlusLookInformations playerInfo;
		
		public GuildFightPlayersHelpersJoinMessage()
		{
		}
		
		public GuildFightPlayersHelpersJoinMessage(double fightId, Types.CharacterMinimalPlusLookInformations playerInfo)
		{
			this.fightId = fightId;
			this.playerInfo = playerInfo;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(fightId);
			playerInfo.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadDouble();
			if ( fightId < 0 )
			{
				throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
			}
			playerInfo = new Types.CharacterMinimalPlusLookInformations();
			playerInfo.Deserialize(reader);
		}
	}
}
