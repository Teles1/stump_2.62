// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'JobCrafterDirectoryDefineSettingsMessage.xml' the '04/04/2012 14:27:27'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class JobCrafterDirectoryDefineSettingsMessage : Message
	{
		public const uint Id = 5649;
		public override uint MessageId
		{
			get
			{
				return 5649;
			}
		}
		
		public Types.JobCrafterDirectorySettings settings;
		
		public JobCrafterDirectoryDefineSettingsMessage()
		{
		}
		
		public JobCrafterDirectoryDefineSettingsMessage(Types.JobCrafterDirectorySettings settings)
		{
			this.settings = settings;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			settings.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			settings = new Types.JobCrafterDirectorySettings();
			settings.Deserialize(reader);
		}
	}
}
