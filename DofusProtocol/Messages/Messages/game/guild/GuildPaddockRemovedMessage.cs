// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildPaddockRemovedMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildPaddockRemovedMessage : Message
	{
		public const uint Id = 5955;
		public override uint MessageId
		{
			get
			{
				return 5955;
			}
		}
		
		public int paddockId;
		
		public GuildPaddockRemovedMessage()
		{
		}
		
		public GuildPaddockRemovedMessage(int paddockId)
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
