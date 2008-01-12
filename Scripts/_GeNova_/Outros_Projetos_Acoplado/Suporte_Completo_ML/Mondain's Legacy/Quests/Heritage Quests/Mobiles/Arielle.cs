using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{	
	public class Arielle : MondainQuester
	{				
		public override Type[] Quests{ get{ return new Type[] 
		{
			typeof( TheJoysOfLifeQuest )
		}; } }
	
		[Constructable]
		public Arielle() : base( "Arielle" )
		{			
			SetSkill( SkillName.Focus, 60.0, 83.0 );
		}
		
		public Arielle( Serial serial ) : base( serial )
		{
		}
		
		public override void InitBody()
		{
			InitStats( 100, 100, 25 );
			
			Female = true;
			
			Hue = 0x80;
			Body = 128;
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