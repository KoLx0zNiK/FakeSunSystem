using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double _t, _dt, _x, _y, _r;
        public void Drow()//рисует солнышко
        {
            Graphics system = pictureBox1.CreateGraphics();
            system.FillEllipse(Brushes.Yellow, 400, 300, 50, 50);
        }

        public void ShowRes()//в Текст боксе должен показывать таймер
        {
            textBox1.Text = _t.ToString();
        }
        private void Planet()//рисует планеты, если на них галочка, убирает, если ее нет
        {
            checkedListBox1.CheckOnClick = true;
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.DarkGray, 395, 300, 5, 5);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.YellowGreen, 375, 300, 20, 20);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.LightSkyBlue, 350, 300, 25, 25);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.OrangeRed, 338, 300, 12, 12);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Orange, 288, 300, 50, 50);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.BlueViolet, 243, 300, 45, 45);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.DeepSkyBlue, 211, 300, 32, 32);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Blue, 181, 300, 30, 30);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 395, 300, 5, 5);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 375, 300, 20, 20);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 350, 300, 25, 25);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 338, 300, 12, 12);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 288, 300, 50, 50);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 243, 300, 45, 45);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 211, 300, 32, 32);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 181, 300, 30, 30);
                _x = _r * Math.Cos(5 * Math.PI / 180); _y = _r * Math.Sin(5 * Math.PI / 180);
            }
        }

        public void timer1_Tick(object sender, EventArgs e)//недотаймер
        {
            _t += 0.01;
        }

        private void button1_Click(object sender, EventArgs e)// по нажатию кнопки должно все заработать
        {
            timer1.Enabled = true;
            Drow();
            Planet();
            ShowRes();
            timer1.Enabled = false;
        }
    }
}
