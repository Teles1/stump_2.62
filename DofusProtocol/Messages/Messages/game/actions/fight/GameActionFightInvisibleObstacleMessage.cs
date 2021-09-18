// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionFightInvisibleObstacleMessage.xml' the '04/04/2012 14:27:20'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameActionFightInvisibleObstacleMessage : AbstractGameActionMessage
	{
		public const uint Id = 5820;
		public override uint MessageId
		{
			get
			{
				return 5820;
			}
		}
		
		public int sourceSpellId;
		
		public GameActionFightInvisibleObstacleMessage()
		{
		}
		
		public GameActionFightInvisibleObstacleMessage(short actionId, int sourceId, int sourceSpellId)
			 : base(actionId, sourceId)
		{
			this.sourceSpellId = sourceSpellId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(sourceSpellId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			sourceSpellId = reader.ReadInt();
			if ( sourceSpellId < 0 )
			{
				throw new Exception("Forbidden value on sourceSpellId = " + sourceSpellId + ", it doesn't respect the following condition : sourceSpellId < 0");
			}
		}
	}
}