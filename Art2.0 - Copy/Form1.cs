using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Art2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "nume" && txtParola.Text == "parola123")
            {
                new Form4().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nume sau parola gresite!");
                txtParola.Clear();
                txtUser.Clear();
                txtUser.Focus();
            }

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PFSTVMOH\SQLEXPRESS;Initial Catalog=Arta;Integrated Security=True"); 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Clienti WHERE nume='" + txtUser.Text + "' AND CNP='" + txtParola.Text + "'", con);
            /* In the above line, the program is selecting the whole data from the table and matching it with the username and password provided by the user. */
            DataTable dt = new DataTable(); // Creating a virtual table
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called the home page. If the user is successfully authenticated, then the form will be moved to the next form. */
                new Form4().Show();
                this.Hide();
            }
            else
            {
               // MessageBox.Show("Nume sau parola gresite!");
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
             
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
