// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PaddockPropertiesMessage.xml' the '04/04/2012 14:27:28'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class PaddockPropertiesMessage : Message
	{
		public const uint Id = 5824;
		public override uint MessageId
		{
			get
			{
				return 5824;
			}
		}
		
		public Types.PaddockInformations properties;
		
		public PaddockPropertiesMessage()
		{
		}
		
		public PaddockPropertiesMessage(Types.PaddockInformations properties)
		{
			this.properties = properties;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(properties.TypeId);
			properties.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			properties = Types.ProtocolTypeManager.GetInstance<Types.PaddockInformations>(reader.ReadShort());
			properties.Deserialize(reader);
		}
	}
}
