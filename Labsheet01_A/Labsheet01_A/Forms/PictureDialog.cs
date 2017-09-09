using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labsheet01_A.Forms
{
    public partial class PictureDialog : Form
    {
        public PictureDialog()
        {
            InitializeComponent();
        }

        public PictureDialog(string title, string message, Bitmap image) : this()
        {
            this.Text = title;
            rchMessage.Text = message;
            pictureBox.Image = image;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
