using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        /*
        private bool addition = false;
        private bool multiplication = false;
        private bool division = false;
        private bool subtraction = false;
        */
        private bool secondNumberOn = false;
        private bool commaOn = false;
        private float firstNumber;
        private float secondNumber;
        private string secondNumberStr;
        private int action = 0;


        ActionClass actClass = new ActionClass();
       

        public Form1()
        {
            InitializeComponent();
            
           
        }

       

        private void Resuslt_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = actClass.Results(action, firstNumber, secondNumberStr);
            
          
        }

        

        private void Zero_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "0";
            
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 0;
            } else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 0;
                secondNumberStr = secondNumber.ToString();
              
            }

            if (commaOn && secondNumberOn)
            {
                secondNumberStr += "0";
                secondNumber = float.Parse(secondNumberStr);
            }
        }

        private void One_Click(object sender, EventArgs e)
        {

            DisplayBox.Text = DisplayBox.Text + "1";

            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 1;
            }
            else if (secondNumberOn && !commaOn)
            {
                secondNumber  = (10 * secondNumber) + 1;
                secondNumberStr += secondNumber.ToString();
                
            }
            
            if (commaOn && secondNumberOn) 
            {

                secondNumberStr += "1";
                secondNumber = float.Parse(secondNumberStr);
                System.Diagnostics.Debug.Write("o second number einai " + secondNumber);
               
            }

          
        }

        

        private void Two_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "2";
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 2;
            } else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 2;
                secondNumberStr +=  secondNumber.ToString();
               
            }


            if (commaOn && secondNumberOn)
            {
                secondNumberStr += "2";
                secondNumber = float.Parse(secondNumberStr);
                System.Diagnostics.Debug.Write("o second number einai " + secondNumber);
            }


        }

        private void Three_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "3";
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 3;
            }
            else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 3;
                secondNumberStr =  secondNumber.ToString();
                System.Diagnostics.Debug.Write("prin ginei parse " + secondNumberStr);
            }
            if (commaOn && secondNumberOn)
            {
                secondNumberStr += "3";
                secondNumber = float.Parse(secondNumberStr);
            }
        }

       

        private void Four_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "4";
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 4;
            }
            else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 4;
                secondNumberStr = secondNumberStr + secondNumber.ToString();
            }

            if (commaOn && secondNumberOn)
            {
                secondNumberStr += "4";
                secondNumber = float.Parse(secondNumberStr);
            }

        }

        private void Five_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "5";
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 5;
            }
            else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 5;
                secondNumberStr = secondNumberStr + secondNumber.ToString();
            }

           if (commaOn && secondNumberOn)
            {
                secondNumberStr += "5";
                secondNumber = float.Parse(secondNumberStr);
            }

        }

        private void Six_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "6";
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 6;
            }
            else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 6;
                secondNumberStr = secondNumberStr + secondNumber.ToString();
            }

            if (commaOn && secondNumberOn)
            {
                secondNumberStr += "6";
                secondNumber = float.Parse(secondNumberStr);
            }
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "7";
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 7;
            }
            else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 7;
                secondNumberStr = secondNumberStr + secondNumber.ToString();
            }

             if (commaOn && secondNumberOn)
            {
                secondNumberStr += "7";
                secondNumber = float.Parse(secondNumberStr);
            }
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "8";
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 8;
            }
            else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 8;
                secondNumberStr = secondNumberStr + secondNumber.ToString();
            }

            if (commaOn && secondNumberOn)
            {
                secondNumberStr += "8";
                secondNumber = float.Parse(secondNumberStr);
            }
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + "9";
            if (!secondNumberOn && !commaOn)
            {
                firstNumber = (10 * firstNumber) + 9;
            }
            else if (secondNumberOn && !commaOn)
            {
                secondNumber = (10 * secondNumber) + 9;
                secondNumberStr = secondNumberStr + secondNumber.ToString();
            }

           if (commaOn && secondNumberOn)
            {
                secondNumberStr += "9";
                secondNumber = float.Parse(secondNumberStr);
            }
        }

       

        private void Addition_Click(object sender, EventArgs e)
        {
            action = 1;
            commaOn = false;
            //addition = true;
            secondNumberOn = true;
            firstNumber = float.Parse(DisplayBox.Text);
            DisplayBox.Text += "+";
            System.Diagnostics.Debug.Write("o firstNumber einai " + firstNumber);
        }

       

        private void Multiplication_Click(object sender, EventArgs e)
        {
            action = 2;
            commaOn = false;
            //multiplication = true;
            secondNumberOn = true;
            firstNumber = float.Parse(DisplayBox.Text);
            DisplayBox.Text += "*";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            action = 3;
            commaOn = false;
            //division = true;
            secondNumberOn = true;
            firstNumber = float.Parse(DisplayBox.Text);
            DisplayBox.Text += "/";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            action = 4;
            commaOn = false;
            //subtraction = true;
            secondNumberOn = true;
           
                firstNumber = float.Parse(DisplayBox.Text);
            
            DisplayBox.Text += "-";
        }

        private void CleanUp_Click(object sender, EventArgs e)
        {
            //addition = false;
            //multiplication = false;
            //division = false;
            //subtraction = false;
            action = 0;
            DisplayBox.Text = " ";
            firstNumber = 0;
            secondNumber = 0;
            secondNumberOn = false;
            commaOn = false;
            secondNumberStr = " ";


        }

        private void Comma_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text + ",";
            if (secondNumberOn)
            {
                secondNumberStr = secondNumber.ToString() + ",";
                System.Diagnostics.Debug.Write("o arithmos me komma einai " + secondNumberStr);
            }
            commaOn = true;
        }

        private void Debug_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.Write("O prwtos ari8mos einai" + firstNumber );
            System.Diagnostics.Debug.Write(" O deuteros ari8mos einai" + secondNumber);
            System.Diagnostics.Debug.Write("to action einai " + action);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = DisplayBox.Text.Remove(DisplayBox.Text.Length - 1);

            if (string.IsNullOrEmpty(DisplayBox.Text))
            {
                DisplayBox.Text = "0";
            }

            if (action == 0 && DisplayBox.Text != null)
            {
                string numb = firstNumber.ToString();
                numb = numb.Remove(numb.Length - 1);
                firstNumber = float.Parse(numb);
            }
            if (action == 1)
            { 
                string numb2 = secondNumber.ToString();
                string num = numb2.Remove(numb2.Length - 1);
                secondNumber = float.Parse(num);
                secondNumberStr = num;
                
                
              
            }
           
            System.Diagnostics.Debug.Write(firstNumber + "...." + secondNumber + "..." + secondNumberStr);

        
        }
    }
}
