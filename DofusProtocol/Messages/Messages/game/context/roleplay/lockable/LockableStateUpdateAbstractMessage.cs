// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'LockableStateUpdateAbstractMessage.xml' the '04/04/2012 14:27:27'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class LockableStateUpdateAbstractMessage : Message
	{
		public const uint Id = 5671;
		public override uint MessageId
		{
			get
			{
				return 5671;
			}
		}
		
		public bool locked;
		
		public LockableStateUpdateAbstractMessage()
		{
		}
		
		public LockableStateUpdateAbstractMessage(bool locked)
		{
			this.locked = locked;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(locked);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			locked = reader.ReadBoolean();
		}
	}
}
