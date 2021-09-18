// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'StatedElementUpdatedMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class StatedElementUpdatedMessage : Message
	{
		public const uint Id = 5709;
		public override uint MessageId
		{
			get
			{
				return 5709;
			}
		}
		
		public Types.StatedElement statedElement;
		
		public StatedElementUpdatedMessage()
		{
		}
		
		public StatedElementUpdatedMessage(Types.StatedElement statedElement)
		{
			this.statedElement = statedElement;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			statedElement.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			statedElement = new Types.StatedElement();
			statedElement.Deserialize(reader);
		}
	}
}