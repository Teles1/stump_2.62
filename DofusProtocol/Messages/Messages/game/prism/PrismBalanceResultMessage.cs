// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismBalanceResultMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PrismBalanceResultMessage : Message
	{
		public const uint Id = 5841;
		public override uint MessageId
		{
			get
			{
				return 5841;
			}
		}
		
		public sbyte totalBalanceValue;
		public sbyte subAreaBalanceValue;
		
		public PrismBalanceResultMessage()
		{
		}
		
		public PrismBalanceResultMessage(sbyte totalBalanceValue, sbyte subAreaBalanceValue)
		{
			this.totalBalanceValue = totalBalanceValue;
			this.subAreaBalanceValue = subAreaBalanceValue;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(totalBalanceValue);
			writer.WriteSByte(subAreaBalanceValue);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			totalBalanceValue = reader.ReadSByte();
			if ( totalBalanceValue < 0 )
			{
				throw new Exception("Forbidden value on totalBalanceValue = " + totalBalanceValue + ", it doesn't respect the following condition : totalBalanceValue < 0");
			}
			subAreaBalanceValue = reader.ReadSByte();
			if ( subAreaBalanceValue < 0 )
			{
				throw new Exception("Forbidden value on subAreaBalanceValue = " + subAreaBalanceValue + ", it doesn't respect the following condition : subAreaBalanceValue < 0");
			}
		}
	}
}