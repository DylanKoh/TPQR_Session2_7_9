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
    public partial class UpdateBooking : Form
    {
        User _user;
        public UpdateBooking(User user)
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

        private void UpdateBooking_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            long total = 0;
            using (var context = new Session2Entities())
            {
                var getBookings = (from x in context.Bookings
                                   where x.userIdFK == _user.userId && x.status == "Approved"
                                   select x);
                foreach (var item in getBookings)
                {
                    var newRow = new List<string>()
                    {
                        item.bookingId.ToString(), item.Package.packageTier,
                        item.Package.packageName, item.Package.packageValue.ToString(), item.quantityBooked.ToString(),
                        (item.Package.packageValue * item.quantityBooked).ToString()
                    };
                    total += item.Package.packageValue * item.quantityBooked;
                    dataGridView1.Rows.Add(newRow.ToArray());
                }
                lblTotal.Text = total.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking to delete!");
            }
            else
            {
                var getBookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("Are you sure you want to delete this booking?", "Delete Booking", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var context = new Session2Entities())
                    {
                        var getBooking = (from x in context.Bookings
                                          where x.bookingId == getBookingID
                                          select x).FirstOrDefault();
                        context.Bookings.Remove(getBooking);
                        context.SaveChanges();
                        MessageBox.Show("Deleted booking!");
                        UpdateBooking_Load(null, null);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking to delete!");
            }
            else
            {
                var getBookingID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (var context = new Session2Entities())
                {
                    var getBooking = (from x in context.Bookings
                                      where x.bookingId == getBookingID
                                      select x).FirstOrDefault();
                    var getPackage = (from x in context.Packages
                                      where x.packageId == getBooking.packageIdFK
                                      select x).FirstOrDefault();
                    if (getPackage.packageQuantity + getBooking.quantityBooked - nudQuantity.Value < 0)
                    {
                        MessageBox.Show("Unable to update! Not enough stock!");
                    }
                    else
                    {
                        getPackage.packageQuantity = getPackage.packageQuantity + getBooking.quantityBooked;
                        context.SaveChanges();
                        getBooking.quantityBooked = Convert.ToInt32(nudQuantity.Value);
                        getBooking.status = "Pending";
                        context.SaveChanges();
                        MessageBox.Show("Updated quantity successful! Please wait for new approval!");
                        UpdateBooking_Load(null, null);
                    }
                }

            }
        }
    }
}
