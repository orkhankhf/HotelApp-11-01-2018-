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
    public partial class BindDetailToRoom : Form
    {
        public BindDetailToRoom()
        {
            InitializeComponent();
        }

        private void BindDetailToRoom_Load(object sender, EventArgs e)
        {
            HotelDatabaseEntities db = new HotelDatabaseEntities();
            bind_room_to_detail_room_number.DataSource = db.Rooms.ToList();
            bind_room_to_detail_room_number.ValueMember = "id";
            bind_room_to_detail_room_number.DisplayMember = "room_number";

            bind_room_to_detail_detail.DataSource = db.Room_Details.ToList();
            bind_room_to_detail_detail.ValueMember = "id";
            bind_room_to_detail_detail.DisplayMember = "detail_name";
        }

        private void bind_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int room_id = Convert.ToInt32(bind_room_to_detail_room_number.SelectedValue);
                int detail_id = Convert.ToInt32(bind_room_to_detail_detail.SelectedValue);

                HotelDatabaseEntities db = new HotelDatabaseEntities();
                Rooms_Details detail = new Rooms_Details();
                detail.room_id = room_id;
                detail.detail_id = detail_id;
                db.Rooms_Details.Add(detail);
                db.SaveChanges();
                MessageBox.Show("Room and Detail succesfully binded!");
            }
            catch
            {
                MessageBox.Show("Please try again!");
            }
        }
    }
}
