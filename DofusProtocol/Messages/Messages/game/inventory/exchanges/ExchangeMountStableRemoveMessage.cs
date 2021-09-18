// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeMountStableRemoveMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeMountStableRemoveMessage : Message
	{
		public const uint Id = 5964;
		public override uint MessageId
		{
			get
			{
				return 5964;
			}
		}
		
		public double mountId;
		
		public ExchangeMountStableRemoveMessage()
		{
		}
		
		public ExchangeMountStableRemoveMessage(double mountId)
		{
			this.mountId = mountId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(mountId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mountId = reader.ReadDouble();
		}
	}
}
