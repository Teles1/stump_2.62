// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildGetInformationsMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildGetInformationsMessage : Message
	{
		public const uint Id = 5550;
		public override uint MessageId
		{
			get
			{
				return 5550;
			}
		}
		
		public sbyte infoType;
		
		public GuildGetInformationsMessage()
		{
		}
		
		public GuildGetInformationsMessage(sbyte infoType)
		{
			this.infoType = infoType;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(infoType);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			infoType = reader.ReadSByte();
			if ( infoType < 0 )
			{
				throw new Exception("Forbidden value on infoType = " + infoType + ", it doesn't respect the following condition : infoType < 0");
			}
		}
	}
}
