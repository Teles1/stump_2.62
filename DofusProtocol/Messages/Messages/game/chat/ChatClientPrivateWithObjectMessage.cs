// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ChatClientPrivateWithObjectMessage.xml' the '04/04/2012 14:27:22'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class ChatClientPrivateWithObjectMessage : ChatClientPrivateMessage
	{
		public const uint Id = 852;
		public override uint MessageId
		{
			get
			{
				return 852;
			}
		}
		
		public IEnumerable<Types.ObjectItem> objects;
		
		public ChatClientPrivateWithObjectMessage()
		{
		}
		
		public ChatClientPrivateWithObjectMessage(string content, string receiver, IEnumerable<Types.ObjectItem> objects)
			 : base(content, receiver)
		{
			this.objects = objects;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUShort((ushort)objects.Count());
			foreach (var entry in objects)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			int limit = reader.ReadUShort();
			objects = new Types.ObjectItem[limit];
			for (int i = 0; i < limit; i++)
			{
				(objects as Types.ObjectItem[])[i] = new Types.ObjectItem();
				(objects as Types.ObjectItem[])[i].Deserialize(reader);
			}
		}
	}
}
