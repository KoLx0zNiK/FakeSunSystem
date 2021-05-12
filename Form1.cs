using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SunSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Drow()//рисует солнышко
        {
            Graphics system = pictureBox1.CreateGraphics();
            system.FillEllipse(Brushes.Yellow, 400, 300, 50, 50);
        }
        private void Planet()//рисует планеты, если на них галочка, убирает, если ее нет
        {
            checkedListBox1.CheckOnClick = true;

            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                Thread thread = new Thread(Raschet0);
                thread.Start();
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                Thread thread = new Thread(Raschet1);
                thread.Start();
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                Thread thread = new Thread(Raschet2);
                thread.Start();
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                Thread thread = new Thread(Raschet3);
                thread.Start();
            }
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Checked)
            {
                Thread thread = new Thread(Raschet4);
                thread.Start();
            }
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
            {
                Thread thread = new Thread(Raschet5);
                thread.Start();
            }
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Checked)
            {
                Thread thread = new Thread(Raschet6);
                thread.Start();
            }
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Checked)
            {
                Thread thread = new Thread(Raschet7);
                thread.Start();
            }
           /* if (checkedListBox1.GetItemCheckState(0) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 395, 300, 5, 5);
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 375, 300, 20, 20);
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 350, 300, 25, 25);
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 338, 300, 12, 12);
            }
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 288, 300, 50, 50);
            }
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 243, 300, 45, 45);
            }
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 211, 300, 32, 32);
            }
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Unchecked)
            {
                Graphics system = pictureBox1.CreateGraphics();
                system.FillEllipse(Brushes.Black, 181, 300, 30, 30);
            }*/
        }

        void Raschet0()
        {

            Graphics system = pictureBox1.CreateGraphics();

            while (0 == 0)
            {
                for (int i = -50; i < 50; i++)
                {
                    system.FillEllipse(Brushes.DarkGray, i + 420, Convert.ToInt32((Math.Sqrt((50 * 50) - (i * i))) + 325), 5, 5);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, i + 420, Convert.ToInt32((Math.Sqrt((50 * 50) - (i * i))) + 325), 5, 5);
                }

                for (int i = -50; i < 50; i++)
                {
                    system.FillEllipse(Brushes.DarkGray, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((50 * 50) - (i * i)))), 5, 5);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((50 * 50) - (i * i)))), 5, 5);

                }
            }
        }
        void Raschet1()
        {

            Graphics system = pictureBox1.CreateGraphics();

            while (0 == 0)
            {
                for (int i = -75; i < 75; i++)
                {
                    system.FillEllipse(Brushes.YellowGreen, i + 420, Convert.ToInt32((Math.Sqrt((75 * 75) - (i * i))) + 325), 20, 20);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, i + 420, Convert.ToInt32((Math.Sqrt((75 * 75) - (i * i))) + 325), 20, 20);
                }

                for (int i = -75; i < 75; i++)
                {
                    system.FillEllipse(Brushes.YellowGreen, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((75 * 75) - (i * i)))), 20, 20);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((75 * 75) - (i * i)))), 20, 20);

                }
            }
        }
        void Raschet2()
        {

            Graphics system = pictureBox1.CreateGraphics();

            while (0 == 0)
            {
                for (int i = -105; i < 105; i++)
                {
                    system.FillEllipse(Brushes.LightSkyBlue, i + 420, Convert.ToInt32((Math.Sqrt((105 * 105) - (i * i))) + 325), 25, 25);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, i + 420, Convert.ToInt32((Math.Sqrt((105 * 105) - (i * i))) + 325), 25, 25);
                }

                for (int i = -105; i < 105; i++)
                {
                    system.FillEllipse(Brushes.LightSkyBlue, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((105 * 105) - (i * i)))), 25, 25);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((105 * 105) - (i * i)))), 25, 25);

                }
            }
        }
        void Raschet3()
        {

            Graphics system = pictureBox1.CreateGraphics();

            while (0 == 0)
            {
                for (int i = -125; i < 125; i++)
                {
                    system.FillEllipse(Brushes.OrangeRed, i + 420, Convert.ToInt32((Math.Sqrt((125 * 125) - (i * i))) + 325), 12, 12);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, i + 420, Convert.ToInt32((Math.Sqrt((125 * 125) - (i * i))) + 325), 12, 12);
                }

                for (int i = -125; i < 125; i++)
                {
                    system.FillEllipse(Brushes.OrangeRed, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((125 * 125) - (i * i)))), 12, 12);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((125 * 125) - (i * i)))), 12, 12);

                }
            }
        }
        void Raschet4()
        {

            Graphics system = pictureBox1.CreateGraphics();

            while (0 == 0)
            {
                for (int i = -180; i < 180; i++)
                {
                    system.FillEllipse(Brushes.Orange, i + 420, Convert.ToInt32((Math.Sqrt((180 * 180) - (i * i))) + 325), 50, 50);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, i + 420, Convert.ToInt32((Math.Sqrt((180 * 180) - (i * i))) + 325), 50, 50);
                }

                for (int i = -180; i < 180; i++)
                {
                    system.FillEllipse(Brushes.Orange, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((180 * 180) - (i * i)))), 50, 50);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((180 * 180) - (i * i)))), 50, 50);

                }
            }
        }
        void Raschet5()
        {

            Graphics system = pictureBox1.CreateGraphics();

            while (0 == 0)
            {
                for (int i = -230; i < 230; i++)
                {
                    system.FillEllipse(Brushes.BlueViolet, i + 420, Convert.ToInt32((Math.Sqrt((230 * 230) - (i * i))) + 325), 45, 45);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, i + 420, Convert.ToInt32((Math.Sqrt((230 * 230) - (i * i))) + 325), 45, 45);
                }

                for (int i = -230; i < 230; i++)
                {
                    system.FillEllipse(Brushes.BlueViolet, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((230 * 230) - (i * i)))), 45, 45);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((230 * 230) - (i * i)))), 45, 45);

                }
            }
        }
        void Raschet6()
        {

            Graphics system = pictureBox1.CreateGraphics();

            while (0 == 0)
            {
                for (int i = -270; i < 270; i++)
                {
                    system.FillEllipse(Brushes.DeepSkyBlue, i + 420, Convert.ToInt32((Math.Sqrt((270 * 270) - (i * i))) + 325), 32, 32);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, i + 420, Convert.ToInt32((Math.Sqrt((270 * 270) - (i * i))) + 325), 32, 32);
                }

                for (int i = -270; i < 270; i++)
                {
                    system.FillEllipse(Brushes.DeepSkyBlue, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((270 * 270) - (i * i)))), 32, 32);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((270 * 270) - (i * i)))), 32, 32);

                }
            }
        }
        void Raschet7()
        {

            Graphics system = pictureBox1.CreateGraphics();

            while (0 == 0)
            {
                for (int i = -305; i < 305; i++)
                {
                    system.FillEllipse(Brushes.Blue, i + 420, Convert.ToInt32((Math.Sqrt((305 * 305) - (i * i))) + 325), 30, 30);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, i + 420, Convert.ToInt32((Math.Sqrt((305 * 305) - (i * i))) + 325), 30, 30);
                }

                for (int i = -305; i < 305; i++)
                {
                    system.FillEllipse(Brushes.Blue, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((305 * 305) - (i * i)))), 30, 30);
                    Thread.Sleep(20);
                    system.FillEllipse(Brushes.Black, 420 - i, Convert.ToInt32(325 - (Math.Sqrt((305 * 305) - (i * i)))), 30, 30);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)// по нажатию кнопки должно все заработать
        {
            Drow();
            Planet();
        }
    }
}
