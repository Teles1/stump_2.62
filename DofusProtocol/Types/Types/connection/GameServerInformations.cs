// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameServerInformations.xml' the '04/04/2012 14:27:36'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class GameServerInformations
	{
		public const uint Id = 25;
		public virtual short TypeId
		{
			get
			{
				return 25;
			}
		}
		
		public ushort id;
		public sbyte status;
		public sbyte completion;
		public bool isSelectable;
		public sbyte charactersCount;
		public double date;
		
		public GameServerInformations()
		{
		}
		
		public GameServerInformations(ushort id, sbyte status, sbyte completion, bool isSelectable, sbyte charactersCount, double date)
		{
			this.id = id;
			this.status = status;
			this.completion = completion;
			this.isSelectable = isSelectable;
			this.charactersCount = charactersCount;
			this.date = date;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteUShort(id);
			writer.WriteSByte(status);
			writer.WriteSByte(completion);
			writer.WriteBoolean(isSelectable);
			writer.WriteSByte(charactersCount);
			writer.WriteDouble(date);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			id = reader.ReadUShort();
			if ( id < 0 || id > 65535 )
			{
				throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0 || id > 65535");
			}
			status = reader.ReadSByte();
			if ( status < 0 )
			{
				throw new Exception("Forbidden value on status = " + status + ", it doesn't respect the following condition : status < 0");
			}
			completion = reader.ReadSByte();
			if ( completion < 0 )
			{
				throw new Exception("Forbidden value on completion = " + completion + ", it doesn't respect the following condition : completion < 0");
			}
			isSelectable = reader.ReadBoolean();
			charactersCount = reader.ReadSByte();
			if ( charactersCount < 0 )
			{
				throw new Exception("Forbidden value on charactersCount = " + charactersCount + ", it doesn't respect the following condition : charactersCount < 0");
			}
			date = reader.ReadDouble();
		}
	}
}
