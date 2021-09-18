// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildPaddockTeleportRequestMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildPaddockTeleportRequestMessage : Message
	{
		public const uint Id = 5957;
		public override uint MessageId
		{
			get
			{
				return 5957;
			}
		}
		
		public int paddockId;
		
		public GuildPaddockTeleportRequestMessage()
		{
		}
		
		public GuildPaddockTeleportRequestMessage(int paddockId)
		{
			this.paddockId = paddockId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(paddockId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			paddockId = reader.ReadInt();
		}
	}
}
