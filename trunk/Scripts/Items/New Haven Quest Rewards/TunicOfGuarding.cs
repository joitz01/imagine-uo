using System; 
using Server; 
using Server.Mobiles;

namespace Server.Items
{
	public class TunicOfGuarding : LeatherChest
	{
		public override int LabelNumber{ get{ return 1077693; } } // Tunic of Guarding

		public override int BasePhysicalResistance{ get{ return 6; } }
		public override int BaseFireResistance{ get{ return 6; } }
		public override int BaseColdResistance{ get{ return 5; } }
		public override int BasePoisonResistance{ get{ return 5; } }
		public override int BaseEnergyResistance{ get{ return 5; } }

		[Constructable]
		public TunicOfGuarding() : base()
		{
			LootType = LootType.Blessed;

			Attributes.BonusHits = 2;
			Attributes.ReflectPhysical = 5;

			ItemValue = ItemValue.Uncommon;
		}

		public TunicOfGuarding( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}