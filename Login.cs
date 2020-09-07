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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please ensure that all field(s) are filled!");
            }
            else
            {
                using (var context = new Session2Entities())
                {
                    var findUser = (from x in context.Users
                                    where x.userId == txtUserID.Text
                                    select x).FirstOrDefault();
                    if (findUser == null)
                    {
                        MessageBox.Show("Invalid User");
                    }
                    else if (findUser.passwd != txtPassword.Text)
                    {
                        MessageBox.Show("Wrong password or user id!");
                    }
                    else
                    {
                        if (findUser.userTypeIdFK == 1)
                        {
                            Hide();
                            (new ManagerMain()).ShowDialog();
                            Close();
                        }
                        else if (findUser.userTypeIdFK == 2)
                        {
                            Hide();
                            (new SponsorMain(findUser)).ShowDialog();
                            Close();
                        }
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Hide();
            (new CreateAccount()).ShowDialog();
            Close();
        }
    }
}
