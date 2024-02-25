using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Art2._0
{
    public partial class Form8 : Form
    {
        //realizare conexiune cu baza da date
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PFSTVMOH\SQLEXPRESS;Initial Catalog=Arta;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader reader;

        int ID = 0;
        public Form8()
        {
            InitializeComponent();
            DisplayData();
        }

        //Afisare toate datele pentru identificarea unui anumit artist in cadrul elementului mai mic de tip dataGridView
        //(coloana Id-urile nu este vizibila)
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Artisti", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            this.artistiTableAdapter.Fill(this.artaDataSet.Artisti);

            con.Open();
                 //se selecteaza temele din tabela Expozitii o singura data
                SqlCommand sc = new SqlCommand("Select Distinct Tema as T from Expozitii",con);
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();

                //se introduc temele in elementul de tip comboBox pentru ca utilizatorul sa poata sa aleaga dintre acestea 
                dt.Columns.Add("T", typeof(string));
                dt.Load(reader);
                comboBox2.ValueMember = "T";
                comboBox2.DataSource = dt;
               
                //se selecteaza anii din tabela Expozitii o singura data
                SqlCommand sc1 = new SqlCommand("Select Distinct Year(DataInceput) as Y from Expozitii", con);
                reader = sc1.ExecuteReader();
                DataTable dt1 = new DataTable();
                //se introduc anii selectati in elementul de tip comboBox pentru ca utilizatorul sa poata sa aleaga dintre acestia
                dt1.Columns.Add("Y", typeof(Int16));
                dt1.Load(reader);
                comboBox3.ValueMember = "Y";
                comboBox3.DataSource = dt1;

            con.Close();

        }

        //la apasarea primului butonului se executa interogarea #3
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            //interogare #3 simpla pentru afisarea tuturor artistilor in ordine descrescatoare in functie de numarul
            //de tablouri aduse in cadrul muzeului 
            adapt = new SqlDataAdapter("SELECT A.Nume, A.Prenume, COUNT(A.ArtistID) AS NrTablouri FROM Artisti as A LEFT OUTER JOIN Picturi as P ON A.ArtistID = P.ArtistID GROUP BY A.Nume,A.Prenume ORDER BY NrTablouri DESC", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //La apasarea capatului unui rand corespunzator unui artist din cadrul elementului mai mic de tip dataGridView
        //se preia id-ul acestuia
        private void dataGridView2_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        //la apasarea butonului se executa interogarea #4
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            //interogare #4 simpla cu parametru variabil pentru afisarea clientilor unui anumit artist selectat
            cmd = new SqlCommand ("SELECT C.Nume, C.Prenume FROM Clienti as C INNER JOIN Comenzi as CO ON C.ClientID = CO.ClientID INNER JOIN Picturi as P ON P.ComandaID = CO.ComandaID INNER JOIN Artisti as A ON P.ArtistID = A.ArtistID WHERE A.ArtistID = @id", con);
           //se ofera parametrului variabil valoarea ID ului obtinuta prin selectarea artistului din tabel
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        //la apasarea butonului se executa interogarea #5
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            string tema = comboBox2.Text;
            //interogare #5 simpla cu parametru variabil pentru afisarea tablourilor dintr-o expozitie cu o tematica selectata
            cmd = new SqlCommand("SELECT P.Titlu, P.Pret FROM Picturi as P INNER JOIN  Organizare as O ON O.PicturaID = P.PicturaID INNER JOIN  Expozitii as E ON E.ExpozitieID = O.ExpozitieID WHERE E.Tema = @tema", con);
            cmd.Parameters.AddWithValue("@tema", tema);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //la apasarea butonului se executa interogarea #6
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            int an = Convert.ToInt16(comboBox3.Text);
            //interogare #6 simpla cu parametru variabil pentru afisarea salilor ce au fost folosite intr-un an selectat
            cmd = new SqlCommand("SELECT distinct S.NrSala, E.Titlu FROM Sali as S INNER JOIN Organizare as O On S.SalaID = O.SalaID INNER JOIN Expozitii as E ON E.ExpozitieID = O.ExpozitieID WHERE @an BETWEEN YEAR(E.DataInceput) AND YEAR(E.DataFinal)", con);
            cmd.Parameters.AddWithValue("@an", an);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }    
}
