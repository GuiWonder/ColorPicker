using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace ColorPicker
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = System.TimeSpan.FromSeconds(0.1);
            timer.Start();
            timer.Tick += Timer_Tick;
        }
        [System.Runtime.InteropServices.DllImport("User32")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [System.Runtime.InteropServices.DllImport("gdi32")]
        public static extern uint GetPixel(IntPtr h, PT p);
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern void GetCursorPos(out PT p);
        [System.Runtime.InteropServices.DllImport("User32")]
        public static extern IntPtr ReleaseDC(int hwnd, IntPtr Hdc);
        public struct PT
        {
            int x;
            int y;
        };
        private void Timer_Tick(object sender, EventArgs e)
        {
            IntPtr hdc = GetDC(new IntPtr(0));
            GetCursorPos(out PT p);
            uint color = GetPixel(hdc, p);
            ReleaseDC(0, hdc);
            uint red = (color & 0xFF);
            uint green = (color & 0xFF00) / 256;
            uint blue = (color & 0xFF0000) / 65536;
            textBox2.Text = red.ToString() + "," + green.ToString() + "," + blue.ToString();
            Color color1 = new Color();
            color1 = Color.FromRgb((byte)red, (byte)green, (byte)blue);
            Rectangle1.Fill = new SolidColorBrush(color1);
            textBox1.Text = "#" + color1.ToString().Substring(3);
        }

        private void textIn_TextChanged(object sender, TextChangedEventArgs e)
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
                Color color1 = Color.FromRgb((byte)r, (byte)g, (byte)b);
                if (Rectangle2 != null && text10 != null)
                {
                    Rectangle2.Fill = new SolidColorBrush(color1);
                    text10.Text = r + "," + g + "," + b;
                }
            }
            catch //(Exception ex)
            { //MessageBox.Show(ex.Message);
                textIn.Text = "000000";
            }
        }

        private void textIn_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.Key < 34 || (int)e.Key > 49)
                e.Handled = true;
        }

        private void textRGB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
                if (!string.IsNullOrWhiteSpace(((TextBox)sender).Text))
                {
                    if (int.Parse(((TextBox)sender).Text) > 255)
                    {
                        ((TextBox)sender).Text = "255";
                    }
                    if (textBoxR != null && textBoxG != null && textBoxB != null && Rectangle2 != null)
                    {
                        SetColor();
                    }
                }
            }
            catch //(Exception ex)
            { //MessageBox.Show(ex.Message); 
                ((TextBox)sender).Text = "0";
            }
        }

        private void SetColor()
        {
            int r = string.IsNullOrWhiteSpace(textBoxR.Text) ? 0 : int.Parse(textBoxR.Text);
            int g = string.IsNullOrWhiteSpace(textBoxG.Text) ? 0 : int.Parse(textBoxG.Text);
            int b = string.IsNullOrWhiteSpace(textBoxB.Text) ? 0 : int.Parse(textBoxB.Text);
            Color color1 = Color.FromRgb((byte)r, (byte)g, (byte)b);
            Rectangle2.Fill = new SolidColorBrush(color1);
            text16.Text = "#" + (Convert.ToString(r, 16).PadLeft(2, '0') + g.ToString("x").PadLeft(2, '0') + b.ToString("x").PadLeft(2, '0')).ToUpper();
        }

        private void textBoxRGB_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.Key < 34 || (int)e.Key > 43)
                e.Handled = true;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e) => Topmost = (bool)CheckBox.IsChecked;

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl)
                textIn.Text = textBox1.Text.Substring(1);
        }
    }
}
