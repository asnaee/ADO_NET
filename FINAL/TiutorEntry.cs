using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class TiutorEntry : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-54JPA7R;Database=FINAL;Trusted_Connection=True;");
        public TiutorEntry()
        {
            InitializeComponent();
        }

        private void TiutorEntry_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM Subjects";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmbSubject.DataSource = ds.Tables[0];
            cmbSubject.DisplayMember = "name";
            cmbSubject.ValueMember = "id";
            con.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicture.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tutors(tutorName,tutorContact,tutorEmail,picture,dob,gender, salary,subjectId) VALUES(@n,@c,@e,@p,@dob,@g,@sal,@sub)";
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@g", chkGender.Checked.ToString());
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@sub", cmbSubject.SelectedValue);
            cmd.Parameters.AddWithValue("@sal",txtsal.Text);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Inserted successfully!!!";
            con.Close();
            allClearr();
        }
         private void allClearr()
        {
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            chkGender.Checked.ToString(null);
            txtsal.Text = "";
        }
    }
}
