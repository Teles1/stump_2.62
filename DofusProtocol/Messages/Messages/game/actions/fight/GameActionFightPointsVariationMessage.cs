// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionFightPointsVariationMessage.xml' the '04/04/2012 14:27:20'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameActionFightPointsVariationMessage : AbstractGameActionMessage
	{
		public const uint Id = 1030;
		public override uint MessageId
		{
			get
			{
				return 1030;
			}
		}
		
		public int targetId;
		public short delta;
		
		public GameActionFightPointsVariationMessage()
		{
		}
		
		public GameActionFightPointsVariationMessage(short actionId, int sourceId, int targetId, short delta)
			 : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.delta = delta;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(targetId);
			writer.WriteShort(delta);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			targetId = reader.ReadInt();
			delta = reader.ReadShort();
		}
	}
}
