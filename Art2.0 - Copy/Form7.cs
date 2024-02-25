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
    public partial class Form7 : Form
    {
        //stabilire conexiunea cu baza de date
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PFSTVMOH\SQLEXPRESS;Initial Catalog=Arta;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Form7()
        {
            InitializeComponent();
        }

        //la apasarea primului buton se executa interogarea #1
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            //interogare #1 simpla pentru afisarea artistilor si datelor sale de contact care au vandut un tablou in ultimele 2 saptamani
            adapt = new SqlDataAdapter("SELECT A.Nume, A.Prenume, A.NrTelefon, A.Email ,SUM(P.Pret) AS SumaPlata FROM Artisti as A INNER JOIN Picturi as P ON A.ArtistID = P.ArtistID INNER JOIN Comenzi as C ON P.ComandaID = C.ComandaID WHERE DATEDIFF(day,C.Data,GETDATE()) between 0 and 15 GROUP BY A.Nume,A.Prenume,A.NrTelefon,A.Email", con);
            adapt.Fill(dt);
            //afisarea solutiei se realizeaza in cadrul elementului de tip dataGridView
            dataGridView1.DataSource = dt;
            con.Close();

        }

        //la apasarea celui de-al doilea buton se executa interogarea #2
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            //interogare #2 simpla pentru afisarea clientilor ce au achizitionat tablouri in ultimele 2 saptamani 
            adapt = new SqlDataAdapter("SELECT C.Nume, C.Prenume ,C.Oras,C.Strada,C.Numar,P.Titlu FROM Clienti as C INNER JOIN Comenzi as CO ON C.ClientID = CO.ClientID INNER JOIN Picturi as P ON P.ComandaID = CO.ComandaID WHERE DATEDIFF(day,CO.Data,GETDATE()) between 0 and 15", con);
            adapt.Fill(dt);
            //afisarea solutiei se realizeaza in cadrul elementului de tip dataGridView
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
