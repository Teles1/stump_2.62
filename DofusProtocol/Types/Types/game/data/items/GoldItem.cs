// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GoldItem.xml' the '04/04/2012 14:27:38'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class GoldItem : Item
	{
		public const uint Id = 123;
		public override short TypeId
		{
			get
			{
				return 123;
			}
		}
		
		public int sum;
		
		public GoldItem()
		{
		}
		
		public GoldItem(int sum)
		{
			this.sum = sum;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(sum);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			sum = reader.ReadInt();
			if ( sum < 0 )
			{
				throw new Exception("Forbidden value on sum = " + sum + ", it doesn't respect the following condition : sum < 0");
			}
		}
	}
}
