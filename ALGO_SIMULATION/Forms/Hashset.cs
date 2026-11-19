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
    public partial class Hashsets : Form
    {
        public HashSet<string> hashSet1 = new HashSet<string>();
        public HashSet<string> hashSet2 = new HashSet<string>();
        public Hashsets()
        {
            InitializeComponent();
        }

        private void lbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearbttn_Click(object sender, EventArgs e)
        {
            // Clear both hash sets
            hashSet1.Clear();
            hashSet2.Clear();

            // Clear the input text boxes
            txtSet1Input.Clear();
            txtSet2Input.Clear();

            // Clear the ListBoxes
            lbSet1.DataSource = null;
            lbSet2.DataSource = null;
            lbOutput.DataSource = null;

            // Optionally, reset the target set dropdown if you want
            cbTargetSet.SelectedItem = null;

        }

        private void btnExceptWith_Click(object sender, EventArgs e)
        {
            if (cbTargetSet.SelectedItem == null)
            {
                MessageBox.Show("Please select a target set (Set1 or Set2).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HashSet<string> result = new HashSet<string>();
            if (cbTargetSet.SelectedItem.ToString() == "Set1")
            {
                result = new HashSet<string>(hashSet1);
                result.ExceptWith(hashSet2);
            }
            else
            {
                result = new HashSet<string>(hashSet2);
                result.ExceptWith(hashSet1);
            }

            UpdateListBox(lbOutput, result); // Display the result in the output ListBox
        }

        private void btnIntersectWith_Click(object sender, EventArgs e)
        {
            if (cbTargetSet.SelectedItem == null)
            {
                MessageBox.Show("Please select a target set (Set1 or Set2).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HashSet<string> result = new HashSet<string>();
            if (cbTargetSet.SelectedItem.ToString() == "Set1")
            {
                result = new HashSet<string>(hashSet1);
                result.IntersectWith(hashSet2);
            }
            else
            {
                result = new HashSet<string>(hashSet2);
                result.IntersectWith(hashSet1);
            }

            UpdateListBox(lbOutput, result); // Display the result in the output ListBox
        }

        private void btnUnionWith_Click(object sender, EventArgs e)
        {
            if (cbTargetSet.SelectedItem == null)
            {
                MessageBox.Show("Please select a target set (Set1 or Set2).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HashSet<string> result = new HashSet<string>();
            if (cbTargetSet.SelectedItem.ToString() == "Set1")
            {
                result = new HashSet<string>(hashSet1);
                result.UnionWith(hashSet2);
            }
            else
            {
                result = new HashSet<string>(hashSet2);
                result.UnionWith(hashSet1);
            }

            UpdateListBox(lbOutput, result); // Display the result in the output ListBox
        }

        private void cbTargetSet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void UpdateListBox(ListBox listBox, HashSet<string> hashSet)
        {
            listBox.DataSource = null;
            listBox.DataSource = new List<string>(hashSet);
        }
        private void btnAddToSet2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSet2Input.Text))
            {
                string input = txtSet2Input.Text.Trim();
                hashSet2.Add(txtSet2Input.Text.Trim());
                UpdateListBox(lbSet2, hashSet2);
                txtSet2Input.Clear();
            }
        }

        private void btnAddToSet1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSet1Input.Text))
            {
                string input = txtSet1Input.Text.Trim();
                hashSet1.Add(txtSet1Input.Text.Trim());
                UpdateListBox(lbSet1, hashSet1);
                txtSet1Input.Clear();
            }
        }

        private void txtSet2Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSet1Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSet2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbSet1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
