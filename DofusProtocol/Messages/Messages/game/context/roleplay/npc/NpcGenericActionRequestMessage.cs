// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'NpcGenericActionRequestMessage.xml' the '04/04/2012 14:27:28'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class NpcGenericActionRequestMessage : Message
	{
		public const uint Id = 5898;
		public override uint MessageId
		{
			get
			{
				return 5898;
			}
		}
		
		public int npcId;
		public sbyte npcActionId;
		public int npcMapId;
		
		public NpcGenericActionRequestMessage()
		{
		}
		
		public NpcGenericActionRequestMessage(int npcId, sbyte npcActionId, int npcMapId)
		{
			this.npcId = npcId;
			this.npcActionId = npcActionId;
			this.npcMapId = npcMapId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(npcId);
			writer.WriteSByte(npcActionId);
			writer.WriteInt(npcMapId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			npcId = reader.ReadInt();
			npcActionId = reader.ReadSByte();
			if ( npcActionId < 0 )
			{
				throw new Exception("Forbidden value on npcActionId = " + npcActionId + ", it doesn't respect the following condition : npcActionId < 0");
			}
			npcMapId = reader.ReadInt();
		}
	}
}