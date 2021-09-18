// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeGoldPaymentForCraftMessage.xml' the '04/04/2012 14:27:32'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeGoldPaymentForCraftMessage : Message
	{
		public const uint Id = 5833;
		public override uint MessageId
		{
			get
			{
				return 5833;
			}
		}
		
		public bool onlySuccess;
		public int goldSum;
		
		public ExchangeGoldPaymentForCraftMessage()
		{
		}
		
		public ExchangeGoldPaymentForCraftMessage(bool onlySuccess, int goldSum)
		{
			this.onlySuccess = onlySuccess;
			this.goldSum = goldSum;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(onlySuccess);
			writer.WriteInt(goldSum);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			onlySuccess = reader.ReadBoolean();
			goldSum = reader.ReadInt();
			if ( goldSum < 0 )
			{
				throw new Exception("Forbidden value on goldSum = " + goldSum + ", it doesn't respect the following condition : goldSum < 0");
			}
		}
	}
}
