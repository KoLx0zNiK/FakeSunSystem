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
        public double _t, _dt, _speedMerc, _speedVen, _speedEarth, _speedMars, _speedUpit, _speedSat, _speedUran, _speedNept;
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
                system.FillEllipse(Brushes.DarkGray, 395, 295, 5, 5);
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.YellowGreen, 375, 275, 20, 20);

            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.LightSkyBlue, 350, 250, 25, 25);
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.OrangeRed, 338, 238, 12, 12);
            }
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Orange, 288, 188, 50, 50);
            }
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.BlueViolet, 243, 143, 45, 45);
            }
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.DeepSkyBlue, 211, 111, 32, 32);
            }
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Checked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Blue, 181, 81, 30, 30);
            }
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 395, 295, 5, 5);
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 375, 275, 20, 20);

            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 350, 250, 25, 25);
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 338, 238, 12, 12);
            }
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 288, 188, 50, 50);
            }
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 243, 143, 45, 45);
            }
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 211, 111, 32, 32);
            }
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 181, 81, 30, 30);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//недотаймер, Жень помоги
        {
            Drow();
            Planet();
            _t += _dt;

        }

        private void button1_Click(object sender, EventArgs e)// по нажатию кнопки должно все заработать
        {
            Drow();
            Planet();
            ShowRes();
        }
    }
}
