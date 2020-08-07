/* Brie Prater
 * 07/31/2020
 * CIS 353
 * Professor Cain
 * Assignment 9.2 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9_Prater
{
    public partial class Form1 : Form // instatiates the form
    {
        int[] rand1 = new int[100]; // instantiates array with 100 indexes
        int[] rand2 = new int[100]; // instantiates array with 100 indexes
        bool one; // used to determine if the guess was correct
        int right = 0; // variable to count correct guesses
        int wrong = 0; // variable to count incorrect guesses
        int iteration = 0; // variable to count iterations and used as index for arrays 
        Random rando = new Random(); // instatiates Random function
 
        public Form1() // initializes form
        {
            InitializeComponent();
        }

        private void createArray() // method to populate arrays
        {
            for (int x = 0; x < 100; x++) // for loop to fill 100 indexes
            {
                rand1[x] = rando.Next(0, 100); // fills each index with a random number
                rand2[x] = rando.Next(0, 100); 
            }
        }
        private void compareNum(int[] rand1, int[] rand2, int iteration) // method to compare which number is higher
            // passes arrays and iteration to method
        {
            if (rand1[iteration] > rand2[iteration]) // boolean to determine which array has a higher number at index of iteration
            {
                this.num1.Visible = true; // displays num1 label if it is higher
                this.num1.Text = rand1[iteration].ToString(); // sets label text to the number at the index
                this.num2.Visible = false; // hides num2 label
                one = true; // set to true for num1 being higher
                 
            }
            else if (rand2[iteration] > rand1[iteration]) // boolean to determine which array has a higher number at index of iteration
            {
                this.num2.Visible = true; // displays num2 label if it is higher
                this.num2.Text = rand2[iteration].ToString(); // sets label text to the number at the index
                this.num1.Visible = false; // hides num1 label
                one = false; // set to false for num2 being higher

            }
            else
            {
                this.num1.Text = rand1[iteration].ToString(); // displays both labels if the numbers are equal
                this.num2.Text = rand2[iteration].ToString();
            }
        }

        private void clickedIt() // method to disable buttons
        {
            guessOne.Enabled = false; // disables button 1
            guessTwo.Enabled = false; // disables button 2
        }
        private void guessOne_Click(object sender, EventArgs e) // method for when button 1 is clicked
        {
            compareNum(rand1, rand2, iteration); // calls compareNum method and passes rand1 and rand2 arrays, and the iteration num
            clickedIt(); // calls clickedIt method
            if (one) // boolean if one is set to true, num1 is higher
            {
                right++; // since button 1 was clicked, this is a correct guess and right counter is increased
            }
            else // num1 was not higher
            { 
                wrong++; // since button 1 was clicked, this is an incorrect guess and wrong counter is increased
            }
            this.correctCnt.Text = right.ToString(); // sets correctCnt label text to right variable
            this.ncorrectCnt.Text = wrong.ToString(); // sets ncorrectCnt label text to wrong variable
        }

        private void guessTwo_Click(object sender, EventArgs e) // method for when button 2 is clicked
        {
            compareNum(rand1, rand2, iteration); // calls compareNum method and passes rand1 and rand2 arrays, and the iteration num
            clickedIt(); // calls clickedIt method
            if (one != true) // boolean if one is set to false, num2 is higher
            {
                right++; // since button 2 was clicked, this is a correct guess and right counter is increased
            }
            else // num2 was not higher
            {
                wrong++; // since button 2 was clicked, this is an incorrect guess and wrong counter is increased
            }
            this.correctCnt.Text = right.ToString(); // sets correctCnt label text to right variable
            this.ncorrectCnt.Text = wrong.ToString(); // sets ncorrectCnt label text to wrong variable
        }

        private void correctCnt_Click(object sender, EventArgs e)
        {
            
        }

        private void ncorrectCnt_Click(object sender, EventArgs e)
        {
            
        }

        private void nxtButton_Click(object sender, EventArgs e) // method for when Next button is clicked
        {
            if (iteration < 100) // checks that iteration is less than 100, which is total number of indexes in each array
            {
                this.num1.Visible = false; // hides num1 label text
                this.num2.Visible = false; // hides num2 label text
                guessOne.Enabled = true; // enables 1 button
                guessTwo.Enabled = true; // enables 2 button
                iteration++; // increases iteration count
            }
            else // 100 guesses have been made, arrays must be repopulated
            {
                createArray(); // calls createArray method
                iteration = 0; // sets iteration back to zero
            }

        }

        private void num1_Click(object sender, EventArgs e)
        {
           
        }

        private void num2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e) // method for when Form1 loads
        {
            createArray(); // calls createArray to populate arrays at initialization
        }

        private void num1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
