// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildCreationStartedMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildCreationStartedMessage : Message
	{
		public const uint Id = 5920;
		public override uint MessageId
		{
			get
			{
				return 5920;
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
