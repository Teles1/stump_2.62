// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'NpcDialogReplyMessage.xml' the '04/04/2012 14:27:28'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class NpcDialogReplyMessage : Message
	{
		public const uint Id = 5616;
		public override uint MessageId
		{
			get
			{
				return 5616;
			}
		}
		
		public short replyId;
		
		public NpcDialogReplyMessage()
		{
		}
		
		public NpcDialogReplyMessage(short replyId)
		{
			this.replyId = replyId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(replyId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			replyId = reader.ReadShort();
			if ( replyId < 0 )
			{
				throw new Exception("Forbidden value on replyId = " + replyId + ", it doesn't respect the following condition : replyId < 0");
			}
		}
	}
}