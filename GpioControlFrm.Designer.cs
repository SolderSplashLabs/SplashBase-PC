namespace SplashBaseControl
{
    partial class GpioControlFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GpioControlFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listGpioList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButRefresh = new System.Windows.Forms.Button();
            this.EdtSelectedPort = new System.Windows.Forms.TextBox();
            this.grpSelectGpio = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButApplyInitChange = new System.Windows.Forms.Button();
            this.ButGpioInitNow = new System.Windows.Forms.Button();
            this.ButApply = new System.Windows.Forms.Button();
            this.EdtInitPortPins = new System.Windows.Forms.TextBox();
            this.EdtInitDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EdtPortPins = new System.Windows.Forms.TextBox();
            this.EdtDirection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpSelectGpio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.listGpioList);
            this.groupBox1.Controls.Add(this.ButRefresh);
            this.groupBox1.Controls.Add(this.EdtSelectedPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPIO Viewer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // listGpioList
            // 
            this.listGpioList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listGpioList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader4});
            this.listGpioList.FullRowSelect = true;
            this.listGpioList.GridLines = true;
            this.listGpioList.Location = new System.Drawing.Point(6, 19);
            this.listGpioList.Name = "listGpioList";
            this.listGpioList.Size = new System.Drawing.Size(543, 286);
            this.listGpioList.TabIndex = 10;
            this.listGpioList.UseCompatibleStateImageBehavior = false;
            this.listGpioList.View = System.Windows.Forms.View.Details;
            this.listGpioList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listRemotesFound_ItemSelectionChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Direction";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Port/Pins";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Protected";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Init Dir";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Init Port/Pin";
            this.columnHeader4.Width = 80;
            // 
            // ButRefresh
            // 
            this.ButRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButRefresh.Location = new System.Drawing.Point(420, 311);
            this.ButRefresh.Name = "ButRefresh";
            this.ButRefresh.Size = new System.Drawing.Size(129, 38);
            this.ButRefresh.TabIndex = 12;
            this.ButRefresh.Text = "Refresh";
            this.ButRefresh.UseVisualStyleBackColor = true;
            this.ButRefresh.Click += new System.EventHandler(this.ButRefresh_Click);
            // 
            // EdtSelectedPort
            // 
            this.EdtSelectedPort.Location = new System.Drawing.Point(326, 321);
            this.EdtSelectedPort.Name = "EdtSelectedPort";
            this.EdtSelectedPort.Size = new System.Drawing.Size(30, 20);
            this.EdtSelectedPort.TabIndex = 0;
            this.EdtSelectedPort.Visible = false;
            this.EdtSelectedPort.TextChanged += new System.EventHandler(this.EdtDirection_TextChanged);
            // 
            // grpSelectGpio
            // 
            this.grpSelectGpio.Controls.Add(this.label3);
            this.grpSelectGpio.Controls.Add(this.label4);
            this.grpSelectGpio.Controls.Add(this.ButApplyInitChange);
            this.grpSelectGpio.Controls.Add(this.ButGpioInitNow);
            this.grpSelectGpio.Controls.Add(this.ButApply);
            this.grpSelectGpio.Controls.Add(this.EdtInitPortPins);
            this.grpSelectGpio.Controls.Add(this.EdtInitDir);
            this.grpSelectGpio.Controls.Add(this.label2);
            this.grpSelectGpio.Controls.Add(this.label1);
            this.grpSelectGpio.Controls.Add(this.EdtPortPins);
            this.grpSelectGpio.Controls.Add(this.EdtDirection);
            this.grpSelectGpio.Location = new System.Drawing.Point(12, 373);
            this.grpSelectGpio.Name = "grpSelectGpio";
            this.grpSelectGpio.Size = new System.Drawing.Size(555, 119);
            this.grpSelectGpio.TabIndex = 13;
            this.grpSelectGpio.TabStop = false;
            this.grpSelectGpio.Text = "Modify GPIO Port : PORTX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Init Port/Pins :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Init Direction :";
            // 
            // ButApplyInitChange
            // 
            this.ButApplyInitChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButApplyInitChange.Location = new System.Drawing.Point(217, 75);
            this.ButApplyInitChange.Name = "ButApplyInitChange";
            this.ButApplyInitChange.Size = new System.Drawing.Size(187, 38);
            this.ButApplyInitChange.TabIndex = 12;
            this.ButApplyInitChange.Text = "Apply Init Change";
            this.ButApplyInitChange.UseVisualStyleBackColor = true;
            this.ButApplyInitChange.Click += new System.EventHandler(this.ButApplyInitChange_Click);
            // 
            // ButGpioInitNow
            // 
            this.ButGpioInitNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButGpioInitNow.Location = new System.Drawing.Point(410, 74);
            this.ButGpioInitNow.Name = "ButGpioInitNow";
            this.ButGpioInitNow.Size = new System.Drawing.Size(139, 38);
            this.ButGpioInitNow.TabIndex = 12;
            this.ButGpioInitNow.Text = "Apply GPIO Init Now";
            this.ButGpioInitNow.UseVisualStyleBackColor = true;
            this.ButGpioInitNow.Click += new System.EventHandler(this.ButGpioInitNow_Click);
            // 
            // ButApply
            // 
            this.ButApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButApply.Location = new System.Drawing.Point(18, 74);
            this.ButApply.Name = "ButApply";
            this.ButApply.Size = new System.Drawing.Size(187, 38);
            this.ButApply.TabIndex = 12;
            this.ButApply.Text = "Apply Port Change";
            this.ButApply.UseVisualStyleBackColor = true;
            this.ButApply.Click += new System.EventHandler(this.ButApply_Click);
            // 
            // EdtInitPortPins
            // 
            this.EdtInitPortPins.Location = new System.Drawing.Point(304, 48);
            this.EdtInitPortPins.Name = "EdtInitPortPins";
            this.EdtInitPortPins.Size = new System.Drawing.Size(100, 20);
            this.EdtInitPortPins.TabIndex = 2;
            this.EdtInitPortPins.TextChanged += new System.EventHandler(this.EdtDirection_TextChanged);
            // 
            // EdtInitDir
            // 
            this.EdtInitDir.Location = new System.Drawing.Point(304, 22);
            this.EdtInitDir.Name = "EdtInitDir";
            this.EdtInitDir.Size = new System.Drawing.Size(100, 20);
            this.EdtInitDir.TabIndex = 3;
            this.EdtInitDir.TextChanged += new System.EventHandler(this.EdtDirection_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port/Pins :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direction :";
            // 
            // EdtPortPins
            // 
            this.EdtPortPins.Location = new System.Drawing.Point(105, 48);
            this.EdtPortPins.Name = "EdtPortPins";
            this.EdtPortPins.Size = new System.Drawing.Size(100, 20);
            this.EdtPortPins.TabIndex = 0;
            this.EdtPortPins.TextChanged += new System.EventHandler(this.EdtDirection_TextChanged);
            // 
            // EdtDirection
            // 
            this.EdtDirection.Location = new System.Drawing.Point(105, 22);
            this.EdtDirection.Name = "EdtDirection";
            this.EdtDirection.Size = new System.Drawing.Size(100, 20);
            this.EdtDirection.TabIndex = 0;
            this.EdtDirection.TextChanged += new System.EventHandler(this.EdtDirection_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Direction : 1 = Output 0 = Input";
            // 
            // GpioControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 503);
            this.Controls.Add(this.grpSelectGpio);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GpioControlFrm";
            this.Text = "[SolderSplash Labs] GPIO Viewer";
            this.Load += new System.EventHandler(this.GpioControlFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSelectGpio.ResumeLayout(false);
            this.grpSelectGpio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listGpioList;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button ButRefresh;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox grpSelectGpio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EdtDirection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdtInitPortPins;
        private System.Windows.Forms.TextBox EdtInitDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdtPortPins;
        private System.Windows.Forms.Button ButApply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox EdtSelectedPort;
        private System.Windows.Forms.Button ButApplyInitChange;
        private System.Windows.Forms.Button ButGpioInitNow;
        private System.Windows.Forms.Label label5;
    }
}