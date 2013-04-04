namespace SplashBaseControl
{
    partial class ControlFrm
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
            "Relay 1",
            "1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Relay 2",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Relay 3",
            "3"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Relay 4",
            "4"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlFrm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.GrpControl = new System.Windows.Forms.GroupBox();
            this.listRelays = new System.Windows.Forms.ListView();
            this.ColRelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameRelayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPwm0 = new System.Windows.Forms.Label();
            this.lblPwm1 = new System.Windows.Forms.Label();
            this.lblPwm2 = new System.Windows.Forms.Label();
            this.lblPwm3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.optAddjustBottom = new System.Windows.Forms.RadioButton();
            this.optAddjustTop = new System.Windows.Forms.RadioButton();
            this.faderTrack = new System.Windows.Forms.TrackBar();
            this.BlueTrack = new System.Windows.Forms.TrackBar();
            this.GreenTrack = new System.Windows.Forms.TrackBar();
            this.RedTrack = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblColourSelectorHsv = new System.Windows.Forms.Label();
            this.lblColourSelectorRgb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.noOfSteps = new System.Windows.Forms.NumericUpDown();
            this.ticksPerStep = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.butSelectBottom = new System.Windows.Forms.Button();
            this.butSelectTop = new System.Windows.Forms.Button();
            this.panelBottomRGB = new System.Windows.Forms.Panel();
            this.panelTopRGB = new System.Windows.Forms.Panel();
            this.lblBottomRGB = new System.Windows.Forms.Label();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.lblTopRGB = new System.Windows.Forms.Label();
            this.butSend = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColourMode = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.butRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.butAutoRefresh = new System.Windows.Forms.Button();
            this.tmrAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.colorWheel1 = new PaintDotNet.ColorWheel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.GrpControl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faderTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticksPerStep)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "192.168.0.3";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frequency :";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBar1.Location = new System.Drawing.Point(66, 22);
            this.trackBar1.Maximum = 65535;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(354, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBar2.Location = new System.Drawing.Point(66, 62);
            this.trackBar2.Maximum = 65535;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(354, 45);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBar3.Location = new System.Drawing.Point(66, 100);
            this.trackBar3.Maximum = 65535;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(354, 45);
            this.trackBar3.TabIndex = 3;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBar4.Location = new System.Drawing.Point(66, 138);
            this.trackBar4.Maximum = 65535;
            this.trackBar4.Minimum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(354, 45);
            this.trackBar4.TabIndex = 3;
            this.trackBar4.Value = 100;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // GrpControl
            // 
            this.GrpControl.Controls.Add(this.listRelays);
            this.GrpControl.Location = new System.Drawing.Point(330, 6);
            this.GrpControl.Name = "GrpControl";
            this.GrpControl.Size = new System.Drawing.Size(198, 187);
            this.GrpControl.TabIndex = 8;
            this.GrpControl.TabStop = false;
            this.GrpControl.Text = "Relay Control ";
            this.GrpControl.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listRelays
            // 
            this.listRelays.CheckBoxes = true;
            this.listRelays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColRelay,
            this.ColName});
            this.listRelays.ContextMenuStrip = this.contextMenuStrip1;
            this.listRelays.FullRowSelect = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.Tag = "1";
            listViewItem2.StateImageIndex = 0;
            listViewItem2.Tag = "2";
            listViewItem3.StateImageIndex = 0;
            listViewItem3.Tag = "4";
            listViewItem4.StateImageIndex = 0;
            listViewItem4.Tag = "8";
            this.listRelays.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listRelays.Location = new System.Drawing.Point(8, 19);
            this.listRelays.Name = "listRelays";
            this.listRelays.Scrollable = false;
            this.listRelays.Size = new System.Drawing.Size(184, 119);
            this.listRelays.TabIndex = 45;
            this.listRelays.UseCompatibleStateImageBehavior = false;
            this.listRelays.View = System.Windows.Forms.View.Details;
            this.listRelays.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listRelays_AfterLabelEdit);
            this.listRelays.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // ColRelay
            // 
            this.ColRelay.Text = "Relay Name";
            this.ColRelay.Width = 120;
            // 
            // ColName
            // 
            this.ColName.Text = "Position";
            this.ColName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColName.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameRelayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // renameRelayToolStripMenuItem
            // 
            this.renameRelayToolStripMenuItem.Name = "renameRelayToolStripMenuItem";
            this.renameRelayToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.renameRelayToolStripMenuItem.Text = "Rename Relay";
            this.renameRelayToolStripMenuItem.Click += new System.EventHandler(this.renameRelayToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PWM0 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "PWM1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PWM2 :";
            // 
            // lblPwm0
            // 
            this.lblPwm0.AutoSize = true;
            this.lblPwm0.Location = new System.Drawing.Point(426, 29);
            this.lblPwm0.Name = "lblPwm0";
            this.lblPwm0.Size = new System.Drawing.Size(37, 13);
            this.lblPwm0.TabIndex = 2;
            this.lblPwm0.Text = "00000";
            // 
            // lblPwm1
            // 
            this.lblPwm1.AutoSize = true;
            this.lblPwm1.Location = new System.Drawing.Point(426, 70);
            this.lblPwm1.Name = "lblPwm1";
            this.lblPwm1.Size = new System.Drawing.Size(37, 13);
            this.lblPwm1.TabIndex = 2;
            this.lblPwm1.Text = "00000";
            // 
            // lblPwm2
            // 
            this.lblPwm2.AutoSize = true;
            this.lblPwm2.Location = new System.Drawing.Point(426, 109);
            this.lblPwm2.Name = "lblPwm2";
            this.lblPwm2.Size = new System.Drawing.Size(37, 13);
            this.lblPwm2.TabIndex = 2;
            this.lblPwm2.Text = "00000";
            // 
            // lblPwm3
            // 
            this.lblPwm3.AutoSize = true;
            this.lblPwm3.Location = new System.Drawing.Point(426, 148);
            this.lblPwm3.Name = "lblPwm3";
            this.lblPwm3.Size = new System.Drawing.Size(37, 13);
            this.lblPwm3.TabIndex = 2;
            this.lblPwm3.Text = "00000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "10ms Per Step :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar4);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPwm3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPwm0);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPwm1);
            this.groupBox1.Controls.Add(this.lblPwm2);
            this.groupBox1.Location = new System.Drawing.Point(6, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 187);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced Manual PWM Control/View";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(181, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "No of Steps :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.optAddjustBottom);
            this.groupBox3.Controls.Add(this.optAddjustTop);
            this.groupBox3.Controls.Add(this.faderTrack);
            this.groupBox3.Controls.Add(this.BlueTrack);
            this.groupBox3.Controls.Add(this.GreenTrack);
            this.groupBox3.Controls.Add(this.RedTrack);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblColourSelectorHsv);
            this.groupBox3.Controls.Add(this.lblColourSelectorRgb);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Label17);
            this.groupBox3.Controls.Add(this.Label16);
            this.groupBox3.Controls.Add(this.Label15);
            this.groupBox3.Controls.Add(this.colorWheel1);
            this.groupBox3.Location = new System.Drawing.Point(6, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 232);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colour Selector";
            // 
            // optAddjustBottom
            // 
            this.optAddjustBottom.AutoSize = true;
            this.optAddjustBottom.Location = new System.Drawing.Point(410, 167);
            this.optAddjustBottom.Name = "optAddjustBottom";
            this.optAddjustBottom.Size = new System.Drawing.Size(90, 17);
            this.optAddjustBottom.TabIndex = 68;
            this.optAddjustBottom.Text = "Adjust Bottom";
            this.optAddjustBottom.UseVisualStyleBackColor = true;
            this.optAddjustBottom.CheckedChanged += new System.EventHandler(this.optAddjustBottom_CheckedChanged);
            // 
            // optAddjustTop
            // 
            this.optAddjustTop.AutoSize = true;
            this.optAddjustTop.Checked = true;
            this.optAddjustTop.Location = new System.Drawing.Point(247, 167);
            this.optAddjustTop.Name = "optAddjustTop";
            this.optAddjustTop.Size = new System.Drawing.Size(76, 17);
            this.optAddjustTop.TabIndex = 68;
            this.optAddjustTop.TabStop = true;
            this.optAddjustTop.Text = "Adjust Top";
            this.optAddjustTop.UseVisualStyleBackColor = true;
            this.optAddjustTop.CheckedChanged += new System.EventHandler(this.optAddjustBottom_CheckedChanged);
            // 
            // faderTrack
            // 
            this.faderTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.faderTrack.LargeChange = 1;
            this.faderTrack.Location = new System.Drawing.Point(284, 140);
            this.faderTrack.Maximum = 100;
            this.faderTrack.Name = "faderTrack";
            this.faderTrack.Size = new System.Drawing.Size(216, 45);
            this.faderTrack.TabIndex = 59;
            this.faderTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.faderTrack.Value = 100;
            this.faderTrack.ValueChanged += new System.EventHandler(this.faderTrack_ValueChanged);
            // 
            // BlueTrack
            // 
            this.BlueTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlueTrack.LargeChange = 1;
            this.BlueTrack.Location = new System.Drawing.Point(284, 109);
            this.BlueTrack.Maximum = 255;
            this.BlueTrack.Name = "BlueTrack";
            this.BlueTrack.Size = new System.Drawing.Size(216, 45);
            this.BlueTrack.TabIndex = 60;
            this.BlueTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueTrack.Value = 255;
            this.BlueTrack.ValueChanged += new System.EventHandler(this.BlueTrack_ValueChanged);
            // 
            // GreenTrack
            // 
            this.GreenTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GreenTrack.LargeChange = 1;
            this.GreenTrack.Location = new System.Drawing.Point(284, 80);
            this.GreenTrack.Maximum = 255;
            this.GreenTrack.Name = "GreenTrack";
            this.GreenTrack.Size = new System.Drawing.Size(216, 45);
            this.GreenTrack.TabIndex = 61;
            this.GreenTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenTrack.Value = 255;
            this.GreenTrack.ValueChanged += new System.EventHandler(this.BlueTrack_ValueChanged);
            // 
            // RedTrack
            // 
            this.RedTrack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RedTrack.LargeChange = 1;
            this.RedTrack.Location = new System.Drawing.Point(284, 49);
            this.RedTrack.Maximum = 255;
            this.RedTrack.Name = "RedTrack";
            this.RedTrack.Size = new System.Drawing.Size(216, 45);
            this.RedTrack.TabIndex = 62;
            this.RedTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedTrack.Value = 255;
            this.RedTrack.ValueChanged += new System.EventHandler(this.BlueTrack_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "RGB : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "HSV : ";
            // 
            // lblColourSelectorHsv
            // 
            this.lblColourSelectorHsv.AutoSize = true;
            this.lblColourSelectorHsv.Location = new System.Drawing.Point(416, 23);
            this.lblColourSelectorHsv.Name = "lblColourSelectorHsv";
            this.lblColourSelectorHsv.Size = new System.Drawing.Size(67, 13);
            this.lblColourSelectorHsv.TabIndex = 61;
            this.lblColourSelectorHsv.Text = "255,255,255";
            // 
            // lblColourSelectorRgb
            // 
            this.lblColourSelectorRgb.AutoSize = true;
            this.lblColourSelectorRgb.Location = new System.Drawing.Point(289, 23);
            this.lblColourSelectorRgb.Name = "lblColourSelectorRgb";
            this.lblColourSelectorRgb.Size = new System.Drawing.Size(67, 13);
            this.lblColourSelectorRgb.TabIndex = 61;
            this.lblColourSelectorRgb.Text = "255,255,255";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Fader :";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(244, 109);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(34, 13);
            this.Label17.TabIndex = 58;
            this.Label17.Text = "Blue :";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(244, 80);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(42, 13);
            this.Label16.TabIndex = 50;
            this.Label16.Text = "Green :";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(244, 55);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(33, 13);
            this.Label15.TabIndex = 49;
            this.Label15.Text = "Red :";
            // 
            // noOfSteps
            // 
            this.noOfSteps.Location = new System.Drawing.Point(256, 106);
            this.noOfSteps.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.noOfSteps.Name = "noOfSteps";
            this.noOfSteps.Size = new System.Drawing.Size(56, 20);
            this.noOfSteps.TabIndex = 41;
            this.noOfSteps.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.noOfSteps.ValueChanged += new System.EventHandler(this.ticksPerStep_ValueChanged);
            // 
            // ticksPerStep
            // 
            this.ticksPerStep.Location = new System.Drawing.Point(118, 105);
            this.ticksPerStep.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ticksPerStep.Name = "ticksPerStep";
            this.ticksPerStep.Size = new System.Drawing.Size(45, 20);
            this.ticksPerStep.TabIndex = 40;
            this.ticksPerStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ticksPerStep.ValueChanged += new System.EventHandler(this.ticksPerStep_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.butSelectBottom);
            this.groupBox4.Controls.Add(this.butSelectTop);
            this.groupBox4.Controls.Add(this.panelBottomRGB);
            this.groupBox4.Controls.Add(this.panelTopRGB);
            this.groupBox4.Controls.Add(this.lblBottomRGB);
            this.groupBox4.Controls.Add(this.chkAutoSend);
            this.groupBox4.Controls.Add(this.lblTopRGB);
            this.groupBox4.Controls.Add(this.butSend);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmbColourMode);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.noOfSteps);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.ticksPerStep);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 187);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Colour Mode Settings";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // butSelectBottom
            // 
            this.butSelectBottom.Location = new System.Drawing.Point(240, 75);
            this.butSelectBottom.Name = "butSelectBottom";
            this.butSelectBottom.Size = new System.Drawing.Size(72, 23);
            this.butSelectBottom.TabIndex = 60;
            this.butSelectBottom.Text = "Select";
            this.toolTip1.SetToolTip(this.butSelectBottom, "Modify the bottom colour with the colour selector below");
            this.butSelectBottom.UseVisualStyleBackColor = true;
            this.butSelectBottom.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // butSelectTop
            // 
            this.butSelectTop.Enabled = false;
            this.butSelectTop.Location = new System.Drawing.Point(240, 46);
            this.butSelectTop.Name = "butSelectTop";
            this.butSelectTop.Size = new System.Drawing.Size(72, 23);
            this.butSelectTop.TabIndex = 60;
            this.butSelectTop.Text = "Selected";
            this.toolTip1.SetToolTip(this.butSelectTop, "Modify the top colour with the colour selector below");
            this.butSelectTop.UseVisualStyleBackColor = true;
            this.butSelectTop.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panelBottomRGB
            // 
            this.panelBottomRGB.BackColor = System.Drawing.Color.Black;
            this.panelBottomRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottomRGB.Location = new System.Drawing.Point(196, 75);
            this.panelBottomRGB.Name = "panelBottomRGB";
            this.panelBottomRGB.Size = new System.Drawing.Size(23, 23);
            this.panelBottomRGB.TabIndex = 62;
            this.panelBottomRGB.Click += new System.EventHandler(this.panelBottomRGB_Click);
            // 
            // panelTopRGB
            // 
            this.panelTopRGB.BackColor = System.Drawing.Color.Black;
            this.panelTopRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopRGB.Location = new System.Drawing.Point(196, 48);
            this.panelTopRGB.Name = "panelTopRGB";
            this.panelTopRGB.Size = new System.Drawing.Size(23, 23);
            this.panelTopRGB.TabIndex = 62;
            this.panelTopRGB.Click += new System.EventHandler(this.panelTopRGB_Click);
            // 
            // lblBottomRGB
            // 
            this.lblBottomRGB.AutoSize = true;
            this.lblBottomRGB.Location = new System.Drawing.Point(115, 80);
            this.lblBottomRGB.Name = "lblBottomRGB";
            this.lblBottomRGB.Size = new System.Drawing.Size(37, 13);
            this.lblBottomRGB.TabIndex = 61;
            this.lblBottomRGB.Text = "0, 0, 0";
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAutoSend.Checked = true;
            this.chkAutoSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoSend.Location = new System.Drawing.Point(57, 154);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(108, 17);
            this.chkAutoSend.TabIndex = 61;
            this.chkAutoSend.Text = "Send On Change";
            this.chkAutoSend.UseVisualStyleBackColor = true;
            // 
            // lblTopRGB
            // 
            this.lblTopRGB.AutoSize = true;
            this.lblTopRGB.Location = new System.Drawing.Point(115, 51);
            this.lblTopRGB.Name = "lblTopRGB";
            this.lblTopRGB.Size = new System.Drawing.Size(37, 13);
            this.lblTopRGB.TabIndex = 61;
            this.lblTopRGB.Text = "0, 0, 0";
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(171, 150);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(141, 23);
            this.butSend.TabIndex = 59;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Bottom RGB Value :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Top RGB Value :";
            // 
            // cmbColourMode
            // 
            this.cmbColourMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColourMode.FormattingEnabled = true;
            this.cmbColourMode.Items.AddRange(new object[] {
            "Off",
            "Cycling",
            "Pulsing",
            "Manaul Static",
            "Pulsing Random"});
            this.cmbColourMode.Location = new System.Drawing.Point(118, 21);
            this.cmbColourMode.Name = "cmbColourMode";
            this.cmbColourMode.Size = new System.Drawing.Size(194, 21);
            this.cmbColourMode.TabIndex = 43;
            this.cmbColourMode.SelectedIndexChanged += new System.EventHandler(this.cmbColourMode_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(69, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Mode : ";
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(463, 699);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(93, 23);
            this.butRefresh.TabIndex = 43;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // butAutoRefresh
            // 
            this.butAutoRefresh.Location = new System.Drawing.Point(318, 699);
            this.butAutoRefresh.Name = "butAutoRefresh";
            this.butAutoRefresh.Size = new System.Drawing.Size(139, 23);
            this.butAutoRefresh.TabIndex = 44;
            this.butAutoRefresh.Text = "Auto Refresh : OFF";
            this.butAutoRefresh.UseVisualStyleBackColor = true;
            this.butAutoRefresh.Click += new System.EventHandler(this.butAutoRefresh_Click);
            // 
            // tmrAutoRefresh
            // 
            this.tmrAutoRefresh.Interval = 50;
            this.tmrAutoRefresh.Tick += new System.EventHandler(this.tmrAutoRefresh_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 681);
            this.tabControl1.TabIndex = 45;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.GrpControl);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Relay and RGB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // colorWheel1
            // 
            this.colorWheel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.colorWheel1.Location = new System.Drawing.Point(21, 21);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(192, 191);
            this.colorWheel1.TabIndex = 39;
            this.colorWheel1.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
            // 
            // ControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 730);
            this.Controls.Add(this.butAutoRefresh);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlFrm";
            this.Text = "[SolderSplash LABS] SplashBase Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlFrm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlFrm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.GrpControl.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faderTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticksPerStep)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.GroupBox GrpControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPwm2;
        private System.Windows.Forms.Label lblPwm1;
        private System.Windows.Forms.Label lblPwm0;
        private System.Windows.Forms.Label lblPwm3;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        internal System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TrackBar BlueTrack;
        internal System.Windows.Forms.TrackBar GreenTrack;
        internal System.Windows.Forms.TrackBar RedTrack;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TrackBar faderTrack;
        private PaintDotNet.ColorWheel colorWheel1;
        private System.Windows.Forms.NumericUpDown noOfSteps;
        private System.Windows.Forms.NumericUpDown ticksPerStep;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbColourMode;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button butSend;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.RadioButton optAddjustBottom;
        private System.Windows.Forms.RadioButton optAddjustTop;
        private System.Windows.Forms.Button butSelectBottom;
        private System.Windows.Forms.Button butSelectTop;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelBottomRGB;
        private System.Windows.Forms.Panel panelTopRGB;
        private System.Windows.Forms.Label lblBottomRGB;
        private System.Windows.Forms.Label lblTopRGB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblColourSelectorRgb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblColourSelectorHsv;
        private System.Windows.Forms.Button butAutoRefresh;
        private System.Windows.Forms.Timer tmrAutoRefresh;
        private System.Windows.Forms.ListView listRelays;
        private System.Windows.Forms.ColumnHeader ColRelay;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renameRelayToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

