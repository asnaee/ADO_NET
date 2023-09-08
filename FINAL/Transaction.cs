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
    public partial class Transaction : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-54JPA7R;Database=FINAL;Trusted_Connection=True;");
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM Subjects";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            colSubject.DataSource = ds.Tables[0];
            colSubject.DisplayMember = "name";
            colSubject.ValueMember = "id";
            con.Close();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction ts = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = ts;
                cmd.CommandText = "INSERT INTO students(name,roll) VALUES(@name,@roll) SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@roll", txtRoll.Text);
                int id = Convert.ToInt32(cmd.ExecuteScalar());

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["colSubject"].Value != null && dataGridView1.Rows[i].Cells["colResult"].Value != null)
                    {
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.Transaction = ts;
                        cmd2.CommandText = "INSERT INTO Result(studentId,subjectId,result) VALUES(@studentId,@subjectId,@result)";
                        cmd2.Parameters.AddWithValue("@studentId", id);
                        cmd2.Parameters.AddWithValue("@subjectId", dataGridView1.Rows[i].Cells["colSubject"].Value);
                        cmd2.Parameters.AddWithValue("@result", dataGridView1.Rows[i].Cells["colResult"].Value);
                        cmd2.ExecuteNonQuery();
                    }
                }
                ts.Commit();
                MessageBox.Show("Data Inserted successfully!!!");
            }
            catch (Exception ex)
            {
                ts.Rollback();
                MessageBox.Show(ex.Message + "\nData not saved!!!");
            }
            con.Close();
        }
    }

}

