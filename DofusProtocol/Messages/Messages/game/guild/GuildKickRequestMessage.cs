// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildKickRequestMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildKickRequestMessage : Message
	{
		public const uint Id = 5887;
		public override uint MessageId
		{
			get
			{
				return 5887;
			}
		}
		
		public int kickedId;
		
		public GuildKickRequestMessage()
		{
		}
		
		public GuildKickRequestMessage(int kickedId)
		{
			this.kickedId = kickedId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(kickedId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			kickedId = reader.ReadInt();
			if ( kickedId < 0 )
			{
				throw new Exception("Forbidden value on kickedId = " + kickedId + ", it doesn't respect the following condition : kickedId < 0");
			}
		}
	}
}