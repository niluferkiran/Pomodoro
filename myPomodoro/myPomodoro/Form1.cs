using Microsoft.EntityFrameworkCore;
using myPomodoro.Models;

namespace myPomodoro
{
    public partial class Form1 : Form
    {
        private int kalansure;

        public Form1()
        {
            InitializeComponent();
            kalansure = 60 * 25;
            lblSure.Text = FormatSure(kalansure);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kalansure > 0)
            {
                kalansure--;
                lblSure.Text = FormatSure(kalansure);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Pomodoro süren bitti! Þimdi 5 dakika mola verme zamaný.");
                System.Media.SystemSounds.Beep.Play();
                kalansure = 5 * 60;
                lblSure.Text = FormatSure(kalansure);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string FormatSure(int sure)
        {
            int dakika = sure / 60;
            int saniye = sure % 60;
            return $"{dakika:D2}:{saniye:D2}";
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            kalansure = 25 * 60;
            lblSure.Text = FormatSure(kalansure);
        }
    }
}