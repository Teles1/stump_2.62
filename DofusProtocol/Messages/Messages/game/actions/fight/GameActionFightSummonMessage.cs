// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameActionFightSummonMessage.xml' the '04/04/2012 14:27:20'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameActionFightSummonMessage : AbstractGameActionMessage
	{
		public const uint Id = 5825;
		public override uint MessageId
		{
			get
			{
				return 5825;
			}
		}
		
		public Types.GameFightFighterInformations summon;
		
		public GameActionFightSummonMessage()
		{
		}
		
		public GameActionFightSummonMessage(short actionId, int sourceId, Types.GameFightFighterInformations summon)
			 : base(actionId, sourceId)
		{
			this.summon = summon;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(summon.TypeId);
			summon.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			summon = Types.ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadShort());
			summon.Deserialize(reader);
		}
	}
}
