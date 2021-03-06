// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildInformationsMemberUpdateMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildInformationsMemberUpdateMessage : Message
	{
		public const uint Id = 5597;
		public override uint MessageId
		{
			get
			{
				return 5597;
			}
		}
		
		public Types.GuildMember member;
		
		public GuildInformationsMemberUpdateMessage()
		{
		}
		
		public GuildInformationsMemberUpdateMessage(Types.GuildMember member)
		{
			this.member = member;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			member.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			member = new Types.GuildMember();
			member.Deserialize(reader);
		}
	}
}
