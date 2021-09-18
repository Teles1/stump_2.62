// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'SpellUpgradeRequestMessage.xml' the '04/04/2012 14:27:30'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class SpellUpgradeRequestMessage : Message
	{
		public const uint Id = 5608;
		public override uint MessageId
		{
			get
			{
				return 5608;
			}
		}
		
		public short spellId;
		
		public SpellUpgradeRequestMessage()
		{
		}
		
		public SpellUpgradeRequestMessage(short spellId)
		{
			this.spellId = spellId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(spellId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			spellId = reader.ReadShort();
			if ( spellId < 0 )
			{
				throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
			}
		}
	}
}