// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'EmotePlayErrorMessage.xml' the '04/04/2012 14:27:25'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class EmotePlayErrorMessage : Message
	{
		public const uint Id = 5688;
		public override uint MessageId
		{
			get
			{
				return 5688;
			}
		}
		
		public sbyte emoteId;
		
		public EmotePlayErrorMessage()
		{
		}
		
		public EmotePlayErrorMessage(sbyte emoteId)
		{
			this.emoteId = emoteId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(emoteId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			emoteId = reader.ReadSByte();
		}
	}
}
