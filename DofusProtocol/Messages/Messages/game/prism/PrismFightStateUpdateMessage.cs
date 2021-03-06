// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismFightStateUpdateMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PrismFightStateUpdateMessage : Message
	{
		public const uint Id = 6040;
		public override uint MessageId
		{
			get
			{
				return 6040;
			}
		}
		
		public sbyte state;
		
		public PrismFightStateUpdateMessage()
		{
		}
		
		public PrismFightStateUpdateMessage(sbyte state)
		{
			this.state = state;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(state);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			state = reader.ReadSByte();
			if ( state < 0 )
			{
				throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
			}
		}
	}
}
