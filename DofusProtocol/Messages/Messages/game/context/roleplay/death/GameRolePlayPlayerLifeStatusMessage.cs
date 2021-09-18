// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayPlayerLifeStatusMessage.xml' the '04/04/2012 14:27:25'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameRolePlayPlayerLifeStatusMessage : Message
	{
		public const uint Id = 5996;
		public override uint MessageId
		{
			get
			{
				return 5996;
			}
		}
		
		public sbyte state;
		
		public GameRolePlayPlayerLifeStatusMessage()
		{
		}
		
		public GameRolePlayPlayerLifeStatusMessage(sbyte state)
		{
			this.state = state;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(state);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			state = reader.ReadSByte();
			if ( state < 0 )
			{
				throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
			}
		}
	}
}