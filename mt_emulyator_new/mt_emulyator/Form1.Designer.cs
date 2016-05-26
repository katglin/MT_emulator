namespace mt_emulyator
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
            this.mtTable = new System.Windows.Forms.DataGridView();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a1n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a2n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountSteps = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Stop = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sw = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lent1 = new System.Windows.Forms.Panel();
            this.lent2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mtTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sw)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtTable
            // 
            this.mtTable.AllowUserToAddRows = false;
            this.mtTable.ColumnHeadersHeight = 24;
            this.mtTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.q,
            this.a1,
            this.a2,
            this.qn,
            this.a1n,
            this.a2n,
            this.V1,
            this.V2});
            this.mtTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.mtTable.Location = new System.Drawing.Point(278, 8);
            this.mtTable.Margin = new System.Windows.Forms.Padding(1);
            this.mtTable.Name = "mtTable";
            this.mtTable.RowHeadersWidth = 38;
            this.mtTable.RowTemplate.Height = 16;
            this.mtTable.Size = new System.Drawing.Size(297, 442);
            this.mtTable.TabIndex = 4;
            // 
            // q
            // 
            this.q.HeaderText = "q";
            this.q.MinimumWidth = 2;
            this.q.Name = "q";
            this.q.Width = 30;
            // 
            // a1
            // 
            this.a1.HeaderText = "a1";
            this.a1.MinimumWidth = 2;
            this.a1.Name = "a1";
            this.a1.Width = 30;
            // 
            // a2
            // 
            this.a2.HeaderText = "a2";
            this.a2.MinimumWidth = 2;
            this.a2.Name = "a2";
            this.a2.Width = 30;
            // 
            // qn
            // 
            this.qn.HeaderText = "qn";
            this.qn.MinimumWidth = 2;
            this.qn.Name = "qn";
            this.qn.Width = 30;
            // 
            // a1n
            // 
            this.a1n.HeaderText = "a1n";
            this.a1n.MinimumWidth = 2;
            this.a1n.Name = "a1n";
            this.a1n.Width = 30;
            // 
            // a2n
            // 
            this.a2n.HeaderText = "a2n";
            this.a2n.MinimumWidth = 2;
            this.a2n.Name = "a2n";
            this.a2n.Width = 30;
            // 
            // V1
            // 
            this.V1.HeaderText = "V1";
            this.V1.MinimumWidth = 2;
            this.V1.Name = "V1";
            this.V1.Width = 30;
            // 
            // V2
            // 
            this.V2.HeaderText = "V2";
            this.V2.MinimumWidth = 2;
            this.V2.Name = "V2";
            this.V2.Width = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "График";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(103, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите слово";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.Location = new System.Drawing.Point(8, 99);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(105, 134);
            this.listBox3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 427);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.CountSteps,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(586, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(228, 17);
            this.status.Text = "Ожидание начала работы программы...";
            // 
            // CountSteps
            // 
            this.CountSteps.Name = "CountSteps";
            this.CountSteps.Size = new System.Drawing.Size(321, 17);
            this.CountSteps.Spring = true;
            this.CountSteps.Text = "Выполнено шагов: 0";
            this.CountSteps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(4, 88);
            this.Stop.Margin = new System.Windows.Forms.Padding(2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(70, 23);
            this.Stop.TabIndex = 14;
            this.Stop.Text = "Прервать";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(77, 88);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Остановить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(8, 249);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(105, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Сохранить как...";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Скорость";
            // 
            // sw
            // 
            this.sw.LargeChange = 1;
            this.sw.Location = new System.Drawing.Point(26, 38);
            this.sw.Margin = new System.Windows.Forms.Padding(2);
            this.sw.Maximum = 4;
            this.sw.Name = "sw";
            this.sw.Size = new System.Drawing.Size(97, 45);
            this.sw.TabIndex = 12;
            this.sw.Scroll += new System.EventHandler(this.sw_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sw);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.Stop);
            this.groupBox2.Location = new System.Drawing.Point(117, 99);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(158, 134);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // lent1
            // 
            this.lent1.AllowDrop = true;
            this.lent1.AutoScroll = true;
            this.lent1.Location = new System.Drawing.Point(11, 313);
            this.lent1.Name = "lent1";
            this.lent1.Size = new System.Drawing.Size(257, 43);
            this.lent1.TabIndex = 18;
            // 
            // lent2
            // 
            this.lent2.AutoScroll = true;
            this.lent2.Location = new System.Drawing.Point(12, 372);
            this.lent2.Name = "lent2";
            this.lent2.Size = new System.Drawing.Size(256, 45);
            this.lent2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(586, 491);
            this.Controls.Add(this.lent2);
            this.Controls.Add(this.lent1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mtTable);
            this.Name = "Form1";
            this.Text = "MT_emulyator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mtTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sw)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView mtTable;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn a1;
        private System.Windows.Forms.DataGridViewTextBoxColumn a2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qn;
        private System.Windows.Forms.DataGridViewTextBoxColumn a1n;
        private System.Windows.Forms.DataGridViewTextBoxColumn a2n;
        private System.Windows.Forms.DataGridViewTextBoxColumn V1;
        private System.Windows.Forms.DataGridViewTextBoxColumn V2;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel status;
        public System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar sw;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ToolStripStatusLabel CountSteps;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Panel lent1;
        public System.Windows.Forms.Panel lent2;
    }
}

