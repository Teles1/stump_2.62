// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightStartMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameFightStartMessage : Message
	{
		public const uint Id = 712;
		public override uint MessageId
		{
			get
			{
				return 712;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}
