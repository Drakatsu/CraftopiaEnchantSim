using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CES_List
{
	public class Enchant
	{
		public int atk_Static, atk_Percent, def_Static, def_Percent, matk_Static, matk_Percent,
			crit_Damage, crit_Chance, move_Speed, atk_Speed,
			mana_Static, mana_Percent, stam_Static, stam_Percent, life_Static, life_Percent,
			hung_Static, hung_Percent;
		public string name;
		public Enchant(int aS, int aP, int dS, int dP, int mS, int mP, int cD, int cC, int mvS, int aSp,
			int mpS, int mpP, int stS, int stP, int lS, int lP, int hS, int hP, string n)
		{
			atk_Static = aS;
			atk_Percent = aP;
			def_Static = dS;
			def_Percent = dP;
			matk_Static = mS;
			matk_Percent = mP;
			crit_Damage = cD;
			crit_Chance = cC;
			move_Speed = mvS;
			atk_Speed = aSp;
			mana_Static = mpS;
			mana_Percent = mpP;
			stam_Static = stS;
			stam_Percent = stP;
			life_Static = lS;
			life_Percent = lP;
			hung_Static = hS;
			hung_Percent = hP;
			name = n;
		}
	}

	public class Material
	{
		public string name;
		public HashSet<Enchant> EnList;

		public Material(string n, HashSet<Enchant> ls)
		{
			name = n;
			EnList = ls;
		}

	}

	public class Equipment
	{
		public string name;
		public HashSet<Enchant> EnLib = new HashSet<Enchant>();
		public int atk, matk, def;

		public Equipment(string n, int a, int m, int d, HashSet<Material> mat)
		{
			name = n;
			atk = a;
			matk = m;
			def = d;
			foreach (Material mt in mat)
				foreach (Enchant en in mt.EnList)
					EnLib.Add(en);

		}
		public Equipment() { }
	}

	public class EquipmentLibrary {
		public HashSet<Enchant> getAllEnchants()
        {
			return dungeon.EnList;
        }

		/*******************************************
						Enchantments
		********************************************/
		#region Enchants
		static Enchant
			ID006 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 40, 0, 0, 0, "Deer's"),

			ID007 = new Enchant(10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Wolf's"),

			ID008 = new Enchant(15, 0, 2, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, "Bear's"),

			ID011 = new Enchant(0, 10, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Dragon's"),

			ID012 = new Enchant(-20, 0, -5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Old"),

			ID015 = new Enchant(0, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -15, 0, 0, "Puppet's"),

			ID018 = new Enchant(0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Sharp"),

			ID020 = new Enchant(0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Hard"),

			ID022 = new Enchant(0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Valley's"),

			ID025 = new Enchant(0, -10, 0, -10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Cracked"),

			ID027 = new Enchant(10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 10, 0, 10, "Goddess's"),

			ID028 = new Enchant(0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, -50, 0, 0, 0, 0, 0, 0, "Cold-Blooded"),

			ID029 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, "Grassland's"),

			ID031 = new Enchant(0, 5, 0, 0, 0, 0, 10, 8, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, "Victorious"),

			ID032 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 5, 0, 5, 0, 0, "Wild"),

			ID034 = new Enchant(5, 0, 5, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Diamond"),

			ID035 = new Enchant(0, 5, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Polished"),

			ID037 = new Enchant(0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, "Shining"),

			ID038 = new Enchant(0, 0, 3, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Hard-Headed"),

			ID044 = new Enchant(0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Protective"),

			ID046 = new Enchant(0, 10, 0, -20, 0, 0, 0, 0, 0, 10, 0, -40, 0, 0, 0, 0, 0, 0, "Violent"),

			ID049 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, "Glorious"),

			ID051 = new Enchant(0, 10, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, -30, 0, 0, "Deadly"),

			ID052 = new Enchant(0, 20, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Frozen"),

			ID054 = new Enchant(0, 0, 0, 0, 10, 5, 0, 0, 0, 0, 40, 0, 0, 0, 0, 0, 0, 0, "Ancient"),

			ID059 = new Enchant(0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Earth's"),

			ID066 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Breeze"),

			ID068 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Raven"),

			ID070 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Fast"),

			ID071 = new Enchant(20, 10, 0, -10, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, -40, "Destructive"),

			ID072 = new Enchant(0, 3, 0, 3, 0, 0, 0, 0, 0, 0, 0, 7, 0, 7, 0, 7, 0, 7, "Rainbow"),

			ID073 = new Enchant(15, 10, -5, 0, 0, 0, 15, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Dangerous"),

			ID081 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, "Storm's"),

			ID083 = new Enchant(0, 20, 0, 20, 0, 0, 0, 0, 0, 0, 0, -50, 0, 0, 0, -50, 0, 0, "Cursed"),

			ID086 = new Enchant(0, 10, 0, 0, 0, 0, 0, 0, -3, -10, 0, 0, 0, 0, 0, 20, 0, 20, "Giant"),

			ID089 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Buffalo's"),

			ID090 = new Enchant(0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Giraffe's"),

			ID091 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, -5, 0, 0, 0, 0, 0, 30, 10, 0, 0, "Elephant's"),

			ID093 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 10, 0, "Camel's"),

			ID094 = new Enchant(0, 0, -5, -20, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, "Chicken's"),

			ID095 = new Enchant(1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Fox's"),

			ID096 = new Enchant(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Black-tailed gull's"),

			ID103 = new Enchant(5, 7, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Gorilla's"),

			ID105 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -5, 0, 0, "Half-dead"),

			ID106 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, "Fresh"),

			ID107 = new Enchant(50, 0, 0, 0, 0, 0, 0, 0, 10, 30, 0, 0, 0, 0, 0, 0, 0, 0, "Legendary"),

			ID108 = new Enchant(0, 0, 0, 0, 20, 5, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, "Bouncing"),

			ID109 = new Enchant(10, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 5, 0, 0, "Gigantic"),

			ID110 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -5, 0, 0, "Wet"),

			ID115 = new Enchant(0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Focused"),

			ID116 = new Enchant(0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Small Spirit's"),

			ID117 = new Enchant(0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Small Fairy's"),

			ID118 = new Enchant(9, 0, -9, 0, 9, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, -9, 0, 0, "Final Deadly"),

			ID119 = new Enchant(0, 0, -10, -50, 0, 0, 0, 100, 0, -40, 0, 0, 0, 0, 0, -50, 0, 0, "Stabbing"),

			ID120 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 40, 0, 0, 0, 0, 0, 0, 0, 0, "Demon's"),

			ID121 = new Enchant(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Goblin's"),

			ID122 = new Enchant(10, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 15, 0, 0, 0, "Warrior"),

			ID123 = new Enchant(-15, -10, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Shaman"),

			ID125 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 5, 10, 0, 0, 0, 0, 0, 0, 0, 0, "Bard"),

			ID126 = new Enchant(0, 0, 0, 0, 0, 0, 0, 10, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Lizard"),

			ID127 = new Enchant(0, 0, 0, 0, 0, 0, 20, -10, -10, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Axe"),

			ID128 = new Enchant(0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0, "Freezing"),

			ID129 = new Enchant(10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0, "Scorching"),

			ID130 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, "Ominous"),

			ID131 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, "Dried"),

			ID132 = new Enchant(10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 0, 0, 0, 0, "More Scorching"),

			ID133 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, "More Ominous"),

			ID134 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, "More Dried"),

			ID135 = new Enchant(10, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Sword"),

			ID136 = new Enchant(0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Golem's"),

			ID137 = new Enchant(0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Stone"),

			ID138 = new Enchant(5, 0, -2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Lava"),

			ID139 = new Enchant(0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, "Ice"),

			ID140 = new Enchant(0, 0, 2, 0, 0, 0, 0, 0, -5, -5, 0, 0, 0, 0, 0, 0, 0, 0, "Iron"),

			ID141 = new Enchant(0, 0, 0 - 5, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, "Skeleton's"),

			ID160 = new Enchant(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Alexandria's"),

			ID161 = new Enchant(0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Kevin's"),

			ID162 = new Enchant(0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Fan's"),

			ID163 = new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, "Smith's"),

			ID164 = new Enchant(0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Ferghus's"),

			ID165 = new Enchant(10, 0, 10, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 10, 0, 0, 0, "Anubis's"),

			ID166 = new Enchant(0, 0, -5, 0, 30, 20, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, 0, 0, "Fire Spirit"),

			ID167 = new Enchant(3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0, 30, 0, 0, 0, "Palm"),

			ID168 = new Enchant(35, 15, -5, 0, -10, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, 0, 0, "Fire Demon"),

			ID169 = new Enchant(15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 30, 0, 0, 0, "Veteran"),

			ID170 = new Enchant(0, 10, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 20, 0, 0, 0, 10, 0, "Crimson");
        #endregion
        /*******************************************
						  Materials
		********************************************/
        #region Materials
        /*
		 = new Material("", new HashSet<Enchant>{})
		 */

        static Material
			log = new Material("Log", new HashSet<Enchant> { ID168, ID166, ID167 }),

			leather = new Material("Leather", new HashSet<Enchant> { ID127, ID008, ID089, ID093, ID073, ID006, ID091, ID095, ID090, ID126, ID135, ID007 }),

			stone = new Material("Stone", new HashSet<Enchant> { ID131, ID128, ID136, ID134, ID129, ID132, ID137 }),

			copper = new Material("Copper", new HashSet<Enchant> { ID131, ID128, ID134, ID129, ID132 }),

			iron = new Material("Iron", new HashSet<Enchant> { ID131, ID128, ID134, ID129, ID132, ID054, ID170, ID073, ID011, ID136, ID137, ID169 }),

			silver = new Material("Silver", new HashSet<Enchant> { ID131, ID128, ID134, ID129, ID132, ID054, ID136, ID137, ID169 }),

			steel = new Material("Steel", new HashSet<Enchant> { ID131, ID128, ID134, ID129, ID132, ID054, ID170, ID073, ID011, ID136, ID137, ID169 }),

			titanium = new Material("Titanium", new HashSet<Enchant> { ID131, ID128, ID134, ID129, ID132, ID170, ID011 }),

			gold = new Material("Gold", new HashSet<Enchant> { ID131, ID128, ID134, ID129, ID132 }),

			platinum = new Material("Platinum", new HashSet<Enchant> { ID131, ID128, ID134, ID129, ID132, ID170, ID011 }),

			feather = new Material("Feather", new HashSet<Enchant> { ID094 }),

			talon = new Material("Talon", new HashSet<Enchant> { ID127, ID008, ID126, ID135 }),

			horn = new Material("Horn", new HashSet<Enchant> { ID089, ID006, ID091 }),

			bone = new Material("Bone", new HashSet<Enchant> { ID089, ID093, ID006, ID090, ID141 }),

			poop = new Material("Feces", new HashSet<Enchant> { ID160, ID165, ID096, ID162, ID164, ID161, ID163, ID007 }),

			fish = new Material("Fish", new HashSet<Enchant> { ID108, ID107 }),

			dungeon = new Material("Dungeon Find or Modded", new HashSet<Enchant> {
										 ID006, ID007, ID008, ID011, ID012, ID015, ID018, ID020, ID025, ID027, ID028, ID029, ID031, ID032, ID034,
										 ID035, ID037, ID038, ID044, ID046, ID049, ID051, ID052, ID054, ID059, ID066, ID068, ID070, ID071,
										 ID072, ID073, ID081, ID083, ID086, ID089, ID090, ID091, ID093, ID094, ID095, ID096, ID103, ID105, ID107,
										 ID108, ID109, ID110, ID115, ID116, ID117, ID118, ID119, ID120, ID121, ID122, ID123, ID125, ID126,
										 ID127, ID128, ID129, ID130, ID131, ID132, ID133, ID134, ID135, ID136, ID137, ID138, ID139, ID140,
										 ID141, ID160, ID161, ID162, ID164, ID165, ID166, ID167, ID168, ID169, ID170 });
        #endregion
        /*******************************************
						Equipments
		********************************************/
        #region Equips
        /*
		 = new Equipment("", 0, 0, 0, new HashSet<Material>{})
		*/

        //Head Slot
        static Equipment
			CopHat = new Equipment("Copper Hat", 0, 0, 5, new HashSet<Material> { leather, copper, feather, horn }),
			MagHat = new Equipment("Magical Hat", 5, 15, 0, new HashSet<Material> { feather }),
			RngHat = new Equipment("Ranger's Cap", 5, 5, 5, new HashSet<Material> { leather, feather, talon }),

			Crown = new Equipment("Glittering Crown", 5, 5, 5, new HashSet<Material> { gold }),
			RBeret = new Equipment("Red Beret", 5, 5, 5, new HashSet<Material> { leather, iron });

		public HashSet<Equipment> Head = new HashSet<Equipment> { CopHat, MagHat, RngHat, Crown, RBeret };

		//Body Slot
		static Equipment
			Cape = new Equipment("Orange/Green Cape", 0, 0, 5, new HashSet<Material> { leather }),
			LArmor = new Equipment("Black/White Light Armor", 0, 0, 5, new HashSet<Material> { leather, iron });

		public HashSet<Equipment> Body = new HashSet<Equipment> { Cape, LArmor };



		//Glider Slot
		static Equipment
			StoneGlider = new Equipment("Stone Glider", 0, 0, 0, new HashSet<Material> { stone, log });

		public HashSet<Equipment> Glider = new HashSet<Equipment> { StoneGlider };

		//Acc Slot
		static Equipment
			Bell = new Equipment("Bell", 0, 0, 0, new HashSet<Material> { iron, silver }),
			Detector = new Equipment("Detector", 0, 0, 0, new HashSet<Material> { stone, copper }),
			IRing = new Equipment("Iron Ring", 0, 0, 2, new HashSet<Material> { iron }),

			IAmulet = new Equipment("Iron Amulet", 2, 2, 0, new HashSet<Material> { iron }),
			PassionAmu = new Equipment("Amulet of Passion", 0, 0, 0, new HashSet<Material> { steel, poop }),
			ImmuneAmu = new Equipment("Amulet of Immunity", 0, 0, 0, new HashSet<Material> { steel, poop }),

			ColdBAmu = new Equipment("Amulet of Cold-blooded", 0, 0, 0, new HashSet<Material> { steel, fish });

		public HashSet<Equipment> Acc = new HashSet<Equipment> { Bell, Detector, IRing, IAmulet, PassionAmu, ImmuneAmu, ColdBAmu };

		//Ammo Slot
		static Equipment
			WArrow = new Equipment("Stronger Arrow", 5, 5, 0, new HashSet<Material> { log }),
			SArrow = new Equipment("Stone Arrow", 10, 10, 0, new HashSet<Material> { log, stone }),
			FArrow = new Equipment("Fire Arrow", 0, 0, 0, new HashSet<Material> { log, stone });

		public HashSet<Equipment> Ammo = new HashSet<Equipment> { WArrow, SArrow, FArrow };

		//Main Hand
		static Equipment
			Stick = new Equipment("Wooden Stick I", 30, 30, 0, new HashSet<Material> { log }),
			Stone1h = new Equipment("Stone One-handed Sword", 40, 40, 0, new HashSet<Material> { log, stone }),
			Copper1h = new Equipment("Copper One-handed Sword", 80, 80, 0, new HashSet<Material> { copper }),

			Iron1h = new Equipment("Iron One-handed Sword", 100, 100, 0, new HashSet<Material> { iron }),
			Silver1h = new Equipment("Silver One-handed Sword", 120, 120, 0, new HashSet<Material> { silver }),
			Steel1h = new Equipment("Steel One-handed Sword", 135, 135, 0, new HashSet<Material> { steel }),

			Tit1h = new Equipment("Titanium One-handed Sword", 150, 150, 0, new HashSet<Material> { titanium }),
			Gold1h = new Equipment("Gold One-handed Sword", 200, 200, 0, new HashSet<Material> { gold }),
			Plat1h = new Equipment("Platinum One-handed Sword", 180, 180, 0, new HashSet<Material> { platinum }),

			StoneBow = new Equipment("Stone Bow", 15, 15, 0, new HashSet<Material> { log, stone }),
			CopperBow = new Equipment("Copper Bow", 30, 30, 0, new HashSet<Material> { log, copper }),
			IronBow = new Equipment("Iron Bow", 40, 40, 0, new HashSet<Material> { log, iron }),

			SilverBow = new Equipment("Silver Bow", 50, 50, 0, new HashSet<Material> { log, leather, silver }),
			SteelBow = new Equipment("Steel Bow", 55, 55, 0, new HashSet<Material> { log, leather, steel }),
			TitBow = new Equipment("Titanium Bow", 60, 60, 0, new HashSet<Material> { log, leather, titanium }),

			GoldBow = new Equipment("Gold Bow", 85, 85, 0, new HashSet<Material> { log, leather, gold }),
			PlatBow = new Equipment("Platinum Bow", 70, 70, 0, new HashSet<Material> { log, leather, platinum }),
			StonePic = new Equipment("Stone Pickaxe", 40, 40, 0, new HashSet<Material> { log, stone }),

			CopperPic = new Equipment("Copper Pickaxe", 80, 80, 0, new HashSet<Material> { copper }),
			IronPic = new Equipment("Iron Pickaxe", 100, 100, 0, new HashSet<Material> { iron }),
			SilverPic = new Equipment("Silver Pickaxe", 120, 120, 0, new HashSet<Material> { silver }),

			SteelPic = new Equipment("Steel Pickaxe", 135, 135, 0, new HashSet<Material> { steel }),
			TitPic = new Equipment("Titanium Pickaxe", 150, 150, 0, new HashSet<Material> { titanium }),
			GoldPic = new Equipment("Gold Pickaxe", 200, 200, 0, new HashSet<Material> { gold }),

			PlatPic = new Equipment("Platinum Pickaxe", 180, 180, 0, new HashSet<Material> { platinum }),
			WoodAx = new Equipment("Wooden Axe", 40, 40, 0, new HashSet<Material> { log }),
			CopperAx = new Equipment("Copper Axe", 80, 80, 0, new HashSet<Material> { log, copper }),

			IronAx = new Equipment("Iron Axe", 100, 100, 0, new HashSet<Material> { log, iron }),
			SilverAx = new Equipment("Silver Axe", 120, 120, 0, new HashSet<Material> { log, silver }),
			SteelAx = new Equipment("Steel Axe", 135, 135, 0, new HashSet<Material> { log, steel }),

			TitAx = new Equipment("Titanium Axe", 150, 150, 0, new HashSet<Material> { log, titanium }),
			GoldAx = new Equipment("Gold Axe", 200, 200, 0, new HashSet<Material> { log, gold }),
			PlatAx = new Equipment("Platinum Axe", 180, 180, 0, new HashSet<Material> { log, platinum }),

			Rod = new Equipment("Wooden Fishing Rod", 0, 0, 0, new HashSet<Material> { log }),
			Knight2h = new Equipment("Knight's Sword", 160, 160, 0, new HashSet<Material> { iron, talon }),
			KukriI = new Equipment("Kukri I", 100, 100, 0, new HashSet<Material> { iron, talon }),

			MacheteI = new Equipment("Machete I", 110, 110, 0, new HashSet<Material> { iron, talon, horn }),
			BroadSwordI = new Equipment("Broad Sword I", 145, 145, 0, new HashSet<Material> { iron, talon, horn }),
			DK2hII = new Equipment("Sword of the Dark Knight II", 245, 245, 0, new HashSet<Material> { talon, horn }),

			Torch2h = new Equipment("Two-handed Torch", 0, 0, 0, new HashSet<Material> { log });

		public HashSet<Equipment> MainHand = new HashSet<Equipment>
		{
			Stick, Stone1h, Copper1h, Iron1h, Silver1h, Steel1h, Tit1h, Gold1h, Plat1h,
									   StoneBow, CopperBow, IronBow, SilverBow, SteelBow, TitBow, GoldBow, PlatBow,
									   StonePic, CopperPic, IronPic, SilverPic, SteelPic, TitPic, GoldPic, PlatPic,
									   WoodAx, CopperAx, IronAx, SilverAx, SteelAx, TitAx, GoldAx, PlatAx,
									   Rod, Knight2h, KukriI, MacheteI, BroadSwordI, DK2hII, Torch2h
		};

		//Off Hand
		static Equipment
			Torch1h = new Equipment("One-handed Torch", 0, 0, 0, new HashSet<Material> { log }),
			MonPrism = new Equipment("Monster Prism", 0, 0, 0, new HashSet<Material> { iron }),
			Bucket = new Equipment("Bucket (Empty)", 0, 0, 0, new HashSet<Material> { iron }),

			CopShield = new Equipment("Copper Shield", 0, 15, 5, new HashSet<Material> { log, copper }),
			IronShield = new Equipment("Iron Shield", 0, 30, 7, new HashSet<Material> { log, iron }),
			SlvShield = new Equipment("Silver Shield", 0, 45, 10, new HashSet<Material> { log, silver }),

			StlShield = new Equipment("Steel Shield", 0, 70, 15, new HashSet<Material> { log, steel }),
			TitShield = new Equipment("Titanium Shield", 0, 40, 21, new HashSet<Material> { log, titanium }),
			GoldShield = new Equipment("Gold Shield", 0, 50, 28, new HashSet<Material> { log, gold }),

			PlatShield = new Equipment("Platinum Shield", 0, 60, 35, new HashSet<Material> { log, platinum });

		public HashSet<Equipment> OffHand = new HashSet<Equipment> { Torch1h, MonPrism, Bucket, CopShield, IronShield, SlvShield, StlShield, TitShield, GoldShield, PlatShield };
	#endregion
	}
}
