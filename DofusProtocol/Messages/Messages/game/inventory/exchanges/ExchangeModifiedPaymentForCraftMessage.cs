// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeModifiedPaymentForCraftMessage.xml' the '04/04/2012 14:27:32'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeModifiedPaymentForCraftMessage : Message
	{
		public const uint Id = 5832;
		public override uint MessageId
		{
			get
			{
				return 5832;
			}
		}
		
		public bool onlySuccess;
		public Types.ObjectItemNotInContainer @object;
		
		public ExchangeModifiedPaymentForCraftMessage()
		{
		}
		
		public ExchangeModifiedPaymentForCraftMessage(bool onlySuccess, Types.ObjectItemNotInContainer @object)
		{
			this.onlySuccess = onlySuccess;
			this.@object = @object;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(onlySuccess);
			@object.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			onlySuccess = reader.ReadBoolean();
			@object = new Types.ObjectItemNotInContainer();
			@object.Deserialize(reader);
		}
	}
}