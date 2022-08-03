using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Цвет
{
    public partial class FormColor : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        Bitmap bmp, orig;
        int w1, h1;
        Color colOld, colNew;
        int a, r, g, b, gray;

        int rr = 0;
        int gg = 0;
        int bb = 0;
        int tr = 0;
        int dd = 0;
        Random rnd = new Random();

        public FormColor()
        {
            InitializeComponent();
        }        

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result;
            //result = MessageBox.Show("Вы уверены, что хотите завершить работу?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.No) e.Cancel = true;
            //else e.Cancel = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Title = "Открыть изображение";
            ofd.Filter = "*.bmp|*.bmp;|*.png|*.png;|*.jpg|*.jpg";
            if (this.ofd.ShowDialog() == DialogResult.OK)
            {                
                this.pictureBoxPict.Load(this.ofd.FileName);
                orig = new Bitmap(pictureBoxPict.Image);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxPict.SizeMode = PictureBoxSizeMode.AutoSize;
            Bitmap bm = new Bitmap(pictureBoxPict.Width, pictureBoxPict.Height);
            pictureBoxPict.DrawToBitmap(bm, pictureBoxPict.Bounds);
            sfd.Title = "Сохранить изображение как ...";
            sfd.Filter = "*.bmp|*.bmp;|*.png|*.png;|*.jpg|*.jpg";
            sfd.AddExtension = true;
            sfd.FileName = "graphicImage";
            if (this.sfd.ShowDialog() == DialogResult.OK)
            {
                bm.Save(sfd.FileName);
                MessageBox.Show("Файл успешно сохранен");
            }
            pictureBoxPict.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // вращать по часовой на 90 градусов
        private void buttonClockwise_Click(object sender, EventArgs e)
        {
            if (pictureBoxPict.Image == null)
            {
                MessageBox.Show("Загрузите изображение!");
                return;
            }
            else
            {
                bmp = new Bitmap(pictureBoxPict.Image);
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBoxPict.Image = bmp;
            }            
        }

        // вращать по часовой на 270 градусов (против часовой на 90)
        private void buttonCounterClockwise_Click(object sender, EventArgs e)
        {
            if (pictureBoxPict.Image == null)
            {
                MessageBox.Show("Загрузите изображение!");
                return;
            }
            else
            {
                bmp = new Bitmap(pictureBoxPict.Image);
                bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBoxPict.Image = bmp;
            }            
        }

        // отразить зеркально верх и низ
        private void buttonFlipTopBottom_Click(object sender, EventArgs e)
        {
            if (pictureBoxPict.Image == null)
            {
                MessageBox.Show("Загрузите изображение!");
                return;
            }
            else
            {
                bmp = new Bitmap(pictureBoxPict.Image);
                bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBoxPict.Image = bmp;
            }            
        }

        // отразить зеркально лево и право
        private void buttonFlipLeftRight_Click(object sender, EventArgs e)
        {
            if (pictureBoxPict.Image == null)
            {
                MessageBox.Show("Загрузите изображение!");
                return;
            }
            else
            {
                bmp = new Bitmap(pictureBoxPict.Image);
                bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBoxPict.Image = bmp;
            }            
        }

        // увеличить изображение
        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            pictureBoxPict.SizeMode = PictureBoxSizeMode.Zoom;
            if (pictureBoxPict.Image == null)
            {
                MessageBox.Show("Загрузите изображение!");
                return;
            }
            else pictureBoxPict.Size = new Size(pictureBoxPict.Width + 10, pictureBoxPict.Height + 10);            
        }

        // уменьшить изображение
        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            pictureBoxPict.SizeMode = PictureBoxSizeMode.Zoom;
            if (pictureBoxPict.Image == null)
            {
                MessageBox.Show("Загрузите изображение!");
                return;
            }
            else
            {
                try
                {
                    pictureBoxPict.Size = new Size(pictureBoxPict.Width - 10, pictureBoxPict.Height - 10);
                }
                catch
                {
                    pictureBoxPict.Width = 1;
                    pictureBoxPict.Height = 1;
                }
            }
        }

        // очистить изображение
        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxPict.Image = null;
        }

        private void FormColor_Load(object sender, EventArgs e)
        {
            orig = new Bitmap(pictureBoxPict.Image);
            bmp = new Bitmap(pictureBoxPict.Image);
            w1 = pictureBoxPict.Width;
            h1 = pictureBoxPict.Height;
        }

        // вернуться к исходному изображению
        private void buttonOriginal_Click(object sender, EventArgs e)
        {
            pictureBoxPict.Image = orig;
            pictureBoxPict.Width = w1;
            pictureBoxPict.Height = h1;
        }        

        private void pictureBoxPict_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBoxPict.SizeMode = PictureBoxSizeMode.AutoSize;
            using (Bitmap bmp = new Bitmap(pictureBoxPict.Image))
            {
                pictureBoxPict.DrawToBitmap(bmp, pictureBoxPict.ClientRectangle);
                Color color = bmp.GetPixel(e.X, e.Y);
                int red = color.R;
                int green = color.G;
                int blue = color.B;
                int trans = color.A;                

                textBoxOriginal.Text = Convert.ToString("A = " + trans + ", R = " + red + ", G = " + green + ", B = " + blue);
                pictureBoxOriginal.BackColor = (pictureBoxPict.Image as Bitmap).GetPixel(e.X, e.Y);
            }
        }
        
        private void buttonPalette_Click(object sender, EventArgs e)
        {
            colorDialogEditor.ShowDialog();
            pictureBoxDesire.BackColor = colorDialogEditor.Color;
            int red = colorDialogEditor.Color.R;
            int green = colorDialogEditor.Color.G;
            int blue = colorDialogEditor.Color.B;
            int trans = colorDialogEditor.Color.A;
            textBoxDesire.Text = Convert.ToString("A = " + trans + ", R = " + red + ", G = " + green + ", B = " + blue);
            textBoxRed.Text = Convert.ToString(red);
            textBoxGreen.Text = Convert.ToString(green);
            textBoxBlue.Text = Convert.ToString(blue);
            textBoxTrans.Text = Convert.ToString(trans);
            trackBarRed.Value = red;
            trackBarGreen.Value = green;
            trackBarBlue.Value = blue;
            trackBarTrans.Value = trans;
        }
        
        private void textBoxRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            rr = trackBarRed.Value;
            gg = trackBarGreen.Value;
            bb = trackBarBlue.Value;
            tr = trackBarTrans.Value;
            dd = trackBarAdmit.Value;
            textBoxTrans.Text = Convert.ToString(tr);
            textBoxRed.Text = Convert.ToString(rr);
            textBoxGreen.Text = Convert.ToString(gg);
            textBoxBlue.Text = Convert.ToString(bb);
            textBoxAdmit.Text = Convert.ToString(dd);
            pictureBoxDesire.BackColor = Color.FromArgb(tr, rr, gg, bb);
            textBoxDesire.Text = Convert.ToString("A = " + tr + ", R = " + rr + ", G = " + gg + ", B = " + bb);
        }
        
        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rr = Convert.ToInt32(textBoxRed.Text);
                gg = Convert.ToInt32(textBoxGreen.Text);
                bb = Convert.ToInt32(textBoxBlue.Text);
                tr = Convert.ToInt32(textBoxTrans.Text);
                dd = Convert.ToInt32(textBoxAdmit.Text);
                
                trackBarRed.Value = rr;
                trackBarGreen.Value = gg;
                trackBarBlue.Value = bb;
                trackBarTrans.Value = tr;
                trackBarAdmit.Value = dd;
                pictureBoxDesire.BackColor = Color.FromArgb(tr, rr, gg, bb);
                textBoxDesire.Text = Convert.ToString("A = " + tr + ", R = " + rr + ", G = " + gg + ", B = " + bb);
            }
            catch
            {
                MessageBox.Show("Недопустимое значение в текстовом поле");
                if (textBoxRed.Text == "" || Convert.ToInt32(textBoxRed.Text.ToString()) > 255) textBoxRed.Text = "0";
                if (textBoxGreen.Text == "" || Convert.ToInt32(textBoxGreen.Text.ToString()) > 255) textBoxGreen.Text = "0";
                if (textBoxBlue.Text == "" || Convert.ToInt32(textBoxBlue.Text.ToString()) > 255) textBoxBlue.Text = "0";
                if (textBoxTrans.Text == "" || Convert.ToInt32(textBoxTrans.Text.ToString()) > 255) textBoxTrans.Text = "0";
                if (textBoxAdmit.Text == "" || Convert.ToInt32(textBoxAdmit.Text.ToString()) > 255) textBoxAdmit.Text = "0";
               // return;
                pictureBoxDesire.BackColor = Color.FromArgb(tr, rr, gg, bb);
                textBoxDesire.Text = Convert.ToString("A = " + tr + ", R = " + rr + ", G = " + gg + ", B = " + bb);
               
            }            
        }
        
        private void buttonRecolor_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            try             //проверка наличия изображения
                            //Обработать каждый пиксель изображения
            {
                for (int i = 0; i < pictureBoxPict.Image.Height - 1; i++)
                {
                    for (int j = 0; j < pictureBoxPict.Image.Width - 1; j++)
                    {
                        //Получить цвет текущего пикселя
                        Color color = bmp.GetPixel(j, i);
                        //Проверить каждую составляющую цвета на попадание в диапазон с допуском
                        if (color.R - trackBarAdmit.Value / 2 <= pictureBoxOriginal.BackColor.R
                             && color.R + trackBarAdmit.Value / 2 >= pictureBoxOriginal.BackColor.R
                             && color.G - trackBarAdmit.Value / 2 <= pictureBoxOriginal.BackColor.G
                             && color.G + trackBarAdmit.Value / 2 >= pictureBoxOriginal.BackColor.G
                             && color.B - trackBarAdmit.Value / 2 <= pictureBoxOriginal.BackColor.B
                             && color.B + trackBarAdmit.Value / 2 >= pictureBoxOriginal.BackColor.B)
                        {
                            //Взять цвет для окрашивания
                            Color color2 = Color.FromArgb(tr, rr, gg, bb);
                            //Окрасить созданным цветом текущий пиксель
                            bmp.SetPixel(j, i, color2);
                            //  bmp.MakeTransparent();
                        }
                    }
                }
                pictureBoxPict.Image = bmp;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void чернобелыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {      
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;
                        gray = (r + g + b) / 3;
                        colNew = Color.FromArgb(255, gray, gray, gray);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();                
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void негативToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        r = 255 - color.R;
                        g = 255 - color.G;
                        b = 255 - color.B;
                        colNew = Color.FromArgb(255, r, g, b);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void осветлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;
                        if (r < 245) r = color.R + 10;
                        else r = color.R;
                        if (g < 245) g = color.G + 10;
                        else r = color.G;
                        if (b < 245) b = color.B + 10;
                        else b = color.B;
                        colNew = Color.FromArgb(255, r, g, b);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void затемнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        r = color.R - color.R/20;
                        g = color.G - color.G/20;
                        b = color.B - color.B/20;
                        colNew = Color.FromArgb(255, r, g, b);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        int r1 = color.R;
                        int g1 = color.G;
                        int b1 = color.B;
                        int r2 = (int)(0.393 * r1 + 0.769 * g1 + 0.189 * b1);
                        int g2 = (int)(0.349 * r1 + 0.686 * g1 + 0.168 * b1);
                        int b2 = (int)(0.272 * r1 + 0.534 * g1 + 0.131 * b1);
                        if (r2 > 255) r1 = 255;
                        else r1 = r2;                        
                        if (g2 > 255) g1 = 255;
                        else g1 = g2;
                        if (b2 > 255) b1 = 255;
                        else b1 = b2;
                        colNew = Color.FromArgb(255, r1, g1, b1);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void мозаикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBoxPict.Image);
            int hh = 10;
            int ww = 10;
            using (Graphics graf = Graphics.FromImage(bit))
            {
                for (int j = 0; j < bit.Width; j += ww)
                {
                    for (int i = 0; i < bit.Height; i += hh)
                    {
                        Brush br = new SolidBrush(bit.GetPixel(j, i));
                        graf.FillRectangle(br, j, i, ww, hh);
                    }
                }
            }
            pictureBoxPict.Image = bit;
        }

        private void подсинениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;
                        if (r > 5) r = color.R - 5;
                        else r = color.R;
                        if (g > 5) g = color.G - 5;
                        else r = color.G;
                        if (b < 115) b = color.B + 140;
                        else b = color.B;
                        colNew = Color.FromArgb(255, r, g, b);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void подкраснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;
                        if (r < 205) r = color.R + 50;
                        else r = color.R;
                        if (g > 5) g = color.G - 5;
                        else r = color.G;
                        if (b > 5) b = color.B - 5;
                        else b = color.B;
                        colNew = Color.FromArgb(255, r, g, b);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void чернобелыйБезИзмененияКрасногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        Color color = bmp.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;
                        gray = (r + g + b) / 3;
                        colNew = Color.FromArgb(255, r, gray, gray);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void цветовойШумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        int ai = rnd.Next(5, 10);
                        int aj = rnd.Next(5, 10);
                        Color color = bmp.GetPixel(i, j);
                        if (i % ai == 0 && j % aj == 0)
                        {
                            r = rnd.Next(0, 255);
                            g = rnd.Next(0, 255);
                            b = rnd.Next(0, 255);
                        }
                        else
                        {
                            r = color.R;
                            g = color.G;
                            b = color.B;
                        }
                        colNew = Color.FromArgb(255, r, g, b);
                        outB.SetPixel(i, j, colNew);
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(pictureBoxPict.Image);
            int hh = 4;
            int ww = 4;
            using (Graphics graf = Graphics.FromImage(bit))
            {
                for (int j = 0; j < bit.Width; j += ww)
                {
                    for (int i = 0; i < bit.Height; i += hh)
                    {
                        Brush br = new SolidBrush(bit.GetPixel(j, i));
                        graf.FillEllipse(br, j, i, ww, hh);
                    }
                }
            }
            pictureBoxPict.Image = bit;

            bmp = new Bitmap(pictureBoxPict.Image);
            Bitmap outB = new Bitmap(bmp.Width, bmp.Height);
            try
            {
                for (int j = 0; j < pictureBoxPict.Image.Height; j++)
                {
                    for (int i = 0; i < pictureBoxPict.Image.Width; i++)
                    {
                        int ai = rnd.Next(1, 2);
                        int aj = rnd.Next(1, 2);
                        Color color = bmp.GetPixel(i, j);
                        r = color.R;
                        g = color.G;
                        b = color.B;
                        if (i < 3 || j < 3 || j > pictureBoxPict.Image.Height - 3 || i > pictureBoxPict.Image.Width - 3)
                        {
                            colNew = Color.FromArgb(255, r, g, b);
                            outB.SetPixel(i, j, colNew);
                        }
                        else if (i % 2 == 0 || j % 2 == 0)
                        {                            
                            colNew = Color.FromArgb(255, r, g, b);
                            outB.SetPixel(i+ai, j-aj, colNew);
                        }
                        else
                        {                            
                            colNew = Color.FromArgb(255, r, g, b);
                            outB.SetPixel(i - ai, j + aj, colNew);
                        }                                                
                    }
                }
                pictureBoxPict.Image = outB;
                pictureBoxPict.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
