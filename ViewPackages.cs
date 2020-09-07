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
    public partial class ViewPackages : Form
    {
        public ViewPackages()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new ManagerMain()).ShowDialog();
            Close();
        }

        private void ViewPackages_Load(object sender, EventArgs e)
        {
            rbTier.Checked = true;
        }

        private void rbTier_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (var context = new Session2Entities())
            {
                var getPackages = (from x in context.Packages
                                   orderby x.packageTier == "Bronze", x.packageTier == "Silver", x.packageTier == "Gold"
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

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (var context = new Session2Entities())
            {
                var getPackages = (from x in context.Packages
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

        private void rbValue_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (var context = new Session2Entities())
            {
                var getPackages = (from x in context.Packages
                                   orderby x.packageValue
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

        private void rbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (var context = new Session2Entities())
            {
                var getPackages = (from x in context.Packages
                                   orderby x.packageQuantity descending
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
    }
}
