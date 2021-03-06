// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'MapComplementaryInformationsDataInHouseMessage.xml' the '04/04/2012 14:27:24'
using System;
using Stump.Core.IO;
using System.Collections.Generic;

namespace Stump.DofusProtocol.Messages
{
	public class MapComplementaryInformationsDataInHouseMessage : MapComplementaryInformationsDataMessage
	{
		public const uint Id = 6130;
		public override uint MessageId
		{
			get
			{
				return 6130;
			}
		}
		
		public Types.HouseInformationsInside currentHouse;
		
		public MapComplementaryInformationsDataInHouseMessage()
		{
		}
		
		public MapComplementaryInformationsDataInHouseMessage(short subAreaId, int mapId, sbyte subareaAlignmentSide, IEnumerable<Types.HouseInformations> houses, IEnumerable<Types.GameRolePlayActorInformations> actors, IEnumerable<Types.InteractiveElement> interactiveElements, IEnumerable<Types.StatedElement> statedElements, IEnumerable<Types.MapObstacle> obstacles, IEnumerable<Types.FightCommonInformations> fights, Types.HouseInformationsInside currentHouse)
			 : base(subAreaId, mapId, subareaAlignmentSide, houses, actors, interactiveElements, statedElements, obstacles, fights)
		{
			this.currentHouse = currentHouse;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			currentHouse.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			currentHouse = new Types.HouseInformationsInside();
			currentHouse.Deserialize(reader);
		}
	}
}
