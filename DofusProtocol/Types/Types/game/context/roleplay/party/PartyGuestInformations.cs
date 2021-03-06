// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'PartyGuestInformations.xml' the '04/04/2012 14:27:38'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class PartyGuestInformations
	{
		public const uint Id = 374;
		public virtual short TypeId
		{
			get
			{
				return 374;
			}
		}
		
		public int guestId;
		public int hostId;
		public string name;
		public Types.EntityLook guestLook;
		
		public PartyGuestInformations()
		{
		}
		
		public PartyGuestInformations(int guestId, int hostId, string name, Types.EntityLook guestLook)
		{
			this.guestId = guestId;
			this.hostId = hostId;
			this.name = name;
			this.guestLook = guestLook;
		}
		
		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(guestId);
			writer.WriteInt(hostId);
			writer.WriteUTF(name);
			guestLook.Serialize(writer);
		}
		
		public virtual void Deserialize(IDataReader reader)
		{
			guestId = reader.ReadInt();
			if ( guestId < 0 )
			{
				throw new Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0");
			}
			hostId = reader.ReadInt();
			if ( hostId < 0 )
			{
				throw new Exception("Forbidden value on hostId = " + hostId + ", it doesn't respect the following condition : hostId < 0");
			}
			name = reader.ReadUTF();
			guestLook = new Types.EntityLook();
			guestLook.Deserialize(reader);
		}
	}
}
