// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildMemberLeavingMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildMemberLeavingMessage : Message
	{
		public const uint Id = 5923;
		public override uint MessageId
		{
			get
			{
				return 5923;
			}
		}
		
		public bool kicked;
		public int memberId;
		
		public GuildMemberLeavingMessage()
		{
		}
		
		public GuildMemberLeavingMessage(bool kicked, int memberId)
		{
			this.kicked = kicked;
			this.memberId = memberId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(kicked);
			writer.WriteInt(memberId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			kicked = reader.ReadBoolean();
			memberId = reader.ReadInt();
		}
	}
}
