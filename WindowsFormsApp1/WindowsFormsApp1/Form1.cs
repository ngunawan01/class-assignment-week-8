using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int subtotal = 0;
        DataTable dt = new DataTable();
        List<string> listItem = new List<string>() { "T-Shirt Kerah Bulat", "T-Shirt Kerah Bulat 2", "T-Shirt Biru Tua", "Shirt Hitam", "Shirt Toska", "Shirt Mboh", "Pants Krem", "Pants Krem 2", "Pants Biru Tua", "L Pants Hijau toska", "L Pants Hijau", "L Pants Purple", "Jewelleries 1", "Jewelleries 2", "Jewelleies 3", "Accesories 1", "Accesories 2", "Accesories 3" };
        List<string> listHarga = new List<string>() { "150000", "100000", "120000", "120000", "110000", "190000", "140000", "190000", "180000", "160000", "110000", "130000", "190000", "160000", "140000", "120000", "180000", "120000" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Item");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Price");
            dt.Columns.Add("Total");
            dgv.DataSource = dt;

        }

        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Text = "Add To Cart";
                btn.Size = new Size(100, 50);
                btn.Tag = i;
                btn.Location = new Point((i) * 120, 220);
                btn.Click += Btn_Click;
                //btn.Image = imageListTShirt.Images[i];
                panel1.Controls.Add(btn);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 150);
                pictureBox.Location = new Point(i * 120, 0);
                pictureBox.Tag = "tshirt" + i;
                pictureBox.Image = imageListTShirt.Images[i];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(pictureBox);

                if (i == 0)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[0];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[0];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else if (i == 1)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[1];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[1];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[2];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[2];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button buttonSender = sender as Button;
            //Label labelSender = sender as Label;
            //int intABC = Convert.ToInt32(buttonSender.Tag);
            bool isTrue = false;
            int helper = 0;
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == listItem[Convert.ToInt32(buttonSender.Tag)])
                    {
                        isTrue = true;
                        helper = i;
                    }
                }
            }

            if (isTrue == true)
            {
                dt.Rows[helper][1] = Convert.ToInt32(dt.Rows[helper][1]) + 1;
                dt.Rows[helper][3] = Convert.ToInt32(dt.Rows[helper][1]) * Convert.ToInt32(listHarga[Convert.ToInt32(buttonSender.Tag)]);
            }
            else
            {
                dt.Rows.Add(listItem[Convert.ToInt32(buttonSender.Tag)], 1, Convert.ToInt32(listHarga[Convert.ToInt32(buttonSender.Tag)]), Convert.ToInt32(listHarga[Convert.ToInt32(buttonSender.Tag)]));
            }

            subtotal = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                subtotal += Convert.ToInt32(dt.Rows[i][3]);
            }

            textBoxSubTotal.Text = subtotal.ToString();
            textBoxTotal.Text = (subtotal * 1.1).ToString();
            dgv.DataSource = dt;
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Text = "Add To Cart";
                btn.Size = new Size(100, 50);
                btn.Tag = i + 3;
                btn.Location = new Point((i) * 120, 220);
                btn.Click += Btn_Click;
                //btn.Image = imageListTShirt.Images[i];
                panel1.Controls.Add(btn);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 150);
                pictureBox.Location = new Point(i * 120, 0);
                pictureBox.Tag = "tshirt" + i;
                pictureBox.Image = imageListTShirt.Images[i + 3];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(pictureBox);

                if (i == 0)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[3];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[3];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else if (i == 1)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[4];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[4];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[5];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[5];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }
            }
        }

        private void shortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Text = "Add To Cart";
                btn.Size = new Size(100, 50);
                btn.Tag = i + 6;
                btn.Location = new Point((i) * 120, 220);
                btn.Click += Btn_Click;
                //btn.Image = imageListTShirt.Images[i];
                panel1.Controls.Add(btn);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 150);
                pictureBox.Location = new Point(i * 120, 0);
                pictureBox.Tag = "tshirt" + i;
                pictureBox.Image = imageListTShirt.Images[i + 6];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(pictureBox);

                if (i == 0)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[6];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[6];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else if (i == 1)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[7];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[7];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[8];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[8];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }
            }
        }

        private void longPantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Text = "Add To Cart";
                btn.Size = new Size(100, 50);
                btn.Tag = i + 9;
                btn.Location = new Point((i) * 120, 220);
                btn.Click += Btn_Click;
                //btn.Image = imageListTShirt.Images[i];
                panel1.Controls.Add(btn);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 150);
                pictureBox.Location = new Point(i * 120, 0);
                pictureBox.Tag = "tshirt" + i;
                pictureBox.Image = imageListTShirt.Images[i + 9];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(pictureBox);

                if (i == 0)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[9];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[9];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else if (i == 1)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[10];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[10];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[11];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[11];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }
            }
        }

        private void jewelleriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Text = "Add To Cart";
                btn.Size = new Size(100, 50);
                btn.Tag = i + 12;
                btn.Location = new Point((i) * 120, 220);
                btn.Click += Btn_Click;
                //btn.Image = imageListTShirt.Images[i];
                panel1.Controls.Add(btn);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 150);
                pictureBox.Location = new Point(i * 120, 0);
                pictureBox.Tag = "tshirt" + i;
                pictureBox.Image = imageListTShirt.Images[i + 12];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(pictureBox);

                if (i == 0)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[12];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[12];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else if (i == 1)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[13];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[13];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[14];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[14];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }
            }
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Text = "Add To Cart";
                btn.Size = new Size(100, 50);
                btn.Tag = i + 15;
                btn.Location = new Point((i) * 120, 220);
                btn.Click += Btn_Click;
                //btn.Image = imageListTShirt.Images[i];
                panel1.Controls.Add(btn);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 150);
                pictureBox.Location = new Point(i * 120, 0);
                pictureBox.Tag = "tshirt" + i;
                pictureBox.Image = imageListTShirt.Images[i + 15];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(pictureBox);

                if (i == 0)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[15];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[15];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else if (i == 1)
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[16];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[16];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }

                else
                {
                    Label label = new Label();
                    label.Tag = "tshirt" + i;
                    label.Text = listItem[17];
                    label.Size = new Size(100, 50);
                    label.Location = new Point(i * 120, 151);

                    Label label2 = new Label();
                    label2.Tag = "tshirt" + i;
                    label2.Text = listHarga[17];
                    label2.Size = new Size(100, 50);
                    label2.Location = new Point(i * 120, 200);
                    panel1.Controls.Add(label);
                    panel1.Controls.Add(label2);
                }
            }
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dt.Rows[e.RowIndex][3] = Convert.ToInt32(dt.Rows[e.RowIndex][2]) * Convert.ToInt32(dt.Rows[e.RowIndex][1]);
            if (Convert.ToInt32(dt.Rows[e.RowIndex][1]) == 0)
            {
                dt.Rows.Remove(dt.Rows[e.RowIndex]);
            }

            subtotal = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                subtotal += Convert.ToInt32(dt.Rows[i][3]);
            }

            textBoxSubTotal.Text = subtotal.ToString();
            textBoxTotal.Text = (subtotal * 1.1).ToString();
        }
    }
}
