/* David Cobbley
 * CS 311 
 * 10-24-14
 * DFA checker.
 * Takes in a DFA from text in specific format, builds it, then checks a given string against it.
 * 
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Variables
        //array of strings
        string[] states, acceptingState, errorState;
        string tempString, testString;
        //multi dimensional array of strings for delta.
        string[,] transitionStates;
        char tempChar;
        //acceptable characters in the language
        char[] alphabet;
        //ints most for initialization of string arrays
        int numStates, numErrorStates, numAcceptingStates, numAlphabet, x, y, currentState;
        bool errorFlag;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //If this button is pushed, import the DFA from text file in local directory.
        private void btn_ImportDfa_Click(object sender, EventArgs e)
        {
            importDfa();
        }
        private void importDfa()
        {
            /*
             * Grab input from text file.
             * Input MUST be in format
             * 
             * number of states
             * number of final states
             * number of Error states
             * number of characters in the alphabet
             * states names, starting at q0
             * name of accepting states
             * error state name if any, else just skip
             * characters in the alphabet
             * starting at Q0, the transitions for each character in the alphabet
             * 
             */
            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/dfa.txt"))
            {
                // set temp variables to the input for the stream reader
                numStates = Convert.ToInt32(sr.ReadLine());
                numAcceptingStates = Convert.ToInt32(sr.ReadLine());
                numErrorStates = Convert.ToInt32(sr.ReadLine());
                numAlphabet = Convert.ToInt32(sr.ReadLine());

                //use variables to init array of strings.
                states = new string[numStates];
                acceptingState = new string[numAcceptingStates];
                errorState = new string[numErrorStates];
                alphabet = new char[numAlphabet + 1];

                //grab all the of the states for each array of strings.
                for (x = 0; x < numStates; x++)
                    states[x] = sr.ReadLine();

                for (x = 0; x < numAcceptingStates; x++)
                    acceptingState[x] = sr.ReadLine();

                for (x = 0; x < numErrorStates; x++)
                    errorState[x] = sr.ReadLine();

                for (x = 0; x < numAlphabet; x++)
                    alphabet[x] = Convert.ToChar(sr.ReadLine());

                //build delta.
                transitionStates = new string[numStates, numAlphabet];

                for (x = 0; x < numStates; ++x)
                {
                    for (y = 0; y < numAlphabet; ++y)
                    {
                        transitionStates[x, y] = sr.ReadLine();
                    }
                }
            }
            //Display the table
            displayDfa();
        }
        private void displayDfa()
        {
            //work through multi dimensional array to display array.
            rtb_displayDfa.Text = "state\t";
            for (x = 0; x < numAlphabet; ++x)
                rtb_displayDfa.Text+=alphabet[x] + "\t";

            for (x = 0; x < numStates; x++)
            {
                rtb_displayDfa.Text += "\n";
                rtb_displayDfa.Text+=states[x] + "\t";
                for (y = 0; y < numAlphabet; y++)
                    rtb_displayDfa.Text+=transitionStates[x, y] + "\t";
            }

            labelDfa.Visible = true;
        }
        //if this button is pushed, call checkString function.
        private void btn_submitString_Click(object sender, EventArgs e)
        {
            if(rtb_stringToCheck.Text!=""&&rtb_stringToCheck.Text!="Please enter a string to check")
                checkString();
        }
        private void checkString()
        {
            currentState = 0;
            errorFlag = false;

            testString = rtb_stringToCheck.Text.ToString();


            for (x = 0; x < testString.Length; ++x)
            {
                tempChar = testString[x];
                //move across the x axis of the table
                for (y = 0; y < numAlphabet; ++y)
                {
                    if (alphabet[y] == tempChar)
                        break;
                }
                tempString = transitionStates[currentState, y];

                //Move across the y-axis of the table
                for (int k = 0; k < numStates; k++)
                {
                    if (states[k] == tempString)
                    {
                        currentState = k;
                        break;
                    }
                }

                //check if error state
                for (y = 0; y < numErrorStates; y++)
                {
                    if (states[currentState] == errorState[y])
                    {
                        rtb_stringToCheck.Text+="\n String rejected";
                        rtb_stringToCheck.ForeColor = Color.Red;
                        errorFlag = true;
                        break;
                    }
                }
                if (errorFlag)
                    break;

            }

            for (x = 0; x < numAcceptingStates; x++)
            {
                //check to make sure you end up in the accepting state
                if (states[currentState] == acceptingState[x])
                {
                    rtb_stringToCheck.Text += "\n String Accepted";
                    rtb_stringToCheck.ForeColor = Color.Green;
                }
                else
                {
                    rtb_stringToCheck.Text += "\n String rejected";
                    rtb_stringToCheck.ForeColor = Color.Red;
                }
            }
        }
        //reset rich text box.
        private void rtb_stringCheckClick(object sender, EventArgs e)
        {
            rtb_stringToCheck.ForeColor = Color.Black;
            rtb_stringToCheck.Text = "";
        }
    }
}
