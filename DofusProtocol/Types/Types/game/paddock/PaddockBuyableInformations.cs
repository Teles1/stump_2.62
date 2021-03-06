// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PaddockBuyableInformations.xml' the '04/04/2012 14:27:39'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class PaddockBuyableInformations : PaddockInformations
	{
		public const uint Id = 130;
		public override short TypeId
		{
			get
			{
				return 130;
			}
		}
		
		public int price;
		public bool locked;
		
		public PaddockBuyableInformations()
		{
		}
		
		public PaddockBuyableInformations(short maxOutdoorMount, short maxItems, int price, bool locked)
			 : base(maxOutdoorMount, maxItems)
		{
			this.price = price;
			this.locked = locked;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(price);
			writer.WriteBoolean(locked);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			price = reader.ReadInt();
			if ( price < 0 )
			{
				throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
			}
			locked = reader.ReadBoolean();
		}
	}
}
