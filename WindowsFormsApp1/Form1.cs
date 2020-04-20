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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source= sql5047.site4now.net; Initial Catalog=DB_A5A766_sebastiantecsup; User ID=DB_A5A766_sebastiantecsup_admin; Password=T3csup3720;");
        SqlCommand cmd;
        SqlDataReader dr;

        Datos cn = new Datos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "Select Pais from clientes";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["Pais"]);
            }
            connection.Close();
        }
    }
}
