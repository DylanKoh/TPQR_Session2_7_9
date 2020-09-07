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
    public partial class BookSponsorship : Form
    {
        User _user;
        List<string> benefits = new List<string>();
        public BookSponsorship(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new SponsorMain(_user)).ShowDialog();
            Close();
        }

        private void cbOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnline.Checked)
            {
                if (!benefits.Contains("Online"))
                {
                    benefits.Add("Online");
                }
            }
            else
            {
                if (benefits.Contains("Online"))
                {
                    benefits.Remove("Online");
                }
            }
            LoadData(1);
        }

        private void cbFlyer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFlyer.Checked)
            {
                if (!benefits.Contains("Flyer"))
                {
                    benefits.Add("Flyer");
                }
            }
            else
            {
                if (benefits.Contains("Flyer"))
                {
                    benefits.Remove("Flyer");
                }
            }
            LoadData(1);
        }

        private void cbBanner_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBanner.Checked)
            {
                if (!benefits.Contains("Banner"))
                {
                    benefits.Add("Banner");
                }
            }
            else
            {
                if (benefits.Contains("Banner"))
                {
                    benefits.Remove("Banner");
                }
            }
            LoadData(1);
        }

        private void BookSponsorship_Load(object sender, EventArgs e)
        {
            LoadTiers();
            LoadData(0);
        }

        private void LoadData(int mode)
        {
            dataGridView1.Rows.Clear();
            if (mode == 0)
            {
                using (var context = new Session2Entities())
                {
                    var getPackages = (from x in context.Packages
                                       where x.packageQuantity > 0
                                       orderby x.packageName
                                       select x);
                    foreach (var item in getPackages)
                    {
                        var newRow = new List<string>()
                        {
                            item.packageId.ToString(), item.packageTier,
                            item.packageName, item.packageValue.ToString(),
                            item.packageQuantity.ToString()
                        };
                        var getBenefits = (from x in context.Benefits
                                           where x.packageIdFK == item.packageId
                                           select x.benefitName).ToList();
                        if (getBenefits.Contains("Online"))
                        {
                            newRow.Add("Yes");
                        }
                        else
                        {
                            newRow.Add("");
                        }
                        if (getBenefits.Contains("Flyer"))
                        {
                            newRow.Add("Yes");
                        }
                        else
                        {
                            newRow.Add("");
                        }
                        if (getBenefits.Contains("Banner"))
                        {
                            newRow.Add("Yes");
                        }
                        else
                        {
                            newRow.Add("");
                        }
                        dataGridView1.Rows.Add(newRow.ToArray());
                    }
                }
            }
            else
            {
                using (var context = new Session2Entities())
                {
                    if (cbTier.SelectedItem.ToString() == "No Filter")
                    {
                        var getPackages = (from x in context.Packages
                                           where x.packageQuantity > 0
                                           orderby x.packageName
                                           select x);
                        if (nudBudget.Value == 0)
                        {
                            foreach (var item in getPackages)
                            {
                                var newRow = new List<string>()
                                {
                                    item.packageId.ToString(), item.packageTier,
                                    item.packageName, item.packageValue.ToString(),
                                    item.packageQuantity.ToString()
                                };
                                var getBenefits = (from x in context.Benefits
                                                   where x.packageIdFK == item.packageId
                                                   select x.benefitName).ToList();
                                if (benefits.Count == 0)
                                {
                                    if (getBenefits.Contains("Online"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Flyer"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Banner"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    dataGridView1.Rows.Add(newRow.ToArray());
                                }
                                else
                                {
                                    var boolCheck = true;
                                    foreach (var benefit in benefits)
                                    {
                                        if (!getBenefits.Contains(benefit))
                                        {
                                            boolCheck = false;
                                        }
                                        if (boolCheck == false)
                                        {
                                            break;
                                        }
                                    }
                                    if (boolCheck == false)
                                    {
                                        continue;
                                    }
                                    if (getBenefits.Contains("Online"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Flyer"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Banner"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    dataGridView1.Rows.Add(newRow.ToArray());
                                }

                            }
                        }
                        else
                        {
                            var filtered = getPackages.Where(x => x.packageValue <= nudBudget.Value);
                            foreach (var item in filtered)
                            {
                                var newRow = new List<string>()
                                {
                                    item.packageId.ToString(), item.packageTier,
                                    item.packageName, item.packageValue.ToString(),
                                    item.packageQuantity.ToString()
                                };
                                var getBenefits = (from x in context.Benefits
                                                   where x.packageIdFK == item.packageId
                                                   select x.benefitName).ToList();
                                if (benefits.Count == 0)
                                {
                                    if (getBenefits.Contains("Online"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Flyer"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Banner"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    dataGridView1.Rows.Add(newRow.ToArray());
                                }
                                else
                                {
                                    var boolCheck = true;
                                    foreach (var benefit in benefits)
                                    {
                                        if (!getBenefits.Contains(benefit))
                                        {
                                            boolCheck = false;
                                        }
                                        if (boolCheck == false)
                                        {
                                            break;
                                        }
                                    }
                                    if (boolCheck == false)
                                    {
                                        continue;
                                    }
                                    if (getBenefits.Contains("Online"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Flyer"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Banner"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    dataGridView1.Rows.Add(newRow.ToArray());
                                }

                            }
                        }
                    }
                    else
                    {

                        var getPackages = (from x in context.Packages
                                           where x.packageQuantity > 0 && x.packageTier == cbTier.SelectedItem.ToString()
                                           orderby x.packageName
                                           select x);
                        if (nudBudget.Value == 0)
                        {
                            foreach (var item in getPackages)
                            {
                                var newRow = new List<string>()
                                {
                                    item.packageId.ToString(), item.packageTier,
                                    item.packageName, item.packageValue.ToString(),
                                    item.packageQuantity.ToString()
                                };
                                var getBenefits = (from x in context.Benefits
                                                   where x.packageIdFK == item.packageId
                                                   select x.benefitName).ToList();
                                if (benefits.Count == 0)
                                {
                                    if (getBenefits.Contains("Online"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Flyer"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Banner"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    dataGridView1.Rows.Add(newRow.ToArray());
                                }
                                else
                                {
                                    var boolCheck = true;
                                    foreach (var benefit in benefits)
                                    {
                                        if (!getBenefits.Contains(benefit))
                                        {
                                            boolCheck = false;
                                        }
                                        if (boolCheck == false)
                                        {
                                            break;
                                        }
                                    }
                                    if (boolCheck == false)
                                    {
                                        continue;
                                    }
                                    if (getBenefits.Contains("Online"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Flyer"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Banner"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    dataGridView1.Rows.Add(newRow.ToArray());
                                }

                            }
                        }
                        else
                        {
                            var filtered = getPackages.Where(x => x.packageValue <= nudBudget.Value);
                            foreach (var item in filtered)
                            {
                                var newRow = new List<string>()
                                {
                                    item.packageId.ToString(), item.packageTier,
                                    item.packageName, item.packageValue.ToString(),
                                    item.packageQuantity.ToString()
                                };
                                var getBenefits = (from x in context.Benefits
                                                   where x.packageIdFK == item.packageId
                                                   select x.benefitName).ToList();
                                if (benefits.Count == 0)
                                {
                                    if (getBenefits.Contains("Online"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Flyer"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Banner"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    dataGridView1.Rows.Add(newRow.ToArray());
                                }
                                else
                                {
                                    var boolCheck = true;
                                    foreach (var benefit in benefits)
                                    {
                                        if (!getBenefits.Contains(benefit))
                                        {
                                            boolCheck = false;
                                        }
                                        if (boolCheck == false)
                                        {
                                            break;
                                        }
                                    }
                                    if (boolCheck == false)
                                    {
                                        continue;
                                    }
                                    if (getBenefits.Contains("Online"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Flyer"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    if (getBenefits.Contains("Banner"))
                                    {
                                        newRow.Add("Yes");
                                    }
                                    else
                                    {
                                        newRow.Add("");
                                    }
                                    dataGridView1.Rows.Add(newRow.ToArray());
                                }

                            }
                        }


                    }
                }

            }
        }

        private void LoadTiers()
        {
            cbTier.Items.Clear();
            cbTier.Items.Add("No Filter");
            using (var context = new Session2Entities())
            {
                var getTiers = (from x in context.Packages
                                select x.packageTier).Distinct().ToArray();
                cbTier.Items.AddRange(getTiers);
            }
            cbTier.SelectedIndex = 0;
        }

        private void cbTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTier.SelectedItem.ToString() == "No Filter" && nudBudget.Value == 0 && benefits.Count == 0)
            {
                LoadData(0);
            }
            else
            {
                LoadData(1);
            }
        }

        private void nudBudget_ValueChanged(object sender, EventArgs e)
        {
            LoadData(1);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a package!");
            }
            else
            {
                var getTotal = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                if (getTotal - nudQuantity.Value < 0)
                {
                    MessageBox.Show("Unable to book! Not enough quantity!");
                }
                else
                {
                    var getPackageID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    using (var context = new Session2Entities())
                    {
                        var newBooking = new Booking()
                        {
                            packageIdFK = getPackageID,
                            quantityBooked = Convert.ToInt32(nudQuantity.Value),
                            status = "Pending",
                            userIdFK = _user.userId
                        };
                        context.Bookings.Add(newBooking);
                        context.SaveChanges();
                        MessageBox.Show("Successfully booked! Please wait for approval!");
                    }
                }
            }
        }
    }
}
