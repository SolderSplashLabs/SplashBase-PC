namespace SplashBaseControl
{
    partial class LogicControlFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogicControlFrm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButClearLogicStatement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblLogicIndx = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EdtSelectedActions = new System.Windows.Forms.TextBox();
            this.EdtAndConditions = new System.Windows.Forms.TextBox();
            this.EdtIfConditions = new System.Windows.Forms.TextBox();
            this.ButUpdateLogic = new System.Windows.Forms.Button();
            this.TabConditionList = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ListEvents = new System.Windows.Forms.ListView();
            this.colLogicIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblCondNo = new System.Windows.Forms.Label();
            this.LblCondIdx = new System.Windows.Forms.Label();
            this.ButUpdateCondition = new System.Windows.Forms.Button();
            this.CmbConditionList = new System.Windows.Forms.ComboBox();
            this.UpDownCondParam2 = new System.Windows.Forms.NumericUpDown();
            this.UpDownCondParam1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConditionListView = new System.Windows.Forms.ListView();
            this.ColConditionIndx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColConditionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButUpdateAction = new System.Windows.Forms.Button();
            this.CmbAction = new System.Windows.Forms.ComboBox();
            this.UpDownActParam2 = new System.Windows.Forms.NumericUpDown();
            this.UpDownActParam1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblActionNo = new System.Windows.Forms.Label();
            this.LblActionIdx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ActionListView = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColActionNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readLogicListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readConiditionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readActionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.TabConditionList.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCondParam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCondParam1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownActParam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownActParam1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 667);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButClearLogicStatement);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.LblLogicIndx);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EdtSelectedActions);
            this.groupBox2.Controls.Add(this.EdtAndConditions);
            this.groupBox2.Controls.Add(this.EdtIfConditions);
            this.groupBox2.Controls.Add(this.ButUpdateLogic);
            this.groupBox2.Location = new System.Drawing.Point(423, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 590);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logic Event Creator";
            // 
            // ButClearLogicStatement
            // 
            this.ButClearLogicStatement.Location = new System.Drawing.Point(12, 561);
            this.ButClearLogicStatement.Name = "ButClearLogicStatement";
            this.ButClearLogicStatement.Size = new System.Drawing.Size(75, 23);
            this.ButClearLogicStatement.TabIndex = 3;
            this.ButClearLogicStatement.Text = "Clear";
            this.ButClearLogicStatement.UseVisualStyleBackColor = true;
            this.ButClearLogicStatement.Click += new System.EventHandler(this.ButClearLogicStatement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Then Execute These Actions :";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 40);
            this.label9.TabIndex = 2;
            this.label9.Text = "Build an event by defining up to which conditions will action which of the 24 act" +
                "ions\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "AND Condition : ";
            // 
            // LblLogicIndx
            // 
            this.LblLogicIndx.AutoSize = true;
            this.LblLogicIndx.Location = new System.Drawing.Point(101, 74);
            this.LblLogicIndx.Name = "LblLogicIndx";
            this.LblLogicIndx.Size = new System.Drawing.Size(78, 13);
            this.LblLogicIndx.TabIndex = 2;
            this.LblLogicIndx.Text = "None Selected";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Logic No :  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IF Condition : ";
            // 
            // EdtSelectedActions
            // 
            this.EdtSelectedActions.Location = new System.Drawing.Point(12, 185);
            this.EdtSelectedActions.Multiline = true;
            this.EdtSelectedActions.Name = "EdtSelectedActions";
            this.EdtSelectedActions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EdtSelectedActions.Size = new System.Drawing.Size(345, 370);
            this.EdtSelectedActions.TabIndex = 1;
            // 
            // EdtAndConditions
            // 
            this.EdtAndConditions.Location = new System.Drawing.Point(100, 125);
            this.EdtAndConditions.Name = "EdtAndConditions";
            this.EdtAndConditions.Size = new System.Drawing.Size(257, 20);
            this.EdtAndConditions.TabIndex = 1;
            // 
            // EdtIfConditions
            // 
            this.EdtIfConditions.Location = new System.Drawing.Point(100, 99);
            this.EdtIfConditions.Name = "EdtIfConditions";
            this.EdtIfConditions.Size = new System.Drawing.Size(257, 20);
            this.EdtIfConditions.TabIndex = 1;
            // 
            // ButUpdateLogic
            // 
            this.ButUpdateLogic.Location = new System.Drawing.Point(249, 561);
            this.ButUpdateLogic.Name = "ButUpdateLogic";
            this.ButUpdateLogic.Size = new System.Drawing.Size(108, 23);
            this.ButUpdateLogic.TabIndex = 0;
            this.ButUpdateLogic.Text = "Update Event";
            this.ButUpdateLogic.UseVisualStyleBackColor = true;
            this.ButUpdateLogic.Click += new System.EventHandler(this.ButUpdateLogic_Click);
            // 
            // TabConditionList
            // 
            this.TabConditionList.Controls.Add(this.tabPage4);
            this.TabConditionList.Controls.Add(this.tabPage5);
            this.TabConditionList.Controls.Add(this.tabPage6);
            this.TabConditionList.Location = new System.Drawing.Point(12, 27);
            this.TabConditionList.Name = "TabConditionList";
            this.TabConditionList.SelectedIndex = 0;
            this.TabConditionList.Size = new System.Drawing.Size(405, 590);
            this.TabConditionList.TabIndex = 64;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ListEvents);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(397, 564);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Event List";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ListEvents
            // 
            this.ListEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLogicIndex,
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader12});
            this.ListEvents.FullRowSelect = true;
            this.ListEvents.GridLines = true;
            this.ListEvents.Location = new System.Drawing.Point(6, 6);
            this.ListEvents.Name = "ListEvents";
            this.ListEvents.Size = new System.Drawing.Size(383, 444);
            this.ListEvents.TabIndex = 1;
            this.ListEvents.UseCompatibleStateImageBehavior = false;
            this.ListEvents.View = System.Windows.Forms.View.Details;
            this.ListEvents.SelectedIndexChanged += new System.EventHandler(this.ListLogic_SelectedIndexChanged);
            // 
            // colLogicIndex
            // 
            this.colLogicIndex.Text = "#";
            this.colLogicIndex.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Condition 1";
            this.columnHeader7.Width = 108;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Condition 2";
            this.columnHeader11.Width = 81;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Actions";
            this.columnHeader12.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.ConditionListView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(397, 564);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Condition List";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblCondNo);
            this.groupBox1.Controls.Add(this.LblCondIdx);
            this.groupBox1.Controls.Add(this.ButUpdateCondition);
            this.groupBox1.Controls.Add(this.CmbConditionList);
            this.groupBox1.Controls.Add(this.UpDownCondParam2);
            this.groupBox1.Controls.Add(this.UpDownCondParam1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Selected Action :";
            // 
            // LblCondNo
            // 
            this.LblCondNo.AutoSize = true;
            this.LblCondNo.Location = new System.Drawing.Point(328, 34);
            this.LblCondNo.Name = "LblCondNo";
            this.LblCondNo.Size = new System.Drawing.Size(49, 13);
            this.LblCondNo.TabIndex = 67;
            this.LblCondNo.Text = "Cond No";
            // 
            // LblCondIdx
            // 
            this.LblCondIdx.AutoSize = true;
            this.LblCondIdx.Location = new System.Drawing.Point(328, 16);
            this.LblCondIdx.Name = "LblCondIdx";
            this.LblCondIdx.Size = new System.Drawing.Size(49, 13);
            this.LblCondIdx.TabIndex = 66;
            this.LblCondIdx.Text = "Cond Idx";
            // 
            // ButUpdateCondition
            // 
            this.ButUpdateCondition.Location = new System.Drawing.Point(247, 67);
            this.ButUpdateCondition.Name = "ButUpdateCondition";
            this.ButUpdateCondition.Size = new System.Drawing.Size(130, 23);
            this.ButUpdateCondition.TabIndex = 65;
            this.ButUpdateCondition.Text = "Update Condition";
            this.ButUpdateCondition.UseVisualStyleBackColor = true;
            this.ButUpdateCondition.Click += new System.EventHandler(this.ButUpdateCondition_Click);
            // 
            // CmbConditionList
            // 
            this.CmbConditionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbConditionList.FormattingEnabled = true;
            this.CmbConditionList.Location = new System.Drawing.Point(88, 18);
            this.CmbConditionList.Name = "CmbConditionList";
            this.CmbConditionList.Size = new System.Drawing.Size(151, 21);
            this.CmbConditionList.TabIndex = 64;
            this.CmbConditionList.SelectedIndexChanged += new System.EventHandler(this.CmbConditionList_SelectedIndexChanged);
            // 
            // UpDownCondParam2
            // 
            this.UpDownCondParam2.Location = new System.Drawing.Point(167, 70);
            this.UpDownCondParam2.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.UpDownCondParam2.Name = "UpDownCondParam2";
            this.UpDownCondParam2.Size = new System.Drawing.Size(72, 20);
            this.UpDownCondParam2.TabIndex = 63;
            // 
            // UpDownCondParam1
            // 
            this.UpDownCondParam1.Location = new System.Drawing.Point(167, 43);
            this.UpDownCondParam1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.UpDownCondParam1.Name = "UpDownCondParam1";
            this.UpDownCondParam1.Size = new System.Drawing.Size(72, 20);
            this.UpDownCondParam1.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Parameter 2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Parameter 1 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Condition :";
            // 
            // ConditionListView
            // 
            this.ConditionListView.CheckBoxes = true;
            this.ConditionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColConditionIndx,
            this.ColConditionType,
            this.columnHeader6,
            this.columnHeader8});
            this.ConditionListView.FullRowSelect = true;
            this.ConditionListView.GridLines = true;
            this.ConditionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ConditionListView.HideSelection = false;
            this.ConditionListView.Location = new System.Drawing.Point(6, 6);
            this.ConditionListView.Name = "ConditionListView";
            this.ConditionListView.Size = new System.Drawing.Size(383, 444);
            this.ConditionListView.TabIndex = 0;
            this.ConditionListView.UseCompatibleStateImageBehavior = false;
            this.ConditionListView.View = System.Windows.Forms.View.Details;
            this.ConditionListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ConditionListView_ItemChecked);
            this.ConditionListView.SelectedIndexChanged += new System.EventHandler(this.ConditionListView_SelectedIndexChanged);
            // 
            // ColConditionIndx
            // 
            this.ColConditionIndx.Text = "#";
            this.ColConditionIndx.Width = 40;
            // 
            // ColConditionType
            // 
            this.ColConditionType.Text = "Condition Type";
            this.ColConditionType.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Param1";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Param2";
            this.columnHeader8.Width = 92;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Controls.Add(this.ActionListView);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(397, 564);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Action List";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ButUpdateAction);
            this.groupBox3.Controls.Add(this.CmbAction);
            this.groupBox3.Controls.Add(this.UpDownActParam2);
            this.groupBox3.Controls.Add(this.UpDownActParam1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.LblActionNo);
            this.groupBox3.Controls.Add(this.LblActionIdx);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 102);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Selected Action :";
            // 
            // ButUpdateAction
            // 
            this.ButUpdateAction.Location = new System.Drawing.Point(247, 67);
            this.ButUpdateAction.Name = "ButUpdateAction";
            this.ButUpdateAction.Size = new System.Drawing.Size(130, 23);
            this.ButUpdateAction.TabIndex = 65;
            this.ButUpdateAction.Text = "Update Action";
            this.ButUpdateAction.UseVisualStyleBackColor = true;
            this.ButUpdateAction.Click += new System.EventHandler(this.ButUpdateAction_Click);
            // 
            // CmbAction
            // 
            this.CmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAction.FormattingEnabled = true;
            this.CmbAction.Location = new System.Drawing.Point(88, 18);
            this.CmbAction.Name = "CmbAction";
            this.CmbAction.Size = new System.Drawing.Size(151, 21);
            this.CmbAction.TabIndex = 64;
            this.CmbAction.SelectedIndexChanged += new System.EventHandler(this.CmbAction_SelectedIndexChanged);
            // 
            // UpDownActParam2
            // 
            this.UpDownActParam2.Location = new System.Drawing.Point(167, 70);
            this.UpDownActParam2.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.UpDownActParam2.Name = "UpDownActParam2";
            this.UpDownActParam2.Size = new System.Drawing.Size(72, 20);
            this.UpDownActParam2.TabIndex = 63;
            // 
            // UpDownActParam1
            // 
            this.UpDownActParam1.Location = new System.Drawing.Point(167, 43);
            this.UpDownActParam1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.UpDownActParam1.Name = "UpDownActParam1";
            this.UpDownActParam1.Size = new System.Drawing.Size(72, 20);
            this.UpDownActParam1.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Parameter 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Parameter 1 :";
            // 
            // LblActionNo
            // 
            this.LblActionNo.AutoSize = true;
            this.LblActionNo.Location = new System.Drawing.Point(323, 34);
            this.LblActionNo.Name = "LblActionNo";
            this.LblActionNo.Size = new System.Drawing.Size(54, 13);
            this.LblActionNo.TabIndex = 60;
            this.LblActionNo.Text = "Action No";
            // 
            // LblActionIdx
            // 
            this.LblActionIdx.AutoSize = true;
            this.LblActionIdx.Location = new System.Drawing.Point(323, 16);
            this.LblActionIdx.Name = "LblActionIdx";
            this.LblActionIdx.Size = new System.Drawing.Size(54, 13);
            this.LblActionIdx.TabIndex = 60;
            this.LblActionIdx.Text = "Action Idx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Action :";
            // 
            // ActionListView
            // 
            this.ActionListView.BackColor = System.Drawing.SystemColors.Window;
            this.ActionListView.CheckBoxes = true;
            this.ActionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader14,
            this.ColActionNo});
            this.ActionListView.FullRowSelect = true;
            this.ActionListView.GridLines = true;
            this.ActionListView.HideSelection = false;
            this.ActionListView.Location = new System.Drawing.Point(6, 6);
            this.ActionListView.Name = "ActionListView";
            this.ActionListView.Size = new System.Drawing.Size(383, 444);
            this.ActionListView.TabIndex = 1;
            this.ActionListView.UseCompatibleStateImageBehavior = false;
            this.ActionListView.View = System.Windows.Forms.View.Details;
            this.ActionListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ActionListView_ItemChecked);
            this.ActionListView.SelectedIndexChanged += new System.EventHandler(this.ActionListView_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "#";
            this.columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Action Type";
            this.columnHeader10.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Param1";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Param2";
            this.columnHeader14.Width = 92;
            // 
            // ColActionNo
            // 
            this.ColActionNo.Width = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Enabled = false;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Enabled = false;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readLogicListToolStripMenuItem,
            this.readConiditionListToolStripMenuItem,
            this.readActionListToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // readLogicListToolStripMenuItem
            // 
            this.readLogicListToolStripMenuItem.Name = "readLogicListToolStripMenuItem";
            this.readLogicListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.readLogicListToolStripMenuItem.Text = "Read Logic List";
            this.readLogicListToolStripMenuItem.Click += new System.EventHandler(this.readLogicListToolStripMenuItem_Click);
            // 
            // readConiditionListToolStripMenuItem
            // 
            this.readConiditionListToolStripMenuItem.Name = "readConiditionListToolStripMenuItem";
            this.readConiditionListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.readConiditionListToolStripMenuItem.Text = "Read Condition List";
            this.readConiditionListToolStripMenuItem.Click += new System.EventHandler(this.readConiditionListToolStripMenuItem_Click);
            // 
            // readActionListToolStripMenuItem
            // 
            this.readActionListToolStripMenuItem.Name = "readActionListToolStripMenuItem";
            this.readActionListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.readActionListToolStripMenuItem.Text = "Read Action List";
            this.readActionListToolStripMenuItem.Click += new System.EventHandler(this.readActionListToolStripMenuItem_Click);
            // 
            // LogicControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TabConditionList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LogicControlFrm";
            this.Text = "[SolderSplash LABS] LOGIC Control";
            this.Load += new System.EventHandler(this.LogicControlFrm_Load);
            this.Shown += new System.EventHandler(this.LogicControlFrm_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TabConditionList.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCondParam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCondParam1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownActParam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownActParam1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdtSelectedActions;
        private System.Windows.Forms.TextBox EdtIfConditions;
        private System.Windows.Forms.Button ButUpdateLogic;
        private System.Windows.Forms.TabControl TabConditionList;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ColumnHeader colLogicIndex;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListView ConditionListView;
        private System.Windows.Forms.ColumnHeader ColConditionIndx;
        private System.Windows.Forms.ColumnHeader ColConditionType;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListView ActionListView;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader ColActionNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButUpdateAction;
        private System.Windows.Forms.ComboBox CmbAction;
        private System.Windows.Forms.NumericUpDown UpDownActParam2;
        private System.Windows.Forms.NumericUpDown UpDownActParam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButUpdateCondition;
        private System.Windows.Forms.ComboBox CmbConditionList;
        private System.Windows.Forms.NumericUpDown UpDownCondParam2;
        private System.Windows.Forms.NumericUpDown UpDownCondParam1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label LblActionIdx;
        private System.Windows.Forms.Label LblActionNo;
        private System.Windows.Forms.Label LblCondNo;
        private System.Windows.Forms.Label LblCondIdx;
        private System.Windows.Forms.ToolStripMenuItem readLogicListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readConiditionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readActionListToolStripMenuItem;
        private System.Windows.Forms.Button ButClearLogicStatement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EdtAndConditions;
        private System.Windows.Forms.ListView ListEvents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblLogicIndx;
    }
}