// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PaddockBuyRequestMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PaddockBuyRequestMessage : Message
	{
		public const uint Id = 5951;
		public override uint MessageId
		{
			get
			{
				return 5951;
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
