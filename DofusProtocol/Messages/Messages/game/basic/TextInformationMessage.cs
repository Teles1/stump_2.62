// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'TextInformationMessage.xml' the '04/04/2012 14:27:22'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class TextInformationMessage : Message
	{
		public const uint Id = 780;
		public override uint MessageId
		{
			get
			{
				return 780;
			}
		}
		
		public sbyte msgType;
		public short msgId;
		public IEnumerable<string> parameters;
		
		public TextInformationMessage()
		{
		}
		
		public TextInformationMessage(sbyte msgType, short msgId, IEnumerable<string> parameters)
		{
			this.msgType = msgType;
			this.msgId = msgId;
			this.parameters = parameters;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(msgType);
			writer.WriteShort(msgId);
			writer.WriteUShort((ushort)parameters.Count());
			foreach (var entry in parameters)
			{
				writer.WriteUTF(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			msgType = reader.ReadSByte();
			if ( msgType < 0 )
			{
				throw new Exception("Forbidden value on msgType = " + msgType + ", it doesn't respect the following condition : msgType < 0");
			}
			msgId = reader.ReadShort();
			if ( msgId < 0 )
			{
				throw new Exception("Forbidden value on msgId = " + msgId + ", it doesn't respect the following condition : msgId < 0");
			}
			int limit = reader.ReadUShort();
			parameters = new string[limit];
			for (int i = 0; i < limit; i++)
			{
				(parameters as string[])[i] = reader.ReadUTF();
			}
		}
	}
}
