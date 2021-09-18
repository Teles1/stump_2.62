// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharacterSelectionWithRecolorMessage.xml' the '04/04/2012 14:27:22'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class CharacterSelectionWithRecolorMessage : CharacterSelectionMessage
	{
		public const uint Id = 6075;
		public override uint MessageId
		{
			get
			{
				return 6075;
			}
		}
		
		public IEnumerable<int> indexedColor;
		
		public CharacterSelectionWithRecolorMessage()
		{
		}
		
		public CharacterSelectionWithRecolorMessage(int id, IEnumerable<int> indexedColor)
			 : base(id)
		{
			this.indexedColor = indexedColor;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUShort((ushort)indexedColor.Count());
			foreach (var entry in indexedColor)
			{
				writer.WriteInt(entry);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			int limit = reader.ReadUShort();
			indexedColor = new int[limit];
			for (int i = 0; i < limit; i++)
			{
				(indexedColor as int[])[i] = reader.ReadInt();
			}
		}
	}
}
