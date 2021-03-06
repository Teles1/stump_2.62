// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GuildInformationsPaddocksMessage.xml' the '04/04/2012 14:27:31'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class GuildInformationsPaddocksMessage : Message
	{
		public const uint Id = 5959;
		public override uint MessageId
		{
			get
			{
				return 5959;
			}
		}
		
		public sbyte nbPaddockMax;
		public IEnumerable<Types.PaddockContentInformations> paddocksInformations;
		
		public GuildInformationsPaddocksMessage()
		{
		}
		
		public GuildInformationsPaddocksMessage(sbyte nbPaddockMax, IEnumerable<Types.PaddockContentInformations> paddocksInformations)
		{
			this.nbPaddockMax = nbPaddockMax;
			this.paddocksInformations = paddocksInformations;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(nbPaddockMax);
			writer.WriteUShort((ushort)paddocksInformations.Count());
			foreach (var entry in paddocksInformations)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			nbPaddockMax = reader.ReadSByte();
			if ( nbPaddockMax < 0 )
			{
				throw new Exception("Forbidden value on nbPaddockMax = " + nbPaddockMax + ", it doesn't respect the following condition : nbPaddockMax < 0");
			}
			int limit = reader.ReadUShort();
			paddocksInformations = new Types.PaddockContentInformations[limit];
			for (int i = 0; i < limit; i++)
			{
				(paddocksInformations as Types.PaddockContentInformations[])[i] = new Types.PaddockContentInformations();
				(paddocksInformations as Types.PaddockContentInformations[])[i].Deserialize(reader);
			}
		}
	}
}
