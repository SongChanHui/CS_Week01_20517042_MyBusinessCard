using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // R, G, B 값을 무작위로 생성하여 배경색에 적용 
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://github.com/SongChanHui") { UseShellExecute = true });
        }

        bool isChanged = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (isChanged == false)
            {
                
                pictureBox1.Image = Properties.Resources.나랑고양이;
                isChanged = true; 
            }
            else
            {
                
                pictureBox1.Image = Properties.Resources.증명사진;
                isChanged = false; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}