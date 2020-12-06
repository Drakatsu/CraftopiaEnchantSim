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

            
            foreach (Equipment eq in EqLib.Head) HeadEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Body) BodyEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Glider) GliderEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Acc) Acc1Equip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Acc) Acc2Equip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.Ammo) AmmoEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.MainHand) MainEquip.Items.Add(eq.name);
            foreach (Equipment eq in EqLib.OffHand) OffEquip.Items.Add(eq.name);
        }


        //The functions below are the event handlers for the form. Each equipment slot has it's own handler. 

        private void EnchantHead1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantStatHead1.Text = getEnStats(getEnchant((string)EnchantHead1.SelectedItem, EqLib.getAllEnchants()));
        }

        private void BodyEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show equipment stats
            EquipStatBody.Text = getEqStats((string)BodyEquip.SelectedItem, EqLib.Body);

            //populate enchant combo boxes
           populateCombo((string)BodyEquip.SelectedItem, EqLib.Body, new List<System.Windows.Forms.ComboBox> { BodyEnchant1, BodyEnchant2, BodyEnchant3, BodyEnchant4 });
        }

        private void HeadEquip_SelectedIndexChanged(object sender, EventArgs e)
        {

            //populate enchant combo boxes
            populateCombo((string)HeadEquip.SelectedItem, EqLib.Head, new List<ComboBox> { EnchantHead1, EnchantHead2, EnchantHead3, EnchantHead4 });
        }

        private void GliderEquip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Acc1Equip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Acc2Equip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmmoEquip_SelectedIndexChanged( object sender, EventArgs e)
        {

        }

    }
}
