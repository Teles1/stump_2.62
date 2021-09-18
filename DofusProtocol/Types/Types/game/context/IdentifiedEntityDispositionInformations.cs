// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'IdentifiedEntityDispositionInformations.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class IdentifiedEntityDispositionInformations : EntityDispositionInformations
	{
		public const uint Id = 107;
		public override short TypeId
		{
			get
			{
				return 107;
			}
		}
		
		public int id;
		
		public IdentifiedEntityDispositionInformations()
		{
		}
		
		public IdentifiedEntityDispositionInformations(short cellId, sbyte direction, int id)
			 : base(cellId, direction)
		{
			this.id = id;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(id);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			id = reader.ReadInt();
		}
	}
}
