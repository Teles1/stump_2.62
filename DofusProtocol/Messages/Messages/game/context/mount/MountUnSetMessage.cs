// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountUnSetMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class MountUnSetMessage : Message
	{
		public const uint Id = 5982;
		public override uint MessageId
		{
			get
			{
				return 5982;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}
