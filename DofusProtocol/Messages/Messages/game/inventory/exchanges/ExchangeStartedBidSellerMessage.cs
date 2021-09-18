// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeStartedBidSellerMessage.xml' the '04/04/2012 14:27:33'
using System;
using Stump.Core.IO;
using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.Messages
{
	public class ExchangeStartedBidSellerMessage : Message
	{
		public const uint Id = 5905;
		public override uint MessageId
		{
			get
			{
				return 5905;
			}
		}
		
		public Types.SellerBuyerDescriptor sellerDescriptor;
		public IEnumerable<Types.ObjectItemToSellInBid> objectsInfos;
		
		public ExchangeStartedBidSellerMessage()
		{
		}
		
		public ExchangeStartedBidSellerMessage(Types.SellerBuyerDescriptor sellerDescriptor, IEnumerable<Types.ObjectItemToSellInBid> objectsInfos)
		{
			this.sellerDescriptor = sellerDescriptor;
			this.objectsInfos = objectsInfos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			sellerDescriptor.Serialize(writer);
			writer.WriteUShort((ushort)objectsInfos.Count());
			foreach (var entry in objectsInfos)
			{
				entry.Serialize(writer);
			}
		}
		
		public override void Deserialize(IDataReader reader)
		{
			sellerDescriptor = new Types.SellerBuyerDescriptor();
			sellerDescriptor.Deserialize(reader);
			int limit = reader.ReadUShort();
			objectsInfos = new Types.ObjectItemToSellInBid[limit];
			for (int i = 0; i < limit; i++)
			{
				(objectsInfos as Types.ObjectItemToSellInBid[])[i] = new Types.ObjectItemToSellInBid();
				(objectsInfos as Types.ObjectItemToSellInBid[])[i].Deserialize(reader);
			}
		}
	}
}