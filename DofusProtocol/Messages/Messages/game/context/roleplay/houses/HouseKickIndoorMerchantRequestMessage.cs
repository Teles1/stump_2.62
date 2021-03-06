// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'HouseKickIndoorMerchantRequestMessage.xml' the '04/04/2012 14:27:26'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class HouseKickIndoorMerchantRequestMessage : Message
	{
		public const uint Id = 5661;
		public override uint MessageId
		{
			get
			{
				return 5661;
			}
		}
		
		public short cellId;
		
		public HouseKickIndoorMerchantRequestMessage()
		{
		}
		
		public HouseKickIndoorMerchantRequestMessage(short cellId)
		{
			this.cellId = cellId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(cellId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			cellId = reader.ReadShort();
			if ( cellId < 0 || cellId > 559 )
			{
				throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
			}
		}
	}
}
