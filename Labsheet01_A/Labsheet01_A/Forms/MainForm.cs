using System;
using System.Drawing;
using System.Windows.Forms;
using Labsheet01_A.Forms;

namespace Labsheet01_A
{
    public partial class frmMain : Form
    {
        const int MIN_PICTURE_INDEX = 1;
        const int MAX_PICTURE_INDEX = 42;

        const string PICTURE_PREFIX = "_";
        const string DEFAULT_PICTURE_DIALOG_TITLE = "Fuck this shit i'm out..~";
        const string DEFAULT_TEXTBOX_NAME_PLACEHOLDER_TEXT = "Enter name here...";
        const string DEFAULT_TEXTBOX_MESSAGE_PLACEHOLDER_TEXT = "Enter message here...";


        Random dice;
        PictureDialog pictureDialog;


        public frmMain()
        {
            InitializeComponent();
            _Init();
        }

        private void _Init()
        {
            dice = new Random();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtName.Text = DEFAULT_TEXTBOX_NAME_PLACEHOLDER_TEXT;
            txtName.ForeColor = Color.Gray;

            txtMessage.Text = DEFAULT_TEXTBOX_MESSAGE_PLACEHOLDER_TEXT;
            txtMessage.ForeColor = Color.Gray;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var imageObject = _GetImageRandomly(MIN_PICTURE_INDEX, MAX_PICTURE_INDEX);

            var title = "Dear '";
            var message = "You said : '";

            title += (txtName.Text == DEFAULT_TEXTBOX_NAME_PLACEHOLDER_TEXT) ? "Annonymous' : " + DEFAULT_PICTURE_DIALOG_TITLE : txtName.Text + "' : " + DEFAULT_PICTURE_DIALOG_TITLE;
            message += (txtMessage.Text == DEFAULT_TEXTBOX_MESSAGE_PLACEHOLDER_TEXT) ? "" : txtMessage.Text + "'";

            pictureDialog = new PictureDialog(title, message, imageObject);
            pictureDialog.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var obj = sender as TextBox;
            obj.ForeColor = Color.Black;
        }

        private void textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var obj = sender as TextBox;
            if (e.KeyCode != Keys.Tab)
            {
                if (obj.Text.Equals(DEFAULT_TEXTBOX_MESSAGE_PLACEHOLDER_TEXT) || 
                    obj.Text.Equals(DEFAULT_TEXTBOX_NAME_PLACEHOLDER_TEXT))
                { 
                    obj.Text = String.Empty;
                }
            }
        }

        private Bitmap _GetImageRandomly(int minImageIndex, int maxImageIndex)
        {
            var randomIndex = dice.Next(minImageIndex, maxImageIndex + 1);
            var targetPictureName = PICTURE_PREFIX + randomIndex;
            var imageObject = Properties.Resources.ResourceManager.GetObject(targetPictureName) as Bitmap;

            return imageObject;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            var dialogResult = MessageBox.Show("Hey~, outa here now?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

            e.Cancel = (dialogResult == DialogResult.No);
        }
    }
}
