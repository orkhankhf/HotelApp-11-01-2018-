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

namespace HotelApp
{
    public partial class AddNewPhoto : Form
    {
        OpenFileDialog file = new OpenFileDialog();
        private string imgPathAndName;
        private string imgName;
        private bool imgSelected = false;

        public AddNewPhoto()
        {
            InitializeComponent();
        }

        private void select_photo_btn_Click(object sender, EventArgs e)
        {
            file.Title = "Select Room Photo";
            file.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgSelected = true;
                imgPathAndName = file.FileName;
                imgName = file.SafeFileName;
                selected_photo_picturebox.ImageLocation = imgPathAndName;
            }
        }

        private void add_photo_btn_Click(object sender, EventArgs e)
        {
            if (imgSelected)
            {
                try
                {
                    File.Copy(imgPathAndName, "../../images/" + imgName);
                    HotelDatabaseEntities db = new HotelDatabaseEntities();
                    Photos photo = new Photos();
                    photo.image_name = Path.GetFileNameWithoutExtension(imgName);
                    photo.image_src = "images/"+imgName;
                    db.Photos.Add(photo);
                    db.SaveChanges();
                    selected_photo_picturebox.ImageLocation = "";
                    MessageBox.Show("Image added!");
                }
                catch
                {
                    MessageBox.Show("Please try again!");
                }
            }
            else
            {
                MessageBox.Show("Please select an image!");
            }
        }
    }
}
