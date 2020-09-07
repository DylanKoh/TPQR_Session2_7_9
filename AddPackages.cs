using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session2_7_9
{
    public partial class AddPackages : Form
    {
        List<string> benefits = new List<string>();

        public AddPackages()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new ManagerMain()).ShowDialog();
            Close();
        }

        private void AddPackages_Load(object sender, EventArgs e)
        {
            cbTier.Items.Clear();
            using (var context = new Session2Entities())
            {
                var getTiers = (from x in context.Packages
                                select x.packageTier).Distinct().ToArray();
                cbTier.Items.AddRange(getTiers);
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var values = File.ReadAllLines(txtFilePath.Text).Skip(1);
            var duplicates = 0;
            foreach (var item in values)
            {
                var node = item.Split(',');
                using (var context = new Session2Entities())
                {
                    var packageName = node[1];
                    var findPackage = (from x in context.Packages
                                       where x.packageName == packageName
                                       select x).FirstOrDefault();
                    if (findPackage != null)
                    {
                        duplicates += 1;
                        continue;
                    }
                    else
                    {
                        var newPackage = new Package()
                        {
                            packageTier = node[0],
                            packageName = node[1],
                            packageValue = Int64.Parse(node[2]),
                            packageQuantity = Int32.Parse(node[3])
                        };
                        context.Packages.Add(newPackage);
                        context.SaveChanges();
                    }

                    MessageBox.Show($"Successfully added packages! Number of duplicates = {duplicates}");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTier.SelectedItem == null || string.IsNullOrWhiteSpace(txtPackageName.Text) || nudQuantity.Value == 0 || nudValue.Value == 0 || benefits.Count == 0)
            {
                MessageBox.Show("Please ensure form is fully filled!");
            }
            else if (cbTier.SelectedItem.ToString() == "Gold" && (benefits.Count != 3 || !(nudValue.Value >= 50000)))
            {
                MessageBox.Show("Gold must have all benefits and more than 50k in value!");
            }
            else if (cbTier.SelectedItem.ToString() == "Silver" && (benefits.Count != 2 || !(nudValue.Value > 10000 && nudValue.Value < 50000)))
            {
                MessageBox.Show("Silver must have 2 benefits and between 10k and 50k in value!");
            }
            else if (cbTier.SelectedItem.ToString() == "Bronze" && (benefits.Count != 1 || !(nudValue.Value > 0 && nudValue.Value <= 10000)))
            {
                MessageBox.Show("Bronze must have 1 benefit and less than 10k in value!");
            }
            else
            {
                using (var context = new Session2Entities())
                {
                    var getPackage = (from x in context.Packages
                                      where x.packageName == txtPackageName.Text
                                      select x).FirstOrDefault();
                    if (getPackage != null)
                    {
                        MessageBox.Show("Package already exist!");
                    }
                    else
                    {
                        var newPackage = new Package()
                        {
                            packageName = txtPackageName.Text,
                            packageQuantity = Convert.ToInt32(nudQuantity.Value),
                            packageTier = cbTier.SelectedItem.ToString(),
                            packageValue = Convert.ToInt64(nudValue.Value)
                        };
                        context.Packages.Add(newPackage);
                        context.SaveChanges();
                        var getNewID = (from x in context.Packages
                                        where x.packageName == txtPackageName.Text
                                        select x.packageId).FirstOrDefault();
                        foreach (var item in benefits)
                        {
                            var newBenefits = new Benefit()
                            {
                                benefitName = item,
                                packageIdFK = getNewID
                            };
                            context.Benefits.Add(newBenefits);
                            context.SaveChanges();
                        }
                        MessageBox.Show("Added package successful!");
                        btnClear_Click(null, null);
                    }
                }
            }
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AddPackages_Load(null, null);
            txtFilePath.Text = string.Empty;
            txtPackageName.Text = string.Empty;
            nudQuantity.Value = 0;
            nudValue.Value = 0;
            cbOnline.Checked = false;
            cbFlyer.Checked = false;
            cbBanner.Checked = false;
        }
    }
}
