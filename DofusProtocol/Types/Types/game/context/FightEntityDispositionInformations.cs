// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'FightEntityDispositionInformations.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class FightEntityDispositionInformations : EntityDispositionInformations
	{
		public const uint Id = 217;
		public override short TypeId
		{
			get
			{
				return 217;
			}
		}
		
		public int carryingCharacterId;
		
		public FightEntityDispositionInformations()
		{
		}
		
		public FightEntityDispositionInformations(short cellId, sbyte direction, int carryingCharacterId)
			 : base(cellId, direction)
		{
			this.carryingCharacterId = carryingCharacterId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(carryingCharacterId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			carryingCharacterId = reader.ReadInt();
		}
	}
}