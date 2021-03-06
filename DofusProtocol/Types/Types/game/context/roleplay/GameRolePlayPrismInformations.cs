// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'GameRolePlayPrismInformations.xml' the '04/04/2012 14:27:37'
using System;
using Stump.Core.IO;

namespace Stump.DofusProtocol.Types
{
	public class GameRolePlayPrismInformations : GameRolePlayActorInformations
	{
		public const uint Id = 161;
		public override short TypeId
		{
			get
			{
				return 161;
			}
		}
		
		public Types.ActorAlignmentInformations alignInfos;
		
		public GameRolePlayPrismInformations()
		{
		}
		
		public GameRolePlayPrismInformations(int contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.ActorAlignmentInformations alignInfos)
			 : base(contextualId, look, disposition)
		{
			this.alignInfos = alignInfos;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			alignInfos.Serialize(writer);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			alignInfos = new Types.ActorAlignmentInformations();
			alignInfos.Deserialize(reader);
		}
	}
}
