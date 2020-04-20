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
    public partial class Form2 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source= ''; Initial Catalog=''; User ''; Password=''");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("select idProveedor, nombrecontacto, pais, ciudad from proveedores");
            cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "select idProveedor, nombreCompañia, pais, ciudad from proveedores";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["idProveedor"].ToString());
                item.SubItems.Add(dr["nombreCompañia"].ToString());
                item.SubItems.Add(dr["pais"].ToString());
                item.SubItems.Add(dr["ciudad"].ToString());
                listView1.Items.Add(item);
            }
            connection.Close();
        }
    }
}
