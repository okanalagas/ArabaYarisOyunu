using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Araba_Yarışı
{
    public partial class FormRace : Form
    {
        public FormRace()
        {
            InitializeComponent();
        }


        int point = 0;
        int roadSpeed;
        int carSpeed;

        bool right = false;
        bool left = false;
        bool music = false;
        int ourSpeed;
        Random random = new Random();

        public void StartGame()
        {

            label_highScore.Text = Settings1.Default.highScore.ToString();
            button_start.Enabled = false;
            crash.Visible = false;
            point = 0;
            panel1.Controls.Add(road);
            // our Car's location

            ourCar.Left = 222;
            ourCar.Top = 467;

            //other Car's location

            car1.Left = 56;
            car1.Top = 440;

            car2.Left = 222;
            car2.Top = 3;

            right = false;
            left = false;

            crash.Left = 222;
            crash.Top = 443;

            timer1.Start();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (point < 500)
            {
                roadSpeed = 9;
                carSpeed = 9;
                ourSpeed = 10;
            }
            else if (point > 500 && point <= 1000)
            {
                roadSpeed = 10;
                carSpeed = 10;
                ourSpeed = 10;
            }
            else if (point > 1000 && point <= 1500)
            {
                roadSpeed = 11;
                carSpeed = 11;
                ourSpeed = 12;
            }
            else if (point > 1500 && point <= 2000)
            {
                roadSpeed = 12;
                carSpeed = 12;
                ourSpeed = 14;
            }
            else if (point > 2000 && point <= 2500)
            {
                roadSpeed = 13;
                carSpeed = 13;
                ourSpeed = 15;
            }
            else if (point > 2500 && point <= 3000)
            {
                roadSpeed = 15;
                carSpeed = 15;
                ourSpeed = 17;
            }

            point++;
            label_score.Text = point.ToString();

            road.Top += roadSpeed;
            road2.Top += roadSpeed;

            if (road.Top > 619)
            {
                road.Top = -620;
            }
            if (road2.Top > 619)
            {
                road2.Top = -620;
            }
            if (right && (ourCar.Left + ourCar.Width < 325))
            {
                ourCar.Left += ourSpeed;
            }
            if (left && ourCar.Left > 35)
            {
                ourCar.Left -= ourSpeed;
            }
            car1.Top += carSpeed;
            car2.Top += carSpeed;

            if (car1.Top > panel1.Height)
            {
                ChangeCar1();
                int y = random.Next(0, 100);
                if (y % 2 == 0)
                {
                    car1.Left = random.Next(35, 93);
                    car1.Top = random.Next(296, 328) * -1;
                }
                else
                {
                    car1.Left = random.Next(188, 240);
                    car1.Top = random.Next(296, 328) * -1;
                }
            }
            if (car2.Top > panel1.Height)
            {
                ChangeCar2();
                int z = random.Next(0, 100);
                if (z % 2 == 0)
                {
                    car2.Left = random.Next(188, 240);
                    car2.Top = random.Next(296, 328) * -1;
                }
                else
                {
                    car2.Left = random.Next(35, 93);
                    car2.Top = random.Next(296, 328) * -1;
                }

            }
            if (ourCar.Bounds.IntersectsWith(car1.Bounds) || ourCar.Bounds.IntersectsWith(car2.Bounds))
            {
                StopGame();
            }
        }

        private void StopGame()
        {
            timer1.Stop();
            if (Convert.ToInt32(label_score.Text) > Convert.ToInt32(Settings1.Default.highScore.ToString()))
            {
                Settings1.Default.highScore = Convert.ToInt32(label_score.Text);
            }
            button_start.Enabled = true;
            crash.Left = ourCar.Left;
            crash.Visible = true;
            ourCar.Controls.Add(crash);
            crash.Location = new Point(7, -5);
            crash.BringToFront();
            crash.BackColor = Color.Transparent;
            MessageBox.Show("Puanınız: " + label_score.Text, "Bilgi");

        }

        private void ChangeCar2()
        {
            int x = random.Next(1, 5);
            switch (x)
            {
                case 1:
                    car2.Image = Properties.Resources.car1;
                    break;
                case 2:
                    car2.Image = Properties.Resources.car2;
                    break;
                case 3:
                    car2.Image = Properties.Resources.car3;
                    break;
                case 4:
                    car2.Image = Properties.Resources.car4;
                    break;

            }
        }

        private void ChangeCar1()
        {
            int x = random.Next(1, 5);
            switch (x)
            {
                case 1:
                    car1.Image = Properties.Resources.car1;
                    break;
                case 2:
                    car1.Image = Properties.Resources.car2;
                    break;
                case 3:
                    car1.Image = Properties.Resources.car3;
                    break;
                case 4:
                    car1.Image = Properties.Resources.car4;
                    break;
            }
        }
        private void FormRace_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && ourCar.Left > 0)
            {
                left = true;
            }
            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && ourCar.Left + ourCar.Width < panel1.Width)
            {
                right = true;
            }
        }

        private void FormRace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = false;
            }
        }
        public void PlaySound()
        {
            music = true;
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath + "\\lostsky.wav";
            player.SoundLocation = path;
            player.Play();
        }

        public void StopSound()
        {
            music = false;
            SoundPlayer player = new SoundPlayer();
            string path = Application.StartupPath + "\\lostsky.wav";
            player.SoundLocation = path;
            player.Stop();
        }

        private void labelMusic_Click(object sender, EventArgs e)
        {           
            if (music == false)
            {
                PlaySound();
                labelMusic.Text = "Müziği Kapat";
            }
            else
            {
                StopSound();
                labelMusic.Text = "Müziği Aç";
            }
        }
    }
}
