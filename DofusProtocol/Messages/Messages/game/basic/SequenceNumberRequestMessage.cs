// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'SequenceNumberRequestMessage.xml' the '04/04/2012 14:27:22'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class SequenceNumberRequestMessage : Message
	{
		public const uint Id = 6316;
		public override uint MessageId
		{
			get
			{
				return 6316;
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