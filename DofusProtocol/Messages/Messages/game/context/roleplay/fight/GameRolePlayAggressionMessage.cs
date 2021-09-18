// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayAggressionMessage.xml' the '04/04/2012 14:27:25'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameRolePlayAggressionMessage : Message
	{
		public const uint Id = 6073;
		public override uint MessageId
		{
			get
			{
				return 6073;
			}
		}
		
		public int attackerId;
		public int defenderId;
		
		public GameRolePlayAggressionMessage()
		{
		}
		
		public GameRolePlayAggressionMessage(int attackerId, int defenderId)
		{
			this.attackerId = attackerId;
			this.defenderId = defenderId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(attackerId);
			writer.WriteInt(defenderId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			attackerId = reader.ReadInt();
			if ( attackerId < 0 )
			{
				throw new Exception("Forbidden value on attackerId = " + attackerId + ", it doesn't respect the following condition : attackerId < 0");
			}
			defenderId = reader.ReadInt();
			if ( defenderId < 0 )
			{
				throw new Exception("Forbidden value on defenderId = " + defenderId + ", it doesn't respect the following condition : defenderId < 0");
			}
		}
	}
}