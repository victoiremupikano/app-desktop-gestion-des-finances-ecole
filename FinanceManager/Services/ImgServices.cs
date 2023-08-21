using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_Management.Services
{
    class ImgServices
    {
        public PictureBox pic { get; set; }

        public PictureBox Take()
        {
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Filter = "Choisir une image(*.jpg; *.png; *.gif; *.ico)|*.jpg; *.png; *.gif; *.ico";
            if (openPic.ShowDialog() == DialogResult.OK)
            {
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.Image = Image.FromFile(openPic.FileName);
            }
            else { }
            return pic;
        }

        public byte[] encoding_img()
        {
            //iMAGE 
            MemoryStream ms = new MemoryStream();
            pic.Image.Save(ms, pic.Image.RawFormat);
            byte[] img = ms.ToArray();
            return img;
        }

        public Image decoding_img(Byte[] var)
        {
            Image result;
            MemoryStream ms = new MemoryStream(var);
            result = Image.FromStream(ms);
            return result;
        }

        // Cette méthode transforme une chaîne de caractère en bytes
        public byte[] transformeEnBytes(string maChaine)
        {
            byte[] bytes = new byte[maChaine.Length * sizeof(char)];
            System.Buffer.BlockCopy(maChaine.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
        // Cette methode sert a enregistrer une image se trouvant dans un picture box
        public bool saveImgChooseLocation(PictureBox pic)
        {
            bool result = false;
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Png Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pic.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case 2:
                        pic.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 3:
                        pic.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 4:
                        pic.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                result = true;
                fs.Close();
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool saveImgAutoLocation(PictureBox pic, string location, string ext)
        {
            bool result = false;
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.ShowDialog();
            saveFileDialog1.FileName = @"" + location + "." + ext;
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                pic.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                result = true;
                fs.Close();
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
