// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismInfoCloseMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PrismInfoCloseMessage : Message
	{
		public const uint Id = 5853;
		public override uint MessageId
		{
			get
			{
				return 5853;
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
