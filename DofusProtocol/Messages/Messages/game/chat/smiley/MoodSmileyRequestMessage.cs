// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MoodSmileyRequestMessage.xml' the '04/04/2012 14:27:23'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class MoodSmileyRequestMessage : Message
	{
		public const uint Id = 6192;
		public override uint MessageId
		{
			get
			{
				return 6192;
			}
		}
		
		public sbyte smileyId;
		
		public MoodSmileyRequestMessage()
		{
		}
		
		public MoodSmileyRequestMessage(sbyte smileyId)
		{
			this.smileyId = smileyId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(smileyId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			smileyId = reader.ReadSByte();
		}
	}
}
