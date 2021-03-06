// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayArenaRegistrationStatusMessage.xml' the '04/04/2012 14:27:26'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameRolePlayArenaRegistrationStatusMessage : Message
	{
		public const uint Id = 6284;
		public override uint MessageId
		{
			get
			{
				return 6284;
			}
		}
		
		public bool registered;
		public sbyte step;
		public int battleMode;
		
		public GameRolePlayArenaRegistrationStatusMessage()
		{
		}
		
		public GameRolePlayArenaRegistrationStatusMessage(bool registered, sbyte step, int battleMode)
		{
			this.registered = registered;
			this.step = step;
			this.battleMode = battleMode;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(registered);
			writer.WriteSByte(step);
			writer.WriteInt(battleMode);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			registered = reader.ReadBoolean();
			step = reader.ReadSByte();
			if ( step < 0 )
			{
				throw new Exception("Forbidden value on step = " + step + ", it doesn't respect the following condition : step < 0");
			}
			battleMode = reader.ReadInt();
			if ( battleMode < 0 )
			{
				throw new Exception("Forbidden value on battleMode = " + battleMode + ", it doesn't respect the following condition : battleMode < 0");
			}
		}
	}
}
