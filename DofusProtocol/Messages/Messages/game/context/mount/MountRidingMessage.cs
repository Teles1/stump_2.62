// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountRidingMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class MountRidingMessage : Message
	{
		public const uint Id = 5967;
		public override uint MessageId
		{
			get
			{
				return 5967;
			}
		}
		
		public bool isRiding;
		
		public MountRidingMessage()
		{
		}
		
		public MountRidingMessage(bool isRiding)
		{
			this.isRiding = isRiding;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(isRiding);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			isRiding = reader.ReadBoolean();
		}
	}
}