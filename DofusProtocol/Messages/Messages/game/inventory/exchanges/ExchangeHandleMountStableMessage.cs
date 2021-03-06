// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeHandleMountStableMessage.xml' the '04/04/2012 14:27:32'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeHandleMountStableMessage : Message
	{
		public const uint Id = 5965;
		public override uint MessageId
		{
			get
			{
				return 5965;
			}
		}
		
		public sbyte actionType;
		public int rideId;
		
		public ExchangeHandleMountStableMessage()
		{
		}
		
		public ExchangeHandleMountStableMessage(sbyte actionType, int rideId)
		{
			this.actionType = actionType;
			this.rideId = rideId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(actionType);
			writer.WriteInt(rideId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			actionType = reader.ReadSByte();
			rideId = reader.ReadInt();
			if ( rideId < 0 )
			{
				throw new Exception("Forbidden value on rideId = " + rideId + ", it doesn't respect the following condition : rideId < 0");
			}
		}
	}
}
