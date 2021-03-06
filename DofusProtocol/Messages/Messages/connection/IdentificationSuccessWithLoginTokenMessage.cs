// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'IdentificationSuccessWithLoginTokenMessage.xml' the '04/04/2012 14:27:19'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
	{
		public const uint Id = 6209;
		public override uint MessageId
		{
			get
			{
				return 6209;
			}
		}
		
		public string loginToken;
		
		public IdentificationSuccessWithLoginTokenMessage()
		{
		}
		
		public IdentificationSuccessWithLoginTokenMessage(bool hasRights, bool wasAlreadyConnected, string login, string nickname, int accountId, sbyte communityId, string secretQuestion, double subscriptionEndDate, double accountCreation, string loginToken)
			 : base(hasRights, wasAlreadyConnected, login, nickname, accountId, communityId, secretQuestion, subscriptionEndDate, accountCreation)
		{
			this.loginToken = loginToken;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(loginToken);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			loginToken = reader.ReadUTF();
		}
	}
}
