using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР8
{
    public partial class Form1 : Form
    {
        bool drawing;
        int historyCounter;
        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;
        Color historyColor;
        List<Image> History;

        Form2 form2 = new Form2(Color.Black);

        public Form1()
        {
            InitializeComponent();

            drawing = false;
            currentPen = new Pen(Color.Black);
            historyColor = currentPen.Color;
            currentPen.Width = trackBar1.Value;
            History = new List<Image>();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;

            Bitmap pic = new Bitmap(724, 391);
            pictureBoxDrawingSurface.Image = pic;
            History.Add(new Bitmap(pictureBoxDrawingSurface.Image));
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Сохранить";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.pictureBoxDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBoxDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.pictureBoxDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.pictureBoxDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
            if (pictureBoxDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: сохранитьToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }

            Graphics g = Graphics.FromImage(pictureBoxDrawingSurface.Image);
            g.Clear(Color.White);
            g.DrawImage(pictureBoxDrawingSurface.Image, 0, 0, 750, 500);
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Открыть";
            OP.FilterIndex = 1;
            if (OP.ShowDialog() != DialogResult.Cancel)
                pictureBoxDrawingSurface.Load(OP.FileName);
            pictureBoxDrawingSurface.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(724, 391);
            pictureBoxDrawingSurface.Image = pic;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Сохранить";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();

            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.pictureBoxDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBoxDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.pictureBoxDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.pictureBoxDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
            if (pictureBoxDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: toolStripButtonSave_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Открыть";
            OP.FilterIndex = 1;
            if (OP.ShowDialog() != DialogResult.Cancel)
                pictureBoxDrawingSurface.Load(OP.FileName);
            pictureBoxDrawingSurface.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            form2.Owner = this;
            form2.ShowDialog();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //сделать диалоговое окно с версией программы, имя разработчика, возможности программы.
            MessageBox.Show("версия программы 1.0 разработчик Заеблина П.Д. возможности программы: красота и практичность");
        }

        private void pictureBoxDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBoxDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
            
            if (e.Button == MouseButtons.Right)
            {
                currentPen.Color = Color.White;
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }

        }

        private void pictureBoxDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch { };

            if (e.Button == MouseButtons.Left)
            {
                currentPen.Color = historyColor;
            }
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch { };

            //History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(pictureBoxDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);
        }

        private void pictureBoxDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(pictureBoxDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                pictureBoxDrawingSurface.Invalidate();
            }

            label1.Text = e.X.ToString() + "," + e.Y.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar1.Value;
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                pictureBoxDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void вернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                pictureBoxDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void солидныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;

            солидныйToolStripMenuItem.Checked = true;
            точкиToolStripMenuItem.Checked = false;
            тОчкаТиреToolStripMenuItem.Checked = false;

        }

        private void точкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;

            солидныйToolStripMenuItem.Checked = false;
            точкиToolStripMenuItem.Checked = true;
            тОчкаТиреToolStripMenuItem.Checked = false;
        }

        private void тОчкаТиреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;

            солидныйToolStripMenuItem.Checked = false;
            точкиToolStripMenuItem.Checked = false;
            тОчкаТиреToolStripMenuItem.Checked = true;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Owner = this;
            form2.ShowDialog();
        }
    }



}
