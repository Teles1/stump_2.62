// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameContextActorInformations.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class GameContextActorInformations
	{
		public const uint Id = 150;
		public virtual short TypeId
		{
			get
			{
				return 150;
			}
		}
		
		public int contextualId;
		public Types.EntityLook look;
		public Types.EntityDispositionInformations disposition;
		
		public GameContextActorInformations()
		{
		}
		
		public GameContextActorInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition)
		{
			this.contextualId = contextualId;
			this.look = look;
			this.disposition = disposition;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(contextualId);
			look.Serialize(writer);
			writer.WriteShort(disposition.TypeId);
			disposition.Serialize(writer);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			contextualId = reader.ReadInt();
			look = new Types.EntityLook();
			look.Deserialize(reader);
			disposition = ProtocolTypeManager.GetInstance<Types.EntityDispositionInformations>(reader.ReadShort());
			disposition.Deserialize(reader);
		}
	}
}
