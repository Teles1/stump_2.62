// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountDataMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class MountDataMessage : Message
	{
		public const uint Id = 5973;
		public override uint MessageId
		{
			get
			{
				return 5973;
			}
		}
		
		public Types.MountClientData mountData;
		
		public MountDataMessage()
		{
		}
		
		public MountDataMessage(Types.MountClientData mountData)
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
