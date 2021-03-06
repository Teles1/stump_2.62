// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'LifePointsRegenEndMessage.xml' the '04/04/2012 14:27:22'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class LifePointsRegenEndMessage : UpdateLifePointsMessage
	{
		public const uint Id = 5686;
		public override uint MessageId
		{
			get
			{
				return 5686;
			}
		}
		
		public int lifePointsGained;
		
		public LifePointsRegenEndMessage()
		{
		}
		
		public LifePointsRegenEndMessage(int lifePoints, int maxLifePoints, int lifePointsGained)
			 : base(lifePoints, maxLifePoints)
		{
			this.lifePointsGained = lifePointsGained;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(lifePointsGained);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			lifePointsGained = reader.ReadInt();
			if ( lifePointsGained < 0 )
			{
				throw new Exception("Forbidden value on lifePointsGained = " + lifePointsGained + ", it doesn't respect the following condition : lifePointsGained < 0");
			}
		}
	}
}
