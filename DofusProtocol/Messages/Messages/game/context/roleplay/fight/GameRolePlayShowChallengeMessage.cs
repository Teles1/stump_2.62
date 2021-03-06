// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayShowChallengeMessage.xml' the '04/04/2012 14:27:26'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameRolePlayShowChallengeMessage : Message
	{
		public const uint Id = 301;
		public override uint MessageId
		{
			get
			{
				return 301;
			}
		}
		
		public Types.FightCommonInformations commonsInfos;
		
		public GameRolePlayShowChallengeMessage()
		{
		}
		
		public GameRolePlayShowChallengeMessage(Types.FightCommonInformations commonsInfos)
		{
			this.commonsInfos = commonsInfos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			commonsInfos.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			commonsInfos = new Types.FightCommonInformations();
			commonsInfos.Deserialize(reader);
		}
	}
}
