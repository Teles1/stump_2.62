// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismInfoValidMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PrismInfoValidMessage : Message
	{
		public const uint Id = 5858;
		public override uint MessageId
		{
			get
			{
				return 5858;
			}
		}
		
		public Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo;
		
		public PrismInfoValidMessage()
		{
		}
		
		public PrismInfoValidMessage(Types.ProtectedEntityWaitingForHelpInfo waitingForHelpInfo)
		{
			this.waitingForHelpInfo = waitingForHelpInfo;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			waitingForHelpInfo.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			waitingForHelpInfo = new Types.ProtectedEntityWaitingForHelpInfo();
			waitingForHelpInfo.Deserialize(reader);
		}
	}
}
