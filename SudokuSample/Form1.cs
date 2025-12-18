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
        int[,] sudokuBoard = new int[4, 4];

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                if(c is TextBox && c.Name.StartsWith("Block"))
                {
                    TextBox tb = (TextBox) c;
                    tb.MaxLength = 1;
                    tb.KeyPress += GeneralBlock_KeyPress;

                }
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
            if(e.KeyChar < '1' || e.KeyChar > '4')
            {
                e.Handled = true;
                //I already handled don't write in the textBox.
            }
        }
    }
}
