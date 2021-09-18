// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FriendJoinRequestMessage.xml' the '04/04/2012 14:27:30'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class FriendJoinRequestMessage : Message
	{
		public const uint Id = 5605;
		public override uint MessageId
		{
			get
			{
				return 5605;
			}
		}
		
		public string name;
		
		public FriendJoinRequestMessage()
		{
		}
		
		public FriendJoinRequestMessage(string name)
		{
			this.name = name;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(name);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			name = reader.ReadUTF();
		}
	}
}