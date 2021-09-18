// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AuthenticationTicketMessage.xml' the '04/04/2012 14:27:21'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class AuthenticationTicketMessage : Message
	{
		public const uint Id = 110;
		public override uint MessageId
		{
			get
			{
				return 110;
			}
		}
		
		public string lang;
		public string ticket;
		
		public AuthenticationTicketMessage()
		{
		}
		
		public AuthenticationTicketMessage(string lang, string ticket)
		{
			this.lang = lang;
			this.ticket = ticket;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(lang);
			writer.WriteUTF(ticket);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			lang = reader.ReadUTF();
			ticket = reader.ReadUTF();
		}
	}
}