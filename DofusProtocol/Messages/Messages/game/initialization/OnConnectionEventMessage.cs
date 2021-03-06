// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'OnConnectionEventMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class OnConnectionEventMessage : Message
	{
		public const uint Id = 5726;
		public override uint MessageId
		{
			get
			{
				return 5726;
			}
		}
		
		public sbyte eventType;
		
		public OnConnectionEventMessage()
		{
		}
		
		public OnConnectionEventMessage(sbyte eventType)
		{
			this.eventType = eventType;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(eventType);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			eventType = reader.ReadSByte();
			if ( eventType < 0 )
			{
				throw new Exception("Forbidden value on eventType = " + eventType + ", it doesn't respect the following condition : eventType < 0");
			}
		}
	}
}
