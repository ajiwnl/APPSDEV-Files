using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Square
{
    public partial class MagicSquare : Form
    {
        public MagicSquare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;

            //try-Catch for input validation
            try
            {
                //method call with one parameter
                Input(out n);
                if (n % 2 == 0)
                {
                    MessageBox.Show("The size of the magic square must be odd.");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            //method call with one parameter
            int[,] square = GenerateMagicSquare(ref n);

            //method call with two parameters parameter
            Display(n, square);
        }

        /// <summary>
        /// Programmer defined method that accepts the value of the input with exeception handling
        /// for text input
        /// </summary>
        /// <param name="n"></param>
        private void Input(out int n )
        {
            //User input validation 
                if (!int.TryParse(InputTxtBox.Text, out n))
                {
                    throw new Exception("Enter a valid number");
                }
                if (n <= 0)
                {

                throw new Exception("The input must be a positive integer.");
                
                }
        }

        /// <summary>
        /// PRogramming defined method for generating the rows and columns for the magic square
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int[,] GenerateMagicSquare( ref int n)
        {
            // create a 2D array to store the magic square
            int[,] square = new int[n, n];

            // initialize the starting row and column index
            int row = n - 1;
            int col = n / 2;

            // loop through each number to place in the square
            for (int i = 1; i <= n * n; i++)
            {
                // place for the current number in the position
                square[row, col] = i;

                // calculate the next row and column index
                int nextRow = (row + 1) % n;
                int nextCol = (col + 1) % n;

                // check if the next position is already filled
                if (square[nextRow, nextCol] != 0)
                {
                    // move to the position above the current position
                    row = (row - 1 + n) % n;
                }
                else
                {
                    // move to the next position
                    row = nextRow;
                    col = nextCol;
                }
            }

            return square;
        }

        /// <summary>
        /// Programmer defined method for Displaying the output using listbox
        /// </summary>
        /// <param name="n"></param>
        /// <param name="square"></param>
        private void Display(int n, int[,] square)
        {
            // clear the listbox every after display button is hit
            OutListBox.Items.Clear();

            // loop through each row of the magic square
            for (int i = 0; i < n; i++)
            {
                string rowStr = "";

                // loop each column of the current row
                for (int j = 0; j < n; j++)
                {
                    // adding  the value at the current position of the row
                    rowStr += square[i, j].ToString().PadLeft(7).PadRight(2) + " ";
                }

                // add the current row string to the listbox
                OutListBox.Items.Add(rowStr);
            }
        }
    }
}
