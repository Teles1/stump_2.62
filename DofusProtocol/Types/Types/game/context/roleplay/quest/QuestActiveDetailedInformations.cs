// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'QuestActiveDetailedInformations.xml' the '04/04/2012 14:27:38'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Types
{
	public class QuestActiveDetailedInformations : QuestActiveInformations
	{
		public const uint Id = 382;
		public override short TypeId
		{
			get
			{
				return 382;
			}
		}
		
		public short stepId;
		public IEnumerable<Types.QuestObjectiveInformations> objectives;
		
		public QuestActiveDetailedInformations()
		{
		}
		
		public QuestActiveDetailedInformations(short questId, short stepId, IEnumerable<Types.QuestObjectiveInformations> objectives)
			 : base(questId)
		{
			this.stepId = stepId;
			this.objectives = objectives;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(stepId);
			writer.WriteUShort((ushort)objectives.Count());
			foreach (var entry in objectives)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			stepId = reader.ReadShort();
			if ( stepId < 0 )
			{
				throw new Exception("Forbidden value on stepId = " + stepId + ", it doesn't respect the following condition : stepId < 0");
			}
			int limit = reader.ReadUShort();
			objectives = new Types.QuestObjectiveInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectives as Types.QuestObjectiveInformations[])[i] = ProtocolTypeManager.GetInstance<Types.QuestObjectiveInformations>(reader.ReadShort());
				(objectives as Types.QuestObjectiveInformations[])[i].Deserialize(reader);
			}
		}
	}
}
