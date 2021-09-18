// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionFightKillMessage.xml' the '04/04/2012 14:27:20'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameActionFightKillMessage : AbstractGameActionMessage
	{
		public const uint Id = 5571;
		public override uint MessageId
		{
			get
			{
				return 5571;
			}
		}
		
		public int targetId;
		
		public GameActionFightKillMessage()
		{
		}
		
		public GameActionFightKillMessage(short actionId, int sourceId, int targetId)
			 : base(actionId, sourceId)
		{
			this.targetId = targetId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(targetId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			targetId = reader.ReadInt();
		}
	}
}