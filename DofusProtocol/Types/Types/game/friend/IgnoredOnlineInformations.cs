// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'IgnoredOnlineInformations.xml' the '04/04/2012 14:27:38'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class IgnoredOnlineInformations : IgnoredInformations
	{
		public const uint Id = 105;
		public override short TypeId
		{
			get
			{
				return 105;
			}
		}
		
		public string playerName;
		public sbyte breed;
		public bool sex;
		
		public IgnoredOnlineInformations()
		{
		}
		
		public IgnoredOnlineInformations(int accountId, string accountName, string playerName, sbyte breed, bool sex)
			 : base(accountId, accountName)
		{
			this.playerName = playerName;
			this.breed = breed;
			this.sex = sex;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(playerName);
			writer.WriteSByte(breed);
			writer.WriteBoolean(sex);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			playerName = reader.ReadUTF();
			breed = reader.ReadSByte();
			if ( breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Zobal )
			{
				throw new Exception("Forbidden value on breed = " + breed + ", it doesn't respect the following condition : breed < (byte)Enums.PlayableBreedEnum.Feca || breed > (byte)Enums.PlayableBreedEnum.Zobal");
			}
			sex = reader.ReadBoolean();
		}
	}
}
