using ALGO_SIMULATION.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ALGO_SIMULATION
{
    public partial class MenuAlgo : Form
    {
        private Form ActiveForm;
        public MenuAlgo()
        {
            InitializeComponent();
            Home home = new Home();
            OpenChildFrom(home, null);
        }
        private void MenuAlgo_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Bhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            OpenChildFrom(home, sender);
        }

        private void Bsort_Click(object sender, EventArgs e)
        {
            SortProcessForm sortForm = new SortProcessForm();
            OpenChildFrom(sortForm , sender);
        }

        private void Blist_Click(object sender, EventArgs e)
        {
            LinkedList_ list = new LinkedList_();
            OpenChildFrom(list, sender);
        }

        private void Bqueue_Click(object sender, EventArgs e)
        {
            Queuee que = new Queuee();
            OpenChildFrom(que, sender);
        }

        private void Bstacks_Click(object sender, EventArgs e)
        {
            Stackss stack = new Stackss();
            OpenChildFrom(stack, sender);
        }
        private void OpenChildFrom(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.InheritFormPanel.Controls.Add(childForm);
            this.InheritFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Bhashset_Click(object sender, EventArgs e)
        {
            Hashsets hash = new Hashsets();
            OpenChildFrom(hash, sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
