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
        

        //Define Backend Ints to hold data
        public int 
            ttl_atk_Static = 0, ttl_atk_Percent = 0, ttl_def_Static = 0, ttl_def_Percent = 0, ttl_matk_Static = 0, ttl_matk_Percent = 0,
            ttl_crit_Damage = 0, ttl_crit_Chance = 0, ttl_move_Speed = 0, ttl_atk_Speed = 0,
            ttl_mana_Static = 0, ttl_mana_Percent = 0, ttl_stam_Static = 0, ttl_stam_Percent = 0, ttl_life_Static = 0, ttl_life_Percent = 0,
            ttl_hung_Static = 0, ttl_hung_Percent = 0;

        //Define Backend String Lists to hold current/previous selections
        public List<string> HeadLS = new List<string> { "", "", "", "", "" }, BodyLS = new List<string> { "", "", "", "", "" }, GliderLS = new List<string> { "", "", "", "", "" }, 
                        Acc1LS = new List<string> { "", "", "", "", "" }, Acc2LS = new List<string> { "", "", "", "", "" }, AmmoLS = new List<string> { "", "", "", "", "" },
                        MainLS = new List<string> { "", "", "", "", "" }, OffLS = new List<string> { "", "", "", "", "" };
        public Form1()
        {
            InitializeComponent();
            EqLib.allEqBuild();
            
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
            //define placeholder string for temporary holding to simplify some code
            string BodyEquipCurrent = (string)BodyEquip.SelectedItem;

            //show equipment stats
            EquipStatBody.Text = getEqStats(BodyEquipCurrent, EqLib.Body);

            //add this to all Equip Selection Change handlers
            //clear enchant combo box selections
            BodyEnchant1.SelectedIndex = -1; EnchantStatBody1.Text = "";
            BodyEnchant2.SelectedIndex = -1; EnchantStatBody2.Text = "";
            BodyEnchant3.SelectedIndex = -1; EnchantStatBody3.Text = "";
            BodyEnchant4.SelectedIndex = -1; EnchantStatBody4.Text = "";

            //populate enchant combo boxes
            populateCombo(BodyEquipCurrent, EqLib.Body, new List<System.Windows.Forms.ComboBox> { BodyEnchant1, BodyEnchant2, BodyEnchant3, BodyEnchant4 });

            //check for any changes in stats and apply them
            calcStat(BodyLS, BodyEquipCurrent, (string)BodyEnchant1.SelectedItem, (string)BodyEnchant2.SelectedItem, (string)BodyEnchant3.SelectedItem, (string)BodyEnchant4.SelectedItem);
            
            //set backend List to new values
            BodyLS = new List<string>{BodyEquipCurrent, (string)BodyEnchant1.SelectedItem, (string)BodyEnchant2.SelectedItem, (string)BodyEnchant3.SelectedItem, (string)BodyEnchant4.SelectedItem};

        }

        private void HeadEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show Equip stats
            EquipStatHead.Text = getEqStats((string)HeadEquip.SelectedItem, EqLib.Head);

            //populate enchant combo boxes
            populateCombo((string)HeadEquip.SelectedItem, EqLib.Head, new List<ComboBox> { EnchantHead1, EnchantHead2, EnchantHead3, EnchantHead4 });

            //Change Build Readout Summary
            HeadEquipDisplay.Text = (string)HeadEquip.SelectedItem;
            //HeadEnchantDisplay.Text = 
        }

        private void GliderEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equip stats 
            EquipStatGlider.Text = getEqStats((string)GliderEquip.SelectedItem, EqLib.Glider);

            //populate enchant combos
            populateCombo((string)GliderEquip.SelectedItem, EqLib.Glider, new List<ComboBox> { GliderEnchant1, GliderEnchant2, GliderEnchant3, GliderEnchant4 });

        }

        private void Acc1Equip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equip Stats
            EquipStatAcc1.Text = getEqStats((string)Acc1Equip.SelectedItem, EqLib.Acc);

            //populate Acc1 enchant 
            populateCombo((string)Acc1Equip.SelectedItem, EqLib.Acc, new List<ComboBox> { Acc1Enchant1, Acc1Enchant2, Acc1Enchant3, Acc1Enchant4 });
        }

        private void Acc2Equip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equp Stats
            EquipStatAcc2.Text = getEqStats((string)Acc2Equip.SelectedItem, EqLib.Acc);

            //populate combo
            populateCombo((string)Acc2Equip.SelectedItem, EqLib.Acc, new List<ComboBox> { Acc2Enchant1, Acc2Enchant2, Acc2Enchant3, Acc2Enchant4 });

        }

        private void AmmoEquip_SelectedIndexChanged( object sender, EventArgs e)
        {
            //Equip stats
            EquipStatAmmo.Text = getEqStats((string)AmmoEquip.SelectedItem, EqLib.Ammo);

            //populate boxes
            populateCombo((string)AmmoEquip.SelectedItem, EqLib.Ammo, new List<ComboBox> { AmmoEnchant1, AmmoEnchant2, AmmoEnchant3, AmmoEnchant4 });


        }

        private void MainEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equip stats
            EquipStatMain.Text = getEqStats((string)MainEquip.SelectedItem, EqLib.MainHand);

            //populate boxes
            populateCombo((string)MainEquip.SelectedItem, EqLib.MainHand, new List<ComboBox> { MainEnchant1, MainEnchant2, MainEnchant3, MainEnchant4 });


        }

        private void OffEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Equip stats
            EquipStatOff.Text = getEqStats((string)OffEquip.SelectedItem, EqLib.OffHand);

            //populate boxes
            populateCombo((string)OffEquip.SelectedItem, EqLib.OffHand, new List<ComboBox> { MainEnchant1, MainEnchant2, MainEnchant3, MainEnchant4 });


        }
        #endregion
        #region Display Box Handlers
        




        #endregion

    }
}
