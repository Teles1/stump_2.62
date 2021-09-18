// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AlignmentAreaUpdateMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class AlignmentAreaUpdateMessage : Message
	{
		public const uint Id = 6060;
		public override uint MessageId
		{
			get
			{
				return 6060;
			}
		}
		
		public short areaId;
		public sbyte side;
		
		public AlignmentAreaUpdateMessage()
		{
		}
		
		public AlignmentAreaUpdateMessage(short areaId, sbyte side)
		{
			this.areaId = areaId;
			this.side = side;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(areaId);
			writer.WriteSByte(side);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			areaId = reader.ReadShort();
			if ( areaId < 0 )
			{
				throw new Exception("Forbidden value on areaId = " + areaId + ", it doesn't respect the following condition : areaId < 0");
			}
			side = reader.ReadSByte();
		}
	}
}