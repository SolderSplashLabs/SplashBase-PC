﻿namespace SplashBaseControl
{
    partial class SplashBaseControl
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "SPI CS0",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "SPI CS1",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "SPI CS2",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "SPI CS3",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "SPI CS4",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "I2C 0x20",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "I2C 0x21",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "I2C 0x22",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "I2C 0x23",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "I2C 0x24",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "I2C 0x25",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "I2C 0x26",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "I2C 0x27",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashBaseControl));
            this.listRemotesFound = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColConfig = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColADC0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColADC1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColADC2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bootloadModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.defaultConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GrpSplashBase = new System.Windows.Forms.GroupBox();
            this.ButSaveConfig = new System.Windows.Forms.Button();
            this.ButRefreshExtendedInfo = new System.Windows.Forms.Button();
            this.EdtSetName = new System.Windows.Forms.Button();
            this.ButApply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EdtNtpOffset = new System.Windows.Forms.NumericUpDown();
            this.EdNtpServerAddr = new System.Windows.Forms.TextBox();
            this.EdtGatewayAddr = new System.Windows.Forms.TextBox();
            this.ChkNtpEnabled = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EdtIpAddr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EdtSubNetAddr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkDynamicIp = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButRescanBridges = new System.Windows.Forms.Button();
            this.ListSolderBridges = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChkLogic = new System.Windows.Forms.CheckBox();
            this.EdtSplashBaseName = new System.Windows.Forms.TextBox();
            this.ChkPwmEn = new System.Windows.Forms.CheckBox();
            this.ChkRGBEnabled = new System.Windows.Forms.CheckBox();
            this.ChkFourRelay = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkUserGpioInit = new System.Windows.Forms.CheckBox();
            this.ButFindSplashBases = new System.Windows.Forms.Button();
            this.ButLogic = new System.Windows.Forms.Button();
            this.ButGpio = new System.Windows.Forms.Button();
            this.ButPwm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EdtDnsAddr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.GrpSplashBase.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdtNtpOffset)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listRemotesFound
            // 
            this.listRemotesFound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listRemotesFound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.ColConfig,
            this.ColADC0,
            this.ColADC1,
            this.ColADC2});
            this.listRemotesFound.ContextMenuStrip = this.contextMenuStrip1;
            this.listRemotesFound.FullRowSelect = true;
            this.listRemotesFound.Location = new System.Drawing.Point(12, 12);
            this.listRemotesFound.Name = "listRemotesFound";
            this.listRemotesFound.Size = new System.Drawing.Size(670, 158);
            this.listRemotesFound.TabIndex = 9;
            this.listRemotesFound.UseCompatibleStateImageBehavior = false;
            this.listRemotesFound.View = System.Windows.Forms.View.Details;
            this.listRemotesFound.SelectedIndexChanged += new System.EventHandler(this.listRemotesFound_SelectedIndexChanged);
            this.listRemotesFound.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listRemotesFound_MouseClick);
            this.listRemotesFound.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRemotesFound_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MAC Address";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Version";
            // 
            // ColConfig
            // 
            this.ColConfig.Text = "Config";
            this.ColConfig.Width = 0;
            // 
            // ColADC0
            // 
            this.ColADC0.Text = "ADC0";
            this.ColADC0.Width = 50;
            // 
            // ColADC1
            // 
            this.ColADC1.Text = "ADC1";
            this.ColADC1.Width = 50;
            // 
            // ColADC2
            // 
            this.ColADC2.Text = "ADC2";
            this.ColADC2.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.rebootToolStripMenuItem,
            this.bootloadModeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.defaultConfigToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 104);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem1.Text = "Get Configuration";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // rebootToolStripMenuItem
            // 
            this.rebootToolStripMenuItem.Name = "rebootToolStripMenuItem";
            this.rebootToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rebootToolStripMenuItem.Text = "Reboot";
            this.rebootToolStripMenuItem.Click += new System.EventHandler(this.rebootToolStripMenuItem_Click);
            // 
            // bootloadModeToolStripMenuItem
            // 
            this.bootloadModeToolStripMenuItem.Name = "bootloadModeToolStripMenuItem";
            this.bootloadModeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bootloadModeToolStripMenuItem.Text = "Bootload Mode";
            this.bootloadModeToolStripMenuItem.Click += new System.EventHandler(this.bootloadModeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 6);
            // 
            // defaultConfigToolStripMenuItem
            // 
            this.defaultConfigToolStripMenuItem.Name = "defaultConfigToolStripMenuItem";
            this.defaultConfigToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.defaultConfigToolStripMenuItem.Text = "Default Config";
            this.defaultConfigToolStripMenuItem.Click += new System.EventHandler(this.defaultConfigToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // GrpSplashBase
            // 
            this.GrpSplashBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpSplashBase.Controls.Add(this.ButSaveConfig);
            this.GrpSplashBase.Controls.Add(this.ButRefreshExtendedInfo);
            this.GrpSplashBase.Controls.Add(this.EdtSetName);
            this.GrpSplashBase.Controls.Add(this.ButApply);
            this.GrpSplashBase.Controls.Add(this.groupBox3);
            this.GrpSplashBase.Controls.Add(this.dateTimePicker1);
            this.GrpSplashBase.Controls.Add(this.label3);
            this.GrpSplashBase.Controls.Add(this.label2);
            this.GrpSplashBase.Controls.Add(this.label1);
            this.GrpSplashBase.Controls.Add(this.groupBox2);
            this.GrpSplashBase.Controls.Add(this.ChkLogic);
            this.GrpSplashBase.Controls.Add(this.EdtSplashBaseName);
            this.GrpSplashBase.Controls.Add(this.ChkPwmEn);
            this.GrpSplashBase.Controls.Add(this.ChkRGBEnabled);
            this.GrpSplashBase.Controls.Add(this.ChkFourRelay);
            this.GrpSplashBase.Controls.Add(this.label4);
            this.GrpSplashBase.Controls.Add(this.ChkUserGpioInit);
            this.GrpSplashBase.Enabled = false;
            this.GrpSplashBase.Location = new System.Drawing.Point(12, 220);
            this.GrpSplashBase.Name = "GrpSplashBase";
            this.GrpSplashBase.Size = new System.Drawing.Size(670, 346);
            this.GrpSplashBase.TabIndex = 10;
            this.GrpSplashBase.TabStop = false;
            this.GrpSplashBase.Text = "Selected SplashBase";
            // 
            // ButSaveConfig
            // 
            this.ButSaveConfig.Location = new System.Drawing.Point(262, 299);
            this.ButSaveConfig.Name = "ButSaveConfig";
            this.ButSaveConfig.Size = new System.Drawing.Size(102, 38);
            this.ButSaveConfig.TabIndex = 11;
            this.ButSaveConfig.Text = "Save Config";
            this.toolTip1.SetToolTip(this.ButSaveConfig, "Commits the current configuration to non volatile memory.  So that they can be us" +
                    "ed upon next booting");
            this.ButSaveConfig.UseVisualStyleBackColor = true;
            this.ButSaveConfig.Click += new System.EventHandler(this.ButSaveConfig_Click);
            // 
            // ButRefreshExtendedInfo
            // 
            this.ButRefreshExtendedInfo.Location = new System.Drawing.Point(8, 299);
            this.ButRefreshExtendedInfo.Name = "ButRefreshExtendedInfo";
            this.ButRefreshExtendedInfo.Size = new System.Drawing.Size(121, 38);
            this.ButRefreshExtendedInfo.TabIndex = 11;
            this.ButRefreshExtendedInfo.Text = "Refresh";
            this.ButRefreshExtendedInfo.UseVisualStyleBackColor = true;
            this.ButRefreshExtendedInfo.Click += new System.EventHandler(this.ButRefreshExtendedInfo_Click);
            // 
            // EdtSetName
            // 
            this.EdtSetName.Location = new System.Drawing.Point(251, 13);
            this.EdtSetName.Name = "EdtSetName";
            this.EdtSetName.Size = new System.Drawing.Size(121, 30);
            this.EdtSetName.TabIndex = 11;
            this.EdtSetName.Text = "Set Name";
            this.EdtSetName.UseVisualStyleBackColor = true;
            this.EdtSetName.Click += new System.EventHandler(this.EdtSetName_Click);
            // 
            // ButApply
            // 
            this.ButApply.Location = new System.Drawing.Point(135, 299);
            this.ButApply.Name = "ButApply";
            this.ButApply.Size = new System.Drawing.Size(121, 38);
            this.ButApply.TabIndex = 11;
            this.ButApply.Text = "Apply Changes";
            this.toolTip1.SetToolTip(this.ButApply, "Apply the current selected configuration");
            this.ButApply.UseVisualStyleBackColor = true;
            this.ButApply.Click += new System.EventHandler(this.ButApply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EdtDnsAddr);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.EdtNtpOffset);
            this.groupBox3.Controls.Add(this.EdNtpServerAddr);
            this.groupBox3.Controls.Add(this.EdtGatewayAddr);
            this.groupBox3.Controls.Add(this.ChkNtpEnabled);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.EdtIpAddr);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.EdtSubNetAddr);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ChkDynamicIp);
            this.groupBox3.Location = new System.Drawing.Point(6, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 158);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SplashBase Network Config";
            // 
            // EdtNtpOffset
            // 
            this.EdtNtpOffset.DecimalPlaces = 1;
            this.EdtNtpOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.EdtNtpOffset.Location = new System.Drawing.Point(233, 126);
            this.EdtNtpOffset.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.EdtNtpOffset.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            -2147483648});
            this.EdtNtpOffset.Name = "EdtNtpOffset";
            this.EdtNtpOffset.Size = new System.Drawing.Size(54, 20);
            this.EdtNtpOffset.TabIndex = 5;
            // 
            // EdNtpServerAddr
            // 
            this.EdNtpServerAddr.Location = new System.Drawing.Point(84, 126);
            this.EdNtpServerAddr.Name = "EdNtpServerAddr";
            this.EdNtpServerAddr.Size = new System.Drawing.Size(133, 20);
            this.EdNtpServerAddr.TabIndex = 3;
            // 
            // EdtGatewayAddr
            // 
            this.EdtGatewayAddr.Location = new System.Drawing.Point(84, 74);
            this.EdtGatewayAddr.Name = "EdtGatewayAddr";
            this.EdtGatewayAddr.Size = new System.Drawing.Size(133, 20);
            this.EdtGatewayAddr.TabIndex = 3;
            // 
            // ChkNtpEnabled
            // 
            this.ChkNtpEnabled.AutoSize = true;
            this.ChkNtpEnabled.Location = new System.Drawing.Point(233, 102);
            this.ChkNtpEnabled.Name = "ChkNtpEnabled";
            this.ChkNtpEnabled.Size = new System.Drawing.Size(116, 17);
            this.ChkNtpEnabled.TabIndex = 0;
            this.ChkNtpEnabled.Text = "Auto Clock Update";
            this.ChkNtpEnabled.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "NTP Server :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gateway : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Time Offset";
            // 
            // EdtIpAddr
            // 
            this.EdtIpAddr.Location = new System.Drawing.Point(84, 22);
            this.EdtIpAddr.Name = "EdtIpAddr";
            this.EdtIpAddr.Size = new System.Drawing.Size(133, 20);
            this.EdtIpAddr.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "IP : ";
            // 
            // EdtSubNetAddr
            // 
            this.EdtSubNetAddr.Location = new System.Drawing.Point(84, 48);
            this.EdtSubNetAddr.Name = "EdtSubNetAddr";
            this.EdtSubNetAddr.Size = new System.Drawing.Size(133, 20);
            this.EdtSubNetAddr.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Subnet : ";
            // 
            // ChkDynamicIp
            // 
            this.ChkDynamicIp.AutoSize = true;
            this.ChkDynamicIp.Location = new System.Drawing.Point(233, 25);
            this.ChkDynamicIp.Name = "ChkDynamicIp";
            this.ChkDynamicIp.Size = new System.Drawing.Size(80, 17);
            this.ChkDynamicIp.TabIndex = 0;
            this.ChkDynamicIp.Text = "Dynamic IP";
            this.ChkDynamicIp.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "- - °C";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temperature : ";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date && Time :";
            this.label1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButRescanBridges);
            this.groupBox2.Controls.Add(this.ListSolderBridges);
            this.groupBox2.Location = new System.Drawing.Point(378, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SPI/I2C SolderBridges :";
            // 
            // ButRescanBridges
            // 
            this.ButRescanBridges.Location = new System.Drawing.Point(6, 274);
            this.ButRescanBridges.Name = "ButRescanBridges";
            this.ButRescanBridges.Size = new System.Drawing.Size(272, 38);
            this.ButRescanBridges.TabIndex = 11;
            this.ButRescanBridges.Text = "Re-scan";
            this.ButRescanBridges.UseVisualStyleBackColor = true;
            this.ButRescanBridges.Click += new System.EventHandler(this.ButRescanBridges_Click);
            // 
            // ListSolderBridges
            // 
            this.ListSolderBridges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSolderBridges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.ListSolderBridges.FullRowSelect = true;
            this.ListSolderBridges.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13});
            this.ListSolderBridges.LabelEdit = true;
            this.ListSolderBridges.Location = new System.Drawing.Point(6, 19);
            this.ListSolderBridges.Name = "ListSolderBridges";
            this.ListSolderBridges.Size = new System.Drawing.Size(272, 249);
            this.ListSolderBridges.TabIndex = 10;
            this.ListSolderBridges.UseCompatibleStateImageBehavior = false;
            this.ListSolderBridges.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Address";
            this.columnHeader5.Width = 63;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SolderBridge Name";
            this.columnHeader6.Width = 164;
            // 
            // ChkLogic
            // 
            this.ChkLogic.AutoSize = true;
            this.ChkLogic.Location = new System.Drawing.Point(19, 276);
            this.ChkLogic.Name = "ChkLogic";
            this.ChkLogic.Size = new System.Drawing.Size(100, 17);
            this.ChkLogic.TabIndex = 0;
            this.ChkLogic.Text = "LOGIC Enabled";
            this.ChkLogic.UseVisualStyleBackColor = true;
            // 
            // EdtSplashBaseName
            // 
            this.EdtSplashBaseName.Location = new System.Drawing.Point(90, 19);
            this.EdtSplashBaseName.MaxLength = 23;
            this.EdtSplashBaseName.Name = "EdtSplashBaseName";
            this.EdtSplashBaseName.Size = new System.Drawing.Size(145, 20);
            this.EdtSplashBaseName.TabIndex = 1;
            // 
            // ChkPwmEn
            // 
            this.ChkPwmEn.AutoSize = true;
            this.ChkPwmEn.Location = new System.Drawing.Point(19, 253);
            this.ChkPwmEn.Name = "ChkPwmEn";
            this.ChkPwmEn.Size = new System.Drawing.Size(95, 17);
            this.ChkPwmEn.TabIndex = 0;
            this.ChkPwmEn.Text = "PWM Enabled";
            this.ChkPwmEn.UseVisualStyleBackColor = true;
            // 
            // ChkRGBEnabled
            // 
            this.ChkRGBEnabled.AutoSize = true;
            this.ChkRGBEnabled.Location = new System.Drawing.Point(120, 253);
            this.ChkRGBEnabled.Name = "ChkRGBEnabled";
            this.ChkRGBEnabled.Size = new System.Drawing.Size(119, 17);
            this.ChkRGBEnabled.TabIndex = 0;
            this.ChkRGBEnabled.Text = "Used For RGB LED";
            this.ChkRGBEnabled.UseVisualStyleBackColor = true;
            // 
            // ChkFourRelay
            // 
            this.ChkFourRelay.AutoSize = true;
            this.ChkFourRelay.Location = new System.Drawing.Point(19, 230);
            this.ChkFourRelay.Name = "ChkFourRelay";
            this.ChkFourRelay.Size = new System.Drawing.Size(182, 17);
            this.ChkFourRelay.TabIndex = 0;
            this.ChkFourRelay.Text = "Four Channel Relay SolderBridge";
            this.ChkFourRelay.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name : ";
            // 
            // ChkUserGpioInit
            // 
            this.ChkUserGpioInit.AutoSize = true;
            this.ChkUserGpioInit.Location = new System.Drawing.Point(19, 207);
            this.ChkUserGpioInit.Name = "ChkUserGpioInit";
            this.ChkUserGpioInit.Size = new System.Drawing.Size(134, 17);
            this.ChkUserGpioInit.TabIndex = 0;
            this.ChkUserGpioInit.Text = "User GPIO Initialisation";
            this.ChkUserGpioInit.UseVisualStyleBackColor = true;
            // 
            // ButFindSplashBases
            // 
            this.ButFindSplashBases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButFindSplashBases.Location = new System.Drawing.Point(12, 176);
            this.ButFindSplashBases.Name = "ButFindSplashBases";
            this.ButFindSplashBases.Size = new System.Drawing.Size(129, 38);
            this.ButFindSplashBases.TabIndex = 11;
            this.ButFindSplashBases.Text = "Find SplashBases";
            this.ButFindSplashBases.UseVisualStyleBackColor = true;
            this.ButFindSplashBases.Click += new System.EventHandler(this.ButFindSplashBases_Click);
            // 
            // ButLogic
            // 
            this.ButLogic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButLogic.Enabled = false;
            this.ButLogic.Location = new System.Drawing.Point(282, 176);
            this.ButLogic.Name = "ButLogic";
            this.ButLogic.Size = new System.Drawing.Size(129, 38);
            this.ButLogic.TabIndex = 11;
            this.ButLogic.Text = "Configure LOGIC";
            this.ButLogic.UseVisualStyleBackColor = true;
            this.ButLogic.Click += new System.EventHandler(this.ButLogic_Click);
            // 
            // ButGpio
            // 
            this.ButGpio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButGpio.Enabled = false;
            this.ButGpio.Location = new System.Drawing.Point(147, 176);
            this.ButGpio.Name = "ButGpio";
            this.ButGpio.Size = new System.Drawing.Size(129, 38);
            this.ButGpio.TabIndex = 11;
            this.ButGpio.Text = "GPIO Control";
            this.ButGpio.UseVisualStyleBackColor = true;
            this.ButGpio.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButPwm
            // 
            this.ButPwm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButPwm.Enabled = false;
            this.ButPwm.Location = new System.Drawing.Point(552, 176);
            this.ButPwm.Name = "ButPwm";
            this.ButPwm.Size = new System.Drawing.Size(129, 38);
            this.ButPwm.TabIndex = 11;
            this.ButPwm.Text = "RGB / PWM && Relay";
            this.ButPwm.UseVisualStyleBackColor = true;
            this.ButPwm.Click += new System.EventHandler(this.ButPwm_Click);
            // 
            // EdtDnsAddr
            // 
            this.EdtDnsAddr.Location = new System.Drawing.Point(84, 100);
            this.EdtDnsAddr.Name = "EdtDnsAddr";
            this.EdtDnsAddr.Size = new System.Drawing.Size(133, 20);
            this.EdtDnsAddr.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "DNS Server : ";
            // 
            // SplashBaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 578);
            this.Controls.Add(this.GrpSplashBase);
            this.Controls.Add(this.ButPwm);
            this.Controls.Add(this.listRemotesFound);
            this.Controls.Add(this.ButGpio);
            this.Controls.Add(this.ButLogic);
            this.Controls.Add(this.ButFindSplashBases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 1024);
            this.MinimumSize = new System.Drawing.Size(16, 540);
            this.Name = "SplashBaseControl";
            this.Text = "[SolderSplash LABS] SplashBase Locate & Control v1.0.3 [Beta]";
            this.Load += new System.EventHandler(this.SplashBaseControl_Load);
            this.Shown += new System.EventHandler(this.SplashBaseControl_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.GrpSplashBase.ResumeLayout(false);
            this.GrpSplashBase.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdtNtpOffset)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listRemotesFound;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox GrpSplashBase;
        private System.Windows.Forms.CheckBox ChkLogic;
        private System.Windows.Forms.CheckBox ChkRGBEnabled;
        private System.Windows.Forms.CheckBox ChkFourRelay;
        private System.Windows.Forms.CheckBox ChkUserGpioInit;
        private System.Windows.Forms.Button ButFindSplashBases;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListSolderBridges;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButLogic;
        private System.Windows.Forms.Button ButGpio;
        private System.Windows.Forms.Button ButPwm;
        private System.Windows.Forms.Button ButRescanBridges;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ChkDynamicIp;
        private System.Windows.Forms.Button ButRefreshExtendedInfo;
        private System.Windows.Forms.TextBox EdtGatewayAddr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EdtSubNetAddr;
        private System.Windows.Forms.TextBox EdtSplashBaseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdNtpServerAddr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EdtIpAddr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader ColConfig;
        private System.Windows.Forms.CheckBox ChkNtpEnabled;
        private System.Windows.Forms.Button ButApply;
        private System.Windows.Forms.Button EdtSetName;
        private System.Windows.Forms.CheckBox ChkPwmEn;
        private System.Windows.Forms.NumericUpDown EdtNtpOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bootloadModeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ColADC0;
        private System.Windows.Forms.ColumnHeader ColADC1;
        private System.Windows.Forms.ColumnHeader ColADC2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem defaultConfigToolStripMenuItem;
        private System.Windows.Forms.Button ButSaveConfig;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox EdtDnsAddr;
        private System.Windows.Forms.Label label10;
    }
}

