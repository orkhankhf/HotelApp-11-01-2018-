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
    public partial class AddNewType : Form
    {
        public AddNewType()
        {
            InitializeComponent();
        }

        private void add_type_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string type_name = add_type_name.Text;
                HotelDatabaseEntities db = new HotelDatabaseEntities();
                Room_Types type = new Room_Types();
                type.room_type_name = type_name;
                db.Room_Types.Add(type);
                db.SaveChanges();
                add_type_name.Text = "";
                MessageBox.Show("Room Type Added!");
            }
            catch
            {
                MessageBox.Show("Please try again");
            }
        }
    }
}
