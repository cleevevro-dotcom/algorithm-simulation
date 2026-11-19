using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALGO_SIMULATION.Forms
{
    public partial class LinkedList_ : Form
    {

        private LinkedList<string> linkedList;

        public LinkedList_()
        {
            InitializeComponent();
            linkedList = new LinkedList<string>();
        }


        void TextBox1TextChanged(object sender, EventArgs e)
        {

            string currentText = textBox1.Text;
        }
        void ListBox2SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void Label1Click(object sender, EventArgs e)
        {

        }

        private void LinkedList_Load(object sender, EventArgs e)
        {

        }

        private void AddFirst_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (!string.IsNullOrEmpty(input))
            {
                linkedList.AddFirst(input);


                listBox1.Items.Clear();
                foreach (var item in linkedList)
                {
                    listBox1.Items.Add(item);
                }

                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter some text before adding.");
            }
        }

        private void AddLast_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (!string.IsNullOrEmpty(input))
            {
                linkedList.AddLast(input);


                listBox1.Items.Clear();
                foreach (var item in linkedList)
                {
                    listBox1.Items.Add(item);
                }

                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter some text before adding.");
            }
        }

        private void RemoveFirst_Click(object sender, EventArgs e)
        {
            if (linkedList.Count > 0)
            {
                linkedList.RemoveFirst();

                listBox1.Items.Clear();
                foreach (var item in linkedList)
                {
                    listBox1.Items.Add(item);
                }

                MessageBox.Show("Removed first item.");
            }
            else
            {
                MessageBox.Show("The List is empty.");
            }
        }

        private void RemoveLast_Click(object sender, EventArgs e)
        {
            if (linkedList.Count > 0)
            {
                linkedList.RemoveLast();

                listBox1.Items.Clear();
                foreach (var item in linkedList)
                {
                    listBox1.Items.Add(item);
                }

                MessageBox.Show("Removed last item.");
            }
            else
            {
                MessageBox.Show("The List is empty.");
            }
        }

        private async void ClearBtn_Click(object sender, EventArgs e)
        {
            if (linkedList.Count > 0)
            {
                listBox2.Items.Clear();

                await Task.Delay(1000);

                listBox1.Items.Clear();

                linkedList.Clear();

                MessageBox.Show("The List has been cleared.");
            }
            else
            {
                MessageBox.Show("The List is empty.");
            }
        }

        private void ShowLinkedList_Click(object sender, EventArgs e)
        {
            if (linkedList.Count > 0)
            {
                listBox2.Items.Clear();

                foreach (var item in listBox1.Items)
                {
                    listBox2.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("The List is empty.");
            }
        }
    }
}
