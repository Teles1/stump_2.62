// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectItemInRolePlay.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class ObjectItemInRolePlay
	{
		public const uint Id = 198;
		public virtual short TypeId
		{
			get
			{
				return 198;
			}
		}
		
		public short cellId;
		public short objectGID;
		
		public ObjectItemInRolePlay()
		{
		}
		
		public ObjectItemInRolePlay(short cellId, short objectGID)
		{
			this.cellId = cellId;
			this.objectGID = objectGID;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteShort(cellId);
			writer.WriteShort(objectGID);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			cellId = reader.ReadShort();
			if ( cellId < 0 || cellId > 559 )
			{
				throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
			}
			objectGID = reader.ReadShort();
			if ( objectGID < 0 )
			{
				throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
			}
		}
	}
}
