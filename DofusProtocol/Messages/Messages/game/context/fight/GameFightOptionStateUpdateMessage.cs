// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightOptionStateUpdateMessage.xml' the '04/04/2012 14:27:23'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameFightOptionStateUpdateMessage : Message
	{
		public const uint Id = 5927;
		public override uint MessageId
		{
			get
			{
				return 5927;
			}
		}
		
		public short fightId;
		public sbyte teamId;
		public sbyte option;
		public bool state;
		
		public GameFightOptionStateUpdateMessage()
		{
		}
		
		public GameFightOptionStateUpdateMessage(short fightId, sbyte teamId, sbyte option, bool state)
		{
			this.fightId = fightId;
			this.teamId = teamId;
			this.option = option;
			this.state = state;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(fightId);
			writer.WriteSByte(teamId);
			writer.WriteSByte(option);
			writer.WriteBoolean(state);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadShort();
			if ( fightId < 0 )
			{
				throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
			}
			teamId = reader.ReadSByte();
			if ( teamId < 0 )
			{
				throw new Exception("Forbidden value on teamId = " + teamId + ", it doesn't respect the following condition : teamId < 0");
			}
			option = reader.ReadSByte();
			if ( option < 0 )
			{
				throw new Exception("Forbidden value on option = " + option + ", it doesn't respect the following condition : option < 0");
			}
			state = reader.ReadBoolean();
		}
	}
}
