// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameFightRefreshFighterMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameFightRefreshFighterMessage : Message
	{
		public const uint Id = 6309;
		public override uint MessageId
		{
			get
			{
				return 6309;
			}
		}
		
		public Types.GameContextActorInformations informations;
		
		public GameFightRefreshFighterMessage()
		{
		}
		
		public GameFightRefreshFighterMessage(Types.GameContextActorInformations informations)
		{
			this.informations = informations;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(informations.TypeId);
			informations.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			informations = Types.ProtocolTypeManager.GetInstance<Types.GameContextActorInformations>(reader.ReadShort());
			informations.Deserialize(reader);
		}
	}
}
