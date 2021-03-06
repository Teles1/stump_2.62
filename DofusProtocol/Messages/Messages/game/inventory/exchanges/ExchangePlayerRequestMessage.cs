// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangePlayerRequestMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangePlayerRequestMessage : ExchangeRequestMessage
	{
		public const uint Id = 5773;
		public override uint MessageId
		{
			get
			{
				return 5773;
			}
		}
		
		public int target;
		
		public ExchangePlayerRequestMessage()
		{
		}
		
		public ExchangePlayerRequestMessage(sbyte exchangeType, int target)
			 : base(exchangeType)
		{
			this.target = target;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(target);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			target = reader.ReadInt();
			if ( target < 0 )
			{
				throw new Exception("Forbidden value on target = " + target + ", it doesn't respect the following condition : target < 0");
			}
		}
	}
}
