// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'BasicWhoAmIRequestMessage.xml' the '04/04/2012 14:27:21'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class BasicWhoAmIRequestMessage : Message
	{
		public const uint Id = 5664;
		public override uint MessageId
		{
			get
			{
				return 5664;
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
