// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PrismFightJoinLeaveRequestMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PrismFightJoinLeaveRequestMessage : Message
	{
		public const uint Id = 5843;
		public override uint MessageId
		{
			get
			{
				return 5843;
			}
		}
		
		public bool join;
		
		public PrismFightJoinLeaveRequestMessage()
		{
		}
		
		public PrismFightJoinLeaveRequestMessage(bool join)
		{
			this.join = join;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(join);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			join = reader.ReadBoolean();
		}
	}
}