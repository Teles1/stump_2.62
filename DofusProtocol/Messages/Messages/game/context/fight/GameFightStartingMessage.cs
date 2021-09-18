// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightStartingMessage.xml' the '04/04/2012 14:27:23'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameFightStartingMessage : Message
	{
		public const uint Id = 700;
		public override uint MessageId
		{
			get
			{
				return 700;
			}
		}
		
		public sbyte fightType;
		
		public GameFightStartingMessage()
		{
		}
		
		public GameFightStartingMessage(sbyte fightType)
		{
			this.fightType = fightType;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(fightType);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightType = reader.ReadSByte();
			if ( fightType < 0 )
			{
				throw new Exception("Forbidden value on fightType = " + fightType + ", it doesn't respect the following condition : fightType < 0");
			}
		}
	}
}