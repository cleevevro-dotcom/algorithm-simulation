using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ALGO_SIMULATION.Forms
{
    public partial class SortProcessForm : Form
    {
        Form AnimationForm;
        int[] num;
        int[] unsortedNum;
        string SortType;
        public SortProcessForm()
        {
            InitializeComponent();
            ClearB.Enabled = false;
            checkBox2.Enabled = false;
        }

        private void BubbleSort()
        {
            int temp = 0;

            for (int i = 0; i < num.Length - 1; i++)
            {

                for (int sort = 0; sort < num.Length - 1; sort++)
                {
                    if (num[sort] > num[sort + 1])
                    {
                        temp = num[sort + 1];
                        num[sort + 1] = num[sort];
                        num[sort] = temp;
                    }
                }
                OutPutProcess.Text += string.Join(" ", num) + Environment.NewLine;
            }
        }
        private void SelectionSort()
        {
            // Holds the previous state of the array to avoid redundant updates in the output
            string previousState = "";

            // Iterating through the array
            for (int i = 0; i < num.Length; i++)
            {
                // Assume the current index has the smallest value
                int minIndex = i;

                // Find the smallest element in the unsorted portion of the array
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] < num[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the found smallest element with the first element of the unsorted portion
                if (minIndex != i)
                {
                    int temp = num[i];
                    num[i] = num[minIndex];
                    num[minIndex] = temp;
                }

                // Capture the current state of the array
                string currentState = string.Join(" ", num);

                // Output the process only if the state has changed
                if (currentState != previousState)
                {
                    OutPutProcess.Text += currentState + Environment.NewLine;
                    previousState = currentState;
                }
            }
        }
        private void InsertionSort()
        {
            string LastNum = "";
            string CurrentState;
            int laststate;
            int Copy, B;
            for (int A = 1; A < num.Length; A++)
            {
                CurrentState = string.Join(" ", num);
                Copy = num[A];
                B = A - 1;
                while (B >= 0 && num[B] > Copy)
                {

                    num[B + 1] = num[B];
                    B--;
                }
                num[B + 1] = Copy;
                if (LastNum != CurrentState)
                {
                    LastNum = string.Join(" ", num);
                    OutPutProcess.Text += string.Join(" ", num) + Environment.NewLine;
                }
            }
            OutPutProcess.Text += string.Join(" ", num) + Environment.NewLine;

        }
        private void ClearB_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            OutPutProcess.Text = "";
            ClearB.Enabled = false;
            EnterValue.Enabled = true;
            textBox2.Enabled = true;
            checkBox2.Enabled = false;
        }

        private void RBbubble_CheckedChanged(object sender, EventArgs e)
        {
            SortType = "Bsort";
        }

        private void RBselection_CheckedChanged(object sender, EventArgs e)
        {
            SortType = "Ssort";
        }

        private void RBinsertion_CheckedChanged(object sender, EventArgs e)
        {
            SortType = "Isort";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (num.Length <= 12)
            {
                SortAnimation SortForm = new SortAnimation(unsortedNum , unsortedNum.Length, SortType);
                if (AnimationForm != null)
                {
                    AnimationForm.Close();
                }
                SortAnimationForm.Show();
                AnimationForm = SortForm;
                SortForm.TopLevel = false;
                SortForm.FormBorderStyle = FormBorderStyle.None;
                SortForm.Dock = DockStyle.Fill;
                this.SortAnimationForm.Controls.Add(SortForm);
                this.SortAnimationForm.Tag = SortForm;
                SortForm.BringToFront();
                SortForm.Show();
            }
        }

        private void EnterValue_Click_1(object sender, EventArgs e)
        {
            if (SortType == null)
            {
                MessageBox.Show("Select a SortType", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int[] ConvertToInt = textBox2.Text.Trim(' ').Split(' ', '\n').Select(int.Parse).ToArray();
                    num = new int[ConvertToInt.Length];
                    unsortedNum = new int[ConvertToInt.Length];

                    for (int i = 0; i < ConvertToInt.Length; i++)
                    {

                        textBox1.Text += " " + ConvertToInt[i];
                        unsortedNum[i] = ConvertToInt[i];
                        num[i] = ConvertToInt[i];
                    }
                    ClearB.Enabled = true;
                    checkBox2.Enabled = true;
                    EnterValue.Enabled = false;
                    textBox2.Enabled = false;
                    switch (SortType)
                    {
                        case "Bsort": BubbleSort(); break;
                        case "Ssort": SelectionSort(); break;
                        case "Isort": InsertionSort(); break;
                    }
                }
                catch
                {
                    MessageBox.Show("Pls Put the Correct Format", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SortAnimationForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OutPutProcess_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
