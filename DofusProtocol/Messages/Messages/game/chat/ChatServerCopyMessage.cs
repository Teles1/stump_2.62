// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ChatServerCopyMessage.xml' the '04/04/2012 14:27:22'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class ChatServerCopyMessage : ChatAbstractServerMessage
	{
		public const uint Id = 882;
		public override uint MessageId
		{
			get
			{
				return 882;
			}
		}
		
		public int receiverId;
		public string receiverName;
		
		public ChatServerCopyMessage()
		{
		}
		
		public ChatServerCopyMessage(sbyte channel, string content, int timestamp, string fingerprint, int receiverId, string receiverName)
			 : base(channel, content, timestamp, fingerprint)
		{
			this.receiverId = receiverId;
			this.receiverName = receiverName;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(receiverId);
			writer.WriteUTF(receiverName);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			receiverId = reader.ReadInt();
			if ( receiverId < 0 )
			{
				throw new Exception("Forbidden value on receiverId = " + receiverId + ", it doesn't respect the following condition : receiverId < 0");
			}
			receiverName = reader.ReadUTF();
		}
	}
}
