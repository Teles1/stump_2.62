// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'EmotePlayMessage.xml' the '04/04/2012 14:27:25'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Messages
{
	public class EmotePlayMessage : EmotePlayAbstractMessage
	{
		public const uint Id = 5683;
		public override uint MessageId
		{
			get
			{
				return 5683;
			}
		}
		
		public int actorId;
		public int accountId;
		
		public EmotePlayMessage()
		{
		}
		
		public EmotePlayMessage(sbyte emoteId, double emoteStartTime, int actorId, int accountId)
			 : base(emoteId, emoteStartTime)
		{
			this.actorId = actorId;
			this.accountId = accountId;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(actorId);
			writer.WriteInt(accountId);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			actorId = reader.ReadInt();
			accountId = reader.ReadInt();
		}
	}
}