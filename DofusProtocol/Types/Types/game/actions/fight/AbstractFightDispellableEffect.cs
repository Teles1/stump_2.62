// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'AbstractFightDispellableEffect.xml' the '04/04/2012 14:27:36'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class AbstractFightDispellableEffect
	{
		public const uint Id = 206;
		public virtual short TypeId
		{
			get
			{
				return 206;
			}
		}
		
		public int uid;
		public int targetId;
		public short turnDuration;
		public sbyte dispelable;
		public short spellId;
		public int parentBoostUid;
		
		public AbstractFightDispellableEffect()
		{
		}
		
		public AbstractFightDispellableEffect(int uid, int targetId, short turnDuration, sbyte dispelable, short spellId, int parentBoostUid)
		{
			this.uid = uid;
			this.targetId = targetId;
			this.turnDuration = turnDuration;
			this.dispelable = dispelable;
			this.spellId = spellId;
			this.parentBoostUid = parentBoostUid;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(uid);
			writer.WriteInt(targetId);
			writer.WriteShort(turnDuration);
			writer.WriteSByte(dispelable);
			writer.WriteShort(spellId);
			writer.WriteInt(parentBoostUid);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			uid = reader.ReadInt();
			if ( uid < 0 )
			{
				throw new Exception("Forbidden value on uid = " + uid + ", it doesn't respect the following condition : uid < 0");
			}
			targetId = reader.ReadInt();
			turnDuration = reader.ReadShort();
			dispelable = reader.ReadSByte();
			if ( dispelable < 0 )
			{
				throw new Exception("Forbidden value on dispelable = " + dispelable + ", it doesn't respect the following condition : dispelable < 0");
			}
			spellId = reader.ReadShort();
			if ( spellId < 0 )
			{
				throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
			}
			parentBoostUid = reader.ReadInt();
			if ( parentBoostUid < 0 )
			{
				throw new Exception("Forbidden value on parentBoostUid = " + parentBoostUid + ", it doesn't respect the following condition : parentBoostUid < 0");
			}
		}
	}
}
