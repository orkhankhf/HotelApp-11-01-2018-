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
    public partial class BindPhotoToRoom : Form
    {
        public BindPhotoToRoom()
        {
            InitializeComponent();
        }

        private void BindPhotoToRoom_Load(object sender, EventArgs e)
        {
            HotelDatabaseEntities db = new HotelDatabaseEntities();
            bind_room_to_photo_room_number.DataSource = db.Rooms.ToList();
            bind_room_to_photo_room_number.ValueMember = "id";
            bind_room_to_photo_room_number.DisplayMember = "room_number";

            bind_room_to_photo_photo_name.DataSource = db.Photos.ToList();
            bind_room_to_photo_photo_name.ValueMember = "id";
            bind_room_to_photo_photo_name.DisplayMember = "image_name";
        }

        private void bind_btn_Click(object sender, EventArgs e)
        {
            int room_id = Convert.ToInt32(bind_room_to_photo_room_number.SelectedValue);
            int photo_id = Convert.ToInt32(bind_room_to_photo_photo_name.SelectedValue);
            HotelDatabaseEntities db = new HotelDatabaseEntities();
            Rooms_Photos room_photo = new Rooms_Photos();
            room_photo.room_id = room_id;
            room_photo.photo_id = photo_id;
            db.Rooms_Photos.Add(room_photo);
            db.SaveChanges();
        }

        private void bind_room_to_photo_photo_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_photo_picturebox.ImageLocation = "../../images/" + bind_room_to_photo_photo_name.Text + ".jpg";
        }
    }
}
