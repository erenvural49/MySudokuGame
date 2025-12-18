namespace SudokuSample
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            Block1Box1 = new TextBox();
            Block1Box2 = new TextBox();
            Block1Box3 = new TextBox();
            Block1Box4 = new TextBox();
            textBox3 = new TextBox();
            Blok1Box5 = new TextBox();
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
            tableLayoutPanel1.Controls.Add(textBox12, 3, 3);
            tableLayoutPanel1.Controls.Add(textBox11, 2, 3);
            tableLayoutPanel1.Controls.Add(textBox10, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox9, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox8, 3, 2);
            tableLayoutPanel1.Controls.Add(textBox7, 2, 2);
            tableLayoutPanel1.Controls.Add(textBox6, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox5, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(Block1Box1, 0, 0);
            tableLayoutPanel1.Controls.Add(Block1Box2, 1, 0);
            tableLayoutPanel1.Controls.Add(Block1Box3, 2, 0);
            tableLayoutPanel1.Controls.Add(Block1Box4, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(Blok1Box5, 2, 1);
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
            // textBox12
            // 
            textBox12.Location = new Point(219, 135);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(58, 27);
            textBox12.TabIndex = 15;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(147, 135);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(58, 27);
            textBox11.TabIndex = 14;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(75, 135);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(58, 27);
            textBox10.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(3, 135);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(58, 27);
            textBox9.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(219, 91);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(58, 27);
            textBox8.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(147, 91);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(58, 27);
            textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(75, 91);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(58, 27);
            textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 91);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(58, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(219, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(58, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(58, 27);
            textBox2.TabIndex = 5;
            // 
            // Block1Box1
            // 
            Block1Box1.Location = new Point(3, 3);
            Block1Box1.Name = "Block1Box1";
            Block1Box1.Size = new Size(56, 27);
            Block1Box1.TabIndex = 0;
            Block1Box1.TextChanged += Block1Box1_TextChanged;
            Block1Box1.KeyPress += Block1Box1_KeyPress;
            // 
            // Block1Box2
            // 
            Block1Box2.Location = new Point(75, 3);
            Block1Box2.Name = "Block1Box2";
            Block1Box2.Size = new Size(56, 27);
            Block1Box2.TabIndex = 1;
            // 
            // Block1Box3
            // 
            Block1Box3.Location = new Point(147, 3);
            Block1Box3.Name = "Block1Box3";
            Block1Box3.Size = new Size(56, 27);
            Block1Box3.TabIndex = 2;
            // 
            // Block1Box4
            // 
            Block1Box4.Location = new Point(219, 3);
            Block1Box4.Name = "Block1Box4";
            Block1Box4.Size = new Size(58, 27);
            Block1Box4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(58, 27);
            textBox3.TabIndex = 6;
            // 
            // Blok1Box5
            // 
            Blok1Box5.Location = new Point(147, 47);
            Blok1Box5.Name = "Blok1Box5";
            Blok1Box5.Size = new Size(58, 27);
            Blok1Box5.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox Block1Box1;
        private TextBox Block1Box2;
        private TextBox Block1Box3;
        private TextBox Block1Box4;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox Blok1Box5;
    }
}