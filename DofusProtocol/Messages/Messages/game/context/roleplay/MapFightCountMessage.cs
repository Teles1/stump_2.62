// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MapFightCountMessage.xml' the '04/04/2012 14:27:25'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class MapFightCountMessage : Message
	{
		public const uint Id = 210;
		public override uint MessageId
		{
			get
			{
				return 210;
			}
		}
		
		public short fightCount;
		
		public MapFightCountMessage()
		{
		}
		
		public MapFightCountMessage(short fightCount)
		{
			this.fightCount = fightCount;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(fightCount);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightCount = reader.ReadShort();
			if ( fightCount < 0 )
			{
				throw new Exception("Forbidden value on fightCount = " + fightCount + ", it doesn't respect the following condition : fightCount < 0");
			}
		}
	}
}
