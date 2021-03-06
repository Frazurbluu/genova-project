using System;
using Server;

namespace Server.Items
{
	public class PrismOfLightKey : MasterKey
	{
		public override int Lifespan{ get{ return 480; } }
		
		public PrismOfLightKey() : base( 0xE27 )
		{
		}
		
		public PrismOfLightKey( Serial serial ) : base( serial )
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
		
		public override bool CanOfferConfirmation( Mobile from )
		{
			if ( from.Region != null && from.Region.IsPartOf( "Prism of Light" ) )
				return true;
				
			return false;
		}
	}
}