// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildMembershipMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildMembershipMessage : GuildJoinedMessage
	{
		public const uint Id = 5835;
		public override uint MessageId
		{
			get
			{
				return 5835;
			}
		}
		
		
		public GuildMembershipMessage()
		{
		}
		
		public GuildMembershipMessage(Types.GuildInformations guildInfo, uint memberRights)
			 : base(guildInfo, memberRights)
		{
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}
	}
}