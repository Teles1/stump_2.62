// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildInvitationAnswerMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildInvitationAnswerMessage : Message
	{
		public const uint Id = 5556;
		public override uint MessageId
		{
			get
			{
				return 5556;
			}
		}
		
		public bool accept;
		
		public GuildInvitationAnswerMessage()
		{
		}
		
		public GuildInvitationAnswerMessage(bool accept)
		{
			this.accept = accept;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(accept);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			accept = reader.ReadBoolean();
		}
	}
}
