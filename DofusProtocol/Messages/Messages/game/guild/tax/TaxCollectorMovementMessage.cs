// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'TaxCollectorMovementMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class TaxCollectorMovementMessage : Message
	{
		public const uint Id = 5633;
		public override uint MessageId
		{
			get
			{
				return 5633;
			}
		}
		
		public bool hireOrFire;
		public Types.TaxCollectorBasicInformations basicInfos;
		public string playerName;
		
		public TaxCollectorMovementMessage()
		{
		}
		
		public TaxCollectorMovementMessage(bool hireOrFire, Types.TaxCollectorBasicInformations basicInfos, string playerName)
		{
			this.hireOrFire = hireOrFire;
			this.basicInfos = basicInfos;
			this.playerName = playerName;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(hireOrFire);
			basicInfos.Serialize(writer);
			writer.WriteUTF(playerName);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			hireOrFire = reader.ReadBoolean();
			basicInfos = new Types.TaxCollectorBasicInformations();
			basicInfos.Deserialize(reader);
			playerName = reader.ReadUTF();
		}
	}
}
