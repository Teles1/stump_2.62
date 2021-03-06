// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'QueueStatusMessage.xml' the '04/04/2012 14:27:36'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class QueueStatusMessage : Message
	{
		public const uint Id = 6100;
		public override uint MessageId
		{
			get
			{
				return 6100;
			}
		}
		
		public ushort position;
		public ushort total;
		
		public QueueStatusMessage()
		{
		}
		
		public QueueStatusMessage(ushort position, ushort total)
		{
			this.position = position;
			this.total = total;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort(position);
			writer.WriteUShort(total);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			position = reader.ReadUShort();
			if ( position < 0 || position > 65535 )
			{
				throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 65535");
			}
			total = reader.ReadUShort();
			if ( total < 0 || total > 65535 )
			{
				throw new Exception("Forbidden value on total = " + total + ", it doesn't respect the following condition : total < 0 || total > 65535");
			}
		}
	}
}
