// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'LockableStateUpdateHouseDoorMessage.xml' the '04/04/2012 14:27:27'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
	{
		public const uint Id = 5668;
		public override uint MessageId
		{
			get
			{
				return 5668;
			}
		}
		
		public int houseId;
		
		public LockableStateUpdateHouseDoorMessage()
		{
		}
		
		public LockableStateUpdateHouseDoorMessage(bool locked, int houseId)
			 : base(locked)
		{
			this.houseId = houseId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(houseId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			houseId = reader.ReadInt();
		}
	}
}
