// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CredentialsAcknowledgementMessage.xml' the '04/04/2012 14:27:19'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class CredentialsAcknowledgementMessage : Message
	{
		public const uint Id = 6314;
		public override uint MessageId
		{
			get
			{
				return 6314;
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
