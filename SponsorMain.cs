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
    public partial class SponsorMain : Form
    {

        User _user;
        public SponsorMain(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new Login()).ShowDialog();
            Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Hide();
            (new BookSponsorship(_user)).ShowDialog();
            Close();
        }
    }
}
