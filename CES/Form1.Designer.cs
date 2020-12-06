using CES_List;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SatTotalDyn = new System.Windows.Forms.TextBox();
            this.PctSatDyn = new System.Windows.Forms.TextBox();
            this.SatBaseDyn = new System.Windows.Forms.TextBox();
            this.StamTotalDyn = new System.Windows.Forms.TextBox();
            this.PctStamDyn = new System.Windows.Forms.TextBox();
            this.StamBaseDyn = new System.Windows.Forms.TextBox();
            this.ManaTotalDyn = new System.Windows.Forms.TextBox();
            this.PctManaDyn = new System.Windows.Forms.TextBox();
            this.ManaBaseDyn = new System.Windows.Forms.TextBox();
            this.HpTotalDyn = new System.Windows.Forms.TextBox();
            this.PctHpDyn = new System.Windows.Forms.TextBox();
            this.HpBaseDyn = new System.Windows.Forms.TextBox();
            this.DefTotDyn = new System.Windows.Forms.TextBox();
            this.PctDefDyn = new System.Windows.Forms.TextBox();
            this.DefBaseDyn = new System.Windows.Forms.TextBox();
            this.MatkTotalDyn = new System.Windows.Forms.TextBox();
            this.PctMatkDyn = new System.Windows.Forms.TextBox();
            this.AtkTotalDyn = new System.Windows.Forms.TextBox();
            this.PctAtkDyn = new System.Windows.Forms.TextBox();
            this.BaseAtkDyn = new System.Windows.Forms.TextBox();
            this.AtkDisplayStatic = new System.Windows.Forms.Label();
            this.MatackDisplayStatic = new System.Windows.Forms.Label();
            this.DefDisplayStatic = new System.Windows.Forms.Label();
            this.HpDisplayStatic = new System.Windows.Forms.Label();
            this.ManaDisplayStatic = new System.Windows.Forms.Label();
            this.StamDisplayStatic = new System.Windows.Forms.Label();
            this.SatietyDisplayStatic = new System.Windows.Forms.Label();
            this.MatkBaseDyn = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CritChanceDyn = new System.Windows.Forms.TextBox();
            this.CritDmgDyn = new System.Windows.Forms.TextBox();
            this.AtkSpdDyn = new System.Windows.Forms.TextBox();
            this.MoveSpdDyn = new System.Windows.Forms.TextBox();
            this.CritChDisplayStatic = new System.Windows.Forms.Label();
            this.CritDmgDisplayStatic = new System.Windows.Forms.Label();
            this.AtkSpdDisplayStatic = new System.Windows.Forms.Label();
            this.MoveSpdDisplayStatic = new System.Windows.Forms.Label();
            this.HeadEquipDisplay = new System.Windows.Forms.Label();
            this.HeadEnchantDisplay = new System.Windows.Forms.Label();
            this.BodyEquipDisplay = new System.Windows.Forms.Label();
            this.BodyEnchantDisplay = new System.Windows.Forms.Label();
            this.GliderEquipDisplay = new System.Windows.Forms.Label();
            this.GliderEnchantDisplay = new System.Windows.Forms.Label();
            this.Acc1EquipDisplay = new System.Windows.Forms.Label();
            this.Acc1EnchantDisplay = new System.Windows.Forms.Label();
            this.Acc2EqiupDisplay = new System.Windows.Forms.Label();
            this.Acc2EnchantDisplay = new System.Windows.Forms.Label();
            this.AmmoEquipDisplay = new System.Windows.Forms.Label();
            this.AmmoEnchantDisplay = new System.Windows.Forms.Label();
            this.MainEquipDisplay = new System.Windows.Forms.Label();
            this.MainEnchantDisplay = new System.Windows.Forms.Label();
            this.OffEquipDisplay = new System.Windows.Forms.Label();
            this.OffEnchantDisplay = new System.Windows.Forms.Label();
            this.BaseStat = new System.Windows.Forms.Label();
            this.PercentStat = new System.Windows.Forms.Label();
            this.TotalStat = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Head.SuspendLayout();
            this.Body.SuspendLayout();
            this.Glider.SuspendLayout();
            this.Acc1.SuspendLayout();
            this.Acc2.SuspendLayout();
            this.Ammo.SuspendLayout();
            this.MainHand.SuspendLayout();
            this.OffHand.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(561, 431);
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
            this.Head.Size = new System.Drawing.Size(553, 405);
            this.Head.TabIndex = 0;
            this.Head.Text = "Head";
            this.Head.UseVisualStyleBackColor = true;
            // 
            // EnchantStatHead4
            // 
            this.EnchantStatHead4.AutoSize = true;
            this.EnchantStatHead4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatHead4.Name = "EnchantStatHead4";
            this.EnchantStatHead4.Size = new System.Drawing.Size(0, 13);
            this.EnchantStatHead4.TabIndex = 9;
            // 
            // EnchantStatHead3
            // 
            this.EnchantStatHead3.AutoSize = true;
            this.EnchantStatHead3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatHead3.Name = "EnchantStatHead3";
            this.EnchantStatHead3.Size = new System.Drawing.Size(0, 13);
            this.EnchantStatHead3.TabIndex = 8;
            // 
            // EnchantStatHead2
            // 
            this.EnchantStatHead2.AutoSize = true;
            this.EnchantStatHead2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatHead2.Name = "EnchantStatHead2";
            this.EnchantStatHead2.Size = new System.Drawing.Size(0, 13);
            this.EnchantStatHead2.TabIndex = 7;
            // 
            // EnchantStatHead1
            // 
            this.EnchantStatHead1.AutoSize = true;
            this.EnchantStatHead1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatHead1.Name = "EnchantStatHead1";
            this.EnchantStatHead1.Size = new System.Drawing.Size(0, 13);
            this.EnchantStatHead1.TabIndex = 6;
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
            this.EquipStatBody.Size = new System.Drawing.Size(10, 13);
            this.EquipStatBody.TabIndex = 10;
            this.EquipStatBody.Text = " ";
            // 
            // EnchantStatBody1
            // 
            this.EnchantStatBody1.AutoSize = true;
            this.EnchantStatBody1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatBody1.Name = "EnchantStatBody1";
            this.EnchantStatBody1.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatBody1.TabIndex = 9;
            this.EnchantStatBody1.Text = " ";
            // 
            // EnchantStatBody2
            // 
            this.EnchantStatBody2.AutoSize = true;
            this.EnchantStatBody2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatBody2.Name = "EnchantStatBody2";
            this.EnchantStatBody2.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatBody2.TabIndex = 8;
            this.EnchantStatBody2.Text = " ";
            // 
            // EnchantStatBody3
            // 
            this.EnchantStatBody3.AutoSize = true;
            this.EnchantStatBody3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatBody3.Name = "EnchantStatBody3";
            this.EnchantStatBody3.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatBody3.TabIndex = 7;
            this.EnchantStatBody3.Text = " ";
            // 
            // EnchantStatBody4
            // 
            this.EnchantStatBody4.AutoSize = true;
            this.EnchantStatBody4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatBody4.Name = "EnchantStatBody4";
            this.EnchantStatBody4.Size = new System.Drawing.Size(10, 13);
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
            this.EquipStatGlider.Size = new System.Drawing.Size(10, 13);
            this.EquipStatGlider.TabIndex = 10;
            this.EquipStatGlider.Text = " ";
            // 
            // EnchantStatGlider1
            // 
            this.EnchantStatGlider1.AutoSize = true;
            this.EnchantStatGlider1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatGlider1.Name = "EnchantStatGlider1";
            this.EnchantStatGlider1.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatGlider1.TabIndex = 9;
            this.EnchantStatGlider1.Text = " ";
            // 
            // EnchantStatGlider2
            // 
            this.EnchantStatGlider2.AutoSize = true;
            this.EnchantStatGlider2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatGlider2.Name = "EnchantStatGlider2";
            this.EnchantStatGlider2.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatGlider2.TabIndex = 8;
            this.EnchantStatGlider2.Text = " ";
            // 
            // EnchantStatGlider3
            // 
            this.EnchantStatGlider3.AutoSize = true;
            this.EnchantStatGlider3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatGlider3.Name = "EnchantStatGlider3";
            this.EnchantStatGlider3.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatGlider3.TabIndex = 7;
            this.EnchantStatGlider3.Text = " ";
            // 
            // EnchantStatGlider4
            // 
            this.EnchantStatGlider4.AutoSize = true;
            this.EnchantStatGlider4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatGlider4.Name = "EnchantStatGlider4";
            this.EnchantStatGlider4.Size = new System.Drawing.Size(10, 13);
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
            this.EquipStatAcc1.Size = new System.Drawing.Size(10, 13);
            this.EquipStatAcc1.TabIndex = 11;
            this.EquipStatAcc1.Text = " ";
            // 
            // EnchantStatAccI1
            // 
            this.EnchantStatAccI1.AutoSize = true;
            this.EnchantStatAccI1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatAccI1.Name = "EnchantStatAccI1";
            this.EnchantStatAccI1.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatAccI1.TabIndex = 10;
            this.EnchantStatAccI1.Text = " ";
            // 
            // EnchantStatAccI2
            // 
            this.EnchantStatAccI2.AutoSize = true;
            this.EnchantStatAccI2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatAccI2.Name = "EnchantStatAccI2";
            this.EnchantStatAccI2.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatAccI2.TabIndex = 9;
            this.EnchantStatAccI2.Text = " ";
            // 
            // EnchantStatAccI3
            // 
            this.EnchantStatAccI3.AutoSize = true;
            this.EnchantStatAccI3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatAccI3.Name = "EnchantStatAccI3";
            this.EnchantStatAccI3.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatAccI3.TabIndex = 8;
            this.EnchantStatAccI3.Text = " ";
            // 
            // EnchantStatAccI4
            // 
            this.EnchantStatAccI4.AutoSize = true;
            this.EnchantStatAccI4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatAccI4.Name = "EnchantStatAccI4";
            this.EnchantStatAccI4.Size = new System.Drawing.Size(10, 13);
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
            this.EquipStatAcc2.Size = new System.Drawing.Size(10, 13);
            this.EquipStatAcc2.TabIndex = 11;
            this.EquipStatAcc2.Text = " ";
            // 
            // EnchantStatAccII1
            // 
            this.EnchantStatAccII1.AutoSize = true;
            this.EnchantStatAccII1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatAccII1.Name = "EnchantStatAccII1";
            this.EnchantStatAccII1.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatAccII1.TabIndex = 10;
            this.EnchantStatAccII1.Text = " ";
            // 
            // EnchantStatAccII2
            // 
            this.EnchantStatAccII2.AutoSize = true;
            this.EnchantStatAccII2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatAccII2.Name = "EnchantStatAccII2";
            this.EnchantStatAccII2.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatAccII2.TabIndex = 9;
            this.EnchantStatAccII2.Text = " ";
            // 
            // EnchantStatAccII3
            // 
            this.EnchantStatAccII3.AutoSize = true;
            this.EnchantStatAccII3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatAccII3.Name = "EnchantStatAccII3";
            this.EnchantStatAccII3.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatAccII3.TabIndex = 8;
            this.EnchantStatAccII3.Text = " ";
            // 
            // EnchantStatAccII4
            // 
            this.EnchantStatAccII4.AutoSize = true;
            this.EnchantStatAccII4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatAccII4.Name = "EnchantStatAccII4";
            this.EnchantStatAccII4.Size = new System.Drawing.Size(10, 13);
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
            this.EquipStatAmmo.Size = new System.Drawing.Size(10, 13);
            this.EquipStatAmmo.TabIndex = 11;
            this.EquipStatAmmo.Text = " ";
            // 
            // EnchantStatAmmo1
            // 
            this.EnchantStatAmmo1.AutoSize = true;
            this.EnchantStatAmmo1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatAmmo1.Name = "EnchantStatAmmo1";
            this.EnchantStatAmmo1.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatAmmo1.TabIndex = 10;
            this.EnchantStatAmmo1.Text = " ";
            // 
            // EnchantStatAmmo2
            // 
            this.EnchantStatAmmo2.AutoSize = true;
            this.EnchantStatAmmo2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatAmmo2.Name = "EnchantStatAmmo2";
            this.EnchantStatAmmo2.Size = new System.Drawing.Size(0, 13);
            this.EnchantStatAmmo2.TabIndex = 9;
            // 
            // EnchantStatAmmo3
            // 
            this.EnchantStatAmmo3.AutoSize = true;
            this.EnchantStatAmmo3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatAmmo3.Name = "EnchantStatAmmo3";
            this.EnchantStatAmmo3.Size = new System.Drawing.Size(0, 13);
            this.EnchantStatAmmo3.TabIndex = 8;
            // 
            // EnchantStatAmmo4
            // 
            this.EnchantStatAmmo4.AutoSize = true;
            this.EnchantStatAmmo4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatAmmo4.Name = "EnchantStatAmmo4";
            this.EnchantStatAmmo4.Size = new System.Drawing.Size(10, 13);
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
            this.EquipStatMain.Size = new System.Drawing.Size(10, 13);
            this.EquipStatMain.TabIndex = 11;
            this.EquipStatMain.Text = " ";
            // 
            // EnchantStatMain1
            // 
            this.EnchantStatMain1.AutoSize = true;
            this.EnchantStatMain1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatMain1.Name = "EnchantStatMain1";
            this.EnchantStatMain1.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatMain1.TabIndex = 10;
            this.EnchantStatMain1.Text = " ";
            // 
            // EnchantStatMain2
            // 
            this.EnchantStatMain2.AutoSize = true;
            this.EnchantStatMain2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatMain2.Name = "EnchantStatMain2";
            this.EnchantStatMain2.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatMain2.TabIndex = 9;
            this.EnchantStatMain2.Text = " ";
            // 
            // EnchantStatMain3
            // 
            this.EnchantStatMain3.AutoSize = true;
            this.EnchantStatMain3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatMain3.Name = "EnchantStatMain3";
            this.EnchantStatMain3.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatMain3.TabIndex = 8;
            this.EnchantStatMain3.Text = " ";
            // 
            // EnchantStatMain4
            // 
            this.EnchantStatMain4.AutoSize = true;
            this.EnchantStatMain4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatMain4.Name = "EnchantStatMain4";
            this.EnchantStatMain4.Size = new System.Drawing.Size(10, 13);
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
            this.OffHand.Size = new System.Drawing.Size(393, 405);
            this.OffHand.TabIndex = 7;
            this.OffHand.Text = "Off-Hand";
            this.OffHand.UseVisualStyleBackColor = true;
            // 
            // EquipStatOff
            // 
            this.EquipStatOff.AutoSize = true;
            this.EquipStatOff.Location = new System.Drawing.Point(234, 38);
            this.EquipStatOff.Name = "EquipStatOff";
            this.EquipStatOff.Size = new System.Drawing.Size(10, 13);
            this.EquipStatOff.TabIndex = 11;
            this.EquipStatOff.Text = " ";
            // 
            // EnchantStatOff1
            // 
            this.EnchantStatOff1.AutoSize = true;
            this.EnchantStatOff1.Location = new System.Drawing.Point(234, 82);
            this.EnchantStatOff1.Name = "EnchantStatOff1";
            this.EnchantStatOff1.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatOff1.TabIndex = 10;
            this.EnchantStatOff1.Text = " ";
            // 
            // EnchantStatOff2
            // 
            this.EnchantStatOff2.AutoSize = true;
            this.EnchantStatOff2.Location = new System.Drawing.Point(234, 119);
            this.EnchantStatOff2.Name = "EnchantStatOff2";
            this.EnchantStatOff2.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatOff2.TabIndex = 9;
            this.EnchantStatOff2.Text = " ";
            // 
            // EnchantStatOff3
            // 
            this.EnchantStatOff3.AutoSize = true;
            this.EnchantStatOff3.Location = new System.Drawing.Point(234, 155);
            this.EnchantStatOff3.Name = "EnchantStatOff3";
            this.EnchantStatOff3.Size = new System.Drawing.Size(10, 13);
            this.EnchantStatOff3.TabIndex = 8;
            this.EnchantStatOff3.Text = " ";
            // 
            // EnchantStatOff4
            // 
            this.EnchantStatOff4.AutoSize = true;
            this.EnchantStatOff4.Location = new System.Drawing.Point(234, 191);
            this.EnchantStatOff4.Name = "EnchantStatOff4";
            this.EnchantStatOff4.Size = new System.Drawing.Size(10, 13);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.SatTotalDyn, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.PctSatDyn, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.SatBaseDyn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.StamTotalDyn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.PctStamDyn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.StamBaseDyn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ManaTotalDyn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.PctManaDyn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ManaBaseDyn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.HpTotalDyn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.PctHpDyn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.HpBaseDyn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DefTotDyn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.PctDefDyn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DefBaseDyn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MatkTotalDyn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PctMatkDyn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AtkTotalDyn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PctAtkDyn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BaseAtkDyn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AtkDisplayStatic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MatackDisplayStatic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DefDisplayStatic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HpDisplayStatic, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ManaDisplayStatic, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.StamDisplayStatic, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SatietyDisplayStatic, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.MatkBaseDyn, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(650, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 235);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SatTotalDyn
            // 
            this.SatTotalDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SatTotalDyn.Location = new System.Drawing.Point(153, 206);
            this.SatTotalDyn.Name = "SatTotalDyn";
            this.SatTotalDyn.Size = new System.Drawing.Size(46, 20);
            this.SatTotalDyn.TabIndex = 27;
            // 
            // PctSatDyn
            // 
            this.PctSatDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PctSatDyn.Location = new System.Drawing.Point(103, 206);
            this.PctSatDyn.Name = "PctSatDyn";
            this.PctSatDyn.Size = new System.Drawing.Size(44, 20);
            this.PctSatDyn.TabIndex = 26;
            // 
            // SatBaseDyn
            // 
            this.SatBaseDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SatBaseDyn.Location = new System.Drawing.Point(53, 206);
            this.SatBaseDyn.Name = "SatBaseDyn";
            this.SatBaseDyn.Size = new System.Drawing.Size(44, 20);
            this.SatBaseDyn.TabIndex = 25;
            // 
            // StamTotalDyn
            // 
            this.StamTotalDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StamTotalDyn.Location = new System.Drawing.Point(153, 171);
            this.StamTotalDyn.Name = "StamTotalDyn";
            this.StamTotalDyn.Size = new System.Drawing.Size(46, 20);
            this.StamTotalDyn.TabIndex = 24;
            // 
            // PctStamDyn
            // 
            this.PctStamDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PctStamDyn.Location = new System.Drawing.Point(103, 171);
            this.PctStamDyn.Name = "PctStamDyn";
            this.PctStamDyn.Size = new System.Drawing.Size(44, 20);
            this.PctStamDyn.TabIndex = 23;
            // 
            // StamBaseDyn
            // 
            this.StamBaseDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StamBaseDyn.Location = new System.Drawing.Point(53, 171);
            this.StamBaseDyn.Name = "StamBaseDyn";
            this.StamBaseDyn.Size = new System.Drawing.Size(44, 20);
            this.StamBaseDyn.TabIndex = 22;
            // 
            // ManaTotalDyn
            // 
            this.ManaTotalDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ManaTotalDyn.Location = new System.Drawing.Point(153, 138);
            this.ManaTotalDyn.Name = "ManaTotalDyn";
            this.ManaTotalDyn.Size = new System.Drawing.Size(46, 20);
            this.ManaTotalDyn.TabIndex = 21;
            // 
            // PctManaDyn
            // 
            this.PctManaDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PctManaDyn.Location = new System.Drawing.Point(103, 138);
            this.PctManaDyn.Name = "PctManaDyn";
            this.PctManaDyn.Size = new System.Drawing.Size(44, 20);
            this.PctManaDyn.TabIndex = 20;
            // 
            // ManaBaseDyn
            // 
            this.ManaBaseDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ManaBaseDyn.Location = new System.Drawing.Point(53, 138);
            this.ManaBaseDyn.Name = "ManaBaseDyn";
            this.ManaBaseDyn.Size = new System.Drawing.Size(44, 20);
            this.ManaBaseDyn.TabIndex = 19;
            // 
            // HpTotalDyn
            // 
            this.HpTotalDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HpTotalDyn.Location = new System.Drawing.Point(153, 105);
            this.HpTotalDyn.Name = "HpTotalDyn";
            this.HpTotalDyn.Size = new System.Drawing.Size(46, 20);
            this.HpTotalDyn.TabIndex = 18;
            // 
            // PctHpDyn
            // 
            this.PctHpDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PctHpDyn.Location = new System.Drawing.Point(103, 105);
            this.PctHpDyn.Name = "PctHpDyn";
            this.PctHpDyn.Size = new System.Drawing.Size(44, 20);
            this.PctHpDyn.TabIndex = 17;
            // 
            // HpBaseDyn
            // 
            this.HpBaseDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HpBaseDyn.Location = new System.Drawing.Point(53, 105);
            this.HpBaseDyn.Name = "HpBaseDyn";
            this.HpBaseDyn.Size = new System.Drawing.Size(44, 20);
            this.HpBaseDyn.TabIndex = 16;
            // 
            // DefTotDyn
            // 
            this.DefTotDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DefTotDyn.Location = new System.Drawing.Point(153, 72);
            this.DefTotDyn.Name = "DefTotDyn";
            this.DefTotDyn.Size = new System.Drawing.Size(46, 20);
            this.DefTotDyn.TabIndex = 15;
            // 
            // PctDefDyn
            // 
            this.PctDefDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PctDefDyn.Location = new System.Drawing.Point(103, 72);
            this.PctDefDyn.Name = "PctDefDyn";
            this.PctDefDyn.Size = new System.Drawing.Size(44, 20);
            this.PctDefDyn.TabIndex = 14;
            // 
            // DefBaseDyn
            // 
            this.DefBaseDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DefBaseDyn.Location = new System.Drawing.Point(53, 72);
            this.DefBaseDyn.Name = "DefBaseDyn";
            this.DefBaseDyn.Size = new System.Drawing.Size(44, 20);
            this.DefBaseDyn.TabIndex = 13;
            // 
            // MatkTotalDyn
            // 
            this.MatkTotalDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MatkTotalDyn.Location = new System.Drawing.Point(153, 39);
            this.MatkTotalDyn.Name = "MatkTotalDyn";
            this.MatkTotalDyn.Size = new System.Drawing.Size(46, 20);
            this.MatkTotalDyn.TabIndex = 12;
            // 
            // PctMatkDyn
            // 
            this.PctMatkDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMatkDyn.Location = new System.Drawing.Point(103, 39);
            this.PctMatkDyn.Name = "PctMatkDyn";
            this.PctMatkDyn.Size = new System.Drawing.Size(44, 20);
            this.PctMatkDyn.TabIndex = 11;
            // 
            // AtkTotalDyn
            // 
            this.AtkTotalDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AtkTotalDyn.Location = new System.Drawing.Point(153, 6);
            this.AtkTotalDyn.Name = "AtkTotalDyn";
            this.AtkTotalDyn.Size = new System.Drawing.Size(46, 20);
            this.AtkTotalDyn.TabIndex = 10;
            // 
            // PctAtkDyn
            // 
            this.PctAtkDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PctAtkDyn.Location = new System.Drawing.Point(103, 6);
            this.PctAtkDyn.Name = "PctAtkDyn";
            this.PctAtkDyn.Size = new System.Drawing.Size(44, 20);
            this.PctAtkDyn.TabIndex = 9;
            // 
            // BaseAtkDyn
            // 
            this.BaseAtkDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseAtkDyn.Location = new System.Drawing.Point(53, 6);
            this.BaseAtkDyn.Name = "BaseAtkDyn";
            this.BaseAtkDyn.Size = new System.Drawing.Size(44, 20);
            this.BaseAtkDyn.TabIndex = 0;
            // 
            // AtkDisplayStatic
            // 
            this.AtkDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AtkDisplayStatic.AutoSize = true;
            this.AtkDisplayStatic.Location = new System.Drawing.Point(3, 10);
            this.AtkDisplayStatic.Name = "AtkDisplayStatic";
            this.AtkDisplayStatic.Size = new System.Drawing.Size(44, 13);
            this.AtkDisplayStatic.TabIndex = 1;
            this.AtkDisplayStatic.Text = "Attack";
            // 
            // MatackDisplayStatic
            // 
            this.MatackDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MatackDisplayStatic.AutoSize = true;
            this.MatackDisplayStatic.Location = new System.Drawing.Point(3, 43);
            this.MatackDisplayStatic.Name = "MatackDisplayStatic";
            this.MatackDisplayStatic.Size = new System.Drawing.Size(44, 13);
            this.MatackDisplayStatic.TabIndex = 2;
            this.MatackDisplayStatic.Text = "MAtk.";
            // 
            // DefDisplayStatic
            // 
            this.DefDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DefDisplayStatic.AutoSize = true;
            this.DefDisplayStatic.Location = new System.Drawing.Point(3, 76);
            this.DefDisplayStatic.Name = "DefDisplayStatic";
            this.DefDisplayStatic.Size = new System.Drawing.Size(44, 13);
            this.DefDisplayStatic.TabIndex = 3;
            this.DefDisplayStatic.Text = "Def. ";
            // 
            // HpDisplayStatic
            // 
            this.HpDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HpDisplayStatic.AutoSize = true;
            this.HpDisplayStatic.Location = new System.Drawing.Point(3, 109);
            this.HpDisplayStatic.Name = "HpDisplayStatic";
            this.HpDisplayStatic.Size = new System.Drawing.Size(44, 13);
            this.HpDisplayStatic.TabIndex = 4;
            this.HpDisplayStatic.Text = "HP";
            // 
            // ManaDisplayStatic
            // 
            this.ManaDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ManaDisplayStatic.AutoSize = true;
            this.ManaDisplayStatic.Location = new System.Drawing.Point(3, 142);
            this.ManaDisplayStatic.Name = "ManaDisplayStatic";
            this.ManaDisplayStatic.Size = new System.Drawing.Size(44, 13);
            this.ManaDisplayStatic.TabIndex = 5;
            this.ManaDisplayStatic.Text = "Mana";
            // 
            // StamDisplayStatic
            // 
            this.StamDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StamDisplayStatic.AutoSize = true;
            this.StamDisplayStatic.Location = new System.Drawing.Point(3, 175);
            this.StamDisplayStatic.Name = "StamDisplayStatic";
            this.StamDisplayStatic.Size = new System.Drawing.Size(44, 13);
            this.StamDisplayStatic.TabIndex = 6;
            this.StamDisplayStatic.Text = "Stam.";
            // 
            // SatietyDisplayStatic
            // 
            this.SatietyDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SatietyDisplayStatic.AutoSize = true;
            this.SatietyDisplayStatic.Location = new System.Drawing.Point(3, 210);
            this.SatietyDisplayStatic.Name = "SatietyDisplayStatic";
            this.SatietyDisplayStatic.Size = new System.Drawing.Size(44, 13);
            this.SatietyDisplayStatic.TabIndex = 7;
            this.SatietyDisplayStatic.Text = "Sat.";
            // 
            // MatkBaseDyn
            // 
            this.MatkBaseDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MatkBaseDyn.Location = new System.Drawing.Point(53, 39);
            this.MatkBaseDyn.Name = "MatkBaseDyn";
            this.MatkBaseDyn.Size = new System.Drawing.Size(44, 20);
            this.MatkBaseDyn.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.67416F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.32584F));
            this.tableLayoutPanel2.Controls.Add(this.CritChanceDyn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CritDmgDyn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.AtkSpdDyn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.MoveSpdDyn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.CritChDisplayStatic, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CritDmgDisplayStatic, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AtkSpdDisplayStatic, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.MoveSpdDisplayStatic, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(858, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(89, 234);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // CritChanceDyn
            // 
            this.CritChanceDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CritChanceDyn.Location = new System.Drawing.Point(57, 19);
            this.CritChanceDyn.Name = "CritChanceDyn";
            this.CritChanceDyn.Size = new System.Drawing.Size(29, 20);
            this.CritChanceDyn.TabIndex = 0;
            // 
            // CritDmgDyn
            // 
            this.CritDmgDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CritDmgDyn.Location = new System.Drawing.Point(57, 77);
            this.CritDmgDyn.Name = "CritDmgDyn";
            this.CritDmgDyn.Size = new System.Drawing.Size(29, 20);
            this.CritDmgDyn.TabIndex = 1;
            // 
            // AtkSpdDyn
            // 
            this.AtkSpdDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AtkSpdDyn.Location = new System.Drawing.Point(57, 135);
            this.AtkSpdDyn.Name = "AtkSpdDyn";
            this.AtkSpdDyn.Size = new System.Drawing.Size(29, 20);
            this.AtkSpdDyn.TabIndex = 2;
            // 
            // MoveSpdDyn
            // 
            this.MoveSpdDyn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveSpdDyn.Location = new System.Drawing.Point(57, 194);
            this.MoveSpdDyn.Name = "MoveSpdDyn";
            this.MoveSpdDyn.Size = new System.Drawing.Size(29, 20);
            this.MoveSpdDyn.TabIndex = 3;
            // 
            // CritChDisplayStatic
            // 
            this.CritChDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CritChDisplayStatic.AutoSize = true;
            this.CritChDisplayStatic.Location = new System.Drawing.Point(3, 16);
            this.CritChDisplayStatic.Name = "CritChDisplayStatic";
            this.CritChDisplayStatic.Size = new System.Drawing.Size(48, 26);
            this.CritChDisplayStatic.TabIndex = 4;
            this.CritChDisplayStatic.Text = "Crit Chance";
            // 
            // CritDmgDisplayStatic
            // 
            this.CritDmgDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CritDmgDisplayStatic.AutoSize = true;
            this.CritDmgDisplayStatic.Location = new System.Drawing.Point(3, 74);
            this.CritDmgDisplayStatic.Name = "CritDmgDisplayStatic";
            this.CritDmgDisplayStatic.Size = new System.Drawing.Size(48, 26);
            this.CritDmgDisplayStatic.TabIndex = 5;
            this.CritDmgDisplayStatic.Text = "Crit Damage";
            // 
            // AtkSpdDisplayStatic
            // 
            this.AtkSpdDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AtkSpdDisplayStatic.AutoSize = true;
            this.AtkSpdDisplayStatic.Location = new System.Drawing.Point(3, 132);
            this.AtkSpdDisplayStatic.Name = "AtkSpdDisplayStatic";
            this.AtkSpdDisplayStatic.Size = new System.Drawing.Size(48, 26);
            this.AtkSpdDisplayStatic.TabIndex = 6;
            this.AtkSpdDisplayStatic.Text = "Atk Speed";
            // 
            // MoveSpdDisplayStatic
            // 
            this.MoveSpdDisplayStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MoveSpdDisplayStatic.AutoSize = true;
            this.MoveSpdDisplayStatic.Location = new System.Drawing.Point(3, 191);
            this.MoveSpdDisplayStatic.Name = "MoveSpdDisplayStatic";
            this.MoveSpdDisplayStatic.Size = new System.Drawing.Size(48, 26);
            this.MoveSpdDisplayStatic.TabIndex = 7;
            this.MoveSpdDisplayStatic.Text = "Move Speed";
            // 
            // HeadEquipDisplay
            // 
            this.HeadEquipDisplay.AutoSize = true;
            this.HeadEquipDisplay.Location = new System.Drawing.Point(653, 298);
            this.HeadEquipDisplay.Name = "HeadEquipDisplay";
            this.HeadEquipDisplay.Size = new System.Drawing.Size(35, 13);
            this.HeadEquipDisplay.TabIndex = 3;
            this.HeadEquipDisplay.Text = "label1";
            // 
            // HeadEnchantDisplay
            // 
            this.HeadEnchantDisplay.AutoSize = true;
            this.HeadEnchantDisplay.Location = new System.Drawing.Point(662, 311);
            this.HeadEnchantDisplay.Name = "HeadEnchantDisplay";
            this.HeadEnchantDisplay.Size = new System.Drawing.Size(35, 13);
            this.HeadEnchantDisplay.TabIndex = 4;
            this.HeadEnchantDisplay.Text = "label2";
            // 
            // BodyEquipDisplay
            // 
            this.BodyEquipDisplay.AutoSize = true;
            this.BodyEquipDisplay.Location = new System.Drawing.Point(653, 334);
            this.BodyEquipDisplay.Name = "BodyEquipDisplay";
            this.BodyEquipDisplay.Size = new System.Drawing.Size(35, 13);
            this.BodyEquipDisplay.TabIndex = 5;
            this.BodyEquipDisplay.Text = "label3";
            // 
            // BodyEnchantDisplay
            // 
            this.BodyEnchantDisplay.AutoSize = true;
            this.BodyEnchantDisplay.Location = new System.Drawing.Point(662, 347);
            this.BodyEnchantDisplay.Name = "BodyEnchantDisplay";
            this.BodyEnchantDisplay.Size = new System.Drawing.Size(35, 13);
            this.BodyEnchantDisplay.TabIndex = 6;
            this.BodyEnchantDisplay.Text = "label4";
            // 
            // GliderEquipDisplay
            // 
            this.GliderEquipDisplay.AutoSize = true;
            this.GliderEquipDisplay.Location = new System.Drawing.Point(653, 369);
            this.GliderEquipDisplay.Name = "GliderEquipDisplay";
            this.GliderEquipDisplay.Size = new System.Drawing.Size(35, 13);
            this.GliderEquipDisplay.TabIndex = 7;
            this.GliderEquipDisplay.Text = "label5";
            // 
            // GliderEnchantDisplay
            // 
            this.GliderEnchantDisplay.AutoSize = true;
            this.GliderEnchantDisplay.Location = new System.Drawing.Point(662, 382);
            this.GliderEnchantDisplay.Name = "GliderEnchantDisplay";
            this.GliderEnchantDisplay.Size = new System.Drawing.Size(35, 13);
            this.GliderEnchantDisplay.TabIndex = 8;
            this.GliderEnchantDisplay.Text = "label6";
            // 
            // Acc1EquipDisplay
            // 
            this.Acc1EquipDisplay.AutoSize = true;
            this.Acc1EquipDisplay.Location = new System.Drawing.Point(653, 404);
            this.Acc1EquipDisplay.Name = "Acc1EquipDisplay";
            this.Acc1EquipDisplay.Size = new System.Drawing.Size(35, 13);
            this.Acc1EquipDisplay.TabIndex = 9;
            this.Acc1EquipDisplay.Text = "label7";
            // 
            // Acc1EnchantDisplay
            // 
            this.Acc1EnchantDisplay.AutoSize = true;
            this.Acc1EnchantDisplay.Location = new System.Drawing.Point(662, 418);
            this.Acc1EnchantDisplay.Name = "Acc1EnchantDisplay";
            this.Acc1EnchantDisplay.Size = new System.Drawing.Size(35, 13);
            this.Acc1EnchantDisplay.TabIndex = 10;
            this.Acc1EnchantDisplay.Text = "label8";
            // 
            // Acc2EqiupDisplay
            // 
            this.Acc2EqiupDisplay.AutoSize = true;
            this.Acc2EqiupDisplay.Location = new System.Drawing.Point(817, 298);
            this.Acc2EqiupDisplay.Name = "Acc2EqiupDisplay";
            this.Acc2EqiupDisplay.Size = new System.Drawing.Size(35, 13);
            this.Acc2EqiupDisplay.TabIndex = 11;
            this.Acc2EqiupDisplay.Text = "label9";
            // 
            // Acc2EnchantDisplay
            // 
            this.Acc2EnchantDisplay.AutoSize = true;
            this.Acc2EnchantDisplay.Location = new System.Drawing.Point(826, 311);
            this.Acc2EnchantDisplay.Name = "Acc2EnchantDisplay";
            this.Acc2EnchantDisplay.Size = new System.Drawing.Size(41, 13);
            this.Acc2EnchantDisplay.TabIndex = 12;
            this.Acc2EnchantDisplay.Text = "label10";
            // 
            // AmmoEquipDisplay
            // 
            this.AmmoEquipDisplay.AutoSize = true;
            this.AmmoEquipDisplay.Location = new System.Drawing.Point(817, 334);
            this.AmmoEquipDisplay.Name = "AmmoEquipDisplay";
            this.AmmoEquipDisplay.Size = new System.Drawing.Size(41, 13);
            this.AmmoEquipDisplay.TabIndex = 13;
            this.AmmoEquipDisplay.Text = "label11";
            // 
            // AmmoEnchantDisplay
            // 
            this.AmmoEnchantDisplay.AutoSize = true;
            this.AmmoEnchantDisplay.Location = new System.Drawing.Point(826, 347);
            this.AmmoEnchantDisplay.Name = "AmmoEnchantDisplay";
            this.AmmoEnchantDisplay.Size = new System.Drawing.Size(41, 13);
            this.AmmoEnchantDisplay.TabIndex = 14;
            this.AmmoEnchantDisplay.Text = "label12";
            // 
            // MainEquipDisplay
            // 
            this.MainEquipDisplay.AutoSize = true;
            this.MainEquipDisplay.Location = new System.Drawing.Point(817, 369);
            this.MainEquipDisplay.Name = "MainEquipDisplay";
            this.MainEquipDisplay.Size = new System.Drawing.Size(41, 13);
            this.MainEquipDisplay.TabIndex = 15;
            this.MainEquipDisplay.Text = "label13";
            // 
            // MainEnchantDisplay
            // 
            this.MainEnchantDisplay.AutoSize = true;
            this.MainEnchantDisplay.Location = new System.Drawing.Point(826, 382);
            this.MainEnchantDisplay.Name = "MainEnchantDisplay";
            this.MainEnchantDisplay.Size = new System.Drawing.Size(41, 13);
            this.MainEnchantDisplay.TabIndex = 16;
            this.MainEnchantDisplay.Text = "label14";
            // 
            // OffEquipDisplay
            // 
            this.OffEquipDisplay.AutoSize = true;
            this.OffEquipDisplay.Location = new System.Drawing.Point(817, 404);
            this.OffEquipDisplay.Name = "OffEquipDisplay";
            this.OffEquipDisplay.Size = new System.Drawing.Size(41, 13);
            this.OffEquipDisplay.TabIndex = 17;
            this.OffEquipDisplay.Text = "label15";
            // 
            // OffEnchantDisplay
            // 
            this.OffEnchantDisplay.AutoSize = true;
            this.OffEnchantDisplay.Location = new System.Drawing.Point(826, 417);
            this.OffEnchantDisplay.Name = "OffEnchantDisplay";
            this.OffEnchantDisplay.Size = new System.Drawing.Size(41, 13);
            this.OffEnchantDisplay.TabIndex = 18;
            this.OffEnchantDisplay.Text = "label16";
            // 
            // BaseStat
            // 
            this.BaseStat.AutoSize = true;
            this.BaseStat.Location = new System.Drawing.Point(703, 41);
            this.BaseStat.Name = "BaseStat";
            this.BaseStat.Size = new System.Drawing.Size(31, 13);
            this.BaseStat.TabIndex = 19;
            this.BaseStat.Text = "Base";
            // 
            // PercentStat
            // 
            this.PercentStat.AutoSize = true;
            this.PercentStat.Location = new System.Drawing.Point(753, 41);
            this.PercentStat.Name = "PercentStat";
            this.PercentStat.Size = new System.Drawing.Size(30, 13);
            this.PercentStat.TabIndex = 20;
            this.PercentStat.Text = "     %";
            // 
            // TotalStat
            // 
            this.TotalStat.AutoSize = true;
            this.TotalStat.Location = new System.Drawing.Point(803, 41);
            this.TotalStat.Name = "TotalStat";
            this.TotalStat.Size = new System.Drawing.Size(31, 13);
            this.TotalStat.TabIndex = 21;
            this.TotalStat.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 501);
            this.Controls.Add(this.TotalStat);
            this.Controls.Add(this.PercentStat);
            this.Controls.Add(this.BaseStat);
            this.Controls.Add(this.OffEnchantDisplay);
            this.Controls.Add(this.OffEquipDisplay);
            this.Controls.Add(this.MainEnchantDisplay);
            this.Controls.Add(this.MainEquipDisplay);
            this.Controls.Add(this.AmmoEnchantDisplay);
            this.Controls.Add(this.AmmoEquipDisplay);
            this.Controls.Add(this.Acc2EnchantDisplay);
            this.Controls.Add(this.Acc2EqiupDisplay);
            this.Controls.Add(this.Acc1EnchantDisplay);
            this.Controls.Add(this.Acc1EquipDisplay);
            this.Controls.Add(this.GliderEnchantDisplay);
            this.Controls.Add(this.GliderEquipDisplay);
            this.Controls.Add(this.BodyEnchantDisplay);
            this.Controls.Add(this.BodyEquipDisplay);
            this.Controls.Add(this.HeadEnchantDisplay);
            this.Controls.Add(this.HeadEquipDisplay);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox BaseAtkDyn;
        private System.Windows.Forms.TextBox SatTotalDyn;
        private System.Windows.Forms.TextBox PctSatDyn;
        private System.Windows.Forms.TextBox SatBaseDyn;
        private System.Windows.Forms.TextBox StamTotalDyn;
        private System.Windows.Forms.TextBox PctStamDyn;
        private System.Windows.Forms.TextBox StamBaseDyn;
        private System.Windows.Forms.TextBox ManaTotalDyn;
        private System.Windows.Forms.TextBox PctManaDyn;
        private System.Windows.Forms.TextBox ManaBaseDyn;
        private System.Windows.Forms.TextBox HpTotalDyn;
        private System.Windows.Forms.TextBox PctHpDyn;
        private System.Windows.Forms.TextBox HpBaseDyn;
        private System.Windows.Forms.TextBox DefTotDyn;
        private System.Windows.Forms.TextBox PctDefDyn;
        private System.Windows.Forms.TextBox DefBaseDyn;
        private System.Windows.Forms.TextBox MatkTotalDyn;
        private System.Windows.Forms.TextBox PctMatkDyn;
        private System.Windows.Forms.TextBox PctAtkDyn;
        private System.Windows.Forms.Label AtkDisplayStatic;
        private System.Windows.Forms.Label MatackDisplayStatic;
        private System.Windows.Forms.Label DefDisplayStatic;
        private System.Windows.Forms.Label HpDisplayStatic;
        private System.Windows.Forms.Label ManaDisplayStatic;
        private System.Windows.Forms.Label StamDisplayStatic;
        private System.Windows.Forms.Label SatietyDisplayStatic;
        private System.Windows.Forms.TextBox MatkBaseDyn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox CritChanceDyn;
        private System.Windows.Forms.TextBox CritDmgDyn;
        private System.Windows.Forms.TextBox AtkSpdDyn;
        private System.Windows.Forms.TextBox MoveSpdDyn;
        private System.Windows.Forms.Label CritChDisplayStatic;
        private System.Windows.Forms.Label CritDmgDisplayStatic;
        private System.Windows.Forms.Label AtkSpdDisplayStatic;
        private System.Windows.Forms.Label MoveSpdDisplayStatic;
        private System.Windows.Forms.TextBox AtkTotalDyn;
        private System.Windows.Forms.Label HeadEquipDisplay;
        private System.Windows.Forms.Label HeadEnchantDisplay;
        private System.Windows.Forms.Label BodyEquipDisplay;
        private System.Windows.Forms.Label BodyEnchantDisplay;
        private System.Windows.Forms.Label GliderEquipDisplay;
        private System.Windows.Forms.Label GliderEnchantDisplay;
        private System.Windows.Forms.Label Acc1EquipDisplay;
        private System.Windows.Forms.Label Acc1EnchantDisplay;
        private System.Windows.Forms.Label Acc2EqiupDisplay;
        private System.Windows.Forms.Label Acc2EnchantDisplay;
        private System.Windows.Forms.Label AmmoEquipDisplay;
        private System.Windows.Forms.Label AmmoEnchantDisplay;
        private System.Windows.Forms.Label MainEquipDisplay;
        private System.Windows.Forms.Label MainEnchantDisplay;
        private System.Windows.Forms.Label OffEquipDisplay;
        private System.Windows.Forms.Label OffEnchantDisplay;
        private System.Windows.Forms.Label BaseStat;
        private System.Windows.Forms.Label PercentStat;
        private System.Windows.Forms.Label TotalStat;
    }
}


