using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	public class Evocaricus : VikingSword
	{
		public override int LabelNumber{ get{ return 1074309; } } // Evocaricus (Juggernaut Set)
		
		public override SetItem SetID{ get{ return SetItem.Juggernaut; } }
		public override int Pieces{ get{ return 2; } }

		[Constructable]
		public Evocaricus() : base()
		{
			SetHue = 0x76D;
			
			Attributes.WeaponDamage = 50;
			
			SetWeaponAttributes.SelfRepair = 3;
			
			SetAttributes.DefendChance = 10;
			SetAttributes.BonusStr = 10;
			SetAttributes.WeaponSpeed = 35;
		}

		public Evocaricus( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}