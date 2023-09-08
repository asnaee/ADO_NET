using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tiutorEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            TiutorEntry TRE = new TiutorEntry();
            TRE.MdiParent = this;
            TRE.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tiutorUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            TiutorUpdateDelet TRUD = new TiutorUpdateDelet();
            TRUD.MdiParent = this; 
            TRUD.Show();
        }

        private void tiutorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer=true;
            TIutorListView TLV = new TIutorListView();
            TLV.MdiParent = this;
            TLV.Show();
        }

        private void subjectEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            SubEntry sub= new SubEntry();
            sub.MdiParent = this;
                sub.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer=true;
            Transaction TRN= new Transaction();
            TRN.MdiParent = this;
            TRN.Show();
        }
    }
}
