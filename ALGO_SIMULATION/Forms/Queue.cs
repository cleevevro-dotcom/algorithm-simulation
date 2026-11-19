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
    public partial class Queuee : Form
    {
        private Stack<string> stack;
        private Queue<string> queue;

        public Queuee()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            stack = new Stack<string>();
            queue = new Queue<string>();

        }

        void TextBox1TextChanged(object sender, EventArgs e)
        {

        }

        void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string item in queue)
            {
                listBox1.Items.Add(item);
            }
        }

        void ListBox2SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            /// Get the text from the TextBox
            string input = textBox1.Text;

            // Check if the input is not empty
            if (!string.IsNullOrWhiteSpace(input))
            {
                // Enqueue the input onto the queue
                queue.Enqueue(input);

                // Clear and repopulate the ListBox to display the queue contents
                listBox2.Items.Clear();
                foreach (string item in queue)
                {
                    listBox2.Items.Add(item);
                }

                // Clear the TextBox for the next input
                textBox1.Clear();
            }
            else
            {
                // Optional: Show a message if the input is empty
                MessageBox.Show("Please enter some text before adding it to the queue.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Check if the queue is not empty
            if (queue.Count > 0)
            {
                // Dequeue the front element from the queue
                queue.Dequeue();

                // Clear and repopulate the ListBox to display the updated queue contents
                listBox2.Items.Clear();
                foreach (string item in queue)
                {
                    listBox2.Items.Add(item);
                }
            }
            else
            {
                // Optional: Show a message if the queue is empty
                MessageBox.Show("The queue is empty. Nothing to dequeue.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Check if the queue is not empty
            if (queue.Count > 0)
            {
                // Display the front element of the queue in label2
                label2.Visible = true;
                label2.Text = queue.Peek();
            }
            else
            {
                // Optional: Show a message if the queue is empty
                MessageBox.Show("The queue is empty. No front element to display.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Clear the queue
            queue.Clear();

            // Clear the ListBox displays
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label2.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string item in queue)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
