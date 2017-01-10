namespace BackJack
{
    partial class BlackJackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBoxTable = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handShuffeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineShuffeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStay = new System.Windows.Forms.Button();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.buttonDouble = new System.Windows.Forms.Button();
            this.buttonBox0 = new System.Windows.Forms.Button();
            this.buttonBox1 = new System.Windows.Forms.Button();
            this.buttonBox2 = new System.Windows.Forms.Button();
            this.buttonBox3 = new System.Windows.Forms.Button();
            this.buttonBox4 = new System.Windows.Forms.Button();
            this.groupBoxBid = new System.Windows.Forms.GroupBox();
            this.button100 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBidOK = new System.Windows.Forms.Button();
            this.textBoxBid = new System.Windows.Forms.TextBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.groupBoxBuyIn = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuyIn = new System.Windows.Forms.TextBox();
            this.buttonBuyInOK = new System.Windows.Forms.Button();
            this.textBoxBidArea0 = new System.Windows.Forms.TextBox();
            this.textBoxBidArea1 = new System.Windows.Forms.TextBox();
            this.textBoxBidArea2 = new System.Windows.Forms.TextBox();
            this.textBoxBidArea3 = new System.Windows.Forms.TextBox();
            this.textBoxBidArea4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countingFaceCardbox = new System.Windows.Forms.TextBox();
            this.countingBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountingValueBox = new System.Windows.Forms.TextBox();
            this.countingCardLeftBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxBid.SuspendLayout();
            this.groupBoxBuyIn.SuspendLayout();
            this.countingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(536, 629);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(92, 38);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // pictureBoxTable
            // 
            this.pictureBoxTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTable.Image = global::BackJack.Properties.Resources.table;
            this.pictureBoxTable.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxTable.Name = "pictureBoxTable";
            this.pictureBoxTable.Size = new System.Drawing.Size(1024, 596);
            this.pictureBoxTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTable.TabIndex = 2;
            this.pictureBoxTable.TabStop = false;
            this.pictureBoxTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTable_Paint);
            this.pictureBoxTable.MouseEnter += new System.EventHandler(this.pictureBoxTable_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.buttonBuyInOK_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handShuffeToolStripMenuItem,
            this.machineShuffeToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // handShuffeToolStripMenuItem
            // 
            this.handShuffeToolStripMenuItem.CheckOnClick = true;
            this.handShuffeToolStripMenuItem.Name = "handShuffeToolStripMenuItem";
            this.handShuffeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.handShuffeToolStripMenuItem.Text = "Manual Shuffle";
            this.handShuffeToolStripMenuItem.Click += new System.EventHandler(this.handShuffeToolStripMenuItem_Click);
            // 
            // machineShuffeToolStripMenuItem
            // 
            this.machineShuffeToolStripMenuItem.CheckOnClick = true;
            this.machineShuffeToolStripMenuItem.Name = "machineShuffeToolStripMenuItem";
            this.machineShuffeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.machineShuffeToolStripMenuItem.Text = "Machine Shuffle";
            this.machineShuffeToolStripMenuItem.Click += new System.EventHandler(this.machineShuffeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(536, 629);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(92, 38);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTable_Paint);
            // 
            // textBox0
            // 
            this.textBox0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox0.Enabled = false;
            this.textBox0.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox0.Location = new System.Drawing.Point(880, 425);
            this.textBox0.Name = "textBox0";
            this.textBox0.ReadOnly = true;
            this.textBox0.Size = new System.Drawing.Size(110, 19);
            this.textBox0.TabIndex = 0;
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(704, 549);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 19);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(464, 591);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(110, 19);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(233, 549);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(110, 19);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(87, 437);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(110, 19);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Location = new System.Drawing.Point(496, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(50, 19);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonHit
            // 
            this.buttonHit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHit.Location = new System.Drawing.Point(0, 15);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(38, 23);
            this.buttonHit.TabIndex = 16;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // buttonStay
            // 
            this.buttonStay.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStay.Location = new System.Drawing.Point(40, 15);
            this.buttonStay.Name = "buttonStay";
            this.buttonStay.Size = new System.Drawing.Size(37, 23);
            this.buttonStay.TabIndex = 17;
            this.buttonStay.Text = "Stay";
            this.buttonStay.UseVisualStyleBackColor = false;
            this.buttonStay.Click += new System.EventHandler(this.buttonStay_Click);
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Enabled = false;
            this.textBoxMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoney.Location = new System.Drawing.Point(435, 629);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(95, 38);
            this.textBoxMoney.TabIndex = 18;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOptions.Controls.Add(this.buttonSplit);
            this.groupBoxOptions.Controls.Add(this.buttonDouble);
            this.groupBoxOptions.Controls.Add(this.buttonHit);
            this.groupBoxOptions.Controls.Add(this.buttonStay);
            this.groupBoxOptions.Location = new System.Drawing.Point(343, 186);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(79, 70);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // buttonSplit
            // 
            this.buttonSplit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSplit.Location = new System.Drawing.Point(40, 44);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(37, 23);
            this.buttonSplit.TabIndex = 19;
            this.buttonSplit.Text = "Split";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // buttonDouble
            // 
            this.buttonDouble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDouble.Location = new System.Drawing.Point(0, 44);
            this.buttonDouble.Name = "buttonDouble";
            this.buttonDouble.Size = new System.Drawing.Size(38, 23);
            this.buttonDouble.TabIndex = 19;
            this.buttonDouble.Text = "Double";
            this.buttonDouble.UseVisualStyleBackColor = true;
            this.buttonDouble.Click += new System.EventHandler(this.buttonDouble_Click);
            // 
            // buttonBox0
            // 
            this.buttonBox0.Location = new System.Drawing.Point(912, 339);
            this.buttonBox0.Name = "buttonBox0";
            this.buttonBox0.Size = new System.Drawing.Size(50, 23);
            this.buttonBox0.TabIndex = 0;
            this.buttonBox0.Text = "Bid";
            this.buttonBox0.UseVisualStyleBackColor = true;
            this.buttonBox0.Click += new System.EventHandler(this.buttonBox0_Click);
            // 
            // buttonBox1
            // 
            this.buttonBox1.Location = new System.Drawing.Point(736, 457);
            this.buttonBox1.Name = "buttonBox1";
            this.buttonBox1.Size = new System.Drawing.Size(50, 23);
            this.buttonBox1.TabIndex = 0;
            this.buttonBox1.Text = "Bid";
            this.buttonBox1.UseVisualStyleBackColor = true;
            this.buttonBox1.Click += new System.EventHandler(this.buttonBox1_Click);
            // 
            // buttonBox2
            // 
            this.buttonBox2.Location = new System.Drawing.Point(496, 504);
            this.buttonBox2.Name = "buttonBox2";
            this.buttonBox2.Size = new System.Drawing.Size(50, 23);
            this.buttonBox2.TabIndex = 0;
            this.buttonBox2.Text = "Bid";
            this.buttonBox2.UseVisualStyleBackColor = true;
            this.buttonBox2.Click += new System.EventHandler(this.buttonBox2_Click);
            // 
            // buttonBox3
            // 
            this.buttonBox3.Location = new System.Drawing.Point(265, 457);
            this.buttonBox3.Name = "buttonBox3";
            this.buttonBox3.Size = new System.Drawing.Size(50, 23);
            this.buttonBox3.TabIndex = 0;
            this.buttonBox3.Text = "Bid";
            this.buttonBox3.UseVisualStyleBackColor = true;
            this.buttonBox3.Click += new System.EventHandler(this.buttonBox3_Click);
            // 
            // buttonBox4
            // 
            this.buttonBox4.Location = new System.Drawing.Point(119, 351);
            this.buttonBox4.Name = "buttonBox4";
            this.buttonBox4.Size = new System.Drawing.Size(50, 23);
            this.buttonBox4.TabIndex = 0;
            this.buttonBox4.Text = "Bid";
            this.buttonBox4.UseVisualStyleBackColor = true;
            this.buttonBox4.Click += new System.EventHandler(this.buttonBox4_Click);
            // 
            // groupBoxBid
            // 
            this.groupBoxBid.Controls.Add(this.button100);
            this.groupBoxBid.Controls.Add(this.button25);
            this.groupBoxBid.Controls.Add(this.button10);
            this.groupBoxBid.Controls.Add(this.buttonCancel);
            this.groupBoxBid.Controls.Add(this.buttonReset);
            this.groupBoxBid.Controls.Add(this.buttonBidOK);
            this.groupBoxBid.Controls.Add(this.textBoxBid);
            this.groupBoxBid.Controls.Add(this.labelMoney);
            this.groupBoxBid.Location = new System.Drawing.Point(649, 205);
            this.groupBoxBid.Name = "groupBoxBid";
            this.groupBoxBid.Size = new System.Drawing.Size(112, 81);
            this.groupBoxBid.TabIndex = 0;
            this.groupBoxBid.TabStop = false;
            this.groupBoxBid.Text = "Bet";
            // 
            // button100
            // 
            this.button100.Location = new System.Drawing.Point(73, 58);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(39, 23);
            this.button100.TabIndex = 0;
            this.button100.Text = "$100";
            this.button100.UseVisualStyleBackColor = true;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(36, 58);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(37, 23);
            this.button25.TabIndex = 6;
            this.button25.Text = "$25";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, 58);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(37, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "$10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(58, 36);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(54, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonBidCancel_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1, 36);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(58, 23);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonBidOK
            // 
            this.buttonBidOK.Location = new System.Drawing.Point(70, 14);
            this.buttonBidOK.Name = "buttonBidOK";
            this.buttonBidOK.Size = new System.Drawing.Size(42, 23);
            this.buttonBidOK.TabIndex = 0;
            this.buttonBidOK.Text = "OK";
            this.buttonBidOK.UseVisualStyleBackColor = true;
            this.buttonBidOK.Click += new System.EventHandler(this.buttonBidOk_Click);
            // 
            // textBoxBid
            // 
            this.textBoxBid.Enabled = false;
            this.textBoxBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBid.Location = new System.Drawing.Point(24, 14);
            this.textBoxBid.Name = "textBoxBid";
            this.textBoxBid.ReadOnly = true;
            this.textBoxBid.Size = new System.Drawing.Size(42, 22);
            this.textBoxBid.TabIndex = 0;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(6, 17);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(15, 16);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "$";
            // 
            // groupBoxBuyIn
            // 
            this.groupBoxBuyIn.Controls.Add(this.label1);
            this.groupBoxBuyIn.Controls.Add(this.textBoxBuyIn);
            this.groupBoxBuyIn.Controls.Add(this.buttonBuyInOK);
            this.groupBoxBuyIn.Location = new System.Drawing.Point(461, 162);
            this.groupBoxBuyIn.Name = "groupBoxBuyIn";
            this.groupBoxBuyIn.Size = new System.Drawing.Size(143, 94);
            this.groupBoxBuyIn.TabIndex = 19;
            this.groupBoxBuyIn.TabStop = false;
            this.groupBoxBuyIn.Text = "BuyIn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "$";
            // 
            // textBoxBuyIn
            // 
            this.textBoxBuyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuyIn.Location = new System.Drawing.Point(49, 24);
            this.textBoxBuyIn.Name = "textBoxBuyIn";
            this.textBoxBuyIn.Size = new System.Drawing.Size(59, 26);
            this.textBoxBuyIn.TabIndex = 1;
            this.textBoxBuyIn.Text = "1000";
            // 
            // buttonBuyInOK
            // 
            this.buttonBuyInOK.Location = new System.Drawing.Point(32, 58);
            this.buttonBuyInOK.Name = "buttonBuyInOK";
            this.buttonBuyInOK.Size = new System.Drawing.Size(75, 23);
            this.buttonBuyInOK.TabIndex = 0;
            this.buttonBuyInOK.Text = "OK";
            this.buttonBuyInOK.UseVisualStyleBackColor = true;
            this.buttonBuyInOK.Click += new System.EventHandler(this.buttonBuyInOK_Click);
            // 
            // textBoxBidArea0
            // 
            this.textBoxBidArea0.Enabled = false;
            this.textBoxBidArea0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBidArea0.Location = new System.Drawing.Point(858, 398);
            this.textBoxBidArea0.Name = "textBoxBidArea0";
            this.textBoxBidArea0.ReadOnly = true;
            this.textBoxBidArea0.Size = new System.Drawing.Size(150, 21);
            this.textBoxBidArea0.TabIndex = 0;
            this.textBoxBidArea0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBidArea1
            // 
            this.textBoxBidArea1.Enabled = false;
            this.textBoxBidArea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBidArea1.Location = new System.Drawing.Point(683, 522);
            this.textBoxBidArea1.Name = "textBoxBidArea1";
            this.textBoxBidArea1.ReadOnly = true;
            this.textBoxBidArea1.Size = new System.Drawing.Size(150, 21);
            this.textBoxBidArea1.TabIndex = 20;
            this.textBoxBidArea1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBidArea2
            // 
            this.textBoxBidArea2.Enabled = false;
            this.textBoxBidArea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBidArea2.Location = new System.Drawing.Point(443, 564);
            this.textBoxBidArea2.Name = "textBoxBidArea2";
            this.textBoxBidArea2.ReadOnly = true;
            this.textBoxBidArea2.Size = new System.Drawing.Size(150, 21);
            this.textBoxBidArea2.TabIndex = 21;
            this.textBoxBidArea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBidArea3
            // 
            this.textBoxBidArea3.Enabled = false;
            this.textBoxBidArea3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBidArea3.Location = new System.Drawing.Point(212, 522);
            this.textBoxBidArea3.Name = "textBoxBidArea3";
            this.textBoxBidArea3.ReadOnly = true;
            this.textBoxBidArea3.Size = new System.Drawing.Size(150, 21);
            this.textBoxBidArea3.TabIndex = 22;
            this.textBoxBidArea3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBidArea4
            // 
            this.textBoxBidArea4.Enabled = false;
            this.textBoxBidArea4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBidArea4.Location = new System.Drawing.Point(67, 410);
            this.textBoxBidArea4.Name = "textBoxBidArea4";
            this.textBoxBidArea4.ReadOnly = true;
            this.textBoxBidArea4.Size = new System.Drawing.Size(150, 21);
            this.textBoxBidArea4.TabIndex = 23;
            this.textBoxBidArea4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(401, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "$";
            // 
            // countingFaceCardbox
            // 
            this.countingFaceCardbox.Enabled = false;
            this.countingFaceCardbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countingFaceCardbox.Location = new System.Drawing.Point(94, 45);
            this.countingFaceCardbox.Name = "countingFaceCardbox";
            this.countingFaceCardbox.ReadOnly = true;
            this.countingFaceCardbox.Size = new System.Drawing.Size(56, 21);
            this.countingFaceCardbox.TabIndex = 25;
            this.countingFaceCardbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countingBox
            // 
            this.countingBox.Controls.Add(this.label5);
            this.countingBox.Controls.Add(this.countingCardLeftBox);
            this.countingBox.Controls.Add(this.CountingValueBox);
            this.countingBox.Controls.Add(this.label4);
            this.countingBox.Controls.Add(this.label3);
            this.countingBox.Controls.Add(this.countingFaceCardbox);
            this.countingBox.Location = new System.Drawing.Point(68, 72);
            this.countingBox.Name = "countingBox";
            this.countingBox.Size = new System.Drawing.Size(161, 100);
            this.countingBox.TabIndex = 26;
            this.countingBox.TabStop = false;
            this.countingBox.Text = "Card Counting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "High rank card %";
            // 
            // CountingValueBox
            // 
            this.CountingValueBox.Enabled = false;
            this.CountingValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountingValueBox.Location = new System.Drawing.Point(94, 17);
            this.CountingValueBox.Name = "CountingValueBox";
            this.CountingValueBox.ReadOnly = true;
            this.CountingValueBox.Size = new System.Drawing.Size(56, 21);
            this.CountingValueBox.TabIndex = 28;
            this.CountingValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countingCardLeftBox
            // 
            this.countingCardLeftBox.Enabled = false;
            this.countingCardLeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countingCardLeftBox.Location = new System.Drawing.Point(94, 73);
            this.countingCardLeftBox.Name = "countingCardLeftBox";
            this.countingCardLeftBox.ReadOnly = true;
            this.countingCardLeftBox.Size = new System.Drawing.Size(56, 21);
            this.countingCardLeftBox.TabIndex = 29;
            this.countingCardLeftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Card left";
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1046, 692);
            this.Controls.Add(this.countingBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBidArea4);
            this.Controls.Add(this.textBoxBidArea3);
            this.Controls.Add(this.textBoxBidArea2);
            this.Controls.Add(this.textBoxBidArea1);
            this.Controls.Add(this.textBoxBidArea0);
            this.Controls.Add(this.groupBoxBuyIn);
            this.Controls.Add(this.groupBoxBid);
            this.Controls.Add(this.buttonBox4);
            this.Controls.Add(this.buttonBox3);
            this.Controls.Add(this.buttonBox2);
            this.Controls.Add(this.buttonBox1);
            this.Controls.Add(this.buttonBox0);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxTable);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1056, 724);
            this.Name = "BlackJackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BlackJack -- BETA 0.11";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxBid.ResumeLayout(false);
            this.groupBoxBid.PerformLayout();
            this.groupBoxBuyIn.ResumeLayout(false);
            this.groupBoxBuyIn.PerformLayout();
            this.countingBox.ResumeLayout(false);
            this.countingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTable;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStay;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button buttonDouble;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.Button buttonBox0;
        private System.Windows.Forms.Button buttonBox1;
        private System.Windows.Forms.Button buttonBox2;
        private System.Windows.Forms.Button buttonBox3;
        private System.Windows.Forms.Button buttonBox4;
        private System.Windows.Forms.GroupBox groupBoxBid;
        private System.Windows.Forms.Button buttonBidOK;
        private System.Windows.Forms.TextBox textBoxBid;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxBuyIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuyIn;
        private System.Windows.Forms.Button buttonBuyInOK;
        private System.Windows.Forms.TextBox textBoxBidArea0;
        private System.Windows.Forms.TextBox textBoxBidArea1;
        private System.Windows.Forms.TextBox textBoxBidArea2;
        private System.Windows.Forms.TextBox textBoxBidArea3;
        private System.Windows.Forms.TextBox textBoxBidArea4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handShuffeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineShuffeToolStripMenuItem;
        private System.Windows.Forms.TextBox countingFaceCardbox;
        private System.Windows.Forms.GroupBox countingBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countingCardLeftBox;
        private System.Windows.Forms.TextBox CountingValueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

