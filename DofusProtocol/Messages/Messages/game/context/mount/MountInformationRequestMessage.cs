// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountInformationRequestMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class MountInformationRequestMessage : Message
	{
		public const uint Id = 5972;
		public override uint MessageId
		{
			get
			{
				return 5972;
			}
		}
		
		public double id;
		public double time;
		
		public MountInformationRequestMessage()
		{
		}
		
		public MountInformationRequestMessage(double id, double time)
		{
			this.id = id;
			this.time = time;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(id);
			writer.WriteDouble(time);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			id = reader.ReadDouble();
			time = reader.ReadDouble();
		}
	}
}