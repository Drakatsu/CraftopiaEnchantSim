using System;
using CES_List;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Create EquipmentLibrary Object to contain all backend info
        readonly EquipmentLibrary EqLib = new EquipmentLibrary();
        public Form1()
        {
            InitializeComponent();

            //populate equip combo boxes
            foreach (Equipment eq in EqLib.Head) HeadEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Body) BodyEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Glider) GliderEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Acc) Acc1Equip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Acc) Acc2Equip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Ammo) AmmoEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.MainHand) MainEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.OffHand) OffEquip.Items.Add(eq.name);
        }


        #region Enchant Combo Handlers + Enchant Stat display
        #region Enchant Head
        private void EnchantHead1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatHead1.Text = getEnStats(getEnchant((string)EnchantHead1.SelectedItem, EqLib.getAllEnchants()));
            
            /* To populate the Textboxes in the display build portion the template is; 
            TextBoxName.Clear();
            TextBoxName.AppendText(Function that returns the appropiate stat);
            
            use the below as an example 
            AtkBaseDyn.Clear();
            AtkBaseDyn.AppendText(Fuckin algorithm I don't got);            
            */
            
            
        }
        private void EnchantHead2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatHead2.Text = getEnStats(getEnchant((string)EnchantHead2.SelectedItem, EqLib.getAllEnchants()));
        }
        private void EnchantHead3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatHead3.Text = getEnStats(getEnchant((string)EnchantHead3.SelectedItem, EqLib.getAllEnchants()));
        }
        private void EnchantHead4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatHead4.Text = getEnStats(getEnchant((string)EnchantHead4.SelectedItem, EqLib.getAllEnchants()));
        }
        #endregion
        #region Enchant Body
        private void BodyEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatBody1.Text = getEnStats(getEnchant((string)BodyEnchant1.SelectedItem, EqLib.getAllEnchants()));
        }
        private void BodyEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatBody2.Text = getEnStats(getEnchant((string)BodyEnchant2.SelectedItem, EqLib.getAllEnchants()));
        }
        private void BodyEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatBody3.Text = getEnStats(getEnchant((string)BodyEnchant3.SelectedItem, EqLib.getAllEnchants()));
        }
        private void BodyEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatBody4.Text = getEnStats(getEnchant((string)BodyEnchant4.SelectedItem, EqLib.getAllEnchants()));
        }

        #endregion
        #region Enchant Glider
        private void GliderEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatGlider1.Text = getEnStats(getEnchant((string)GliderEnchant1.SelectedItem, EqLib.getAllEnchants()));
        }
        private void GliderEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatGlider2.Text = getEnStats(getEnchant((string)GliderEnchant2.SelectedItem, EqLib.getAllEnchants()));
        }

        private void GliderEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatGlider3.Text = getEnStats(getEnchant((string)GliderEnchant3.SelectedItem, EqLib.getAllEnchants()));
        }

        private void GliderEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatGlider4.Text = getEnStats(getEnchant((string)GliderEnchant4.SelectedItem, EqLib.getAllEnchants()));
        }
        #endregion
        #region Enchant Acc1 
        private void Acc1Enchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI1.Text = getEnStats(getEnchant((string)Acc1Enchant1.SelectedItem, EqLib.getAllEnchants()));
        }
        private void Acc1Enchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI2.Text = getEnStats(getEnchant((string)Acc1Enchant2.SelectedItem, EqLib.getAllEnchants()));
        }

        private void Acc1Enchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI3.Text = getEnStats(getEnchant((string)Acc1Enchant3.SelectedItem, EqLib.getAllEnchants()));
        }

        private void Acc1Enchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI4.Text = getEnStats(getEnchant((string)Acc1Enchant4.SelectedItem, EqLib.getAllEnchants()));
        }
        #endregion
        #region Enchant Acc2
        private void Acc2Enchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI1.Text = getEnStats(getEnchant((string)Acc2Enchant1.SelectedItem, EqLib.getAllEnchants()));
        }
        private void Acc2Enchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI2.Text = getEnStats(getEnchant((string)Acc2Enchant2.SelectedItem, EqLib.getAllEnchants()));
        }
        private void Acc2Enchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI3.Text = getEnStats(getEnchant((string)Acc2Enchant3.SelectedItem, EqLib.getAllEnchants()));
        }
        private void Acc2Enchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI4.Text = getEnStats(getEnchant((string)Acc2Enchant4.SelectedItem, EqLib.getAllEnchants()));
        }
        #endregion
        #region Enchant Ammo
        private void AmmoEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAmmo1.Text = getEnStats(getEnchant((string)AmmoEnchant1.SelectedItem, EqLib.getAllEnchants()));
        }
        private void AmmoEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAmmo2.Text = getEnStats(getEnchant((string)AmmoEnchant2.SelectedItem, EqLib.getAllEnchants()));
        }
        private void AmmoEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAmmo3.Text = getEnStats(getEnchant((string)AmmoEnchant3.SelectedItem, EqLib.getAllEnchants()));
        }
        private void AmmoEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAmmo4.Text = getEnStats(getEnchant((string)AmmoEnchant4.SelectedItem, EqLib.getAllEnchants()));
        }
        #endregion
        #region Enchant MainHand
        private void MainEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatMain1.Text = getEnStats(getEnchant((string)MainEnchant1.SelectedItem, EqLib.getAllEnchants()));
        }
        private void MainEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatMain2.Text = getEnStats(getEnchant((string)MainEnchant2.SelectedItem, EqLib.getAllEnchants()));
        }
        private void MainEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatMain3.Text = getEnStats(getEnchant((string)MainEnchant3.SelectedItem, EqLib.getAllEnchants()));
        }
        private void MainEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatMain4.Text = getEnStats(getEnchant((string)MainEnchant4.SelectedItem, EqLib.getAllEnchants()));
        }
        #endregion
        #region Enchant OffHand
        private void OffEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatOff1.Text = getEnStats(getEnchant((string)OffEnchant1.SelectedItem, EqLib.getAllEnchants()));
        }
        private void OffEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatOff2.Text = getEnStats(getEnchant((string)OffEnchant2.SelectedItem, EqLib.getAllEnchants()));
        }
        private void OffEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatOff3.Text = getEnStats(getEnchant((string)OffEnchant3.SelectedItem, EqLib.getAllEnchants()));
        }
        private void OffEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatOff4.Text = getEnStats(getEnchant((string)OffEnchant4.SelectedItem, EqLib.getAllEnchants()));
        }
        #endregion

        #endregion
        #region Equip Stat Display + Combo Box handlers 
        private void BodyEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show equipment stats
            EquipStatBody.Text = getEqStats((string)BodyEquip.SelectedItem, EqLib.Body);

            //clear enchant combo box selections
            BodyEnchant1.SelectedIndex = -1; EnchantStatBody1.Text = "";
            BodyEnchant2.SelectedIndex = -1; EnchantStatBody2.Text = "";
            BodyEnchant3.SelectedIndex = -1; EnchantStatBody3.Text = "";
            BodyEnchant4.SelectedIndex = -1; EnchantStatBody4.Text = "";

            //populate enchant combo boxes
            populateCombo((string)BodyEquip.SelectedItem, EqLib.Body, new List<System.Windows.Forms.ComboBox> { BodyEnchant1, BodyEnchant2, BodyEnchant3, BodyEnchant4 });
        }

        private void HeadEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show equip stats
            EquipStatHead.Text = getEqStats((string)HeadEquip.SelectedItem, EqLib.Head);

            //clear enchant combo box selections
            EnchantHead1.SelectedIndex = -1; EnchantStatHead1.Text = "";
            EnchantHead2.SelectedIndex = -1; EnchantStatHead2.Text = "";
            EnchantHead3.SelectedIndex = -1; EnchantStatHead3.Text = "";
            EnchantHead4.SelectedIndex = -1; EnchantStatHead4.Text = "";

            //populate enchant combo boxes
            populateCombo((string)HeadEquip.SelectedItem, EqLib.Head, new List<ComboBox> { EnchantHead1, EnchantHead2, EnchantHead3, EnchantHead4 });

            //Change Build Readout Summary
            HeadEquipDisplay.Text = (string)HeadEquip.SelectedItem;
            //HeadEnchantDisplay.Text = 
        }

        private void GliderEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //equip stats 
            EquipStatGlider.Text = getEqStats((string)GliderEquip.SelectedItem, EqLib.Glider);

            //clear enchant combo box selections
            GliderEnchant1.SelectedIndex = -1; EnchantStatGlider1.Text = "";
            GliderEnchant2.SelectedIndex = -1; EnchantStatGlider2.Text = "";
            GliderEnchant3.SelectedIndex = -1; EnchantStatGlider3.Text = "";
            GliderEnchant4.SelectedIndex = -1; EnchantStatGlider4.Text = "";

            //populate enchant combos
            populateCombo((string)GliderEquip.SelectedItem, EqLib.Glider, new List<ComboBox> { GliderEnchant1, GliderEnchant2, GliderEnchant3, GliderEnchant4 });

        }

        private void Acc1Equip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equip Stats
            EquipStatAcc1.Text = getEqStats((string)Acc1Equip.SelectedItem, EqLib.Acc);

            //clear enchant combo box selections
            Acc1Enchant1.SelectedIndex = -1; EnchantStatAccI1.Text = "";
            Acc1Enchant2.SelectedIndex = -1; EnchantStatAccI2.Text = "";
            Acc1Enchant3.SelectedIndex = -1; EnchantStatAccI3.Text = "";
            Acc1Enchant4.SelectedIndex = -1; EnchantStatAccI4.Text = "";

            //populate Acc1 enchant 
            populateCombo((string)Acc1Equip.SelectedItem, EqLib.Acc, new List<ComboBox> { Acc1Enchant1, Acc1Enchant2, Acc1Enchant3, Acc1Enchant4 });
        }

        private void Acc2Equip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equp Stats
            EquipStatAcc2.Text = getEqStats((string)Acc2Equip.SelectedItem, EqLib.Acc);

            //clear enchant combo box selections
            Acc2Enchant1.SelectedIndex = -1; EnchantStatAccII1.Text = "";
            Acc2Enchant2.SelectedIndex = -1; EnchantStatAccII2.Text = "";
            Acc2Enchant3.SelectedIndex = -1; EnchantStatAccII3.Text = "";
            Acc2Enchant4.SelectedIndex = -1; EnchantStatAccII4.Text = "";

            //populate combo
            populateCombo((string)Acc2Equip.SelectedItem, EqLib.Acc, new List<ComboBox> { Acc2Enchant1, Acc2Enchant2, Acc2Enchant3, Acc2Enchant4 });

        }

        private void AmmoEquip_SelectedIndexChanged( object sender, EventArgs e)
        {
            //Equip stats
            EquipStatAmmo.Text = getEqStats((string)AmmoEquip.SelectedItem, EqLib.Ammo);

            //clear enchant combo box selections
            AmmoEnchant1.SelectedIndex = -1; EnchantStatAmmo1.Text = "";
            AmmoEnchant2.SelectedIndex = -1; EnchantStatAmmo2.Text = "";
            AmmoEnchant3.SelectedIndex = -1; EnchantStatAmmo3.Text = "";
            AmmoEnchant4.SelectedIndex = -1; EnchantStatAmmo4.Text = "";

            //populate boxes
            populateCombo((string)AmmoEquip.SelectedItem, EqLib.Ammo, new List<ComboBox> { AmmoEnchant1, AmmoEnchant2, AmmoEnchant3, AmmoEnchant4 });


        }

        private void MainEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equip stats
            EquipStatMain.Text = getEqStats((string)MainEquip.SelectedItem, EqLib.MainHand);

            //clear enchant combo box selections
            MainEnchant1.SelectedIndex = -1; EnchantStatMain1.Text = "";
            MainEnchant2.SelectedIndex = -1; EnchantStatMain2.Text = "";
            MainEnchant3.SelectedIndex = -1; EnchantStatMain3.Text = "";
            MainEnchant4.SelectedIndex = -1; EnchantStatMain4.Text = "";

            //populate boxes
            populateCombo((string)MainEquip.SelectedItem, EqLib.MainHand, new List<ComboBox> { MainEnchant1, MainEnchant2, MainEnchant3, MainEnchant4 });


        }

        private void OffEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equip stats
            EquipStatOff.Text = getEqStats((string)OffEquip.SelectedItem, EqLib.OffHand);

            //clear enchant combo box selections
            OffEnchant1.SelectedIndex = -1; EnchantStatOff1.Text = "";
            OffEnchant2.SelectedIndex = -1; EnchantStatOff2.Text = "";
            OffEnchant3.SelectedIndex = -1; EnchantStatOff3.Text = "";
            OffEnchant4.SelectedIndex = -1; EnchantStatOff4.Text = "";

            //populate boxes
            populateCombo((string)OffEquip.SelectedItem, EqLib.OffHand, new List<ComboBox> { MainEnchant1, MainEnchant2, MainEnchant3, MainEnchant4 });


        }


        #endregion





        #region Get functions
        public Enchant getEnchant(string n, HashSet<Enchant> EnList)
        {
            foreach (Enchant en in EnList)
                if (n == en.name)
                {
                    return en;
                }
            return new Enchant(-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "Error");
        }
        #endregion

        #region quick control methods
        /*
         Method to populate any set of comboboxes when new equipment selection is made
         Pass the name of the selected Equipment, the HashSet it belongs to, and a {List} of all the comboboxes it will effect
        ie: put the 4 boxes for enchants in the {List}
         */


        public void populateCombo(string n, HashSet<Equipment> EqList, List<System.Windows.Forms.ComboBox> enchBoxs)
        {
            Equipment temp = new Equipment();
            foreach (Equipment en in EqList)
            {
                if (en.name == n)
                {
                    temp = en;
                    break;
                }
            }

            foreach (System.Windows.Forms.ComboBox eBox in enchBoxs)
            {
                foreach (Enchant enc in temp.EnLib) eBox.Items.Add(enc.name);
            }
        }



        /*
         * Method that returns single string consisting of visible data of all buffs/debuffs of an enchant
         * Does not show 0's
         */
        public string getEnStats(Enchant e)
        {
            bool first = true;
            /*
            if (e. != 0)
            {
                stats += " ";
                if (e. > 0) stats += "+";
                stats += e. + "";
            }
             */
            string stats = "";

            if (e.atk_Static != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.atk_Static > 0) stats += "+";
                stats += e.atk_Static + " Atk";
            }

            if (e.atk_Percent != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.atk_Percent > 0) stats += "+";
                stats += e.atk_Percent + "% Atk";
            }

            if (e.def_Static != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.def_Static > 0) stats += "+";
                stats += e.def_Static + " Def";
            }

            if (e.def_Percent != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;

                if (e.def_Percent > 0) stats += "+";
                stats += e.def_Percent + "% Def";
            }

            if (e.matk_Static != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.matk_Static > 0) stats += "+";
                stats += e.matk_Static + " MAtk";
            }

            if (e.matk_Percent != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.matk_Percent > 0) stats += "+";
                stats += e.matk_Percent + "% MAtk";
            }

            if (e.crit_Damage != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.crit_Damage > 0) stats += "+";
                stats += e.crit_Damage + "% Crit dmg";
            }

            if (e.crit_Chance != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.crit_Chance > 0) stats += "+";
                stats += e.crit_Chance + "% Crit";
            }

            if (e.move_Speed != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.move_Speed > 0) stats += "+";
                stats += e.move_Speed + " Move Spd";
            }

            if (e.atk_Speed != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.atk_Speed > 0) stats += "+";
                stats += e.atk_Speed + " Atk Spd";
            }

            if (e.mana_Static != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.mana_Static > 0) stats += "+";
                stats += e.mana_Static + " Mana";
            }

            if (e.mana_Percent != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.mana_Percent > 0) stats += "+";
                stats += e.mana_Percent + "% Mana";
            }

            if (e.stam_Static != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.stam_Static > 0) stats += "+";
                stats += e.stam_Static + " Stam";
            }

            if (e.stam_Percent != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.stam_Percent > 0) stats += "+";
                stats += e.stam_Percent + "% Stam";
            }

            if (e.life_Static != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.life_Static > 0) stats += "+";
                stats += e.life_Static + " HP";
            }

            if (e.life_Percent != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.life_Percent > 0) stats += "+";
                stats += e.life_Percent + "% HP";
            }

            if (e.hung_Static != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.hung_Static > 0) stats += "+";
                stats += e.hung_Static + " Sat";
            }

            if (e.hung_Percent != 0)
            {
                if (!first)
                    stats += ", ";
                else first = false;
                if (e.hung_Percent > 0) stats += "+";
                stats += e.hung_Percent + "% Sat";
            }

            return stats;
        }

        private string getEqStats(string n, HashSet<Equipment> eqL)
        {
            foreach (Equipment e in eqL)
            {
                if (n == e.name)
                    return e.atk + " ATK, " + e.matk + " MATK, " + e.def + " DEF";
            }
            return "Error";
        }

        #endregion



    }
    //private string getEnName()

}

