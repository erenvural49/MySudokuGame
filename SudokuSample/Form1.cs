using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SudokuSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] sudokuTable = new int[4, 4];
        HashSet<int> numbers = new HashSet<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is TextBox tb && c.Name.StartsWith("Block"))
                {
                    tb.KeyPress += GeneralBlock_KeyPress;
                    tb.MaxLength = 1;
                }
            }

            Block1Box1.ReadOnly = true;
            Block2Box1.ReadOnly = true;
            Block2Box4.ReadOnly = true;
            Block3Box1.ReadOnly = true;
            Block3Box4.ReadOnly = true;
            Block4Box4.ReadOnly = true;

            Block1Box1.BackColor = Color.LightGray;
            Block2Box1.BackColor = Color.LightGray;
            Block2Box4.BackColor = Color.LightGray;
            Block3Box1.BackColor = Color.LightGray;
            Block3Box4.BackColor = Color.LightGray;
            Block4Box4.BackColor = Color.LightGray;
        }
        private Boolean IsValidSudokuTable()
        {
            try
            {
                sudokuTable[0, 0] = Convert.ToInt32(Block1Box1.Text);
                sudokuTable[0, 1] = Convert.ToInt32(Block1Box2.Text);
                sudokuTable[0, 2] = Convert.ToInt32(Block2Box1.Text);
                sudokuTable[0, 3] = Convert.ToInt32(Block2Box2.Text);


                sudokuTable[1, 0] = Convert.ToInt32(Block1Box3.Text);
                sudokuTable[1, 1] = Convert.ToInt32(Block1Box4.Text);
                sudokuTable[1, 2] = Convert.ToInt32(Block2Box3.Text);
                sudokuTable[1, 3] = Convert.ToInt32(Block2Box4.Text);

                sudokuTable[2, 0] = Convert.ToInt32(Block3Box1.Text);
                sudokuTable[2, 1] = Convert.ToInt32(Block3Box2.Text);
                sudokuTable[2, 2] = Convert.ToInt32(Block4Box1.Text);
                sudokuTable[2, 3] = Convert.ToInt32(Block4Box2.Text);

                sudokuTable[3, 0] = Convert.ToInt32(Block3Box3.Text);
                sudokuTable[3, 1] = Convert.ToInt32(Block3Box4.Text);
                sudokuTable[3, 2] = Convert.ToInt32(Block4Box3.Text);
                sudokuTable[3, 3] = Convert.ToInt32(Block4Box4.Text);
            }
            catch
            {
                MessageBox.Show("You should write between 1-4 number to a box.");
                return false;
            }

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    numbers.Add(sudokuTable[row, col]);
                }
                if (numbers.Count != 4)
                {
                    for (int col = 0; col < 4; col++)
                        ChangeColorRow(col, row);

                    return false;

                }
                numbers.Clear();
            }

            for (int col = 0; col < 4; col++)
            {
                for (int row = 0; row < 4; row++)
                {
                    numbers.Add(sudokuTable[row, col]);
                }
                if (numbers.Count != 4)
                {
                    for (int row = 0; row < 4; row++)
                        ChangeColorRow(col, row);
                    return false;
                }
                numbers.Clear();
            }

            numbers.Add(sudokuTable[0, 0]);
            numbers.Add(sudokuTable[0, 1]);
            numbers.Add(sudokuTable[1, 0]);
            numbers.Add(sudokuTable[1, 1]);
            if (numbers.Count != 4)
                return false;

            numbers.Clear();

            numbers.Add(sudokuTable[0, 2]);
            numbers.Add(sudokuTable[0, 3]);
            numbers.Add(sudokuTable[1, 2]);
            numbers.Add(sudokuTable[1, 3]);

            if (numbers.Count != 4)
                return false;

            numbers.Clear();

            numbers.Add(sudokuTable[2, 0]);
            numbers.Add(sudokuTable[2, 1]);
            numbers.Add(sudokuTable[3, 0]);
            numbers.Add(sudokuTable[3, 1]);

            if (numbers.Count != 4)
                return false;

            numbers.Clear();

            numbers.Add(sudokuTable[2, 2]);
            numbers.Add(sudokuTable[2, 3]);
            numbers.Add(sudokuTable[3, 2]);
            numbers.Add(sudokuTable[3, 3]);

            if (numbers.Count != 4)
                return false;

            return true;

        }
        private void ChangeColorRow(int col, int row)
        {
            Control c = tableLayoutPanel1.GetControlFromPosition(col, row);
            if (c is TextBox)
            {
                TextBox tb = (TextBox)c;
                c.BackColor = Color.LightGray;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Block1Box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GeneralBlock_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Delete number is allowed
            if (char.IsControl(e.KeyChar))
            {
                return;   // e.keyChar exp: 'A'
            }

            // except between 1-4 others can't write in textBox
            if (e.KeyChar < '1' || e.KeyChar > '4')
            {
                e.Handled = true;
                //I already handled don't write in the textBox.
            }
        }

        private void Block1Box1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsValidSudokuTable())
            {
                foreach(Control c in tableLayoutPanel1.Controls)
                {
                    if(c is TextBox tb && !tb.ReadOnly)
                    {
                        c.BackColor = SystemColors.Window;
                    }
                }
                MessageBox.Show("YOU ACED.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                if(c is TextBox tb && !tb.ReadOnly)
                {
                    tb.Text = string.Empty;
                    tb.BackColor = SystemColors.Window;
                }
            }
        }
    }
}
