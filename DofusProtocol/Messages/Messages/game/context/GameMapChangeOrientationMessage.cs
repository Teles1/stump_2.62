// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameMapChangeOrientationMessage.xml' the '04/04/2012 14:27:23'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class GameMapChangeOrientationMessage : Message
	{
		public const uint Id = 946;
		public override uint MessageId
		{
			get
			{
				return 946;
			}
		}
		
		public Types.ActorOrientation orientation;
		
		public GameMapChangeOrientationMessage()
		{
		}
		
		public GameMapChangeOrientationMessage(Types.ActorOrientation orientation)
		{
			this.orientation = orientation;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			orientation.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			orientation = new Types.ActorOrientation();
			orientation.Deserialize(reader);
		}
	}
}
