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
    public partial class ApproveBookings : Form
    {
        public ApproveBookings()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new ManagerMain()).ShowDialog();
            Close();
        }

        private void ApproveBookings_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (var context = new Session2Entities())
            {
                var getBookings = (from x in context.Bookings
                                   orderby x.status == "Rejected", x.status == "Approved", x.status == "Pending"
                                   select x);
                foreach (var item in getBookings)
                {
                    var newRow = new List<string>()
                    {
                        item.bookingId.ToString(), item.User.name,
                        item.Package.packageName, item.status
                    };
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to reject!");
            }
            else
            {
                var boolCheck = true;
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    if (dataGridView1[3, item.Index].Value.ToString() == "Approved" || dataGridView1[3, item.Index].Value.ToString() == "Rejected")
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
                    MessageBox.Show("Unable to reject a non-pending booking!");
                }
                else
                {
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {
                        var getBookingID = Convert.ToInt32(dataGridView1[0, item.Index].Value);
                        using (var context = new Session2Entities())
                        {
                            var getBooking = (from x in context.Bookings
                                              where x.bookingId == getBookingID
                                              select x).FirstOrDefault();
                            getBooking.status = "Rejected";
                            context.SaveChanges();
                        }
                    }
                    MessageBox.Show("Bookings rejected!");
                    ApproveBookings_Load(null, null);
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to approve!");
            }
            else
            {
                var boolCheck = true;
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    if (dataGridView1[3, item.Index].Value.ToString() == "Approved" || dataGridView1[3, item.Index].Value.ToString() == "Rejected")
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
                    MessageBox.Show("Unable to approve a non-pending booking!");
                }
                else
                {
                    var sb = new StringBuilder("Unable to approve:");
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {
                        var getBookingID = Convert.ToInt32(dataGridView1[0, item.Index].Value);
                        using (var context = new Session2Entities())
                        {
                            var getBooking = (from x in context.Bookings
                                              where x.bookingId == getBookingID
                                              select x).FirstOrDefault();
                            var getPackageAmount = (from x in context.Packages
                                                    where x.packageId == getBooking.packageIdFK
                                                    select x).FirstOrDefault();
                            if (getPackageAmount.packageQuantity - getBooking.quantityBooked < 0)
                            {
                                sb.Append($"\n{getBooking.User.name}'s {getBooking.Package.packageName}");
                            }
                            else
                            {
                                getBooking.status = "Approved";
                                getPackageAmount.packageQuantity -= getBooking.quantityBooked;
                                context.SaveChanges();
                            }
                            
                        }
                    }
                    MessageBox.Show($"Bookings approved successfully!\n{sb}");
                    ApproveBookings_Load(null, null);
                }
            }
        }
    }
}
