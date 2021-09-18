// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectItemNotInContainer.xml' the '04/04/2012 14:27:38'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Types
{
	public class ObjectItemNotInContainer : Item
	{
		public const uint Id = 134;
		public override short TypeId
		{
			get
			{
				return 134;
			}
		}
		
		public short objectGID;
		public short powerRate;
		public bool overMax;
		public IEnumerable<Types.ObjectEffect> effects;
		public int objectUID;
		public int quantity;
		
		public ObjectItemNotInContainer()
		{
		}
		
		public ObjectItemNotInContainer(short objectGID, short powerRate, bool overMax, IEnumerable<Types.ObjectEffect> effects, int objectUID, int quantity)
		{
			this.objectGID = objectGID;
			this.powerRate = powerRate;
			this.overMax = overMax;
			this.effects = effects;
			this.objectUID = objectUID;
			this.quantity = quantity;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(objectGID);
			writer.WriteShort(powerRate);
			writer.WriteBoolean(overMax);
			writer.WriteUShort((ushort)effects.Count());
			foreach (var entry in effects)
			{
				writer.WriteShort(entry.TypeId);
				entry.Serialize(writer);
			}
			writer.WriteInt(objectUID);
			writer.WriteInt(quantity);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			objectGID = reader.ReadShort();
			if ( objectGID < 0 )
			{
				throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
			}
			powerRate = reader.ReadShort();
			overMax = reader.ReadBoolean();
			int limit = reader.ReadUShort();
			effects = new Types.ObjectEffect[limit];
			for (int i = 0; i < limit; i++)
			{
				(effects as Types.ObjectEffect[])[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
				(effects as Types.ObjectEffect[])[i].Deserialize(reader);
			}
			objectUID = reader.ReadInt();
			if ( objectUID < 0 )
			{
				throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
			}
			quantity = reader.ReadInt();
			if ( quantity < 0 )
			{
				throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
			}
		}
	}
}