// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'KamasUpdateMessage.xml' the '04/04/2012 14:27:32'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class KamasUpdateMessage : Message
	{
		public const uint Id = 5537;
		public override uint MessageId
		{
			get
			{
				return 5537;
			}
		}
		
		public int kamasTotal;
		
		public KamasUpdateMessage()
		{
		}
		
		public KamasUpdateMessage(int kamasTotal)
		{
			this.kamasTotal = kamasTotal;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(kamasTotal);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			kamasTotal = reader.ReadInt();
		}
	}
}