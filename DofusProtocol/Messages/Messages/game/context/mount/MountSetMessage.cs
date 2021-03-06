// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountSetMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class MountSetMessage : Message
	{
		public const uint Id = 5968;
		public override uint MessageId
		{
			get
			{
				return 5968;
			}
		}
		
		public Types.MountClientData mountData;
		
		public MountSetMessage()
		{
		}
		
		public MountSetMessage(Types.MountClientData mountData)
		{
			this.mountData = mountData;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			mountData.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mountData = new Types.MountClientData();
			mountData.Deserialize(reader);
		}
	}
}
