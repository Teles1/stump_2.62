// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildPaddockBoughtMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GuildPaddockBoughtMessage : Message
	{
		public const uint Id = 5952;
		public override uint MessageId
		{
			get
			{
				return 5952;
			}
		}
		
		public Types.PaddockContentInformations paddockInfo;
		
		public GuildPaddockBoughtMessage()
		{
		}
		
		public GuildPaddockBoughtMessage(Types.PaddockContentInformations paddockInfo)
		{
			this.paddockInfo = paddockInfo;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			paddockInfo.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			paddockInfo = new Types.PaddockContentInformations();
			paddockInfo.Deserialize(reader);
		}
	}
}
