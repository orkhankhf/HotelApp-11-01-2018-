using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class AddNewDetail : Form
    {
        public AddNewDetail()
        {
            InitializeComponent();
        }

        private void add_detail_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string detail_name = add_detail_name.Text;
                HotelDatabaseEntities db = new HotelDatabaseEntities();
                Room_Details detail = new Room_Details();
                detail.detail_name = detail_name;
                db.Room_Details.Add(detail);
                db.SaveChanges();
                add_detail_name.Text = "";
                MessageBox.Show("Room Detail Added!");
            }
            catch
            {
                MessageBox.Show("Please try again!");
            }
        }
    }
}
