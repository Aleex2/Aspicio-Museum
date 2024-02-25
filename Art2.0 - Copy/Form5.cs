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
    public partial class Form5 : Form
    {
        //se declara conexiunea cu baza de date
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PFSTVMOH\SQLEXPRESS;Initial Catalog=Arta;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int ID = 0;

        public Form5()
        {
            InitializeComponent();

            //afisare date din tabela artisti la deschiderea form-ului
            DisplayData();
        }


        //functie pentru afisarea datelor
        //coloana cu id-uri se afla in tabel, dar nu este afisata in interfata grafica
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Artisti", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

         //stergere date din casutele text si reinitializare
        private void ClearData()
        {
            txt_nume.Text = "";
            txt_prenume.Text = "";
            txt_scoala.Text = "";
            txt_stil.Text = "";
            txt_an.Text = "";
            txt_oras.Text = "";
            txt_judet.Text = "";
            txt_telefon.Text = "";
            txt_email.Text = "";
            txt_CNP.Text = "";
            txt_sex.Text = "";
            ID = 0;
        }


        private void btn_Insert_Click_1(object sender, EventArgs e)
        {

            if (txt_nume.Text != "" && txt_prenume.Text != "" && txt_CNP.Text != "" && txt_oras.Text != "" && txt_judet.Text != "" && txt_telefon.Text != "")
            {
                //interogare introducere date din casutele text
                cmd = new SqlCommand("INSERT INTO Artisti(Nume,Prenume,ScoalaDomeniu,Stil,AnDebut,CNP,Oras,Judet,Sex,NrTelefon,Email) VALUES(@name,@prenume,@scoala,@stil,@an,@cnp,@oras,@judet,@sex,@tel,@mail)", con);
                con.Open();
                //preluarea datelor din casute text , atribuite parametrilor folositi in cadrul interogarii
                cmd.Parameters.AddWithValue("@name", txt_nume.Text);
                cmd.Parameters.AddWithValue("@prenume", txt_prenume.Text);
                cmd.Parameters.AddWithValue("@scoala", txt_scoala.Text);
                cmd.Parameters.AddWithValue("@stil", txt_stil.Text);
                cmd.Parameters.AddWithValue("@an", txt_an.Text);
                cmd.Parameters.AddWithValue("@cnp", txt_CNP.Text);
                cmd.Parameters.AddWithValue("@oras", txt_oras.Text);
                cmd.Parameters.AddWithValue("@judet", txt_judet.Text);
                cmd.Parameters.AddWithValue("@sex", txt_sex.Text);
                cmd.Parameters.AddWithValue("@tel", txt_telefon.Text);
                cmd.Parameters.AddWithValue("@mail", txt_email.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Introducere artistului reusita!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Completati datele obligatorii!");
            }

        }

        //preluarea datelor unui anumit artist din tabelul afisat si dispunerea acestora
        //in casutele de text corespunzatoare atunci cand este selectata
        //o anumita linie (click la inceputul liniei)
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_nume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_prenume.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_scoala.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stil.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_an.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_CNP.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_oras.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_judet.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_sex.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_telefon.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        //actualizarea datelor in tabel
        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (txt_nume.Text != "" && txt_prenume.Text != "" && txt_CNP.Text != "" && txt_oras.Text != "" && txt_judet.Text != "" && txt_telefon.Text != "")
            {
                cmd = new SqlCommand("UPDATE Artisti SET Nume=@nume,Prenume=@prenume,ScoalaDomeniu=@scoala,Stil=@stil,AnDebut=@an,CNP=@cnp,Oras=@oras,Judet=@judet,Sex=@sex,NrTelefon=@tel,Email=@mail WHERE ArtistID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@nume", txt_nume.Text);
                cmd.Parameters.AddWithValue("@prenume", txt_prenume.Text);
                cmd.Parameters.AddWithValue("@scoala", txt_scoala.Text);
                cmd.Parameters.AddWithValue("@stil", txt_stil.Text);
                cmd.Parameters.AddWithValue("@an", txt_an.Text);
                cmd.Parameters.AddWithValue("@cnp", txt_CNP.Text);
                cmd.Parameters.AddWithValue("@oras", txt_oras.Text);
                cmd.Parameters.AddWithValue("@judet", txt_judet.Text);
                cmd.Parameters.AddWithValue("@sex", txt_sex.Text);
                cmd.Parameters.AddWithValue("@tel", txt_telefon.Text);
                cmd.Parameters.AddWithValue("@mail", txt_email.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Date actualizate cu succes!");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Alegeti artistul ale carui date doriti sa le actualizati!");
            }
        }

        //stergere inregistrari
        //se selecteaza artistul din tabel prin click,preluandu-se ID ul dupa care va fi stearsa inregistarea
        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Artisti where ArtistID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inregistrare stearsa cu succes!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Alegeti artistul ale carui date doriti sa le stergeti!");
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artaDataSet.Artisti' table. You can move, or remove it, as needed.
            this.artistiTableAdapter.Fill(this.artaDataSet.Artisti);

        }
    }
}
