// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameEntityDispositionErrorMessage.xml' the '04/04/2012 14:27:23'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameEntityDispositionErrorMessage : Message
	{
		public const uint Id = 5695;
		public override uint MessageId
		{
			get
			{
				return 5695;
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