using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Square_3x3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = 3;
            int[,] magicSquare = new int[size, size]; // Matrix size equals to 9 since 3*3
            int row = size / 2;
            int col = size - 1;

            for (int num = 1; num <= size * size;)
            {
                if (row == -1 && col == size)
                {
                    col = size - 2;
                    row = 0;
                }
                else
                {
                    if (col == size)
                    {
                        col = 0;
                    }
                    if (row < 0)
                    {
                        row = size - 1;
                    }
                }

                if (magicSquare[row, col] != 0)
                {
                    col -= 2;
                    row++;
                    continue;
                }
                else
                {
                    magicSquare[row, col] = num++;
                }
                col++;
                row--;
            }

            // Magic Square Matrix Print format
            for (row = 0; row < size; row++)
            {
                string currentRow = "";
                for (col = 0; col < size; col++)
                {
                    currentRow += magicSquare[row, col].ToString().PadLeft(4) + " ";
                }

                // Add the current row string to the ListBox
                listBox1.Items.Add(currentRow);
            }
        }

    }
}
