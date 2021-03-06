// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MountEmoteIconUsedOkMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class MountEmoteIconUsedOkMessage : Message
	{
		public const uint Id = 5978;
		public override uint MessageId
		{
			get
			{
				return 5978;
			}
		}
		
		public int mountId;
		public sbyte reactionType;
		
		public MountEmoteIconUsedOkMessage()
		{
		}
		
		public MountEmoteIconUsedOkMessage(int mountId, sbyte reactionType)
		{
			this.mountId = mountId;
			this.reactionType = reactionType;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(mountId);
			writer.WriteSByte(reactionType);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			mountId = reader.ReadInt();
			reactionType = reader.ReadSByte();
			if ( reactionType < 0 )
			{
				throw new Exception("Forbidden value on reactionType = " + reactionType + ", it doesn't respect the following condition : reactionType < 0");
			}
		}
	}
}
