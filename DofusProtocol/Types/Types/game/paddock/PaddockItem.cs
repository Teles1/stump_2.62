// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PaddockItem.xml' the '04/04/2012 14:27:39'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class PaddockItem : ObjectItemInRolePlay
	{
		public const uint Id = 185;
		public override short TypeId
		{
			get
			{
				return 185;
			}
		}
		
		public Types.ItemDurability durability;
		
		public PaddockItem()
		{
		}
		
		public PaddockItem(short cellId, short objectGID, Types.ItemDurability durability)
			 : base(cellId, objectGID)
		{
			this.durability = durability;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			durability.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			durability = new Types.ItemDurability();
			durability.Deserialize(reader);
		}
	}
}
