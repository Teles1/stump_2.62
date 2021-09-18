// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'QuestStepInfoMessage.xml' the '04/04/2012 14:27:30'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class QuestStepInfoMessage : Message
	{
		public const uint Id = 5625;
		public override uint MessageId
		{
			get
			{
				return 5625;
			}
		}
		
		public Types.QuestActiveInformations infos;
		
		public QuestStepInfoMessage()
		{
		}
		
		public QuestStepInfoMessage(Types.QuestActiveInformations infos)
		{
			this.infos = infos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(infos.TypeId);
			infos.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			infos = Types.ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadShort());
			infos.Deserialize(reader);
		}
	}
}
