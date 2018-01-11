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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HotelDatabaseEntities db = new HotelDatabaseEntities();
            add_room_type.DataSource = db.Room_Types.ToList();
            add_room_type.ValueMember = "id";
            add_room_type.DisplayMember = "room_type_name";
        }

        private void add_room_btn_Click(object sender, EventArgs e)
        {
            var room_number = Convert.ToInt32(add_room_number.Text);
            var room_type_id = Convert.ToInt32(add_room_type.SelectedValue);
            var bed_count = Convert.ToInt32(add_room_bed_count.Text);
            var room_price = Convert.ToInt32(add_room_price.Text);
            var reservation_status = add_room_reservation_status.SelectedItem.ToString();
            var cleaning_status = add_room_cleaning_status.SelectedItem.ToString();
            var room_status = add_room_room_status.SelectedItem.ToString();

            try
            {
                HotelDatabaseEntities db = new HotelDatabaseEntities();
                var new_room = new Rooms();
                new_room.room_number = room_number;
                new_room.room_type_id = room_type_id;
                new_room.bed_count = bed_count;
                new_room.room_price = room_price;
                new_room.room_reservation_status = Convert.ToBoolean(reservation_status);
                new_room.room_cleaning_status = Convert.ToBoolean(cleaning_status);
                new_room.room_status = Convert.ToBoolean(room_status);
                db.Rooms.Add(new_room);
                db.SaveChanges();
                MessageBox.Show("New room has created!");
            }
            catch
            {
                MessageBox.Show("Please try again!");
            }
        }

        private void add_new_photo_btn_Click(object sender, EventArgs e)
        {
            AddNewPhoto AddNewPhoto_Page = new AddNewPhoto();
            AddNewPhoto_Page.ShowDialog();
        }

        private void add_new_detail_btn_Click(object sender, EventArgs e)
        {
            AddNewDetail AddNewDetail_Page = new AddNewDetail();
            AddNewDetail_Page.ShowDialog();
        }

        private void add_new_type_btn_Click(object sender, EventArgs e)
        {
            AddNewType AddNewType_Page = new AddNewType();
            AddNewType_Page.ShowDialog();
        }

        private void bind_detail_to_room_btn_Click(object sender, EventArgs e)
        {
            BindDetailToRoom BindDetailToRoom_Page = new BindDetailToRoom();
            BindDetailToRoom_Page.ShowDialog();
        }

        private void bind_photo_to_room_btn_Click(object sender, EventArgs e)
        {
            BindPhotoToRoom BindPhotoToRoom_Page = new BindPhotoToRoom();
            BindPhotoToRoom_Page.ShowDialog();
        }
    }
}
