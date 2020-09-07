using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session2_7_9
{
    public partial class ViewSummary : Form
    {
        public ViewSummary()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new ManagerMain()).ShowDialog();
            Close();
        }

        private void ViewSummary_Load(object sender, EventArgs e)
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
            LoadGraph();
        }

        private void LoadGraph()
        {
            using (var context = new Session2Entities())
            {
                chart1.Series[0].Points.Clear();
                long total = 0;
                if (cbTier.SelectedItem.ToString() == "No Filter")
                {
                    var getBookings = (from x in context.Bookings
                                       group x by x.Package.packageName into y
                                       select y);
                    foreach (var item in getBookings)
                    {
                        total += item.Sum(x => x.quantityBooked * x.Package.packageValue);
                        var idx = chart1.Series[0].Points.AddY(item.Sum(x => x.quantityBooked));
                        chart1.Series[0].Points[idx].AxisLabel = item.Key;
                        chart1.Series[0].Points[idx].LabelToolTip = $"{item.Key}, {item.Sum(x => x.quantityBooked)}, #PERCENT";
                    }
                    lblTotal.Text = total.ToString();
                }
                else
                {
                    var getBookings = (from x in context.Bookings
                                       where x.Package.packageTier == cbTier.SelectedItem.ToString()
                                       group x by x.Package.packageName into y
                                       select y);
                    foreach (var item in getBookings)
                    {
                        total += item.Sum(x => x.quantityBooked * x.Package.packageValue);
                        var idx = chart1.Series[0].Points.AddY(item.Sum(x => x.quantityBooked));
                        chart1.Series[0].Points[idx].AxisLabel = item.Key;
                        chart1.Series[0].Points[idx].LabelToolTip = $"{item.Key}, {item.Sum(x => x.quantityBooked)}, #PERCENT";
                    }
                    lblTotal.Text = total.ToString();
                }
            }
            
        }
    }
}
