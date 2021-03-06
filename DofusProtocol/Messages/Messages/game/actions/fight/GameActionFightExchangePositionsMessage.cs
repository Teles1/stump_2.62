// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionFightExchangePositionsMessage.xml' the '04/04/2012 14:27:19'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameActionFightExchangePositionsMessage : AbstractGameActionMessage
	{
		public const uint Id = 5527;
		public override uint MessageId
		{
			get
			{
				return 5527;
			}
		}
		
		public int targetId;
		public short casterCellId;
		public short targetCellId;
		
		public GameActionFightExchangePositionsMessage()
		{
		}
		
		public GameActionFightExchangePositionsMessage(short actionId, int sourceId, int targetId, short casterCellId, short targetCellId)
			 : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.casterCellId = casterCellId;
			this.targetCellId = targetCellId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(targetId);
			writer.WriteShort(casterCellId);
			writer.WriteShort(targetCellId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			targetId = reader.ReadInt();
			casterCellId = reader.ReadShort();
			if ( casterCellId < -1 || casterCellId > 559 )
			{
				throw new Exception("Forbidden value on casterCellId = " + casterCellId + ", it doesn't respect the following condition : casterCellId < -1 || casterCellId > 559");
			}
			targetCellId = reader.ReadShort();
			if ( targetCellId < -1 || targetCellId > 559 )
			{
				throw new Exception("Forbidden value on targetCellId = " + targetCellId + ", it doesn't respect the following condition : targetCellId < -1 || targetCellId > 559");
			}
		}
	}
}
