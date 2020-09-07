using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session2_7_9
{
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new Login()).ShowDialog();
            Close();
        }

        private void btnViewPackages_Click(object sender, EventArgs e)
        {
            Hide();
            (new ViewPackages()).ShowDialog();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            (new AddPackages()).ShowDialog();
            Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            Hide();
            (new ApproveBookings()).ShowDialog();
            Close();
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {

        }
    }
}
