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
        bool Cheating = false;

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
            EqLib.AllEqBuild();
            
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

            //check for any changes
            HeadLS = reshow(HeadLS, (string)HeadEquip.SelectedItem, (string)EnchantHead1.SelectedItem, (string)EnchantHead2.SelectedItem, (string)EnchantHead3.SelectedItem, (string)EnchantHead4.SelectedItem, HeadEquipDisplay, HeadEnchantDisplay);

        }
        private void EnchantHead2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatHead2.Text = getEnStats(getEnchant((string)EnchantHead2.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            HeadLS = reshow(HeadLS, (string)HeadEquip.SelectedItem, (string)EnchantHead1.SelectedItem, (string)EnchantHead2.SelectedItem, (string)EnchantHead3.SelectedItem, (string)EnchantHead4.SelectedItem, HeadEquipDisplay, HeadEnchantDisplay);

        }
        private void EnchantHead3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatHead3.Text = getEnStats(getEnchant((string)EnchantHead3.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            HeadLS = reshow(HeadLS, (string)HeadEquip.SelectedItem, (string)EnchantHead1.SelectedItem, (string)EnchantHead2.SelectedItem, (string)EnchantHead3.SelectedItem, (string)EnchantHead4.SelectedItem, HeadEquipDisplay, HeadEnchantDisplay);

        }
        private void EnchantHead4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatHead4.Text = getEnStats(getEnchant((string)EnchantHead4.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            HeadLS = reshow(HeadLS, (string)HeadEquip.SelectedItem, (string)EnchantHead1.SelectedItem, (string)EnchantHead2.SelectedItem, (string)EnchantHead3.SelectedItem, (string)EnchantHead4.SelectedItem, HeadEquipDisplay, HeadEnchantDisplay);

        }
        #endregion
        #region Enchant Body
        private void BodyEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatBody1.Text = getEnStats(getEnchant((string)BodyEnchant1.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            BodyLS = reshow(BodyLS, (string)BodyEquip.SelectedItem, (string)BodyEnchant1.SelectedItem, (string)BodyEnchant2.SelectedItem, (string)BodyEnchant3.SelectedItem, (string)BodyEnchant4.SelectedItem, BodyEquipDisplay, BodyEnchantDisplay);

        }
        private void BodyEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatBody2.Text = getEnStats(getEnchant((string)BodyEnchant2.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            BodyLS = reshow(BodyLS, (string)BodyEquip.SelectedItem, (string)BodyEnchant1.SelectedItem, (string)BodyEnchant2.SelectedItem, (string)BodyEnchant3.SelectedItem, (string)BodyEnchant4.SelectedItem, BodyEquipDisplay, BodyEnchantDisplay);

        }
        private void BodyEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatBody3.Text = getEnStats(getEnchant((string)BodyEnchant3.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            BodyLS = reshow(BodyLS, (string)BodyEquip.SelectedItem, (string)BodyEnchant1.SelectedItem, (string)BodyEnchant2.SelectedItem, (string)BodyEnchant3.SelectedItem, (string)BodyEnchant4.SelectedItem, BodyEquipDisplay, BodyEnchantDisplay);

        }
        private void BodyEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatBody4.Text = getEnStats(getEnchant((string)BodyEnchant4.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            BodyLS = reshow(BodyLS, (string)BodyEquip.SelectedItem, (string)BodyEnchant1.SelectedItem, (string)BodyEnchant2.SelectedItem, (string)BodyEnchant3.SelectedItem, (string)BodyEnchant4.SelectedItem, BodyEquipDisplay, BodyEnchantDisplay);

        }

        #endregion
        #region Enchant Glider
        private void GliderEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatGlider1.Text = getEnStats(getEnchant((string)GliderEnchant1.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            GliderLS = reshow(GliderLS, (string)GliderEquip.SelectedItem, (string)GliderEnchant1.SelectedItem, (string)GliderEnchant2.SelectedItem, (string)GliderEnchant3.SelectedItem, (string)GliderEnchant4.SelectedItem, GliderEquipDisplay, GliderEnchantDisplay);

        }
        private void GliderEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatGlider2.Text = getEnStats(getEnchant((string)GliderEnchant2.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            GliderLS = reshow(GliderLS, (string)GliderEquip.SelectedItem, (string)GliderEnchant1.SelectedItem, (string)GliderEnchant2.SelectedItem, (string)GliderEnchant3.SelectedItem, (string)GliderEnchant4.SelectedItem, GliderEquipDisplay, GliderEnchantDisplay);

        }
        private void GliderEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatGlider3.Text = getEnStats(getEnchant((string)GliderEnchant3.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            GliderLS = reshow(GliderLS, (string)GliderEquip.SelectedItem, (string)GliderEnchant1.SelectedItem, (string)GliderEnchant2.SelectedItem, (string)GliderEnchant3.SelectedItem, (string)GliderEnchant4.SelectedItem, GliderEquipDisplay, GliderEnchantDisplay);

        }
        private void GliderEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatGlider4.Text = getEnStats(getEnchant((string)GliderEnchant4.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            GliderLS = reshow(GliderLS, (string)GliderEquip.SelectedItem, (string)GliderEnchant1.SelectedItem, (string)GliderEnchant2.SelectedItem, (string)GliderEnchant3.SelectedItem, (string)GliderEnchant4.SelectedItem, GliderEquipDisplay, GliderEnchantDisplay);

        }
        #endregion
        #region Enchant Acc1 
        private void Acc1Enchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI1.Text = getEnStats(getEnchant((string)Acc1Enchant1.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            Acc1LS = reshow(Acc1LS, (string)Acc1Equip.SelectedItem, (string)Acc1Enchant1.SelectedItem, (string)Acc1Enchant2.SelectedItem, (string)Acc1Enchant3.SelectedItem, (string)Acc1Enchant4.SelectedItem, Acc1EquipDisplay, Acc1EnchantDisplay);

        }
        private void Acc1Enchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI2.Text = getEnStats(getEnchant((string)Acc1Enchant2.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            Acc1LS = reshow(Acc1LS, (string)Acc1Equip.SelectedItem, (string)Acc1Enchant1.SelectedItem, (string)Acc1Enchant2.SelectedItem, (string)Acc1Enchant3.SelectedItem, (string)Acc1Enchant4.SelectedItem, Acc1EquipDisplay, Acc1EnchantDisplay);

        }
        private void Acc1Enchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI3.Text = getEnStats(getEnchant((string)Acc1Enchant3.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            Acc1LS = reshow(Acc1LS, (string)Acc1Equip.SelectedItem, (string)Acc1Enchant1.SelectedItem, (string)Acc1Enchant2.SelectedItem, (string)Acc1Enchant3.SelectedItem, (string)Acc1Enchant4.SelectedItem, Acc1EquipDisplay, Acc1EnchantDisplay);

        }
        private void Acc1Enchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccI4.Text = getEnStats(getEnchant((string)Acc1Enchant4.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            Acc1LS = reshow(Acc1LS, (string)Acc1Equip.SelectedItem, (string)Acc1Enchant1.SelectedItem, (string)Acc1Enchant2.SelectedItem, (string)Acc1Enchant3.SelectedItem, (string)Acc1Enchant4.SelectedItem, Acc1EquipDisplay, Acc1EnchantDisplay);

        }
        #endregion
        #region Enchant Acc2
        private void Acc2Enchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccII1.Text = getEnStats(getEnchant((string)Acc2Enchant1.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            Acc2LS = reshow(Acc2LS, (string)Acc2Equip.SelectedItem, (string)Acc2Enchant1.SelectedItem, (string)Acc2Enchant2.SelectedItem, (string)Acc2Enchant3.SelectedItem, (string)Acc2Enchant4.SelectedItem, Acc2EquipDisplay, Acc2EnchantDisplay);

        }
        private void Acc2Enchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccII2.Text = getEnStats(getEnchant((string)Acc2Enchant2.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            Acc2LS = reshow(Acc2LS, (string)Acc2Equip.SelectedItem, (string)Acc2Enchant1.SelectedItem, (string)Acc2Enchant2.SelectedItem, (string)Acc2Enchant3.SelectedItem, (string)Acc2Enchant4.SelectedItem, Acc2EquipDisplay, Acc2EnchantDisplay);

        }
        private void Acc2Enchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccII3.Text = getEnStats(getEnchant((string)Acc2Enchant3.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            Acc2LS = reshow(Acc2LS, (string)Acc2Equip.SelectedItem, (string)Acc2Enchant1.SelectedItem, (string)Acc2Enchant2.SelectedItem, (string)Acc2Enchant3.SelectedItem, (string)Acc2Enchant4.SelectedItem, Acc2EquipDisplay, Acc2EnchantDisplay);

        }
        private void Acc2Enchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAccII4.Text = getEnStats(getEnchant((string)Acc2Enchant4.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            Acc2LS = reshow(Acc2LS, (string)Acc2Equip.SelectedItem, (string)Acc2Enchant1.SelectedItem, (string)Acc2Enchant2.SelectedItem, (string)Acc2Enchant3.SelectedItem, (string)Acc2Enchant4.SelectedItem, Acc2EquipDisplay, Acc2EnchantDisplay);

        }
        #endregion
        #region Enchant Ammo
        private void AmmoEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAmmo1.Text = getEnStats(getEnchant((string)AmmoEnchant1.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            AmmoLS = reshow(AmmoLS, (string)AmmoEquip.SelectedItem, (string)AmmoEnchant1.SelectedItem, (string)AmmoEnchant2.SelectedItem, (string)AmmoEnchant3.SelectedItem, (string)AmmoEnchant4.SelectedItem, AmmoEquipDisplay, AmmoEnchantDisplay);

        }
        private void AmmoEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAmmo2.Text = getEnStats(getEnchant((string)AmmoEnchant2.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            AmmoLS = reshow(AmmoLS, (string)AmmoEquip.SelectedItem, (string)AmmoEnchant1.SelectedItem, (string)AmmoEnchant2.SelectedItem, (string)AmmoEnchant3.SelectedItem, (string)AmmoEnchant4.SelectedItem, AmmoEquipDisplay, AmmoEnchantDisplay);

        }
        private void AmmoEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAmmo3.Text = getEnStats(getEnchant((string)AmmoEnchant3.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            AmmoLS = reshow(AmmoLS, (string)AmmoEquip.SelectedItem, (string)AmmoEnchant1.SelectedItem, (string)AmmoEnchant2.SelectedItem, (string)AmmoEnchant3.SelectedItem, (string)AmmoEnchant4.SelectedItem, AmmoEquipDisplay, AmmoEnchantDisplay);

        }
        private void AmmoEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatAmmo4.Text = getEnStats(getEnchant((string)AmmoEnchant4.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            AmmoLS = reshow(AmmoLS, (string)AmmoEquip.SelectedItem, (string)AmmoEnchant1.SelectedItem, (string)AmmoEnchant2.SelectedItem, (string)AmmoEnchant3.SelectedItem, (string)AmmoEnchant4.SelectedItem, AmmoEquipDisplay, AmmoEnchantDisplay);

        }
        #endregion
        #region Enchant MainHand
        private void MainEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatMain1.Text = getEnStats(getEnchant((string)MainEnchant1.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            MainLS = reshow(MainLS, (string)MainEquip.SelectedItem, (string)MainEnchant1.SelectedItem, (string)MainEnchant2.SelectedItem, (string)MainEnchant3.SelectedItem, (string)MainEnchant4.SelectedItem, MainEquipDisplay, MainEnchantDisplay);

        }
        private void MainEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatMain2.Text = getEnStats(getEnchant((string)MainEnchant2.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            MainLS = reshow(MainLS, (string)MainEquip.SelectedItem, (string)MainEnchant1.SelectedItem, (string)MainEnchant2.SelectedItem, (string)MainEnchant3.SelectedItem, (string)MainEnchant4.SelectedItem, MainEquipDisplay, MainEnchantDisplay);

        }
        private void MainEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatMain3.Text = getEnStats(getEnchant((string)MainEnchant3.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            MainLS = reshow(MainLS, (string)MainEquip.SelectedItem, (string)MainEnchant1.SelectedItem, (string)MainEnchant2.SelectedItem, (string)MainEnchant3.SelectedItem, (string)MainEnchant4.SelectedItem, MainEquipDisplay, MainEnchantDisplay);

        }
        private void MainEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatMain4.Text = getEnStats(getEnchant((string)MainEnchant4.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            MainLS = reshow(MainLS, (string)MainEquip.SelectedItem, (string)MainEnchant1.SelectedItem, (string)MainEnchant2.SelectedItem, (string)MainEnchant3.SelectedItem, (string)MainEnchant4.SelectedItem, MainEquipDisplay, MainEnchantDisplay);

        }
        #endregion
        #region Enchant OffHand
        private void OffEnchant1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatOff1.Text = getEnStats(getEnchant((string)OffEnchant1.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            OffLS = reshow(OffLS, (string)OffEquip.SelectedItem, (string)OffEnchant1.SelectedItem, (string)OffEnchant2.SelectedItem, (string)OffEnchant3.SelectedItem, (string)OffEnchant4.SelectedItem, OffEquipDisplay, OffEnchantDisplay);

        }
        private void OffEnchant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatOff2.Text = getEnStats(getEnchant((string)OffEnchant2.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            OffLS = reshow(OffLS, (string)OffEquip.SelectedItem, (string)OffEnchant1.SelectedItem, (string)OffEnchant2.SelectedItem, (string)OffEnchant3.SelectedItem, (string)OffEnchant4.SelectedItem, OffEquipDisplay, OffEnchantDisplay);

        }
        private void OffEnchant3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatOff3.Text = getEnStats(getEnchant((string)OffEnchant3.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            OffLS = reshow(OffLS, (string)OffEquip.SelectedItem, (string)OffEnchant1.SelectedItem, (string)OffEnchant2.SelectedItem, (string)OffEnchant3.SelectedItem, (string)OffEnchant4.SelectedItem, OffEquipDisplay, OffEnchantDisplay);

        }
        private void OffEnchant4_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatOff4.Text = getEnStats(getEnchant((string)OffEnchant4.SelectedItem, EqLib.getAllEnchants()));

            //check for any changes
            OffLS = reshow(OffLS, (string)OffEquip.SelectedItem, (string)OffEnchant1.SelectedItem, (string)OffEnchant2.SelectedItem, (string)OffEnchant3.SelectedItem, (string)OffEnchant4.SelectedItem, OffEquipDisplay, OffEnchantDisplay);

        }
        #endregion

        #endregion
        #region Equip Stat Display + Combo Box handlers 
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

            //check for any changes
            HeadLS = reshow(HeadLS, (string)HeadEquip.SelectedItem, (string)EnchantHead1.SelectedItem, (string)EnchantHead2.SelectedItem, (string)EnchantHead3.SelectedItem, (string)EnchantHead4.SelectedItem, HeadEquipDisplay, HeadEnchantDisplay);


        }

        private void BodyEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //define placeholder string for temporary holding to simplify some code
            string BodyEquipCurrent = (string)BodyEquip.SelectedItem;

            //show equipment stats
            EquipStatBody.Text = getEqStats( BodyEquipCurrent, EqLib.Body);

            //add this to all Equip Selection Change handlers
            //clear enchant combo box selections
            BodyEnchant1.SelectedIndex = -1; EnchantStatBody1.Text = "";
            BodyEnchant2.SelectedIndex = -1; EnchantStatBody2.Text = "";
            BodyEnchant3.SelectedIndex = -1; EnchantStatBody3.Text = "";
            BodyEnchant4.SelectedIndex = -1; EnchantStatBody4.Text = "";

            //populate enchant combo boxes
            populateCombo( BodyEquipCurrent, EqLib.Body, new List<System.Windows.Forms.ComboBox> { BodyEnchant1, BodyEnchant2, BodyEnchant3, BodyEnchant4 });

            //check for any changes
            BodyLS = reshow(BodyLS, BodyEquipCurrent, (string)BodyEnchant1.SelectedItem, (string)BodyEnchant2.SelectedItem, (string)BodyEnchant3.SelectedItem, (string)BodyEnchant4.SelectedItem, BodyEquipDisplay, BodyEnchantDisplay);


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

            //check for any changes
            GliderLS = reshow(GliderLS, (string)GliderEquip.SelectedItem, (string)GliderEnchant1.SelectedItem, (string)GliderEnchant2.SelectedItem, (string)GliderEnchant3.SelectedItem, (string)GliderEnchant4.SelectedItem, GliderEquipDisplay, GliderEnchantDisplay);

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

            //check for any changes
            Acc1LS = reshow(Acc1LS, (string)Acc1Equip.SelectedItem, (string)Acc1Enchant1.SelectedItem, (string)Acc1Enchant2.SelectedItem, (string)Acc1Enchant3.SelectedItem, (string)Acc1Enchant4.SelectedItem, Acc1EquipDisplay, Acc1EnchantDisplay);

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

            //check for any changes
            Acc2LS = reshow(Acc2LS, (string)Acc2Equip.SelectedItem, (string)Acc2Enchant1.SelectedItem, (string)Acc2Enchant2.SelectedItem, (string)Acc2Enchant3.SelectedItem, (string)Acc2Enchant4.SelectedItem, Acc2EquipDisplay, Acc2EnchantDisplay);

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

            //check for any changes
            AmmoLS = reshow(AmmoLS, (string)AmmoEquip.SelectedItem, (string)AmmoEnchant1.SelectedItem, (string)AmmoEnchant2.SelectedItem, (string)AmmoEnchant3.SelectedItem, (string)AmmoEnchant4.SelectedItem, AmmoEquipDisplay, AmmoEnchantDisplay);

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

            //check for any changes
            MainLS = reshow(MainLS, (string)MainEquip.SelectedItem, (string)MainEnchant1.SelectedItem, (string)MainEnchant2.SelectedItem, (string)MainEnchant3.SelectedItem, (string)MainEnchant4.SelectedItem, MainEquipDisplay, MainEnchantDisplay);


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
            populateCombo((string)OffEquip.SelectedItem, EqLib.OffHand, new List<ComboBox> { OffEnchant1, OffEnchant2, OffEnchant3, OffEnchant4 });

            //check for any changes
            OffLS = reshow(OffLS, (string)OffEquip.SelectedItem, (string)OffEnchant1.SelectedItem, (string)OffEnchant2.SelectedItem, (string)OffEnchant3.SelectedItem, (string)OffEnchant4.SelectedItem, OffEquipDisplay, OffEnchantDisplay);

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
            return new Enchant(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "None");
        }

        public Equipment getEquipment(string n, HashSet<Equipment> Equips)
        {
            foreach (Equipment eq in Equips)
            {
                if (n == eq.name)
                {
                    return eq;
                }
            }
            return new Equipment("Error", 0, 0, 0, new HashSet<Material> { });
        }
        #endregion

        #region Quick control methods
        /*
         * Method that returns single string consisting of visible data of all buffs/debuffs of an enchant
         * Does not show 0's
         */
        /*
         Method to populate any set of comboboxes when new equipment selection is made
         Pass the name of the selected Equipment, the HashSet it belongs to, and a {List} of all the comboboxes it will effect
        ie: put the 4 boxes for enchants in the {List}
         */

        public void populateCombo(string n, HashSet<Equipment> EqList, List<System.Windows.Forms.ComboBox> enchBoxs)
        {
            foreach (ComboBox eBox in enchBoxs) eBox.Items.Clear();

            Equipment temp = new Equipment();
            foreach (Equipment en in EqList)
            {
                if (en.name == n)
                {
                    temp = en;
                    break;
                }
            }

            foreach (ComboBox eBox in enchBoxs)
            {
                foreach (Enchant enc in temp.EnLib) eBox.Items.Add(enc.name);
            }
        }



        //Method that returns single string consisting of visible data of all buffs/debuffs of an enchant
        //Does not show 0's
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

        //Method that returns single string consisting of visible data of all buffs/debuffs of an equipment
        //does not show 0's
        private string getEqStats(string n, HashSet<Equipment> eqL)
        {
            foreach (Equipment e in eqL)
            {
                if (n == e.name)
                    return e.atk + " ATK, " + e.matk + " MATK, " + e.def + " DEF";
            }
            return "Error";
        }

        //Method used to check for changes in equipment and enchants and change total stat accordingly
        public void calcStat(List<string> ls, string n, string e1, string e2, string e3, string e4)
        {
            //Set temporary Old and New counterparts for each equipment and enchant based on input strings
            Equipment
                oldN = getEquipment(ls[0], EqLib.allEq),
                tempN = getEquipment(n, EqLib.allEq);
            Enchant
                Oe1 = getEnchant(ls[1], EqLib.getAllEnchants()),
                Oe2 = getEnchant(ls[2], EqLib.getAllEnchants()),
                Oe3 = getEnchant(ls[3], EqLib.getAllEnchants()),
                Oe4 = getEnchant(ls[4], EqLib.getAllEnchants()),
                Te1 = getEnchant(e1, EqLib.getAllEnchants()),
                Te2 = getEnchant(e2, EqLib.getAllEnchants()),
                Te3 = getEnchant(e3, EqLib.getAllEnchants()),
                Te4 = getEnchant(e4, EqLib.getAllEnchants());

            //First case, checks if equipment has been changed
            //when equipment gets changed, it removes all enchantments currently applied to that slot as well
            if (ls[0] != n)
            {
                #region out with the old
                ttl_atk_Static -= (oldN.atk + Oe1.atk_Static + Oe2.atk_Static + Oe3.atk_Static + Oe4.atk_Static);
                ttl_atk_Percent -= (Oe1.atk_Percent + Oe2.atk_Percent + Oe3.atk_Percent + Oe4.atk_Percent);
                ttl_def_Static -= (oldN.def + Oe1.def_Static + Oe2.def_Static + Oe3.def_Static + Oe4.def_Static);
                ttl_def_Percent -= (Oe1.def_Percent + Oe2.def_Percent + Oe3.def_Percent + Oe4.def_Percent);
                ttl_matk_Static -= (oldN.matk + Oe1.matk_Static + Oe2.matk_Static + Oe3.matk_Static + Oe4.matk_Static);
                ttl_matk_Percent -= (Oe1.matk_Percent + Oe2.matk_Percent + Oe3.matk_Percent + Oe4.matk_Percent);
                ttl_crit_Damage -= (Oe1.crit_Damage + Oe2.crit_Damage + Oe3.crit_Damage + Oe4.crit_Damage);
                ttl_crit_Chance -= (Oe1.crit_Chance + Oe2.crit_Chance + Oe3.crit_Chance + Oe4.crit_Chance);
                ttl_move_Speed -= (Oe1.move_Speed + Oe2.move_Speed + Oe3.move_Speed + Oe4.move_Speed);
                ttl_atk_Speed -= (Oe1.atk_Speed + Oe2.atk_Speed + Oe3.atk_Speed + Oe4.atk_Speed);
                ttl_mana_Static -= (Oe1.mana_Static + Oe2.mana_Static + Oe3.mana_Static + Oe4.mana_Static);
                ttl_mana_Percent -= (Oe1.mana_Percent + Oe2.mana_Percent + Oe3.mana_Percent + Oe4.mana_Percent);
                ttl_stam_Static -= (Oe1.stam_Static + Oe2.stam_Static + Oe3.stam_Static + Oe4.stam_Static);
                ttl_stam_Percent -= (Oe1.stam_Percent + Oe2.stam_Percent + Oe3.stam_Percent + Oe4.stam_Percent);
                ttl_life_Static -= (Oe1.life_Static + Oe2.life_Static + Oe3.life_Static + Oe4.life_Static);
                ttl_life_Percent -= (Oe1.life_Percent + Oe2.life_Percent + Oe3.life_Percent + Oe4.life_Percent);
                ttl_hung_Static -= (Oe1.hung_Static + Oe2.hung_Static + Oe3.hung_Static + Oe4.hung_Static);
                ttl_hung_Percent -= (Oe1.hung_Percent + Oe2.hung_Percent + Oe3.hung_Percent + Oe4.hung_Percent);
                #endregion

                #region in with the new
                ttl_atk_Static += tempN.atk;
                ttl_def_Static += tempN.def;
                ttl_matk_Static += tempN.matk;
                #endregion
            }
            //If the equipment was not changed, then one of the enchants were
            else
            {
                //Checks to see if the current selection is different from the one used for calculating current stats
                if (!ls.Contains(e1))
                {
                    //Checks to see if there are more than 1 occurances of the enchant, as enchants only apply once
                    #region out with the old
                    if (countOccur(ls, ls[1]) < 2)
                    {
                        //Remove old enchant stats
                        ttl_atk_Static -= Oe1.atk_Static;
                        ttl_atk_Percent -= Oe1.atk_Percent;
                        ttl_def_Static -= Oe1.def_Static;
                        ttl_def_Percent -= Oe1.def_Percent;
                        ttl_matk_Static -= Oe1.matk_Static;
                        ttl_matk_Percent -= Oe1.matk_Percent;
                        ttl_crit_Damage -= Oe1.crit_Damage;
                        ttl_crit_Chance -= Oe1.crit_Chance;
                        ttl_move_Speed -= Oe1.move_Speed;
                        ttl_atk_Speed -= Oe1.atk_Speed;
                        ttl_mana_Static -= Oe1.mana_Static;
                        ttl_mana_Percent -= Oe1.mana_Percent;
                        ttl_stam_Static -= Oe1.stam_Static;
                        ttl_stam_Percent -= Oe1.stam_Percent;
                        ttl_life_Static -= Oe1.life_Static;
                        ttl_life_Percent -= Oe1.life_Percent;
                        ttl_hung_Static -= Oe1.hung_Static;
                        ttl_hung_Percent -= Oe1.hung_Percent;
                    }
                    #endregion

                    #region in with the new
                    //add new enchant stats
                    ttl_atk_Static += Te1.atk_Static;
                    ttl_atk_Percent += Te1.atk_Percent;
                    ttl_def_Static += Te1.def_Static;
                    ttl_def_Percent += Te1.def_Percent;
                    ttl_matk_Static += Te1.matk_Static;
                    ttl_matk_Percent += Te1.matk_Percent;
                    ttl_crit_Damage += Te1.crit_Damage;
                    ttl_crit_Chance += Te1.crit_Chance;
                    ttl_move_Speed += Te1.move_Speed;
                    ttl_atk_Speed += Te1.atk_Speed;
                    ttl_mana_Static += Te1.mana_Static;
                    ttl_mana_Percent += Te1.mana_Percent;
                    ttl_stam_Static += Te1.stam_Static;
                    ttl_stam_Percent += Te1.stam_Percent;
                    ttl_life_Static += Te1.life_Static;
                    ttl_life_Percent += Te1.life_Percent;
                    ttl_hung_Static += Te1.hung_Static;
                    ttl_hung_Percent += Te1.hung_Percent;
                    #endregion
                }

                //Checks to see if the current selection is different from the one used for calculating current stats
                if (!ls.Contains(e2))
                {
                    //Checks to see if there are more than 1 occurances of the enchant, as enchants only apply once
                    #region out with the old
                    if (countOccur(ls, ls[2]) < 2)
                    {
                        //Remove old enchant stats
                        ttl_atk_Static -= Oe2.atk_Static;
                        ttl_atk_Percent -= Oe2.atk_Percent;
                        ttl_def_Static -= Oe2.def_Static;
                        ttl_def_Percent -= Oe2.def_Percent;
                        ttl_matk_Static -= Oe2.matk_Static;
                        ttl_matk_Percent -= Oe2.matk_Percent;
                        ttl_crit_Damage -= Oe2.crit_Damage;
                        ttl_crit_Chance -= Oe2.crit_Chance;
                        ttl_move_Speed -= Oe2.move_Speed;
                        ttl_atk_Speed -= Oe2.atk_Speed;
                        ttl_mana_Static -= Oe2.mana_Static;
                        ttl_mana_Percent -= Oe2.mana_Percent;
                        ttl_stam_Static -= Oe2.stam_Static;
                        ttl_stam_Percent -= Oe2.stam_Percent;
                        ttl_life_Static -= Oe2.life_Static;
                        ttl_life_Percent -= Oe2.life_Percent;
                        ttl_hung_Static -= Oe2.hung_Static;
                        ttl_hung_Percent -= Oe2.hung_Percent;
                    }
                    #endregion

                    #region in with the new
                    //add new enchant stats
                    ttl_atk_Static += Te2.atk_Static;
                    ttl_atk_Percent += Te2.atk_Percent;
                    ttl_def_Static += Te2.def_Static;
                    ttl_def_Percent += Te2.def_Percent;
                    ttl_matk_Static += Te2.matk_Static;
                    ttl_matk_Percent += Te2.matk_Percent;
                    ttl_crit_Damage += Te2.crit_Damage;
                    ttl_crit_Chance += Te2.crit_Chance;
                    ttl_move_Speed += Te2.move_Speed;
                    ttl_atk_Speed += Te2.atk_Speed;
                    ttl_mana_Static += Te2.mana_Static;
                    ttl_mana_Percent += Te2.mana_Percent;
                    ttl_stam_Static += Te2.stam_Static;
                    ttl_stam_Percent += Te2.stam_Percent;
                    ttl_life_Static += Te2.life_Static;
                    ttl_life_Percent += Te2.life_Percent;
                    ttl_hung_Static += Te2.hung_Static;
                    ttl_hung_Percent += Te2.hung_Percent;
                    #endregion
                }

                //Checks to see if the current selection is different from the one used for calculating current stats
                if (!ls.Contains(e3))
                {
                    //Checks to see if there are more than 1 occurances of the enchant, as enchants only apply once
                    #region out with the old
                    if (countOccur(ls, ls[3]) < 2)
                    {
                        //Remove old enchant stats
                        ttl_atk_Static -= Oe3.atk_Static;
                        ttl_atk_Percent -= Oe3.atk_Percent;
                        ttl_def_Static -= Oe3.def_Static;
                        ttl_def_Percent -= Oe3.def_Percent;
                        ttl_matk_Static -= Oe3.matk_Static;
                        ttl_matk_Percent -= Oe3.matk_Percent;
                        ttl_crit_Damage -= Oe3.crit_Damage;
                        ttl_crit_Chance -= Oe3.crit_Chance;
                        ttl_move_Speed -= Oe3.move_Speed;
                        ttl_atk_Speed -= Oe3.atk_Speed;
                        ttl_mana_Static -= Oe3.mana_Static;
                        ttl_mana_Percent -= Oe3.mana_Percent;
                        ttl_stam_Static -= Oe3.stam_Static;
                        ttl_stam_Percent -= Oe3.stam_Percent;
                        ttl_life_Static -= Oe3.life_Static;
                        ttl_life_Percent -= Oe3.life_Percent;
                        ttl_hung_Static -= Oe3.hung_Static;
                        ttl_hung_Percent -= Oe3.hung_Percent;
                    }
                    #endregion

                    #region in with the new
                    //add new enchant stats
                    ttl_atk_Static += Te3.atk_Static;
                    ttl_atk_Percent += Te3.atk_Percent;
                    ttl_def_Static += Te3.def_Static;
                    ttl_def_Percent += Te3.def_Percent;
                    ttl_matk_Static += Te3.matk_Static;
                    ttl_matk_Percent += Te3.matk_Percent;
                    ttl_crit_Damage += Te3.crit_Damage;
                    ttl_crit_Chance += Te3.crit_Chance;
                    ttl_move_Speed += Te3.move_Speed;
                    ttl_atk_Speed += Te3.atk_Speed;
                    ttl_mana_Static += Te3.mana_Static;
                    ttl_mana_Percent += Te3.mana_Percent;
                    ttl_stam_Static += Te3.stam_Static;
                    ttl_stam_Percent += Te3.stam_Percent;
                    ttl_life_Static += Te3.life_Static;
                    ttl_life_Percent += Te3.life_Percent;
                    ttl_hung_Static += Te3.hung_Static;
                    ttl_hung_Percent += Te3.hung_Percent;
                    #endregion
                }

                //Checks to see if the current selection is different from the one used for calculating current stats
                if (!ls.Contains(e4))
                {
                    //Checks to see if there are more than 1 occurances of the enchant, as enchants only apply once
                    #region out with the old
                    if (countOccur(ls, ls[4]) < 2)
                    {
                        //Remove old enchant stats
                        ttl_atk_Static -= Oe4.atk_Static;
                        ttl_atk_Percent -= Oe4.atk_Percent;
                        ttl_def_Static -= Oe4.def_Static;
                        ttl_def_Percent -= Oe4.def_Percent;
                        ttl_matk_Static -= Oe4.matk_Static;
                        ttl_matk_Percent -= Oe4.matk_Percent;
                        ttl_crit_Damage -= Oe4.crit_Damage;
                        ttl_crit_Chance -= Oe4.crit_Chance;
                        ttl_move_Speed -= Oe4.move_Speed;
                        ttl_atk_Speed -= Oe4.atk_Speed;
                        ttl_mana_Static -= Oe4.mana_Static;
                        ttl_mana_Percent -= Oe4.mana_Percent;
                        ttl_stam_Static -= Oe4.stam_Static;
                        ttl_stam_Percent -= Oe4.stam_Percent;
                        ttl_life_Static -= Oe4.life_Static;
                        ttl_life_Percent -= Oe4.life_Percent;
                        ttl_hung_Static -= Oe4.hung_Static;
                        ttl_hung_Percent -= Oe4.hung_Percent;
                    }
                    #endregion

                    #region in with the new
                    //add new enchant stats
                    ttl_atk_Static += Te4.atk_Static;
                    ttl_atk_Percent += Te4.atk_Percent;
                    ttl_def_Static += Te4.def_Static;
                    ttl_def_Percent += Te4.def_Percent;
                    ttl_matk_Static += Te4.matk_Static;
                    ttl_matk_Percent += Te4.matk_Percent;
                    ttl_crit_Damage += Te4.crit_Damage;
                    ttl_crit_Chance += Te4.crit_Chance;
                    ttl_move_Speed += Te4.move_Speed;
                    ttl_atk_Speed += Te4.atk_Speed;
                    ttl_mana_Static += Te4.mana_Static;
                    ttl_mana_Percent += Te4.mana_Percent;
                    ttl_stam_Static += Te4.stam_Static;
                    ttl_stam_Percent += Te4.stam_Percent;
                    ttl_life_Static += Te4.life_Static;
                    ttl_life_Percent += Te4.life_Percent;
                    ttl_hung_Static += Te4.hung_Static;
                    ttl_hung_Percent += Te4.hung_Percent;
                    #endregion
                }
            }

        }

        //Method that accepts the current list of equipments and enchants, as well as corresponding 2 labels
        //Uses list to set name of both labels, skipping dupe enchants
        public void showName(List<string> ls, System.Windows.Forms.Label n, System.Windows.Forms.Label es)
        {
            n.Text = ls[0];
            string encs = "", e1 = ls[1], e2 = ls[2], e3 = ls[3], e4 = ls[4];
            encs += e1 + " ";
            if (e2 != e1) encs += e2 + " ";
            if ((e3 != e1) && (e3 != e2)) encs += e3 + " ";
            if ((e4 != e1) && (e4 != e2) && (e4 != e3)) encs += e4;
            es.Text = encs;
        }
        #endregion

        //Composite method to streamline
        public List<string> reshow(List<string> ls, string n, string e1, string e2, string e3, string e4, System.Windows.Forms.Label na, System.Windows.Forms.Label es)
        {
            //check for any changes in stats and apply them
            calcStat(ls, n, e1, e2, e3, e4);

            //show new equip
            showName(new List<string> { n, e1, e2, e3, e4 }, na, es);

            //Set Table values
            reTable();

            //return new values
            return new List<string> { n, e1, e2, e3, e4 };
        }

        //Simple method that Sets values for tables, including math done to them
        private void reTable()
        {

            BaseAtkDyn.Text = (ttl_atk_Static.ToString());
            PctAtkDyn.Text = (ttl_atk_Percent.ToString());
            AtkTotalDyn.Text = ((double)ttl_atk_Static * (1 + (double)ttl_atk_Percent / 100)).ToString();

            DefBaseDyn.Text = (ttl_def_Static.ToString());
            PctDefDyn.Text = (ttl_def_Percent.ToString());
            DefTotDyn.Text = ((double)ttl_def_Static * (1 + (double)ttl_def_Percent / 100)).ToString();

            MatkBaseDyn.Text = (ttl_matk_Static.ToString());
            PctMatkDyn.Text = (ttl_matk_Percent.ToString());
            MatkTotalDyn.Text = ((double)ttl_matk_Static * (1 + (double)ttl_matk_Percent / 100)).ToString();

            CritChanceDyn.Text = (ttl_crit_Damage.ToString()) + "%";
            CritDmgDyn.Text = (ttl_crit_Chance.ToString()) + "%";
            
            MoveSpdDyn.Text = (ttl_move_Speed.ToString()) + "%";
            AtkSpdDyn.Text = (ttl_atk_Speed.ToString()) + "%";
            
            ManaBaseDyn.Text = (ttl_mana_Static.ToString());
            PctManaDyn.Text = (ttl_mana_Percent.ToString());
            ManaTotalDyn.Text = ((double)ttl_mana_Static * (1 + (double)ttl_mana_Percent / 100)).ToString();

            StamBaseDyn.Text = (ttl_stam_Static.ToString());
            PctStamDyn.Text = (ttl_stam_Percent.ToString());
            StamTotalDyn.Text = ((double)ttl_stam_Static * (1 + (double)ttl_stam_Percent / 100)).ToString();

            HpBaseDyn.Text = (ttl_life_Static.ToString());
            PctHpDyn.Text = (ttl_life_Percent.ToString());
            HpTotalDyn.Text = ((double)ttl_life_Static * (1 + (double)ttl_life_Percent / 100)).ToString();

            SatBaseDyn.Text = (ttl_hung_Static.ToString());
            PctSatDyn.Text = (ttl_hung_Percent.ToString());
            SatTotalDyn.Text = ((double)ttl_hung_Static * (1 + (double)ttl_hung_Percent / 100)).ToString();


        }

        public int countOccur(List<string> listS, string item)
        {
            int occur = 0;
            foreach(string s in listS)
            {
                if (s == item) occur++;
            }

            return occur;
        }

    }

}

