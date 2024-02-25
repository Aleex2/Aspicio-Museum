using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art2._0
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //Pentru fiecare buton apasat din meniul principal se va deschide un alt form pentru acea categorie
        private void button1_Click(object sender, EventArgs e)
        {
            Form5 child = new Form5() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panelAfisare.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 child = new Form6() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panelAfisare.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 child = new Form7() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panelAfisare.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 child = new Form8() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panelAfisare.Controls.Add(child);
            child.BringToFront();
            child.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 child = new Form9() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panelAfisare.Controls.Add(child);
            child.BringToFront();
            child.Show();
        }
    }
}
