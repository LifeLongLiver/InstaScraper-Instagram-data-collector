namespace Instagram_Email_Grabber
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.proxBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.emailCount = new System.Windows.Forms.Label();
            this.count1 = new System.Windows.Forms.Label();
            this.threadCountUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.countLBdisp = new System.Windows.Forms.Label();
            this.namesBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TriedCount = new System.Windows.Forms.Label();
            this.pLineLbl = new System.Windows.Forms.Label();
            this.uLineLbl = new System.Windows.Forms.Label();
            this.proxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.followCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.threadCountUD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // proxBtn
            // 
            this.proxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.proxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.proxBtn.Location = new System.Drawing.Point(6, 471);
            this.proxBtn.Name = "proxBtn";
            this.proxBtn.Size = new System.Drawing.Size(212, 99);
            this.proxBtn.TabIndex = 0;
            this.proxBtn.Text = "Proxies";
            this.proxBtn.UseVisualStyleBackColor = false;
            this.proxBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.startBtn.Location = new System.Drawing.Point(6, 156);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(212, 99);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.countLbl.Location = new System.Drawing.Point(59, 23);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(54, 20);
            this.countLbl.TabIndex = 10;
            this.countLbl.Text = "Tried:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(6, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 99);
            this.button1.TabIndex = 11;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // emailCount
            // 
            this.emailCount.AutoSize = true;
            this.emailCount.Location = new System.Drawing.Point(280, 4);
            this.emailCount.Name = "emailCount";
            this.emailCount.Size = new System.Drawing.Size(0, 13);
            this.emailCount.TabIndex = 13;
            // 
            // count1
            // 
            this.count1.AutoSize = true;
            this.count1.Location = new System.Drawing.Point(47, 345);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(0, 13);
            this.count1.TabIndex = 14;
            // 
            // threadCountUD
            // 
            this.threadCountUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.threadCountUD.Location = new System.Drawing.Point(59, 55);
            this.threadCountUD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.threadCountUD.Name = "threadCountUD";
            this.threadCountUD.Size = new System.Drawing.Size(86, 20);
            this.threadCountUD.TabIndex = 17;
            this.threadCountUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.threadCountUD.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(65, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Threads:";
            // 
            // countLBdisp
            // 
            this.countLBdisp.AutoSize = true;
            this.countLBdisp.Location = new System.Drawing.Point(90, 522);
            this.countLBdisp.Name = "countLBdisp";
            this.countLBdisp.Size = new System.Drawing.Size(0, 13);
            this.countLBdisp.TabIndex = 20;
            // 
            // namesBtn
            // 
            this.namesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.namesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.namesBtn.Location = new System.Drawing.Point(6, 366);
            this.namesBtn.Name = "namesBtn";
            this.namesBtn.Size = new System.Drawing.Size(212, 99);
            this.namesBtn.TabIndex = 7;
            this.namesBtn.Text = "Usernames";
            this.namesBtn.UseVisualStyleBackColor = false;
            this.namesBtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pLineLbl);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.uLineLbl);
            this.panel1.Controls.Add(this.namesBtn);
            this.panel1.Controls.Add(this.proxBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 654);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TriedCount);
            this.panel2.Controls.Add(this.countLbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.threadCountUD);
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 99);
            this.panel2.TabIndex = 13;
            // 
            // TriedCount
            // 
            this.TriedCount.AutoSize = true;
            this.TriedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.TriedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.TriedCount.Location = new System.Drawing.Point(120, 19);
            this.TriedCount.Name = "TriedCount";
            this.TriedCount.Size = new System.Drawing.Size(25, 26);
            this.TriedCount.TabIndex = 20;
            this.TriedCount.Text = "0";
            // 
            // pLineLbl
            // 
            this.pLineLbl.AutoSize = true;
            this.pLineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.pLineLbl.Location = new System.Drawing.Point(3, 614);
            this.pLineLbl.Name = "pLineLbl";
            this.pLineLbl.Size = new System.Drawing.Size(88, 13);
            this.pLineLbl.TabIndex = 25;
            this.pLineLbl.Text = "Imported Proxies:";
            // 
            // uLineLbl
            // 
            this.uLineLbl.AutoSize = true;
            this.uLineLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.uLineLbl.Location = new System.Drawing.Point(3, 589);
            this.uLineLbl.Name = "uLineLbl";
            this.uLineLbl.Size = new System.Drawing.Size(107, 13);
            this.uLineLbl.TabIndex = 24;
            this.uLineLbl.Text = "Imported Usernames:";
            // 
            // proxBox
            // 
            this.proxBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.proxBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proxBox.Location = new System.Drawing.Point(1124, 32);
            this.proxBox.Multiline = true;
            this.proxBox.Name = "proxBox";
            this.proxBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.proxBox.Size = new System.Drawing.Size(258, 614);
            this.proxBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(1133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Successful Proxies:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.Column1,
            this.FullName,
            this.Column2,
            this.Column4,
            this.followCell,
            this.Column5,
            this.BusCat});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(224, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(868, 650);
            this.dataGridView1.TabIndex = 27;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Username";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Followers";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // followCell
            // 
            this.followCell.HeaderText = "Following";
            this.followCell.Name = "followCell";
            this.followCell.Width = 96;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Is Business ";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // BusCat
            // 
            this.BusCat.HeaderText = "Business Category";
            this.BusCat.Name = "BusCat";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.checkBox1.Location = new System.Drawing.Point(67, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Enable Proxies";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1409, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proxBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.countLBdisp);
            this.Controls.Add(this.count1);
            this.Controls.Add(this.emailCount);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "InstaScraper";
            ((System.ComponentModel.ISupportInitialize)(this.threadCountUD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proxBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label emailCount;
        private System.Windows.Forms.Label count1;
        private System.Windows.Forms.NumericUpDown threadCountUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countLBdisp;
        private System.Windows.Forms.Button namesBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TriedCount;
        private System.Windows.Forms.TextBox proxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uLineLbl;
        private System.Windows.Forms.Label pLineLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn followCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusCat;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

