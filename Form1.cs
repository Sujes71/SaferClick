using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SaferClickByHyak
{
    public partial class Form1 : Form
    {
        public static int xPos, yPos, xPos2, yPos2, xPos3, yPos3, xPos4, yPos4, xPos5, yPos5, xPos6, yPos6, xPos7, yPos7, xPos8, yPos8;

        public static bool flag = false;

        public static Point cursor, cursor2, cursor3, cursor4, cursor5, cursor6, cursor7, cursor8;

        public string cliente = @"C:\Usuarios\el_da\NotaSaferClick.txt", key;

        TextWriter write;

        TextReader read;

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void mouse_event(int dwflags, int dx, int dy, int cbuttons, int dwExtraInfo);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern bool GetAsyncKeyState(Keys vkeys);
        public Form1()
        {
            InitializeComponent();
        }
        private void timer10_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                label10.Show();
                if (key.Equals("Hola Hyak."))
                {
                    if (GetAsyncKeyState(Keys.F1))
                    {
                        label10.Text = "ON";
                        label10.ForeColor = Color.Lime;
                        timer2.Start();
                    }
                    if (GetAsyncKeyState(Keys.F2))
                    {
                        timer2.Stop();
                        timer3.Stop();
                        timer4.Stop();
                        timer5.Stop();
                        timer6.Stop();
                        timer7.Stop();
                        timer8.Stop();
                        timer9.Stop();
                        label10.Text = "OFF";
                        label10.ForeColor = Color.Red;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                write = new StreamWriter(cliente);
                write.WriteLine("Hola Hyak.\nTe informo que la aplicación *Saferclick* está protegida y que no podrás compartirla con otros dispositivos.");
                write.Close();

                read = new StreamReader(cliente);
                key = read.ReadLine();
                read.Close();
                flag = true;
                button1.Hide();
            }
            catch(Exception)
            {
                MessageBox.Show("Contacta a Hyak por discord (Sujesito71#3198) para adquirir el programa.");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!flag)
                label10.Hide();
            if(numericUpDown2.Value != 0)
            {
                timer2.Interval = Convert.ToInt32(numericUpDown2.Value);
            }
            if (numericUpDown3.Value != 0)
            {
                timer3.Interval = Convert.ToInt32(numericUpDown3.Value);
            }
            if (numericUpDown5.Value != 0)
            {
                timer4.Interval = Convert.ToInt32(numericUpDown5.Value);
            }
            if (numericUpDown7.Value != 0)
            {
                timer5.Interval = Convert.ToInt32(numericUpDown7.Value);
            }
            if (numericUpDown9.Value != 0)
            {
                timer6.Interval = Convert.ToInt32(numericUpDown9.Value);
            }
            if (numericUpDown11.Value != 0)
            {
                timer7.Interval = Convert.ToInt32(numericUpDown11.Value);
            }
            if (numericUpDown13.Value != 0)
            {
                timer8.Interval = Convert.ToInt32(numericUpDown13.Value);
            }
            if (numericUpDown15.Value != 0)
            {
                timer9.Interval = Convert.ToInt32(numericUpDown15.Value);
            }
            if (GetAsyncKeyState(Keys.F3))
            {
                cursor = default(Point);
                GetCursorPos(out cursor);
                xPos = cursor.X;
                yPos = cursor.Y;
                textBox1.Text = xPos.ToString();
                textBox16.Text = yPos.ToString();
            }
            if (GetAsyncKeyState(Keys.F4))
            {
                cursor2 = default(Point);
                GetCursorPos(out cursor2);
                xPos2 = cursor2.X;
                yPos2 = cursor2.Y;
                textBox2.Text = xPos2.ToString();
                textBox15.Text = yPos2.ToString();
            }
            if (GetAsyncKeyState(Keys.F5))
            {
                cursor3 = default(Point);
                GetCursorPos(out cursor3);
                xPos3 = cursor3.X;
                yPos3 = cursor3.Y;
                textBox3.Text = xPos3.ToString();
                textBox14.Text = yPos3.ToString();
            }
            if (GetAsyncKeyState(Keys.F6))
            {
                cursor4 = default(Point);
                GetCursorPos(out cursor4);
                xPos4 = cursor4.X;
                yPos4 = cursor4.Y;
                textBox4.Text = xPos4.ToString();
                textBox13.Text = yPos4.ToString();
            }
            if (GetAsyncKeyState(Keys.F7))
            {
                cursor5 = default(Point);
                GetCursorPos(out cursor5);
                xPos5 = cursor5.X;
                yPos5 = cursor5.Y;
                textBox5.Text = xPos5.ToString();
                textBox12.Text = yPos5.ToString();
            }
            if (GetAsyncKeyState(Keys.F8))
            {
                cursor6 = default(Point);
                GetCursorPos(out cursor6);
                xPos6 = cursor6.X;
                yPos6 = cursor6.Y;
                textBox6.Text = xPos6.ToString();
                textBox11.Text = yPos6.ToString();
            }
            if (GetAsyncKeyState(Keys.F9))
            {
                cursor7 = default(Point);
                GetCursorPos(out cursor7);
                xPos7 = cursor7.X;
                yPos7 = cursor7.Y;
                textBox7.Text = xPos7.ToString();
                textBox10.Text = yPos7.ToString();
            }
            if (GetAsyncKeyState(Keys.F10))
            {
                cursor8 = default(Point);
                GetCursorPos(out cursor8);
                xPos8 = cursor8.X;
                yPos8 = cursor8.Y;
                textBox8.Text = xPos8.ToString();
                textBox9.Text = yPos8.ToString();
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(xPos != 0 || yPos != 0)
            {
                Cursor.Position = new Point(xPos, yPos);
                mouse_event(2, 0, 0, 0, 0);
                mouse_event(4, 0, 0, 0, 0);
                if (!numericUpDown2.Text.Equals(0.ToString()))
                {
                    timer2.Stop();
                    if (xPos2 != 0 || yPos2 != 0)
                    {
                        timer3.Start();
                    }
                    else
                    {
                        timer2.Start();
                    }
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(xPos2 != 0 || yPos2 != 0)
            {
                Cursor.Position = new Point(xPos2, yPos2);
                mouse_event(2, 0, 0, 0, 0);
                mouse_event(4, 0, 0, 0, 0);
                if (!numericUpDown3.Text.Equals(0.ToString()))
                {
                    timer3.Stop();
                    if (xPos3 != 0 || yPos3 != 0)
                    {
                        timer4.Start();
                    }
                    else
                    {
                        timer2.Start();
                    }
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (xPos3 != 0 || yPos3 != 0)
            {
                Cursor.Position = new Point(xPos3, yPos3);
                mouse_event(2, 0, 0, 0, 0);
                mouse_event(4, 0, 0, 0, 0);
                if (!numericUpDown5.Text.Equals(0.ToString()))
                {
                    timer4.Stop();
                    if (xPos4 != 0 || yPos4 != 0)
                    {
                        timer5.Start();
                    }
                    else
                    {
                        timer2.Start();
                    }
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (xPos4 != 0 || yPos4 != 0)
            {
                Cursor.Position = new Point(xPos4, yPos4);
                mouse_event(2, 0, 0, 0, 0);
                mouse_event(4, 0, 0, 0, 0);
                if (!numericUpDown7.Text.Equals(0.ToString()))
                {
                    timer5.Stop();
                    if (xPos5 != 0 || yPos5 != 0)
                    {
                        timer6.Start();
                    }
                    else
                    {
                        timer2.Start();
                    }
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (xPos5 != 0 || yPos5 != 0)
            {
                Cursor.Position = new Point(xPos5, yPos5);
                mouse_event(2, 0, 0, 0, 0);
                mouse_event(4, 0, 0, 0, 0);
                if (!numericUpDown9.Text.Equals(0.ToString()))
                {
                    timer6.Stop();
                    if (xPos6 != 0 || yPos6 != 0)
                    {
                        timer7.Start();
                    }
                    else
                    {
                        timer2.Start();
                    }
                }
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (xPos6 != 0 || yPos6 != 0)
            {
                Cursor.Position = new Point(xPos6, yPos6);
                mouse_event(2, 0, 0, 0, 0);
                mouse_event(4, 0, 0, 0, 0);
                if (!numericUpDown11.Text.Equals(0.ToString()))
                {
                    timer7.Stop();
                    if (xPos7 != 0 || yPos7 != 0)
                    {
                        timer8.Start();
                    }
                    else
                    {
                        timer2.Start();
                    }
                }
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (xPos7 != 0 || yPos7 != 0)
            {
                Cursor.Position = new Point(xPos7, yPos7);
                mouse_event(2, 0, 0, 0, 0);
                mouse_event(4, 0, 0, 0, 0);
                if (!numericUpDown13.Text.Equals(0.ToString()))
                {
                    timer8.Stop();
                    if (xPos8 != 0 || yPos8 != 0)
                    {
                        timer9.Start();
                    }
                    else
                    {
                        timer2.Start();
                    }
                }
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (xPos8 != 0 || yPos8 != 0)
            {
                Cursor.Position = new Point(xPos8, yPos8);
                mouse_event(2, 0, 0, 0, 0);
                mouse_event(4, 0, 0, 0, 0);
                if (!numericUpDown15.Text.Equals(0.ToString()))
                {
                    timer9.Stop();
                    timer2.Start();
                }
            }
        }
        
    }
}
