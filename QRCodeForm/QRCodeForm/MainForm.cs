using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace QRCodeForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            plQrColor.BackColor = Color.Black;
            plBackgroundColor.BackColor = Color.White;
            logoSettingVisible(false); 
            CreateQR(20, @"https://www.cnblogs.com/EminemJK/", Color.Black, Color.White); 
        }
         
        private void CreateQR(int pixelsPerModule, string info, Color qrColor, Color qrBackgroundColor, Bitmap logo, int iconSizePercent = 15, int iconBorderWidth = 6)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(pixelsPerModule, qrColor, qrBackgroundColor, logo, iconSizePercent, iconBorderWidth, true);
            picBoxQRCode.Image = qrCodeImage;
        }

        private void CreateQR(int pixelsPerModule, string info, Color qrColor, Color qrBackgroundColor)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(info, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(pixelsPerModule, qrColor, qrBackgroundColor, true);
            picBoxQRCode.Image = qrCodeImage;
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxOutput.Text))
            {
                MessageBox.Show("内容可以是网址、文字等内容");
                return;
            }
            decimal pixelsPerModule = 20, iconSizePercent = 15, iconBorderWidth = 6;
            if (numQRSize.Value <= 0)
            {
                MessageBox.Show("二维码图片大小不能小于0");
                return;
            }
            pixelsPerModule = numQRSize.Value;

            if (numLogoSize.Value <= 0)
            {
                MessageBox.Show("Logo大小不能小于0");
                return;
            }
            iconSizePercent = numLogoSize.Value;

            if (numLogoBorderSize.Value < 0)
            {
                MessageBox.Show("二维码边框大小不能小于0");
                return;
            }
            iconBorderWidth = numLogoBorderSize.Value;
            Color qrColor = plQrColor.BackColor, qrBackgroundColor = plBackgroundColor.BackColor;

            if (!string.IsNullOrEmpty(txtLogo.Text))
            {
                CreateQR((int)pixelsPerModule, txtBoxOutput.Text, qrColor, qrBackgroundColor, (Bitmap)Bitmap.FromFile(txtLogo.Text), (int)iconSizePercent, (int)iconBorderWidth);
            }
            else
            {
                CreateQR((int)pixelsPerModule, txtBoxOutput.Text, qrColor, qrBackgroundColor);
            }
        }

        /// <summary>
        /// logo设置显示隐藏
        /// </summary>
        /// <param name="b"></param>
        private void logoSettingVisible(bool b)
        {
            lbLogoBorderSize.Visible = lbLogoSize.Visible = numLogoSize.Visible = numLogoBorderSize.Visible = b;
        }

        /// <summary>
        /// 颜色拾取
        /// </summary>
        private void ColorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var pl = sender as Panel;
                pl.BackColor = colorDialog1.Color;
            }
        }

        private void btnSearchLogo_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片|*.jpg;*.png;*.bmp;*.gif";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtLogo.Text = openFileDialog.FileName;
                picBoxLogo.Image = Bitmap.FromFile(txtLogo.Text);
                logoSettingVisible(true);
            }
        }

        private void btnLogoClear_Click(object sender, EventArgs e)
        {
            txtLogo.Text = "";
            picBoxLogo.Image = null;
            logoSettingVisible(false);
        }

        private void btnSavePic_Click(object sender, EventArgs e)
        {
            if (picBoxQRCode.Image != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "图片|*.jpg;*.png";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    var pictureName = saveFile.FileName;
                    Bitmap bmp = new Bitmap(picBoxQRCode.Image);
                    bmp.Save(pictureName, picBoxQRCode.Image.RawFormat);
                    bmp.Dispose();
                }
            }
        }
    }
}
