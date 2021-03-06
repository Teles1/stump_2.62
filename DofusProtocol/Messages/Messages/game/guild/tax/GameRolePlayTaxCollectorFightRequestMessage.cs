// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayTaxCollectorFightRequestMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameRolePlayTaxCollectorFightRequestMessage : Message
	{
		public const uint Id = 5954;
		public override uint MessageId
		{
			get
			{
				return 5954;
			}
		}
		
		public int taxCollectorId;
		
		public GameRolePlayTaxCollectorFightRequestMessage()
		{
		}
		
		public GameRolePlayTaxCollectorFightRequestMessage(int taxCollectorId)
		{
			this.taxCollectorId = taxCollectorId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(taxCollectorId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			taxCollectorId = reader.ReadInt();
		}
	}
}
