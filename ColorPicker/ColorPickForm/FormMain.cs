using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPick
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("User32")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        public static extern uint GetPixel(IntPtr h, Point p);
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern void GetCursorPos(out Point p);
        [System.Runtime.InteropServices.DllImport("User32")]
        public static extern IntPtr ReleaseDC(int hwnd, IntPtr Hdc);

        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr hdc = GetDC(new IntPtr(0));
            GetCursorPos(out Point p);
            uint color = GetPixel(hdc, p);
            ReleaseDC(0, hdc);
            uint red = (color & 0xFF);
            uint green = (color & 0xFF00) / 256;
            uint blue = (color & 0xFF0000) / 65536;
            textBox1.Text = "#" + (Convert.ToString(red, 16).PadLeft(2, '0') + green.ToString("x").PadLeft(2, '0') + blue.ToString("x").PadLeft(2, '0')).ToUpper();
            textBox2.Text = red.ToString() + "," + green.ToString() + "," + blue.ToString();
            Color color1 = new Color();
            color1 = Color.FromArgb((int)red, (int)green, (int)blue);
            pictureBox1.BackColor = color1;
        }

        private void textIn_TextChanged(object sender, EventArgs e)
        {
            string input = textIn.Text;
            string rs = "";
            string gs = "";
            string bs = "";
            int r;
            int g;
            int b;
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i < 2)
                    {
                        rs += input.Substring(i, 1);
                    }
                    else if (i < 4)
                    {
                        gs += input.Substring(i, 1);
                    }
                    else
                    {
                        bs += input.Substring(i, 1);
                    }
                }
                if (rs == "")
                {
                    r = 0;
                }
                else
                {
                    r = (int)Convert.ToUInt64(rs, 16);
                }
                if (gs == "")
                {
                    g = 0;
                }
                else
                {
                    g = (int)Convert.ToUInt64(gs, 16);
                }
                if (bs == "")
                {
                    b = 0;
                }
                else
                {
                    b = (int)Convert.ToUInt64(bs, 16);
                }
                pictureBox2.BackColor = Color.FromArgb(r, g, b);
                label10.Text = r + "," + g + "," + b;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); textIn.Text = "000000"; }
        }

        private void textIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0') || e.KeyChar > 'f') && e.KeyChar != (char)8)
                e.KeyChar = (char)0;
            if (e.KeyChar > 'F' && e.KeyChar < 'a')
                e.KeyChar = (char)0;
            if (e.KeyChar > '9' && e.KeyChar < 'A')
                e.KeyChar = (char)0;
        }

        private void textBoxRGB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void textBoxRGB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
                    return;
                if (int.Parse(((TextBox)sender).Text) > 255)
                {
                    ((TextBox)sender).Text = "255";
                }
                SetColor();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); ((TextBox)sender).Text = "0"; }
        }

        private void SetColor()
        {
            int r = string.IsNullOrWhiteSpace(textBoxR.Text) ? 0 : int.Parse(textBoxR.Text);
            int g = string.IsNullOrWhiteSpace(textBoxG.Text) ? 0 : int.Parse(textBoxG.Text);
            int b = string.IsNullOrWhiteSpace(textBoxB.Text) ? 0 : int.Parse(textBoxB.Text);
            pictureBox2.BackColor = Color.FromArgb(r, g, b);
            label16.Text = "#" + (Convert.ToString(r, 16).PadLeft(2, '0') + g.ToString("x").PadLeft(2, '0') + b.ToString("x").PadLeft(2, '0')).ToUpper();
        }

        private void checkBoxTop_CheckedChanged(object sender, EventArgs e) => TopMost = checkBoxTop.Checked;
    }
}
