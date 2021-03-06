// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AdminCommandMessage.xml' the '04/04/2012 14:27:18'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class AdminCommandMessage : Message
	{
		public const uint Id = 76;
		public override uint MessageId
		{
			get
			{
				return 76;
			}
		}
		
		public string content;
		
		public AdminCommandMessage()
		{
		}
		
		public AdminCommandMessage(string content)
		{
			this.content = content;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(content);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			content = reader.ReadUTF();
		}
	}
}
