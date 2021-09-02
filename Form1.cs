using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Robotik_Kol___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var ports = SerialPort.GetPortNames();
            combobox_comport.DataSource = ports;
            serialPort1.PortName = "COM6";
            serialPort1.BaudRate = 9600;
        }

        private void btn_baglan_Click(object sender, EventArgs e)
        {
            timer1.Start();

            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    btn_baglantidurumu.Visible = true;
                    btn_baglantidurumu.BackColor = Color.Green;
                    btn_baglantidurumu.Text = "BAĞLANDI";

                }
            }
            catch (Exception exception)
            {
                btn_baglantidurumu.BackColor = Color.Red;
                btn_baglantidurumu.Text = "BAĞLANTI YOK";
                MessageBox.Show("BAĞLANTI GERÇEKLEŞTİRİLEMEDİ");
                //throw;
            }
        }

        private void btn_baglantikes_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort1.Close();
            btn_baglantidurumu.BackColor = Color.Red;
            btn_baglantidurumu.Text = "BAĞLANTI KESİLDİ";
            MessageBox.Show("BAĞLANTI SONLANDIRILDI");
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            combobox_comport.DataSource = ports;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string bilgi = serialPort1.ReadExisting();
            //txtbox_anlikveri.Text = bilgi.ToString();
            System.Threading.Thread.Sleep(500);
        }

        int i = 0;

        private void btn_kontrolubaslat_KeyDown(object sender, KeyEventArgs e)
        {
            btn_kontrolubaslat.BackColor = Color.Green;

            if (e.KeyCode == Keys.W)
            {
                btn_s1_sol.PerformClick();
            }
            else if (e.KeyCode == Keys.A)
            {
                btn_s1_sag.PerformClick();
            }
            else if(e.KeyCode == Keys.E)
            {
                btn_s2_sol.PerformClick();
            }
            else if (e.KeyCode == Keys.S)
            {
                btn_s2_sag.PerformClick();
            }
            else if (e.KeyCode == Keys.R)
            {
                btn_s3_sol.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                btn_s3_sag.PerformClick();
            }
            else if (e.KeyCode == Keys.T)
            {
                btn_s4_sol.PerformClick();
            }
            else if (e.KeyCode == Keys.F)
            {
                btn_s4_sag.PerformClick();
            }
            else if (e.KeyCode == Keys.Y)
            {
                btn_s5_sol.PerformClick();
            }
            else if (e.KeyCode == Keys.G)
            {
                btn_s5_sag.PerformClick();
            }
            else if (e.KeyCode == Keys.U)
            {
                btn_s6_sol.PerformClick();
            }
            else if (e.KeyCode == Keys.H)
            {
                btn_s6_sag.PerformClick();
            }
        }

        private void btn_s1_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("w");
        }

        private void btn_s1_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("a");
        }

        private void btn_s2_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("e");
        }

        private void btn_s2_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("s");
        }

        private void btn_s3_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("r");
        }

        private void btn_s3_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("d");
        }

        private void btn_s4_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("t");
        }

        private void btn_s4_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("f");
        }

        private void btn_s5_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("y");
        }

        private void btn_s5_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("g");
        }

        private void btn_s6_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("u");
        }

        private void btn_s6_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("h");
        }

    }
}
