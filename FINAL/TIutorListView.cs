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
    public partial class TIutorListView : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-54JPA7R;Database=FINAL;Trusted_Connection=True;");
        public TIutorListView()
        {
            InitializeComponent();
        }

        private void TIutorListView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select t.tutorId,t.tutorName,t.tutorContact,t.tutorEmail,t.dob,t.gender,t.salary,t.picture,s.name from \r\ntutors t inner join Subjects s ON t.subjectId=s.id", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
