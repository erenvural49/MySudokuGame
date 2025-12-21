namespace SudokuSample
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            tableLayoutPanel1 = new TableLayoutPanel();
            Block1Box1 = new TextBox();
            Block1Box2 = new TextBox();
            Block2Box1 = new TextBox();
            Block2Box2 = new TextBox();
            Block1Box3 = new TextBox();
            Block1Box4 = new TextBox();
            Block2Box3 = new TextBox();
            Block3Box1 = new TextBox();
            Block3Box2 = new TextBox();
            Block4Box1 = new TextBox();
            Block4Box2 = new TextBox();
            Block3Box3 = new TextBox();
            Block3Box4 = new TextBox();
            Block4Box3 = new TextBox();
            Block4Box4 = new TextBox();
            Block2Box4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Block1Box1, 0, 0);
            tableLayoutPanel1.Controls.Add(Block1Box2, 1, 0);
            tableLayoutPanel1.Controls.Add(Block2Box1, 2, 0);
            tableLayoutPanel1.Controls.Add(Block2Box2, 3, 0);
            tableLayoutPanel1.Controls.Add(Block1Box3, 0, 1);
            tableLayoutPanel1.Controls.Add(Block1Box4, 1, 1);
            tableLayoutPanel1.Controls.Add(Block2Box3, 2, 1);
            tableLayoutPanel1.Controls.Add(Block3Box1, 0, 2);
            tableLayoutPanel1.Controls.Add(Block3Box2, 1, 2);
            tableLayoutPanel1.Controls.Add(Block4Box1, 2, 2);
            tableLayoutPanel1.Controls.Add(Block4Box2, 3, 2);
            tableLayoutPanel1.Controls.Add(Block3Box3, 0, 3);
            tableLayoutPanel1.Controls.Add(Block3Box4, 1, 3);
            tableLayoutPanel1.Controls.Add(Block4Box3, 2, 3);
            tableLayoutPanel1.Controls.Add(Block4Box4, 3, 3);
            tableLayoutPanel1.Controls.Add(Block2Box4, 3, 1);
            tableLayoutPanel1.Location = new Point(358, 113);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(288, 178);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Block1Box1
            // 
            Block1Box1.BackColor = SystemColors.Window;
            Block1Box1.Location = new Point(3, 3);
            Block1Box1.Name = "Block1Box1";
            Block1Box1.Size = new Size(66, 27);
            Block1Box1.TabIndex = 0;
            Block1Box1.Text = "1";
            Block1Box1.TextAlign = HorizontalAlignment.Center;
            Block1Box1.TextChanged += Block1Box1_TextChanged_1;
            Block1Box1.KeyPress += GeneralBlock_KeyPress;
            // 
            // Block1Box2
            // 
            Block1Box2.BackColor = SystemColors.Window;
            Block1Box2.Location = new Point(75, 3);
            Block1Box2.Name = "Block1Box2";
            Block1Box2.Size = new Size(66, 27);
            Block1Box2.TabIndex = 1;
            // 
            // Block2Box1
            // 
            Block2Box1.BackColor = SystemColors.Window;
            Block2Box1.Location = new Point(147, 3);
            Block2Box1.Name = "Block2Box1";
            Block2Box1.Size = new Size(66, 27);
            Block2Box1.TabIndex = 2;
            Block2Box1.Text = "3";
            Block2Box1.TextAlign = HorizontalAlignment.Center;
            // 
            // Block2Box2
            // 
            Block2Box2.BackColor = SystemColors.Window;
            Block2Box2.Location = new Point(219, 3);
            Block2Box2.Name = "Block2Box2";
            Block2Box2.Size = new Size(66, 27);
            Block2Box2.TabIndex = 3;
            // 
            // Block1Box3
            // 
            Block1Box3.Location = new Point(3, 47);
            Block1Box3.Name = "Block1Box3";
            Block1Box3.Size = new Size(66, 27);
            Block1Box3.TabIndex = 4;
            // 
            // Block1Box4
            // 
            Block1Box4.Location = new Point(75, 47);
            Block1Box4.Name = "Block1Box4";
            Block1Box4.Size = new Size(66, 27);
            Block1Box4.TabIndex = 5;
            // 
            // Block2Box3
            // 
            Block2Box3.BackColor = SystemColors.Window;
            Block2Box3.Location = new Point(147, 47);
            Block2Box3.Name = "Block2Box3";
            Block2Box3.Size = new Size(66, 27);
            Block2Box3.TabIndex = 6;
            // 
            // Block3Box1
            // 
            Block3Box1.BackColor = SystemColors.Window;
            Block3Box1.Location = new Point(3, 91);
            Block3Box1.Name = "Block3Box1";
            Block3Box1.Size = new Size(66, 27);
            Block3Box1.TabIndex = 8;
            Block3Box1.Text = "4";
            Block3Box1.TextAlign = HorizontalAlignment.Center;
            // 
            // Block3Box2
            // 
            Block3Box2.BackColor = SystemColors.Window;
            Block3Box2.Location = new Point(75, 91);
            Block3Box2.Name = "Block3Box2";
            Block3Box2.Size = new Size(66, 27);
            Block3Box2.TabIndex = 9;
            // 
            // Block4Box1
            // 
            Block4Box1.Location = new Point(147, 91);
            Block4Box1.Name = "Block4Box1";
            Block4Box1.Size = new Size(66, 27);
            Block4Box1.TabIndex = 10;
            // 
            // Block4Box2
            // 
            Block4Box2.Location = new Point(219, 91);
            Block4Box2.Name = "Block4Box2";
            Block4Box2.Size = new Size(66, 27);
            Block4Box2.TabIndex = 11;
            // 
            // Block3Box3
            // 
            Block3Box3.BackColor = SystemColors.Window;
            Block3Box3.Location = new Point(3, 135);
            Block3Box3.Name = "Block3Box3";
            Block3Box3.Size = new Size(66, 27);
            Block3Box3.TabIndex = 12;
            // 
            // Block3Box4
            // 
            Block3Box4.BackColor = SystemColors.Window;
            Block3Box4.Location = new Point(75, 135);
            Block3Box4.Name = "Block3Box4";
            Block3Box4.Size = new Size(66, 27);
            Block3Box4.TabIndex = 13;
            Block3Box4.Text = "1";
            Block3Box4.TextAlign = HorizontalAlignment.Center;
            // 
            // Block4Box3
            // 
            Block4Box3.Location = new Point(147, 135);
            Block4Box3.Name = "Block4Box3";
            Block4Box3.Size = new Size(66, 27);
            Block4Box3.TabIndex = 14;
            // 
            // Block4Box4
            // 
            Block4Box4.Location = new Point(219, 135);
            Block4Box4.Name = "Block4Box4";
            Block4Box4.Size = new Size(66, 27);
            Block4Box4.TabIndex = 15;
            Block4Box4.Text = "3";
            Block4Box4.TextAlign = HorizontalAlignment.Center;
            // 
            // Block2Box4
            // 
            Block2Box4.BackColor = SystemColors.Window;
            Block2Box4.Location = new Point(219, 47);
            Block2Box4.Name = "Block2Box4";
            Block2Box4.Size = new Size(66, 27);
            Block2Box4.TabIndex = 7;
            Block2Box4.Text = "2";
            Block2Box4.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Location = new Point(126, 117);
            button1.Name = "button1";
            button1.Size = new Size(138, 53);
            button1.TabIndex = 1;
            button1.Text = "Check Solution";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Location = new Point(126, 238);
            button3.Name = "button3";
            button3.Size = new Size(138, 53);
            button3.TabIndex = 2;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Sudoku Sample";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox Block1Box1;
        private TextBox Block1Box2;
        private TextBox Block2Box1;
        private TextBox Block2Box2;
        private TextBox Block1Box3;
        private TextBox Block1Box4;
        private TextBox Block2Box3;
        private TextBox Block2Box4;
        private TextBox Block3Box1;
        private TextBox Block3Box2;
        private TextBox Block4Box1;
        private TextBox Block4Box2;
        private TextBox Block3Box3;
        private TextBox Block3Box4;
        private TextBox Block4Box3;
        private TextBox Block4Box4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}