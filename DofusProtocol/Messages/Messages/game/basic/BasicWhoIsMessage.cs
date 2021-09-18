// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'BasicWhoIsMessage.xml' the '04/04/2012 14:27:21'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class BasicWhoIsMessage : Message
	{
		public const uint Id = 180;
		public override uint MessageId
		{
			get
			{
				return 180;
			}
		}
		
		public bool self;
		public sbyte position;
		public string accountNickname;
		public string characterName;
		public short areaId;
		
		public BasicWhoIsMessage()
		{
		}
		
		public BasicWhoIsMessage(bool self, sbyte position, string accountNickname, string characterName, short areaId)
		{
			this.self = self;
			this.position = position;
			this.accountNickname = accountNickname;
			this.characterName = characterName;
			this.areaId = areaId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(self);
			writer.WriteSByte(position);
			writer.WriteUTF(accountNickname);
			writer.WriteUTF(characterName);
			writer.WriteShort(areaId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			self = reader.ReadBoolean();
			position = reader.ReadSByte();
			accountNickname = reader.ReadUTF();
			characterName = reader.ReadUTF();
			areaId = reader.ReadShort();
		}
	}
}