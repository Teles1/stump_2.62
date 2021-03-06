// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayFightRequestCanceledMessage.xml' the '04/04/2012 14:27:25'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameRolePlayFightRequestCanceledMessage : Message
	{
		public const uint Id = 5822;
		public override uint MessageId
		{
			get
			{
				return 5822;
			}
		}
		
		public int fightId;
		public int sourceId;
		public int targetId;
		
		public GameRolePlayFightRequestCanceledMessage()
		{
		}
		
		public GameRolePlayFightRequestCanceledMessage(int fightId, int sourceId, int targetId)
		{
			this.fightId = fightId;
			this.sourceId = sourceId;
			this.targetId = targetId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(fightId);
			writer.WriteInt(sourceId);
			writer.WriteInt(targetId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadInt();
			sourceId = reader.ReadInt();
			if ( sourceId < 0 )
			{
				throw new Exception("Forbidden value on sourceId = " + sourceId + ", it doesn't respect the following condition : sourceId < 0");
			}
			targetId = reader.ReadInt();
		}
	}
}
