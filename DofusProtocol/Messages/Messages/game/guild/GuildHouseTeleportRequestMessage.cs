// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildHouseTeleportRequestMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildHouseTeleportRequestMessage : Message
	{
		public const uint Id = 5712;
		public override uint MessageId
		{
			get
			{
				return 5712;
			}
		}
		
		public int houseId;
		
		public GuildHouseTeleportRequestMessage()
		{
		}
		
		public GuildHouseTeleportRequestMessage(int houseId)
		{
			this.houseId = houseId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(houseId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			houseId = reader.ReadInt();
			if ( houseId < 0 )
			{
				throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
			}
		}
	}
}