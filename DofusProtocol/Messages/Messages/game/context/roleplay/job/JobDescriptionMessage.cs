// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'JobDescriptionMessage.xml' the '04/04/2012 14:27:27'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class JobDescriptionMessage : Message
	{
		public const uint Id = 5655;
		public override uint MessageId
		{
			get
			{
				return 5655;
			}
		}
		
		public IEnumerable<Types.JobDescription> jobsDescription;
		
		public JobDescriptionMessage()
		{
		}
		
		public JobDescriptionMessage(IEnumerable<Types.JobDescription> jobsDescription)
		{
			this.jobsDescription = jobsDescription;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUShort((ushort)jobsDescription.Count());
			foreach (var entry in jobsDescription)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			int limit = reader.ReadUShort();
			jobsDescription = new Types.JobDescription[limit];
			for (int i = 0; i < limit; i++)
			{
				(jobsDescription as Types.JobDescription[])[i] = new Types.JobDescription();
				(jobsDescription as Types.JobDescription[])[i].Deserialize(reader);
			}
		}
	}
}
