using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALGO_SIMULATION.Forms
{
    public partial class Stackss : Form
    {
        private Stack<string> stack;
        public Stackss()
        {
            InitializeComponent();
            stack = new Stack<string>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Get the text from the TextBox
            string input = textBox1.Text;

            // Check if the input is not empty
            if (!string.IsNullOrWhiteSpace(input))
            {
                // Push the input onto the stack
                stack.Push(input);

                // Clear and repopulate the ListBox to display the stack contents
                listBox2.Items.Clear();
                foreach (string item in stack)
                {
                    listBox2.Items.Add(item);
                }

                // Clear the TextBox for the next input
                textBox1.Clear();
            }
            else
            {
                // Optional: Show a message if the input is empty
                MessageBox.Show("Please enter some text before adding it to the stack.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if the stack is not empty
            if (stack.Count > 0)
            {
                // Pop the top element from the stack
                stack.Pop();

                // Clear and repopulate the ListBox to display the updated stack contents
                listBox2.Items.Clear();
                foreach (string item in stack)
                {
                    listBox2.Items.Add(item);
                }
            }
            else
            {
                // Optional: Show a message if the stack is empty
                MessageBox.Show("The stack is empty. Nothing to pop.", "Stack Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                // Display the top element of the stack in label2
                label2.Visible = true;
                label2.Text = stack.Peek();
            }
            else
            {
                // Optional: Show a message if the stack is empty
                MessageBox.Show("The stack is empty. No top element to display.", "Stack Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string item in stack)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Clear the stack
            stack.Clear();

            // Clear the ListBox displays
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label2.Visible = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
