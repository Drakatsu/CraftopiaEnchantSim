using CES_List;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public enum Stat
    {
        ATK,
        MATK,
        DEF,
        CritC,
        CritD,
        ASpd,
        MSpd,
        MP,
        ST,
        HP,
        Sat
    }
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Head = new System.Windows.Forms.TabPage();
            this.EnchantStatHead4 = new System.Windows.Forms.Label();
            this.EnchantStatHead3 = new System.Windows.Forms.Label();
            this.EnchantStatHead2 = new System.Windows.Forms.Label();
            this.EnchantStatHead1 = new System.Windows.Forms.Label();
            this.EquipStatHead = new System.Windows.Forms.Label();
            this.EnchantHead4 = new System.Windows.Forms.ComboBox();
            this.EnchantHead3 = new System.Windows.Forms.ComboBox();
            this.EnchantHead2 = new System.Windows.Forms.ComboBox();
            this.EnchantHead1 = new System.Windows.Forms.ComboBox();
            this.HeadEquip = new System.Windows.Forms.ComboBox();
            this.Body = new System.Windows.Forms.TabPage();
            this.EquipStatBody = new System.Windows.Forms.Label();
            this.EnchantStatBody1 = new System.Windows.Forms.Label();
            this.EnchantStatBody2 = new System.Windows.Forms.Label();
            this.EnchantStatBody3 = new System.Windows.Forms.Label();
            this.EnchantStatBody4 = new System.Windows.Forms.Label();
            this.BodyEnchant4 = new System.Windows.Forms.ComboBox();
            this.BodyEnchant3 = new System.Windows.Forms.ComboBox();
            this.BodyEnchant2 = new System.Windows.Forms.ComboBox();
            this.BodyEnchant1 = new System.Windows.Forms.ComboBox();
            this.BodyEquip = new System.Windows.Forms.ComboBox();
            this.Glider = new System.Windows.Forms.TabPage();
            this.EquipStatGlider = new System.Windows.Forms.Label();
            this.EnchantStatGlider1 = new System.Windows.Forms.Label();
            this.EnchantStatGlider2 = new System.Windows.Forms.Label();
            this.EnchantStatGlider3 = new System.Windows.Forms.Label();
            this.EnchantStatGlider4 = new System.Windows.Forms.Label();
            this.GliderEnchant3 = new System.Windows.Forms.ComboBox();
            this.GliderEnchant4 = new System.Windows.Forms.ComboBox();
            this.GliderEnchant1 = new System.Windows.Forms.ComboBox();
            this.GliderEnchant2 = new System.Windows.Forms.ComboBox();
            this.GliderEquip = new System.Windows.Forms.ComboBox();
            this.Acc1 = new System.Windows.Forms.TabPage();
            this.EquipStatAcc1 = new System.Windows.Forms.Label();
            this.EnchantStatAccI1 = new System.Windows.Forms.Label();
            this.EnchantStatAccI2 = new System.Windows.Forms.Label();
            this.EnchantStatAccI3 = new System.Windows.Forms.Label();
            this.EnchantStatAccI4 = new System.Windows.Forms.Label();
            this.Acc1Enchant1 = new System.Windows.Forms.ComboBox();
            this.Acc1Enchant2 = new System.Windows.Forms.ComboBox();
            this.Acc1Enchant3 = new System.Windows.Forms.ComboBox();
            this.Acc1Enchant4 = new System.Windows.Forms.ComboBox();
            this.Acc1Equip = new System.Windows.Forms.ComboBox();
            this.Acc2 = new System.Windows.Forms.TabPage();
            this.EquipStatAcc2 = new System.Windows.Forms.Label();
            this.EnchantStatAccII1 = new System.Windows.Forms.Label();
            this.EnchantStatAccII2 = new System.Windows.Forms.Label();
            this.EnchantStatAccII3 = new System.Windows.Forms.Label();
            this.EnchantStatAccII4 = new System.Windows.Forms.Label();
            this.Acc2Enchant1 = new System.Windows.Forms.ComboBox();
            this.Acc2Enchant2 = new System.Windows.Forms.ComboBox();
            this.Acc2Enchant3 = new System.Windows.Forms.ComboBox();
            this.Acc2Enchant4 = new System.Windows.Forms.ComboBox();
            this.Acc2Equip = new System.Windows.Forms.ComboBox();
            this.Ammo = new System.Windows.Forms.TabPage();
            this.EquipStatAmmo = new System.Windows.Forms.Label();
            this.EnchantStatAmmo1 = new System.Windows.Forms.Label();
            this.EnchantStatAmmo2 = new System.Windows.Forms.Label();
            this.EnchantStatAmmo3 = new System.Windows.Forms.Label();
            this.EnchantStatAmmo4 = new System.Windows.Forms.Label();
            this.AmmoEnchant1 = new System.Windows.Forms.ComboBox();
            this.AmmoEnchant2 = new System.Windows.Forms.ComboBox();
            this.AmmoEnchant3 = new System.Windows.Forms.ComboBox();
            this.AmmoEnchant4 = new System.Windows.Forms.ComboBox();
            this.AmmoEquip = new System.Windows.Forms.ComboBox();
            this.MainHand = new System.Windows.Forms.TabPage();
            this.EquipStatMain = new System.Windows.Forms.Label();
            this.EnchantStatMain1 = new System.Windows.Forms.Label();
            this.EnchantStatMain2 = new System.Windows.Forms.Label();
            this.EnchantStatMain3 = new System.Windows.Forms.Label();
            this.EnchantStatMain4 = new System.Windows.Forms.Label();
            this.MainEnchant1 = new System.Windows.Forms.ComboBox();
            this.MainEnchant2 = new System.Windows.Forms.ComboBox();
            this.MainEnchant3 = new System.Windows.Forms.ComboBox();
            this.MainEnchant4 = new System.Windows.Forms.ComboBox();
            this.MainEquip = new System.Windows.Forms.ComboBox();
            this.OffHand = new System.Windows.Forms.TabPage();
            this.EquipStatOff = new System.Windows.Forms.Label();
            this.EnchantStatOff1 = new System.Windows.Forms.Label();
            this.EnchantStatOff2 = new System.Windows.Forms.Label();
            this.EnchantStatOff3 = new System.Windows.Forms.Label();
            this.EnchantStatOff4 = new System.Windows.Forms.Label();
            this.OffEnchant1 = new System.Windows.Forms.ComboBox();
            this.OffEnchant2 = new System.Windows.Forms.ComboBox();
            this.OffEnchant3 = new System.Windows.Forms.ComboBox();
            this.OffEnchant4 = new System.Windows.Forms.ComboBox();
            this.OffEquip = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.Head.SuspendLayout();
            this.Body.SuspendLayout();
            this.Glider.SuspendLayout();
            this.Acc1.SuspendLayout();
            this.Acc2.SuspendLayout();
            this.Ammo.SuspendLayout();
            this.MainHand.SuspendLayout();
            this.OffHand.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Head);
            this.tabControl1.Controls.Add(this.Body);
            this.tabControl1.Controls.Add(this.Glider);
            this.tabControl1.Controls.Add(this.Acc1);
            this.tabControl1.Controls.Add(this.Acc2);
            this.tabControl1.Controls.Add(this.Ammo);
            this.tabControl1.Controls.Add(this.MainHand);
            this.tabControl1.Controls.Add(this.OffHand);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // Head
            // 
            this.Head.Controls.Add(this.EnchantStatHead4);
            this.Head.Controls.Add(this.EnchantStatHead3);
            this.Head.Controls.Add(this.EnchantStatHead2);
            this.Head.Controls.Add(this.EnchantStatHead1);
            this.Head.Controls.Add(this.EquipStatHead);
            this.Head.Controls.Add(this.EnchantHead4);
            this.Head.Controls.Add(this.EnchantHead3);
            this.Head.Controls.Add(this.EnchantHead2);
            this.Head.Controls.Add(this.EnchantHead1);
            this.Head.Controls.Add(this.HeadEquip);
            this.Head.Location = new System.Drawing.Point(4, 22);
            this.Head.Name = "Head";
            this.Head.Padding = new System.Windows.Forms.Padding(3);
            this.Head.Size = new System.Drawing.Size(678, 405);
            this.Head.TabIndex = 0;
            this.Head.Text = "Head";
            this.Head.UseVisualStyleBackColor = true;
            // 
            // EnchantStatHead4
            // 
            this.EnchantStatHead4.AutoSize = true;
            this.EnchantStatHead4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatHead4.Name = "EnchantStatHead4";
            this.EnchantStatHead4.Size = new System.Drawing.Size(76, 13);
            this.EnchantStatHead4.TabIndex = 9;
            this.EnchantStatHead4.Text = "--No Enchant--";
            // 
            // EnchantStatHead3
            // 
            this.EnchantStatHead3.AutoSize = true;
            this.EnchantStatHead3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatHead3.Name = "EnchantStatHead3";
            this.EnchantStatHead3.Size = new System.Drawing.Size(76, 13);
            this.EnchantStatHead3.TabIndex = 8;
            this.EnchantStatHead3.Text = "--No Enchant--";
            // 
            // EnchantStatHead2
            // 
            this.EnchantStatHead2.AutoSize = true;
            this.EnchantStatHead2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatHead2.Name = "EnchantStatHead2";
            this.EnchantStatHead2.Size = new System.Drawing.Size(76, 13);
            this.EnchantStatHead2.TabIndex = 7;
            this.EnchantStatHead2.Text = "--No Enchant--";
            // 
            // EnchantStatHead1
            // 
            this.EnchantStatHead1.AutoSize = true;
            this.EnchantStatHead1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatHead1.Name = "EnchantStatHead1";
            this.EnchantStatHead1.Size = new System.Drawing.Size(76, 13);
            this.EnchantStatHead1.TabIndex = 6;
            this.EnchantStatHead1.Text = "--No Enchant--";
            // 
            // EquipStatHead
            // 
            this.EquipStatHead.AutoSize = true;
            this.EquipStatHead.Location = new System.Drawing.Point(234, 38);
            this.EquipStatHead.Name = "EquipStatHead";
            this.EquipStatHead.Size = new System.Drawing.Size(0, 13);
            this.EquipStatHead.TabIndex = 5;
            // 
            // EnchantHead4
            // 
            this.EnchantHead4.FormattingEnabled = true;
            this.EnchantHead4.Location = new System.Drawing.Point(75, 188);
            this.EnchantHead4.Name = "EnchantHead4";
            this.EnchantHead4.Size = new System.Drawing.Size(121, 21);
            this.EnchantHead4.TabIndex = 4;
            this.EnchantHead4.SelectedIndexChanged += new System.EventHandler(this.EnchantHead4_SelectedIndexChanged);
            // 
            // EnchantHead3
            // 
            this.EnchantHead3.FormattingEnabled = true;
            this.EnchantHead3.Location = new System.Drawing.Point(75, 152);
            this.EnchantHead3.Name = "EnchantHead3";
            this.EnchantHead3.Size = new System.Drawing.Size(121, 21);
            this.EnchantHead3.TabIndex = 3;
            this.EnchantHead3.SelectedIndexChanged += new System.EventHandler(this.EnchantHead3_SelectedIndexChanged);
            // 
            // EnchantHead2
            // 
            this.EnchantHead2.FormattingEnabled = true;
            this.EnchantHead2.Location = new System.Drawing.Point(75, 116);
            this.EnchantHead2.Name = "EnchantHead2";
            this.EnchantHead2.Size = new System.Drawing.Size(121, 21);
            this.EnchantHead2.TabIndex = 2;
            this.EnchantHead2.SelectedIndexChanged += new System.EventHandler(this.EnchantHead2_SelectedIndexChanged);
            // 
            // EnchantHead1
            // 
            this.EnchantHead1.FormattingEnabled = true;
            this.EnchantHead1.Location = new System.Drawing.Point(75, 79);
            this.EnchantHead1.Name = "EnchantHead1";
            this.EnchantHead1.Size = new System.Drawing.Size(121, 21);
            this.EnchantHead1.TabIndex = 1;
            this.EnchantHead1.SelectedIndexChanged += new System.EventHandler(this.EnchantHead1_SelectedIndexChanged);
            // 
            // HeadEquip
            // 
            this.HeadEquip.FormattingEnabled = true;
            this.HeadEquip.Location = new System.Drawing.Point(35, 35);
            this.HeadEquip.Name = "HeadEquip";
            this.HeadEquip.Size = new System.Drawing.Size(161, 21);
            this.HeadEquip.TabIndex = 0;
            this.HeadEquip.SelectedIndexChanged += new System.EventHandler(this.HeadEquip_SelectedIndexChanged);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.EquipStatBody);
            this.Body.Controls.Add(this.EnchantStatBody1);
            this.Body.Controls.Add(this.EnchantStatBody2);
            this.Body.Controls.Add(this.EnchantStatBody3);
            this.Body.Controls.Add(this.EnchantStatBody4);
            this.Body.Controls.Add(this.BodyEnchant4);
            this.Body.Controls.Add(this.BodyEnchant3);
            this.Body.Controls.Add(this.BodyEnchant2);
            this.Body.Controls.Add(this.BodyEnchant1);
            this.Body.Controls.Add(this.BodyEquip);
            this.Body.Location = new System.Drawing.Point(4, 22);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(3);
            this.Body.Size = new System.Drawing.Size(678, 405);
            this.Body.TabIndex = 1;
            this.Body.Text = "Body";
            this.Body.UseVisualStyleBackColor = true;
            // 
            // EquipStatBody
            // 
            this.EquipStatBody.AutoSize = true;
            this.EquipStatBody.Location = new System.Drawing.Point(234, 38);
            this.EquipStatBody.Name = "EquipStatBody";
            this.EquipStatBody.Size = new System.Drawing.Size(90, 13);
            this.EquipStatBody.TabIndex = 10;
            this.EquipStatBody.Text = " ";
            // 
            // EnchantStatBody1
            // 
            this.EnchantStatBody1.AutoSize = true;
            this.EnchantStatBody1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatBody1.Name = "EnchantStatBody1";
            this.EnchantStatBody1.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatBody1.TabIndex = 9;
            this.EnchantStatBody1.Text = " ";
            // 
            // EnchantStatBody2
            // 
            this.EnchantStatBody2.AutoSize = true;
            this.EnchantStatBody2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatBody2.Name = "EnchantStatBody2";
            this.EnchantStatBody2.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatBody2.TabIndex = 8;
            this.EnchantStatBody2.Text = " ";
            // 
            // EnchantStatBody3
            // 
            this.EnchantStatBody3.AutoSize = true;
            this.EnchantStatBody3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatBody3.Name = "EnchantStatBody3";
            this.EnchantStatBody3.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatBody3.TabIndex = 7;
            this.EnchantStatBody3.Text = " ";
            // 
            // EnchantStatBody4
            // 
            this.EnchantStatBody4.AutoSize = true;
            this.EnchantStatBody4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatBody4.Name = "EnchantStatBody4";
            this.EnchantStatBody4.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatBody4.TabIndex = 6;
            this.EnchantStatBody4.Text = " ";
            // 
            // BodyEnchant4
            // 
            this.BodyEnchant4.FormattingEnabled = true;
            this.BodyEnchant4.Location = new System.Drawing.Point(75, 188);
            this.BodyEnchant4.Name = "BodyEnchant4";
            this.BodyEnchant4.Size = new System.Drawing.Size(121, 21);
            this.BodyEnchant4.TabIndex = 5;
            this.BodyEnchant4.SelectedIndexChanged += new System.EventHandler(this.BodyEnchant4_SelectedIndexChanged);
            // 
            // BodyEnchant3
            // 
            this.BodyEnchant3.FormattingEnabled = true;
            this.BodyEnchant3.Location = new System.Drawing.Point(75, 152);
            this.BodyEnchant3.Name = "BodyEnchant3";
            this.BodyEnchant3.Size = new System.Drawing.Size(121, 21);
            this.BodyEnchant3.TabIndex = 4;
            this.BodyEnchant3.SelectedIndexChanged += new System.EventHandler(this.BodyEnchant3_SelectedIndexChanged);
            // 
            // BodyEnchant2
            // 
            this.BodyEnchant2.FormattingEnabled = true;
            this.BodyEnchant2.Location = new System.Drawing.Point(75, 116);
            this.BodyEnchant2.Name = "BodyEnchant2";
            this.BodyEnchant2.Size = new System.Drawing.Size(121, 21);
            this.BodyEnchant2.TabIndex = 3;
            this.BodyEnchant2.SelectedIndexChanged += new System.EventHandler(this.BodyEnchant2_SelectedIndexChanged);
            // 
            // BodyEnchant1
            // 
            this.BodyEnchant1.FormattingEnabled = true;
            this.BodyEnchant1.Location = new System.Drawing.Point(75, 79);
            this.BodyEnchant1.Name = "BodyEnchant1";
            this.BodyEnchant1.Size = new System.Drawing.Size(121, 21);
            this.BodyEnchant1.TabIndex = 2;
            this.BodyEnchant1.SelectedIndexChanged += new System.EventHandler(this.BodyEnchant1_SelectedIndexChanged);
            // 
            // BodyEquip
            // 
            this.BodyEquip.FormattingEnabled = true;
            this.BodyEquip.Location = new System.Drawing.Point(35, 35);
            this.BodyEquip.Name = "BodyEquip";
            this.BodyEquip.Size = new System.Drawing.Size(161, 21);
            this.BodyEquip.TabIndex = 1;
            this.BodyEquip.SelectedIndexChanged += new System.EventHandler(this.BodyEquip_SelectedIndexChanged);
            // 
            // Glider
            // 
            this.Glider.Controls.Add(this.EquipStatGlider);
            this.Glider.Controls.Add(this.EnchantStatGlider1);
            this.Glider.Controls.Add(this.EnchantStatGlider2);
            this.Glider.Controls.Add(this.EnchantStatGlider3);
            this.Glider.Controls.Add(this.EnchantStatGlider4);
            this.Glider.Controls.Add(this.GliderEnchant3);
            this.Glider.Controls.Add(this.GliderEnchant4);
            this.Glider.Controls.Add(this.GliderEnchant1);
            this.Glider.Controls.Add(this.GliderEnchant2);
            this.Glider.Controls.Add(this.GliderEquip);
            this.Glider.Location = new System.Drawing.Point(4, 22);
            this.Glider.Name = "Glider";
            this.Glider.Size = new System.Drawing.Size(678, 405);
            this.Glider.TabIndex = 2;
            this.Glider.Text = "Glider";
            this.Glider.UseVisualStyleBackColor = true;
            // 
            // EquipStatGlider
            // 
            this.EquipStatGlider.AutoSize = true;
            this.EquipStatGlider.Location = new System.Drawing.Point(234, 38);
            this.EquipStatGlider.Name = "EquipStatGlider";
            this.EquipStatGlider.Size = new System.Drawing.Size(90, 13);
            this.EquipStatGlider.TabIndex = 10;
            this.EquipStatGlider.Text = " ";
            // 
            // EnchantStatGlider1
            // 
            this.EnchantStatGlider1.AutoSize = true;
            this.EnchantStatGlider1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatGlider1.Name = "EnchantStatGlider1";
            this.EnchantStatGlider1.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatGlider1.TabIndex = 9;
            this.EnchantStatGlider1.Text = " ";
            // 
            // EnchantStatGlider2
            // 
            this.EnchantStatGlider2.AutoSize = true;
            this.EnchantStatGlider2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatGlider2.Name = "EnchantStatGlider2";
            this.EnchantStatGlider2.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatGlider2.TabIndex = 8;
            this.EnchantStatGlider2.Text = " ";
            // 
            // EnchantStatGlider3
            // 
            this.EnchantStatGlider3.AutoSize = true;
            this.EnchantStatGlider3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatGlider3.Name = "EnchantStatGlider3";
            this.EnchantStatGlider3.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatGlider3.TabIndex = 7;
            this.EnchantStatGlider3.Text = " ";
            // 
            // EnchantStatGlider4
            // 
            this.EnchantStatGlider4.AutoSize = true;
            this.EnchantStatGlider4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatGlider4.Name = "EnchantStatGlider4";
            this.EnchantStatGlider4.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatGlider4.TabIndex = 6;
            this.EnchantStatGlider4.Text = " ";
            // 
            // GliderEnchant3
            // 
            this.GliderEnchant3.FormattingEnabled = true;
            this.GliderEnchant3.Location = new System.Drawing.Point(75, 152);
            this.GliderEnchant3.Name = "GliderEnchant3";
            this.GliderEnchant3.Size = new System.Drawing.Size(121, 21);
            this.GliderEnchant3.TabIndex = 5;
            this.GliderEnchant3.SelectedIndexChanged += new System.EventHandler(this.GliderEnchant3_SelectedIndexChanged);
            // 
            // GliderEnchant4
            // 
            this.GliderEnchant4.FormattingEnabled = true;
            this.GliderEnchant4.Location = new System.Drawing.Point(75, 188);
            this.GliderEnchant4.Name = "GliderEnchant4";
            this.GliderEnchant4.Size = new System.Drawing.Size(121, 21);
            this.GliderEnchant4.TabIndex = 4;
            this.GliderEnchant4.SelectedIndexChanged += new System.EventHandler(this.GliderEnchant4_SelectedIndexChanged);
            // 
            // GliderEnchant1
            // 
            this.GliderEnchant1.FormattingEnabled = true;
            this.GliderEnchant1.Location = new System.Drawing.Point(75, 79);
            this.GliderEnchant1.Name = "GliderEnchant1";
            this.GliderEnchant1.Size = new System.Drawing.Size(121, 21);
            this.GliderEnchant1.TabIndex = 3;
            this.GliderEnchant1.SelectedIndexChanged += new System.EventHandler(this.GliderEnchant1_SelectedIndexChanged);
            // 
            // GliderEnchant2
            // 
            this.GliderEnchant2.FormattingEnabled = true;
            this.GliderEnchant2.Location = new System.Drawing.Point(75, 116);
            this.GliderEnchant2.Name = "GliderEnchant2";
            this.GliderEnchant2.Size = new System.Drawing.Size(121, 21);
            this.GliderEnchant2.TabIndex = 2;
            this.GliderEnchant2.SelectedIndexChanged += new System.EventHandler(this.GliderEnchant2_SelectedIndexChanged);
            // 
            // GliderEquip
            // 
            this.GliderEquip.FormattingEnabled = true;
            this.GliderEquip.Location = new System.Drawing.Point(35, 35);
            this.GliderEquip.Name = "GliderEquip";
            this.GliderEquip.Size = new System.Drawing.Size(161, 21);
            this.GliderEquip.TabIndex = 1;
            this.GliderEquip.SelectedIndexChanged += new System.EventHandler(this.GliderEquip_SelectedIndexChanged);
            // 
            // Acc1
            // 
            this.Acc1.Controls.Add(this.EquipStatAcc1);
            this.Acc1.Controls.Add(this.EnchantStatAccI1);
            this.Acc1.Controls.Add(this.EnchantStatAccI2);
            this.Acc1.Controls.Add(this.EnchantStatAccI3);
            this.Acc1.Controls.Add(this.EnchantStatAccI4);
            this.Acc1.Controls.Add(this.Acc1Enchant1);
            this.Acc1.Controls.Add(this.Acc1Enchant2);
            this.Acc1.Controls.Add(this.Acc1Enchant3);
            this.Acc1.Controls.Add(this.Acc1Enchant4);
            this.Acc1.Controls.Add(this.Acc1Equip);
            this.Acc1.Location = new System.Drawing.Point(4, 22);
            this.Acc1.Name = "Acc1";
            this.Acc1.Size = new System.Drawing.Size(678, 405);
            this.Acc1.TabIndex = 3;
            this.Acc1.Text = "Acc 1";
            this.Acc1.UseVisualStyleBackColor = true;
            // 
            // EquipStatAcc1
            // 
            this.EquipStatAcc1.AutoSize = true;
            this.EquipStatAcc1.Location = new System.Drawing.Point(234, 38);
            this.EquipStatAcc1.Name = "EquipStatAcc1";
            this.EquipStatAcc1.Size = new System.Drawing.Size(90, 13);
            this.EquipStatAcc1.TabIndex = 11;
            this.EquipStatAcc1.Text = " ";
            // 
            // EnchantStatAccI1
            // 
            this.EnchantStatAccI1.AutoSize = true;
            this.EnchantStatAccI1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatAccI1.Name = "EnchantStatAccI1";
            this.EnchantStatAccI1.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAccI1.TabIndex = 10;
            this.EnchantStatAccI1.Text = " ";
            // 
            // EnchantStatAccI2
            // 
            this.EnchantStatAccI2.AutoSize = true;
            this.EnchantStatAccI2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatAccI2.Name = "EnchantStatAccI2";
            this.EnchantStatAccI2.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAccI2.TabIndex = 9;
            this.EnchantStatAccI2.Text = " ";
            // 
            // EnchantStatAccI3
            // 
            this.EnchantStatAccI3.AutoSize = true;
            this.EnchantStatAccI3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatAccI3.Name = "EnchantStatAccI3";
            this.EnchantStatAccI3.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAccI3.TabIndex = 8;
            this.EnchantStatAccI3.Text = " ";
            // 
            // EnchantStatAccI4
            // 
            this.EnchantStatAccI4.AutoSize = true;
            this.EnchantStatAccI4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatAccI4.Name = "EnchantStatAccI4";
            this.EnchantStatAccI4.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAccI4.TabIndex = 7;
            this.EnchantStatAccI4.Text = " ";
            // 
            // Acc1Enchant1
            // 
            this.Acc1Enchant1.FormattingEnabled = true;
            this.Acc1Enchant1.Location = new System.Drawing.Point(75, 79);
            this.Acc1Enchant1.Name = "Acc1Enchant1";
            this.Acc1Enchant1.Size = new System.Drawing.Size(121, 21);
            this.Acc1Enchant1.TabIndex = 6;
            this.Acc1Enchant1.SelectedIndexChanged += new System.EventHandler(this.Acc1Enchant1_SelectedIndexChanged);
            // 
            // Acc1Enchant2
            // 
            this.Acc1Enchant2.FormattingEnabled = true;
            this.Acc1Enchant2.Location = new System.Drawing.Point(75, 116);
            this.Acc1Enchant2.Name = "Acc1Enchant2";
            this.Acc1Enchant2.Size = new System.Drawing.Size(121, 21);
            this.Acc1Enchant2.TabIndex = 5;
            this.Acc1Enchant2.SelectedIndexChanged += new System.EventHandler(this.Acc1Enchant2_SelectedIndexChanged);
            // 
            // Acc1Enchant3
            // 
            this.Acc1Enchant3.FormattingEnabled = true;
            this.Acc1Enchant3.Location = new System.Drawing.Point(75, 152);
            this.Acc1Enchant3.Name = "Acc1Enchant3";
            this.Acc1Enchant3.Size = new System.Drawing.Size(121, 21);
            this.Acc1Enchant3.TabIndex = 4;
            this.Acc1Enchant3.SelectedIndexChanged += new System.EventHandler(this.Acc1Enchant3_SelectedIndexChanged);
            // 
            // Acc1Enchant4
            // 
            this.Acc1Enchant4.FormattingEnabled = true;
            this.Acc1Enchant4.Location = new System.Drawing.Point(75, 188);
            this.Acc1Enchant4.Name = "Acc1Enchant4";
            this.Acc1Enchant4.Size = new System.Drawing.Size(121, 21);
            this.Acc1Enchant4.TabIndex = 3;
            this.Acc1Enchant4.SelectedIndexChanged += new System.EventHandler(this.Acc1Enchant4_SelectedIndexChanged);
            // 
            // Acc1Equip
            // 
            this.Acc1Equip.FormattingEnabled = true;
            this.Acc1Equip.Location = new System.Drawing.Point(35, 35);
            this.Acc1Equip.Name = "Acc1Equip";
            this.Acc1Equip.Size = new System.Drawing.Size(161, 21);
            this.Acc1Equip.TabIndex = 2;
            this.Acc1Equip.SelectedIndexChanged += new System.EventHandler(this.Acc1Equip_SelectedIndexChanged);
            // 
            // Acc2
            // 
            this.Acc2.Controls.Add(this.EquipStatAcc2);
            this.Acc2.Controls.Add(this.EnchantStatAccII1);
            this.Acc2.Controls.Add(this.EnchantStatAccII2);
            this.Acc2.Controls.Add(this.EnchantStatAccII3);
            this.Acc2.Controls.Add(this.EnchantStatAccII4);
            this.Acc2.Controls.Add(this.Acc2Enchant1);
            this.Acc2.Controls.Add(this.Acc2Enchant2);
            this.Acc2.Controls.Add(this.Acc2Enchant3);
            this.Acc2.Controls.Add(this.Acc2Enchant4);
            this.Acc2.Controls.Add(this.Acc2Equip);
            this.Acc2.Location = new System.Drawing.Point(4, 22);
            this.Acc2.Name = "Acc2";
            this.Acc2.Size = new System.Drawing.Size(678, 405);
            this.Acc2.TabIndex = 4;
            this.Acc2.Text = "Acc 2";
            this.Acc2.UseVisualStyleBackColor = true;
            // 
            // EquipStatAcc2
            // 
            this.EquipStatAcc2.AutoSize = true;
            this.EquipStatAcc2.Location = new System.Drawing.Point(234, 38);
            this.EquipStatAcc2.Name = "EquipStatAcc2";
            this.EquipStatAcc2.Size = new System.Drawing.Size(90, 13);
            this.EquipStatAcc2.TabIndex = 11;
            this.EquipStatAcc2.Text = " ";
            // 
            // EnchantStatAccII1
            // 
            this.EnchantStatAccII1.AutoSize = true;
            this.EnchantStatAccII1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatAccII1.Name = "EnchantStatAccII1";
            this.EnchantStatAccII1.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAccII1.TabIndex = 10;
            this.EnchantStatAccII1.Text = " ";
            // 
            // EnchantStatAccII2
            // 
            this.EnchantStatAccII2.AutoSize = true;
            this.EnchantStatAccII2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatAccII2.Name = "EnchantStatAccII2";
            this.EnchantStatAccII2.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAccII2.TabIndex = 9;
            this.EnchantStatAccII2.Text = " ";
            // 
            // EnchantStatAccII3
            // 
            this.EnchantStatAccII3.AutoSize = true;
            this.EnchantStatAccII3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatAccII3.Name = "EnchantStatAccII3";
            this.EnchantStatAccII3.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAccII3.TabIndex = 8;
            this.EnchantStatAccII3.Text = " ";
            // 
            // EnchantStatAccII4
            // 
            this.EnchantStatAccII4.AutoSize = true;
            this.EnchantStatAccII4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatAccII4.Name = "EnchantStatAccII4";
            this.EnchantStatAccII4.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAccII4.TabIndex = 7;
            this.EnchantStatAccII4.Text = " ";
            // 
            // Acc2Enchant1
            // 
            this.Acc2Enchant1.FormattingEnabled = true;
            this.Acc2Enchant1.Location = new System.Drawing.Point(75, 79);
            this.Acc2Enchant1.Name = "Acc2Enchant1";
            this.Acc2Enchant1.Size = new System.Drawing.Size(121, 21);
            this.Acc2Enchant1.TabIndex = 6;
            this.Acc2Enchant1.SelectedIndexChanged += new System.EventHandler(this.Acc2Enchant1_SelectedIndexChanged);
            // 
            // Acc2Enchant2
            // 
            this.Acc2Enchant2.FormattingEnabled = true;
            this.Acc2Enchant2.Location = new System.Drawing.Point(75, 116);
            this.Acc2Enchant2.Name = "Acc2Enchant2";
            this.Acc2Enchant2.Size = new System.Drawing.Size(121, 21);
            this.Acc2Enchant2.TabIndex = 5;
            this.Acc2Enchant2.SelectedIndexChanged += new System.EventHandler(this.Acc2Enchant2_SelectedIndexChanged);
            // 
            // Acc2Enchant3
            // 
            this.Acc2Enchant3.FormattingEnabled = true;
            this.Acc2Enchant3.Location = new System.Drawing.Point(75, 152);
            this.Acc2Enchant3.Name = "Acc2Enchant3";
            this.Acc2Enchant3.Size = new System.Drawing.Size(121, 21);
            this.Acc2Enchant3.TabIndex = 4;
            this.Acc2Enchant3.SelectedIndexChanged += new System.EventHandler(this.Acc2Enchant3_SelectedIndexChanged);
            // 
            // Acc2Enchant4
            // 
            this.Acc2Enchant4.FormattingEnabled = true;
            this.Acc2Enchant4.Location = new System.Drawing.Point(75, 188);
            this.Acc2Enchant4.Name = "Acc2Enchant4";
            this.Acc2Enchant4.Size = new System.Drawing.Size(121, 21);
            this.Acc2Enchant4.TabIndex = 3;
            this.Acc2Enchant4.SelectedIndexChanged += new System.EventHandler(this.Acc2Enchant4_SelectedIndexChanged);
            // 
            // Acc2Equip
            // 
            this.Acc2Equip.FormattingEnabled = true;
            this.Acc2Equip.Location = new System.Drawing.Point(35, 35);
            this.Acc2Equip.Name = "Acc2Equip";
            this.Acc2Equip.Size = new System.Drawing.Size(161, 21);
            this.Acc2Equip.TabIndex = 2;
            this.Acc2Equip.SelectedIndexChanged += new System.EventHandler(this.Acc2Equip_SelectedIndexChanged);
            // 
            // Ammo
            // 
            this.Ammo.Controls.Add(this.EquipStatAmmo);
            this.Ammo.Controls.Add(this.EnchantStatAmmo1);
            this.Ammo.Controls.Add(this.EnchantStatAmmo2);
            this.Ammo.Controls.Add(this.EnchantStatAmmo3);
            this.Ammo.Controls.Add(this.EnchantStatAmmo4);
            this.Ammo.Controls.Add(this.AmmoEnchant1);
            this.Ammo.Controls.Add(this.AmmoEnchant2);
            this.Ammo.Controls.Add(this.AmmoEnchant3);
            this.Ammo.Controls.Add(this.AmmoEnchant4);
            this.Ammo.Controls.Add(this.AmmoEquip);
            this.Ammo.Location = new System.Drawing.Point(4, 22);
            this.Ammo.Name = "Ammo";
            this.Ammo.Size = new System.Drawing.Size(678, 405);
            this.Ammo.TabIndex = 5;
            this.Ammo.Text = "Ammo";
            this.Ammo.UseVisualStyleBackColor = true;
            // 
            // EquipStatAmmo
            // 
            this.EquipStatAmmo.AutoSize = true;
            this.EquipStatAmmo.Location = new System.Drawing.Point(234, 38);
            this.EquipStatAmmo.Name = "EquipStatAmmo";
            this.EquipStatAmmo.Size = new System.Drawing.Size(90, 13);
            this.EquipStatAmmo.TabIndex = 11;
            this.EquipStatAmmo.Text = " ";
            // 
            // EnchantStatAmmo1
            // 
            this.EnchantStatAmmo1.AutoSize = true;
            this.EnchantStatAmmo1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatAmmo1.Name = "EnchantStatAmmo1";
            this.EnchantStatAmmo1.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAmmo1.TabIndex = 10;
            this.EnchantStatAmmo1.Text = " ";
            // 
            // EnchantStatAmmo2
            // 
            this.EnchantStatAmmo2.AutoSize = true;
            this.EnchantStatAmmo2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatAmmo2.Name = "EnchantStatAmmo2";
            this.EnchantStatAmmo2.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAmmo2.TabIndex = 9;
            this.EnchantStatAmmo2.Text = "";
            // 
            // EnchantStatAmmo3
            // 
            this.EnchantStatAmmo3.AutoSize = true;
            this.EnchantStatAmmo3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatAmmo3.Name = "EnchantStatAmmo3";
            this.EnchantStatAmmo3.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAmmo3.TabIndex = 8;
            this.EnchantStatAmmo3.Text = "";
            // 
            // EnchantStatAmmo4
            // 
            this.EnchantStatAmmo4.AutoSize = true;
            this.EnchantStatAmmo4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatAmmo4.Name = "EnchantStatAmmo4";
            this.EnchantStatAmmo4.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatAmmo4.TabIndex = 7;
            this.EnchantStatAmmo4.Text = " ";
            // 
            // AmmoEnchant1
            // 
            this.AmmoEnchant1.FormattingEnabled = true;
            this.AmmoEnchant1.Location = new System.Drawing.Point(75, 79);
            this.AmmoEnchant1.Name = "AmmoEnchant1";
            this.AmmoEnchant1.Size = new System.Drawing.Size(121, 21);
            this.AmmoEnchant1.TabIndex = 6;
            this.AmmoEnchant1.SelectedIndexChanged += new System.EventHandler(this.AmmoEnchant1_SelectedIndexChanged);
            // 
            // AmmoEnchant2
            // 
            this.AmmoEnchant2.FormattingEnabled = true;
            this.AmmoEnchant2.Location = new System.Drawing.Point(75, 116);
            this.AmmoEnchant2.Name = "AmmoEnchant2";
            this.AmmoEnchant2.Size = new System.Drawing.Size(121, 21);
            this.AmmoEnchant2.TabIndex = 5;
            this.AmmoEnchant2.SelectedIndexChanged += new System.EventHandler(this.AmmoEnchant2_SelectedIndexChanged);
            // 
            // AmmoEnchant3
            // 
            this.AmmoEnchant3.FormattingEnabled = true;
            this.AmmoEnchant3.Location = new System.Drawing.Point(75, 152);
            this.AmmoEnchant3.Name = "AmmoEnchant3";
            this.AmmoEnchant3.Size = new System.Drawing.Size(121, 21);
            this.AmmoEnchant3.TabIndex = 4;
            this.AmmoEnchant3.SelectedIndexChanged += new System.EventHandler(this.AmmoEnchant3_SelectedIndexChanged);
            // 
            // AmmoEnchant4
            // 
            this.AmmoEnchant4.FormattingEnabled = true;
            this.AmmoEnchant4.Location = new System.Drawing.Point(75, 188);
            this.AmmoEnchant4.Name = "AmmoEnchant4";
            this.AmmoEnchant4.Size = new System.Drawing.Size(121, 21);
            this.AmmoEnchant4.TabIndex = 3;
            this.AmmoEnchant4.SelectedIndexChanged += new System.EventHandler(this.AmmoEnchant4_SelectedIndexChanged);
            // 
            // AmmoEquip
            // 
            this.AmmoEquip.FormattingEnabled = true;
            this.AmmoEquip.Location = new System.Drawing.Point(35, 35);
            this.AmmoEquip.Name = "AmmoEquip";
            this.AmmoEquip.Size = new System.Drawing.Size(161, 21);
            this.AmmoEquip.TabIndex = 2;
            this.AmmoEquip.SelectedIndexChanged += new System.EventHandler(this.AmmoEquip_SelectedIndexChanged);
            // 
            // MainHand
            // 
            this.MainHand.Controls.Add(this.EquipStatMain);
            this.MainHand.Controls.Add(this.EnchantStatMain1);
            this.MainHand.Controls.Add(this.EnchantStatMain2);
            this.MainHand.Controls.Add(this.EnchantStatMain3);
            this.MainHand.Controls.Add(this.EnchantStatMain4);
            this.MainHand.Controls.Add(this.MainEnchant1);
            this.MainHand.Controls.Add(this.MainEnchant2);
            this.MainHand.Controls.Add(this.MainEnchant3);
            this.MainHand.Controls.Add(this.MainEnchant4);
            this.MainHand.Controls.Add(this.MainEquip);
            this.MainHand.Location = new System.Drawing.Point(4, 22);
            this.MainHand.Name = "MainHand";
            this.MainHand.Size = new System.Drawing.Size(678, 405);
            this.MainHand.TabIndex = 6;
            this.MainHand.Text = "Main-Hand";
            this.MainHand.UseVisualStyleBackColor = true;
            // 
            // EquipStatMain
            // 
            this.EquipStatMain.AutoSize = true;
            this.EquipStatMain.Location = new System.Drawing.Point(234, 38);
            this.EquipStatMain.Name = "EquipStatMain";
            this.EquipStatMain.Size = new System.Drawing.Size(90, 13);
            this.EquipStatMain.TabIndex = 11;
            this.EquipStatMain.Text = " ";
            // 
            // EnchantStatMain1
            // 
            this.EnchantStatMain1.AutoSize = true;
            this.EnchantStatMain1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatMain1.Name = "EnchantStatMain1";
            this.EnchantStatMain1.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatMain1.TabIndex = 10;
            this.EnchantStatMain1.Text = " ";
            // 
            // EnchantStatMain2
            // 
            this.EnchantStatMain2.AutoSize = true;
            this.EnchantStatMain2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatMain2.Name = "EnchantStatMain2";
            this.EnchantStatMain2.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatMain2.TabIndex = 9;
            this.EnchantStatMain2.Text = " ";
            // 
            // EnchantStatMain3
            // 
            this.EnchantStatMain3.AutoSize = true;
            this.EnchantStatMain3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatMain3.Name = "EnchantStatMain3";
            this.EnchantStatMain3.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatMain3.TabIndex = 8;
            this.EnchantStatMain3.Text = " ";
            // 
            // EnchantStatMain4
            // 
            this.EnchantStatMain4.AutoSize = true;
            this.EnchantStatMain4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatMain4.Name = "EnchantStatMain4";
            this.EnchantStatMain4.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatMain4.TabIndex = 7;
            this.EnchantStatMain4.Text = " ";
            // 
            // MainEnchant1
            // 
            this.MainEnchant1.FormattingEnabled = true;
            this.MainEnchant1.Location = new System.Drawing.Point(75, 79);
            this.MainEnchant1.Name = "MainEnchant1";
            this.MainEnchant1.Size = new System.Drawing.Size(121, 21);
            this.MainEnchant1.TabIndex = 6;
            this.MainEnchant1.SelectedIndexChanged += new System.EventHandler(this.MainEnchant1_SelectedIndexChanged);
            // 
            // MainEnchant2
            // 
            this.MainEnchant2.FormattingEnabled = true;
            this.MainEnchant2.Location = new System.Drawing.Point(75, 116);
            this.MainEnchant2.Name = "MainEnchant2";
            this.MainEnchant2.Size = new System.Drawing.Size(121, 21);
            this.MainEnchant2.TabIndex = 5;
            this.MainEnchant2.SelectedIndexChanged += new System.EventHandler(this.MainEnchant2_SelectedIndexChanged);
            // 
            // MainEnchant3
            // 
            this.MainEnchant3.FormattingEnabled = true;
            this.MainEnchant3.Location = new System.Drawing.Point(75, 152);
            this.MainEnchant3.Name = "MainEnchant3";
            this.MainEnchant3.Size = new System.Drawing.Size(121, 21);
            this.MainEnchant3.TabIndex = 4;
            this.MainEnchant3.SelectedIndexChanged += new System.EventHandler(this.MainEnchant3_SelectedIndexChanged);
            // 
            // MainEnchant4
            // 
            this.MainEnchant4.FormattingEnabled = true;
            this.MainEnchant4.Location = new System.Drawing.Point(75, 188);
            this.MainEnchant4.Name = "MainEnchant4";
            this.MainEnchant4.Size = new System.Drawing.Size(121, 21);
            this.MainEnchant4.TabIndex = 3;
            this.MainEnchant4.SelectedIndexChanged += new System.EventHandler(this.MainEnchant4_SelectedIndexChanged);
            // 
            // MainEquip
            // 
            this.MainEquip.FormattingEnabled = true;
            this.MainEquip.Location = new System.Drawing.Point(35, 35);
            this.MainEquip.Name = "MainEquip";
            this.MainEquip.Size = new System.Drawing.Size(161, 21);
            this.MainEquip.TabIndex = 2;
            this.MainEquip.SelectedIndexChanged += new System.EventHandler(this.MainEquip_SelectedIndexChanged);
            // 
            // OffHand
            // 
            this.OffHand.Controls.Add(this.EquipStatOff);
            this.OffHand.Controls.Add(this.EnchantStatOff1);
            this.OffHand.Controls.Add(this.EnchantStatOff2);
            this.OffHand.Controls.Add(this.EnchantStatOff3);
            this.OffHand.Controls.Add(this.EnchantStatOff4);
            this.OffHand.Controls.Add(this.OffEnchant1);
            this.OffHand.Controls.Add(this.OffEnchant2);
            this.OffHand.Controls.Add(this.OffEnchant3);
            this.OffHand.Controls.Add(this.OffEnchant4);
            this.OffHand.Controls.Add(this.OffEquip);
            this.OffHand.Location = new System.Drawing.Point(4, 22);
            this.OffHand.Name = "OffHand";
            this.OffHand.Size = new System.Drawing.Size(678, 405);
            this.OffHand.TabIndex = 7;
            this.OffHand.Text = "Off-Hand";
            this.OffHand.UseVisualStyleBackColor = true;
            // 
            // EquipStatOff
            // 
            this.EquipStatOff.AutoSize = true;
            this.EquipStatOff.Location = new System.Drawing.Point(234, 38);
            this.EquipStatOff.Name = "EquipStatOff";
            this.EquipStatOff.Size = new System.Drawing.Size(90, 13);
            this.EquipStatOff.TabIndex = 11;
            this.EquipStatOff.Text = " ";
            // 
            // EnchantStatOff1
            // 
            this.EnchantStatOff1.AutoSize = true;
            this.EnchantStatOff1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatOff1.Name = "EnchantStatOff1";
            this.EnchantStatOff1.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatOff1.TabIndex = 10;
            this.EnchantStatOff1.Text = " ";
            // 
            // EnchantStatOff2
            // 
            this.EnchantStatOff2.AutoSize = true;
            this.EnchantStatOff2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatOff2.Name = "EnchantStatOff2";
            this.EnchantStatOff2.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatOff2.TabIndex = 9;
            this.EnchantStatOff2.Text = " ";
            // 
            // EnchantStatOff3
            // 
            this.EnchantStatOff3.AutoSize = true;
            this.EnchantStatOff3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatOff3.Name = "EnchantStatOff3";
            this.EnchantStatOff3.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatOff3.TabIndex = 8;
            this.EnchantStatOff3.Text = " ";
            // 
            // EnchantStatOff4
            // 
            this.EnchantStatOff4.AutoSize = true;
            this.EnchantStatOff4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatOff4.Name = "EnchantStatOff4";
            this.EnchantStatOff4.Size = new System.Drawing.Size(90, 13);
            this.EnchantStatOff4.TabIndex = 7;
            this.EnchantStatOff4.Text = " ";
            // 
            // OffEnchant1
            // 
            this.OffEnchant1.FormattingEnabled = true;
            this.OffEnchant1.Location = new System.Drawing.Point(75, 79);
            this.OffEnchant1.Name = "OffEnchant1";
            this.OffEnchant1.Size = new System.Drawing.Size(121, 21);
            this.OffEnchant1.TabIndex = 6;
            this.OffEnchant1.SelectedIndexChanged += new System.EventHandler(this.OffEnchant1_SelectedIndexChanged);
            // 
            // OffEnchant2
            // 
            this.OffEnchant2.FormattingEnabled = true;
            this.OffEnchant2.Location = new System.Drawing.Point(75, 116);
            this.OffEnchant2.Name = "OffEnchant2";
            this.OffEnchant2.Size = new System.Drawing.Size(121, 21);
            this.OffEnchant2.TabIndex = 5;
            this.OffEnchant2.SelectedIndexChanged += new System.EventHandler(this.OffEnchant2_SelectedIndexChanged);
            // 
            // OffEnchant3
            // 
            this.OffEnchant3.FormattingEnabled = true;
            this.OffEnchant3.Location = new System.Drawing.Point(75, 152);
            this.OffEnchant3.Name = "OffEnchant3";
            this.OffEnchant3.Size = new System.Drawing.Size(121, 21);
            this.OffEnchant3.TabIndex = 4;
            this.OffEnchant3.SelectedIndexChanged += new System.EventHandler(this.OffEnchant4_SelectedIndexChanged);
            // 
            // OffEnchant4
            // 
            this.OffEnchant4.FormattingEnabled = true;
            this.OffEnchant4.Location = new System.Drawing.Point(75, 188);
            this.OffEnchant4.Name = "OffEnchant4";
            this.OffEnchant4.Size = new System.Drawing.Size(121, 21);
            this.OffEnchant4.TabIndex = 3;
            this.OffEnchant4.SelectedIndexChanged += new System.EventHandler(this.OffEnchant4_SelectedIndexChanged);
            // 
            // OffEquip
            // 
            this.OffEquip.FormattingEnabled = true;
            this.OffEquip.Location = new System.Drawing.Point(35, 35);
            this.OffEquip.Name = "OffEquip";
            this.OffEquip.Size = new System.Drawing.Size(161, 21);
            this.OffEquip.TabIndex = 2;
            this.OffEquip.SelectedIndexChanged += new System.EventHandler(this.OffEquip_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.Glider.ResumeLayout(false);
            this.Glider.PerformLayout();
            this.Acc1.ResumeLayout(false);
            this.Acc1.PerformLayout();
            this.Acc2.ResumeLayout(false);
            this.Acc2.PerformLayout();
            this.Ammo.ResumeLayout(false);
            this.Ammo.PerformLayout();
            this.MainHand.ResumeLayout(false);
            this.MainHand.PerformLayout();
            this.OffHand.ResumeLayout(false);
            this.OffHand.PerformLayout();
            this.ResumeLayout(false);

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
            foreach(Equipment eq in Equips)
            {
                if (n == eq.name)
                {
                    return eq;
                }
            }
            return new Equipment("Error", -1, -1, -1, new HashSet<Material> { });
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

            foreach(System.Windows.Forms.ComboBox eBox in enchBoxs)
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
            foreach(Equipment e in eqL)
            {
                if (n == e.name)
                    return e.atk + " ATK, " + e.matk + " MATK, " + e.def + " DEF";
            }
            return "Error";
        }


        //method to calc stat
       /* public void calcStats()
        {

            foreach (System.Windows.Forms.ComboBox cb in
                new List<System.Windows.Forms.ComboBox> {
                    HeadEquip, BodyEquip, GliderEquip, Acc1Equip, Acc2Equip, AmmoEquip, MainEquip, OffEquip
                })
            {
                if (cb.SelectedItem != null)
                {
                    ttl_atk_Static += getEquipment((string)cb.SelectedItem, EqLib.allEq).atk;
                    ttl_matk_Static += getEquipment((string)cb.SelectedItem, EqLib.allEq).matk;
                    ttl_def_Static += getEquipment((string)cb.SelectedItem, EqLib.allEq).def;
                }
            }

            foreach (System.Windows.Forms.ComboBox cb in 
                new List<System.Windows.Forms.ComboBox> { 
                    EnchantHead1, EnchantHead2, EnchantHead3, EnchantHead4,
                    BodyEnchant1, BodyEnchant2, BodyEnchant3, BodyEnchant4,
                    GliderEnchant1, GliderEnchant2, GliderEnchant3, GliderEnchant4,
                    Acc1Enchant1, Acc1Enchant2, Acc1Enchant3, Acc1Enchant4, 
                    Acc2Enchant1, Acc2Enchant2, Acc2Enchant3, Acc2Enchant4,
                    AmmoEnchant1, AmmoEnchant2, AmmoEnchant3, AmmoEnchant4,
                    MainEnchant1, MainEnchant2, MainEnchant3, MainEnchant4,
                    OffEnchant1, OffEnchant2, OffEnchant3, OffEnchant4
                })
            {
                if(cb.SelectedItem != null)
                {
                    ttl_atk_Static += getEnchant((string)cb.SelectedItem,EqLib.getAllEnchants()).atk_Static;
                    ttl_atk_Percent += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).atk_Percent;
                    ttl_def_Static += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).def_Static;
                    ttl_def_Percent += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).def_Percent;
                    ttl_matk_Static += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).matk_Static;
                    ttl_matk_Percent += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).matk_Percent;
                    ttl_crit_Damage += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).crit_Damage;
                    ttl_crit_Chance += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).crit_Chance;
                    ttl_move_Speed += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).move_Speed;
                    ttl_atk_Speed += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).atk_Speed;
                    ttl_mana_Static += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).mana_Static;
                    ttl_mana_Percent += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).mana_Percent;
                    ttl_stam_Static += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).stam_Static;
                    ttl_stam_Percent += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).stam_Percent;
                    ttl_life_Static += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).life_Static;
                    ttl_life_Percent += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).life_Percent;
                    ttl_hung_Static += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).hung_Static;
                    ttl_hung_Percent += getEnchant((string)cb.SelectedItem, EqLib.getAllEnchants()).hung_Percent;
                }
            }

        


        }*/

        public void calcStat(List<string> ls, string n, string e1, string e2, string e3, string e4)
        {
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

            if (!ls.Contains(n))
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
            else
            {
                if (!ls.Contains(e1))
                {
                    #region out with the old
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
                    #endregion

                    #region in with the new
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
                if (!ls.Contains(e2))
                {
                    #region out with the old
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
                    #endregion

                    #region in with the new
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
                if (!ls.Contains(e3))
                {
                    #region out with the old
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
                    #endregion

                    #region in with the new
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
                if (!ls.Contains(e4))
                {
                    #region out with the old
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
                    #endregion

                    #region in with the new
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

        #endregion

        #region All the variables
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Head;
        private System.Windows.Forms.ComboBox EnchantHead4;
        private System.Windows.Forms.ComboBox EnchantHead3;
        private System.Windows.Forms.ComboBox EnchantHead2;
        private System.Windows.Forms.ComboBox EnchantHead1;
        private System.Windows.Forms.ComboBox HeadEquip;
        private System.Windows.Forms.TabPage Body;
        private System.Windows.Forms.TabPage Glider;
        private System.Windows.Forms.TabPage Acc1;
        private System.Windows.Forms.TabPage Acc2;
        private System.Windows.Forms.TabPage Ammo;
        private System.Windows.Forms.TabPage MainHand;
        private System.Windows.Forms.TabPage OffHand;
        private System.Windows.Forms.Label EquipStatHead;
        private System.Windows.Forms.Label EnchantStatHead4;
        private System.Windows.Forms.Label EnchantStatHead3;
        private System.Windows.Forms.Label EnchantStatHead2;
        private System.Windows.Forms.Label EnchantStatHead1;
        private System.Windows.Forms.ComboBox BodyEquip;
        private System.Windows.Forms.ComboBox GliderEquip;
        private System.Windows.Forms.ComboBox BodyEnchant4;
        private System.Windows.Forms.ComboBox BodyEnchant3;
        private System.Windows.Forms.ComboBox BodyEnchant2;
        private System.Windows.Forms.ComboBox BodyEnchant1;
        private System.Windows.Forms.ComboBox GliderEnchant3;
        private System.Windows.Forms.ComboBox GliderEnchant4;
        private System.Windows.Forms.ComboBox GliderEnchant1;
        private System.Windows.Forms.ComboBox GliderEnchant2;
        private System.Windows.Forms.ComboBox Acc1Enchant1;
        private System.Windows.Forms.ComboBox Acc1Enchant2;
        private System.Windows.Forms.ComboBox Acc1Enchant3;
        private System.Windows.Forms.ComboBox Acc1Enchant4;
        private System.Windows.Forms.ComboBox Acc1Equip;
        private System.Windows.Forms.ComboBox Acc2Enchant1;
        private System.Windows.Forms.ComboBox Acc2Enchant2;
        private System.Windows.Forms.ComboBox Acc2Enchant3;
        private System.Windows.Forms.ComboBox Acc2Enchant4;
        private System.Windows.Forms.ComboBox Acc2Equip;
        private System.Windows.Forms.ComboBox AmmoEnchant1;
        private System.Windows.Forms.ComboBox AmmoEnchant2;
        private System.Windows.Forms.ComboBox AmmoEnchant3;
        private System.Windows.Forms.ComboBox AmmoEnchant4;
        private System.Windows.Forms.ComboBox AmmoEquip;
        private System.Windows.Forms.ComboBox MainEnchant1;
        private System.Windows.Forms.ComboBox MainEnchant2;
        private System.Windows.Forms.ComboBox MainEnchant3;
        private System.Windows.Forms.ComboBox MainEnchant4;
        private System.Windows.Forms.ComboBox MainEquip;
        private System.Windows.Forms.ComboBox OffEnchant1;
        private System.Windows.Forms.ComboBox OffEnchant2;
        private System.Windows.Forms.ComboBox OffEnchant3;
        private System.Windows.Forms.ComboBox OffEnchant4;
        private System.Windows.Forms.ComboBox OffEquip;
        private System.Windows.Forms.Label EquipStatBody;
        private System.Windows.Forms.Label EnchantStatBody1;
        private System.Windows.Forms.Label EnchantStatBody2;
        private System.Windows.Forms.Label EnchantStatBody3;
        private System.Windows.Forms.Label EnchantStatBody4;
        private System.Windows.Forms.Label EquipStatGlider;
        private System.Windows.Forms.Label EnchantStatGlider1;
        private System.Windows.Forms.Label EnchantStatGlider2;
        private System.Windows.Forms.Label EnchantStatGlider3;
        private System.Windows.Forms.Label EnchantStatGlider4;
        private System.Windows.Forms.Label EquipStatAcc1;
        private System.Windows.Forms.Label EnchantStatAccI1;
        private System.Windows.Forms.Label EnchantStatAccI2;
        private System.Windows.Forms.Label EnchantStatAccI3;
        private System.Windows.Forms.Label EnchantStatAccI4;
        private System.Windows.Forms.Label EquipStatAcc2;
        private System.Windows.Forms.Label EnchantStatAccII1;
        private System.Windows.Forms.Label EnchantStatAccII2;
        private System.Windows.Forms.Label EnchantStatAccII3;
        private System.Windows.Forms.Label EnchantStatAccII4;
        private System.Windows.Forms.Label EquipStatAmmo;
        private System.Windows.Forms.Label EnchantStatAmmo1;
        private System.Windows.Forms.Label EnchantStatAmmo2;
        private System.Windows.Forms.Label EnchantStatAmmo3;
        private System.Windows.Forms.Label EnchantStatAmmo4;
        private System.Windows.Forms.Label EquipStatMain;
        private System.Windows.Forms.Label EnchantStatMain1;
        private System.Windows.Forms.Label EnchantStatMain2;
        private System.Windows.Forms.Label EnchantStatMain3;
        private System.Windows.Forms.Label EnchantStatMain4;
        private System.Windows.Forms.Label EquipStatOff;
        private System.Windows.Forms.Label EnchantStatOff1;
        private System.Windows.Forms.Label EnchantStatOff2;
        private System.Windows.Forms.Label EnchantStatOff3;
        private System.Windows.Forms.Label EnchantStatOff4;
        #endregion
    }
}


