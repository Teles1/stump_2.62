// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectEffectCreature.xml' the '04/04/2012 14:27:38'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class ObjectEffectCreature : ObjectEffect
	{
		public const uint Id = 71;
		public override short TypeId
		{
			get
			{
				return 71;
			}
		}
		
		public short monsterFamilyId;
		
		public ObjectEffectCreature()
		{
		}
		
		public ObjectEffectCreature(short actionId, short monsterFamilyId)
			 : base(actionId)
		{
			this.monsterFamilyId = monsterFamilyId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(monsterFamilyId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			monsterFamilyId = reader.ReadShort();
			if ( monsterFamilyId < 0 )
			{
				throw new Exception("Forbidden value on monsterFamilyId = " + monsterFamilyId + ", it doesn't respect the following condition : monsterFamilyId < 0");
			}
		}
	}
}
