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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new Login()).ShowDialog();
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var context = new Session2Entities())
            {
                if (string.IsNullOrWhiteSpace(txtCompanyName.Text) || string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtRePassword.Text))
                {
                    MessageBox.Show("Please ensure all your field(s) are filled!");
                }
                else if (txtUserID.TextLength < 8)
                {
                    MessageBox.Show("Please ensure User ID has at least 8 characters!");
                }
                else if (txtPassword.Text != txtRePassword.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                }
                else
                {
                    var findUser = (from x in context.Users
                                    where x.name == txtCompanyName.Text
                                    select x).FirstOrDefault();
                    var checkUserID = (from x in context.Users
                                       where x.userId == txtUserID.Text
                                       select x).FirstOrDefault();
                    if (checkUserID != null)
                    {
                        MessageBox.Show("Please use another User ID!");
                    }
                    else if (findUser != null)
                    {
                        MessageBox.Show("Company already has a sponsor account!");
                    }
                    else
                    {
                        var newUser = new User()
                        {
                            name = txtCompanyName.Text,
                            userId = txtUserID.Text,
                            passwd = txtPassword.Text,
                            userTypeIdFK = 2
                        };
                        context.Users.Add(newUser);
                        context.SaveChanges();
                        MessageBox.Show("User created!");
                        Hide();
                        (new Login()).ShowDialog();
                        Close();
                    }
                }
            }
        }
    }
}
