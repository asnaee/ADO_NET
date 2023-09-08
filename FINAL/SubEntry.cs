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

namespace FINAL
{
    public partial class SubEntry : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-54JPA7R;Database=FINAL;Trusted_Connection=True;");
        public SubEntry()
        {
            InitializeComponent();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO subjects (name) VALUES ('" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            label3.Text = "Data Inserted successfully!!!";
            LoadGrid();
            con.Close();
            ClearAll();
        }
        private void ClearAll()
        {
            textBox1.Text = "";

        }

        private void SubEntry_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Subjects";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            // LoadGrid();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Subjects", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

       
    }
}
