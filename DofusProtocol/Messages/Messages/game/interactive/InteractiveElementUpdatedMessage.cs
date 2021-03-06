// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'InteractiveElementUpdatedMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class InteractiveElementUpdatedMessage : Message
	{
		public const uint Id = 5708;
		public override uint MessageId
		{
			get
			{
				return 5708;
			}
		}
		
		public Types.InteractiveElement interactiveElement;
		
		public InteractiveElementUpdatedMessage()
		{
		}
		
		public InteractiveElementUpdatedMessage(Types.InteractiveElement interactiveElement)
		{
			this.interactiveElement = interactiveElement;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			interactiveElement.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			interactiveElement = new Types.InteractiveElement();
			interactiveElement.Deserialize(reader);
		}
	}
}
