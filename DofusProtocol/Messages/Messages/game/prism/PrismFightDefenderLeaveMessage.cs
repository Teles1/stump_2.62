// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismFightDefenderLeaveMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PrismFightDefenderLeaveMessage : Message
	{
		public const uint Id = 5892;
		public override uint MessageId
		{
			get
			{
				return 5892;
			}
		}
		
		public double fightId;
		public int fighterToRemoveId;
		public int successor;
		
		public PrismFightDefenderLeaveMessage()
		{
		}
		
		public PrismFightDefenderLeaveMessage(double fightId, int fighterToRemoveId, int successor)
		{
			this.fightId = fightId;
			this.fighterToRemoveId = fighterToRemoveId;
			this.successor = successor;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(fightId);
			writer.WriteInt(fighterToRemoveId);
			writer.WriteInt(successor);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			fightId = reader.ReadDouble();
			fighterToRemoveId = reader.ReadInt();
			if ( fighterToRemoveId < 0 )
			{
				throw new Exception("Forbidden value on fighterToRemoveId = " + fighterToRemoveId + ", it doesn't respect the following condition : fighterToRemoveId < 0");
			}
			successor = reader.ReadInt();
			if ( successor < 0 )
			{
				throw new Exception("Forbidden value on successor = " + successor + ", it doesn't respect the following condition : successor < 0");
			}
		}
	}
}
