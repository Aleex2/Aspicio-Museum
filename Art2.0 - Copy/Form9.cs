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
    public partial class Form9 : Form
    {
        //realizare conexiune cu baza de date
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PFSTVMOH\SQLEXPRESS;Initial Catalog=Arta;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader reader;

        int ID = 0;
        public Form9()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Artisti", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con.Open();
            //se selecteaza scolile de domeniu din tabela Artisti o singura data
            SqlCommand sc = new SqlCommand("Select Distinct ScoalaDomeniu as S from Artisti", con);
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            //se introduc scolile in elementul de tip comboBox pentru ca utilizatorul sa poata sa aleaga dintre acestea 
            dt.Columns.Add("S", typeof(string));
            dt.Load(reader);
            comboBox1.ValueMember = "S";
            comboBox1.DataSource = dt;
            con.Close();

        }

        //la apasarea butonului se executa interogarea #1 complexa
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            //interogare #1 complexa pentru afisarea artistilor ce au un pret mediu de vanzarea al tablourilor
            //mai mare de pretul mediu al unui tablou din cadrul muzeului
            adapt = new SqlDataAdapter("SELECT A.Nume, A.Prenume, AVG(P.Pret) FROM Artisti as A INNER JOIN Picturi as P ON A.ArtistID = P.ArtistID GROUP BY A.Nume,A.Prenume\r\nHAVING AVG(P.Pret) > (SELECT AVG(P1.Pret) FROM Picturi as P1)", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //la apasarea butonului se executa interogarea #2 complexa
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            //interogare #2 complexa pentru afisarea clientilor ce au participat la top 3 cele mai populare expozitii
            //alaturi suma totala a comenzilor
            adapt = new SqlDataAdapter("SELECT C.Nume, C.Prenume, SUM(P.Pret)\r\nFROM Clienti as C INNER JOIN Comenzi as CO ON C.ClientID = CO.ClientID\r\n                  INNER JOIN Picturi as P ON P.ComandaID = CO.ComandaID\r\n\t\t\t\t  INNER JOIN Bilete as B1 ON C.ClientID = B1.ClientID\r\n\t\t\t\t  INNER JOIN (SELECT TOP 3 B.ExpozitieID, COUNT(*) as Numar\r\n\t\t\t\t\t FROM Bilete as B \r\n\t\t\t\t\t GROUP BY B.ExpozitieID\r\n\t\t\t\t\t ORDER BY COUNT(*) desc)AS N ON N.ExpozitieID = B1.ExpozitieID\r\nGROUP BY C.Nume,C.Prenume", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //la apasarea butonului se executa interogarea #3 complexa
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            //interogare #3 complexa cu parametru variabil pentru afisarea tuturor clientilor ce au particippat la toate
            //expozitiile unui anumit artist selectat
            cmd = new SqlCommand("SELECT C.Nume, C.Prenume\r\nFROM Clienti as C  \r\nWHERE (SELECT COUNT(N.ExpozitieID)\r\n        FROM Clienti as C1 INNER JOIN Bilete as B ON C1.ClientID = B.ClientID\r\n\t\tINNER JOIN (SELECT distinct A.ArtistID, A.Nume, A.Prenume ,O.ExpozitieID \r\n\t\t             FROM  Artisti as A INNER JOIN Picturi as P ON A.ArtistID = P.ArtistID\r\n\t\t\t\t\t                    INNER JOIN Organizare as O ON P.PicturaID =  O.PicturaID\r\n\t\t\t\t\tWHERE A.ArtistID = @id) as N\r\n\t\tON B.ExpozitieID = N.ExpozitieID\r\n\t\tWHERE C1.ClientID = C.ClientID) = (SELECT COUNT(distinct O.ExpozitieID)\r\n\t\t             FROM  Artisti as A1 INNER JOIN Picturi as P ON A1.ArtistID = P.ArtistID\r\n\t\t\t\t\t                    INNER JOIN Organizare as O ON P.PicturaID =  O.PicturaID\r\n\t\t\t\t\tWHERE A1.ArtistID = @id )", con);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show(Convert.ToString(ID));
        }

        //la apasarea butonului se executa interogarea #4 complexa
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            string scoala = comboBox1.Text;
            //interogare #4 complexa cu parametru variabil pentru afisarea artistilor care au mai multe tablouri decat media de tablouri avute 
            //de absolventi ale unei anumite scoli selectate
            cmd = new SqlCommand("SELECT A.Nume, A.Prenume, COUNT(P.PicturaID) as NrPicturi\r\nFROM Artisti as A INNER JOIN Picturi as P ON A.ArtistID = P.ArtistID\r\nGROUP BY A.Nume,A.Prenume\r\nHAVING COUNT(P.PicturaID) > (SELECT AVG(N.NrTablouri) FROM (SELECT A1.Nume, A1.Prenume, COUNT(P1.PicturaID) as NrTablouri\r\n       FROM Artisti as A1 LEFT OUTER JOIN Picturi as P1 ON A1.ArtistID = P1.ArtistID\r\nWHERE A1.ScoalaDomeniu = @scoala\r\nGROUP BY A1.Nume,A1.Prenume) AS N)", con);
            cmd.Parameters.AddWithValue("@scoala", scoala);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
