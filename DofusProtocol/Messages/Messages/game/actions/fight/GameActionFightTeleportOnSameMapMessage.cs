// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionFightTeleportOnSameMapMessage.xml' the '04/04/2012 14:27:20'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameActionFightTeleportOnSameMapMessage : AbstractGameActionMessage
	{
		public const uint Id = 5528;
		public override uint MessageId
		{
			get
			{
				return 5528;
			}
		}
		
		public int targetId;
		public short cellId;
		
		public GameActionFightTeleportOnSameMapMessage()
		{
		}
		
		public GameActionFightTeleportOnSameMapMessage(short actionId, int sourceId, int targetId, short cellId)
			 : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.cellId = cellId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(targetId);
			writer.WriteShort(cellId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			targetId = reader.ReadInt();
			cellId = reader.ReadShort();
			if ( cellId < -1 || cellId > 559 )
			{
				throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
			}
		}
	}
}