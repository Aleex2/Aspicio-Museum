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

namespace Art2._0
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PFSTVMOH\SQLEXPRESS;Initial Catalog=Arta;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        
        int ID = 0;
        public Form6()
        {
            InitializeComponent();
            DisplayData();
        }



        // Display Data in DataGridView
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Expozitii", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        // Clear Data
        private void ClearData()
        {
            txt_titlu.Text = "";
            txt_tema.Text = "";
            txt_pret.Text = "";
            txt_inceput.Text = "";
            txt_final.Text = "";
            
            ID = 0;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_titlu.Text != "" && txt_tema.Text != "" && txt_pret.Text != "" && txt_inceput.Text != "" && txt_final.Text != "" )
            {
                cmd = new SqlCommand("INSERT INTO Expozitii(Titlu,Tema,PretBilet,DataInceput,DataFinal) VALUES(@titlu,@tema,@pret,@in,@fin)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@titlu", txt_titlu.Text);
                cmd.Parameters.AddWithValue("@tema", txt_tema.Text);
                cmd.Parameters.AddWithValue("@pret", Convert.ToDecimal(txt_pret.Text));
                cmd.Parameters.AddWithValue("@in", Convert.ToDateTime(txt_inceput.Text));
                cmd.Parameters.AddWithValue("@fin", Convert.ToDateTime(txt_final.Text));
        
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Completati datele obligatorii!");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_titlu.Text != "" && txt_tema.Text != "" && txt_pret.Text != "" && txt_inceput.Text != "" && txt_final.Text != "")
            {
                cmd = new SqlCommand("UPDATE Expozitii SET Titlu=@titlu,Tema=@tema,PretBilet=@pret,DataInceput=@in,DataFinal=@fin WHERE ExpozitieID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@titlu", txt_titlu.Text);
                cmd.Parameters.AddWithValue("@tema", txt_tema.Text);
                cmd.Parameters.AddWithValue("@pret", Convert.ToDecimal(txt_pret.Text));
                cmd.Parameters.AddWithValue("@in", Convert.ToDateTime(txt_inceput.Text));
                cmd.Parameters.AddWithValue("@fin", Convert.ToDateTime(txt_final.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Expozitii where ExpozitieID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_titlu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_tema.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_pret.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_inceput.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_final.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_titlu.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_tema.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_pret.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_inceput.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_final.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artaDataSet.Expozitii' table. You can move, or remove it, as needed.
            this.expozitiiTableAdapter.Fill(this.artaDataSet.Expozitii);

        }
    }
}
