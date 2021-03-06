// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeReadyMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeReadyMessage : Message
	{
		public const uint Id = 5511;
		public override uint MessageId
		{
			get
			{
				return 5511;
			}
		}
		
		public bool ready;
		
		public ExchangeReadyMessage()
		{
		}
		
		public ExchangeReadyMessage(bool ready)
		{
			this.ready = ready;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(ready);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			ready = reader.ReadBoolean();
		}
	}
}
