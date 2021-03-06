// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'InventoryPresetItemUpdateRequestMessage.xml' the '04/04/2012 14:27:35'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class InventoryPresetItemUpdateRequestMessage : Message
	{
		public const uint Id = 6210;
		public override uint MessageId
		{
			get
			{
				return 6210;
			}
		}
		
		public sbyte presetId;
		public byte position;
		public int objUid;
		
		public InventoryPresetItemUpdateRequestMessage()
		{
		}
		
		public InventoryPresetItemUpdateRequestMessage(sbyte presetId, byte position, int objUid)
		{
			this.presetId = presetId;
			this.position = position;
			this.objUid = objUid;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(presetId);
			writer.WriteByte(position);
			writer.WriteInt(objUid);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			presetId = reader.ReadSByte();
			if ( presetId < 0 )
			{
				throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
			}
			position = reader.ReadByte();
			if ( position < 0 || position > 255 )
			{
				throw new Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 255");
			}
			objUid = reader.ReadInt();
			if ( objUid < 0 )
			{
				throw new Exception("Forbidden value on objUid = " + objUid + ", it doesn't respect the following condition : objUid < 0");
			}
		}
	}
}
