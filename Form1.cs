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
            //serialPort1.Open();
            var ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                combobox_comport.Items.Add(port);
                combobox_comport.SelectedIndex = 0;
            }
            //combobox_comport.DataSource = ports;
            //serialPort1.PortName = "COM3";
            //serialPort1.PortName = combobox_comport.SelectedItem.ToString();
            serialPort1.BaudRate = 9600;
        }

        private void btn_baglan_Click(object sender, EventArgs e)
        {
            timer1.Start();

            timer2.Start();

            serialPort1.PortName = combobox_comport.Text;

            try
            {
                if (!serialPort1.IsOpen)
                {
                    //serialPort1.PortName = combobox_comport.SelectedItem.ToString();
                    serialPort1.Open();
                    btn_baglantidurumu.Visible = true;
                    btn_baglantidurumu.BackColor = Color.Green;
                    btn_baglantidurumu.Text = "BAĞLANDI";

                    bar_s1.Value = 90;
                    bar_s2.Value = 90;
                    bar_s3.Value = 90;
                    bar_s4.Value = 90;
                    bar_s5.Value = 90;
                    bar_s6.Value = 90;
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
            timer2.Stop();
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

        //public int deneme = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string bilgi = serialPort1.ReadExisting();
            //txtbox_anlikveri.Text = bilgi.ToString();
            //System.Threading.Thread.Sleep(500);

            try
            {
                string result = serialPort1.ReadExisting();
                txtbox_anlikveri.Text = result.ToString();
                listbox_veri.Text = result.ToString();
                listbox_veri.SelectedIndex = listbox_veri.Items.Count - 1;
                /*
                deneme += 5;
                string result2 = "Aci7 =" + deneme;
                txtbox_anlikveri.Text = result2.ToString();
                listbox_veri.Items.Add(result2);
                if (result2[3] == '7' && result2.Length == 7)
                {
                    char value1 = result2[6];
                    int value1_converted = (int)Char.GetNumericValue(value1);
                    bar_s2.Value = value1_converted;
                    lbl_aci2.Text = Convert.ToString(value1_converted);
                }

                if (result2[3] == '7' && result2.Length == 8)
                {
                    char value1 = result2[6];
                    char value2 = result2[7];
                    int value1_converted = (int)Char.GetNumericValue(value1);
                    int value2_converted = (int)Char.GetNumericValue(value2);
                    int result_value = value1_converted * 10 + value2_converted;
                    bar_s2.Value = value1_converted;
                    lbl_aci2.Text = Convert.ToString(result_value);
                }

                if (result2[3] == '7' && result2.Length == 9)
                {
                    char value1 = result2[6];
                    char value2 = result2[7];
                    char value3 = result2[8];
                    int value1_converted = (int)Char.GetNumericValue(value1);
                    int value2_converted = (int)Char.GetNumericValue(value2);
                    int value3_converted = (int)Char.GetNumericValue(value3);
                    int result_value = value1_converted * 100 + value2_converted * 10 + value3_converted;
                    bar_s2.Value = result_value;
                    lbl_aci2.Text = Convert.ToString(result_value);
                }
                */

                if (result.Length == 8)
                {
                    if (result[3] == '1')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int result_value = value1_converted * 10 + value2_converted;
                        bar_s1.Value = result_value;
                        lbl_aci1.Text = Convert.ToString(result_value);
                    }

                    else if (result[3] == '2')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int result_value = value1_converted * 10 + value2_converted;
                        bar_s2.Value = result_value;
                        lbl_aci2.Text = Convert.ToString(result_value);
                    }
                    else if (result[3] == '3')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int result_value = value1_converted * 10 + value2_converted;
                        bar_s3.Value = result_value;
                        lbl_aci3.Text = Convert.ToString(result_value);
                    }
                    else if (result[3] == '4')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int result_value = value1_converted * 10 + value2_converted;
                        bar_s4.Value = result_value;
                        lbl_aci4.Text = Convert.ToString(result_value);
                    }
                    else if (result[3] == '5')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int result_value = value1_converted * 10 + value2_converted;
                        bar_s5.Value = result_value;
                        lbl_aci5.Text = Convert.ToString(result_value);
                    }
                    else if (result[3] == '6')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int result_value = value1_converted * 10 + value2_converted;
                        bar_s6.Value = result_value;
                        lbl_aci6.Text = Convert.ToString(result_value);
                    }
                }
                else if (result.Length == 9)
                {
                    if (result[3] == '1')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        char value3 = result[8];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int value3_converted = (int)Char.GetNumericValue(value3);
                        int result_value = value1_converted * 100 + value2_converted * 10 + value3_converted;
                        bar_s1.Value = result_value;
                        lbl_aci1.Text = Convert.ToString(result_value);
                    }

                    else if (result[3] == '2')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        char value3 = result[8];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int value3_converted = (int)Char.GetNumericValue(value3);
                        int result_value = value1_converted * 100 + value2_converted * 10 + value3_converted;
                        bar_s2.Value = result_value;
                        lbl_aci2.Text = Convert.ToString(result_value);
                    }
                    else if (result[3] == '3')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        char value3 = result[8];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int value3_converted = (int)Char.GetNumericValue(value3);
                        int result_value = value1_converted * 100 + value2_converted * 10 + value3_converted;
                        bar_s3.Value = result_value;
                        lbl_aci3.Text = Convert.ToString(result_value);
                    }
                    else if (result[3] == '4')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        char value3 = result[8];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int value3_converted = (int)Char.GetNumericValue(value3);
                        int result_value = value1_converted * 100 + value2_converted * 10 + value3_converted;
                        bar_s4.Value = result_value;
                        lbl_aci4.Text = Convert.ToString(result_value);
                    }
                    else if (result[3] == '5')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        char value3 = result[8];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int value3_converted = (int)Char.GetNumericValue(value3);
                        int result_value = value1_converted * 100 + value2_converted * 10 + value3_converted;
                        bar_s5.Value = result_value;
                        lbl_aci5.Text = Convert.ToString(result_value);
                    }
                    else if (result[3] == '6')
                    {
                        char value1 = result[6];
                        char value2 = result[7];
                        char value3 = result[8];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        int value2_converted = (int)Char.GetNumericValue(value2);
                        int value3_converted = (int)Char.GetNumericValue(value3);
                        int result_value = value1_converted * 100 + value2_converted * 10 + value3_converted;
                        bar_s6.Value = result_value;
                        lbl_aci6.Text = Convert.ToString(result_value);
                    }
                }
                else if (result.Length == 7)
                {
                    if (result[3] == '1')
                    {
                        char value1 = result[6];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        bar_s1.Value = value1_converted;
                        lbl_aci1.Text = Convert.ToString(value1_converted);
                    }
                    else if (result[3] == '2')
                    {
                        char value1 = result[6];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        bar_s2.Value = value1_converted;
                        lbl_aci2.Text = Convert.ToString(value1_converted);
                    }
                    else if (result[3] == '3')
                    {
                        char value1 = result[6];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        bar_s3.Value = value1_converted;
                        lbl_aci3.Text = Convert.ToString(value1_converted);
                    }
                    else if (result[3] == '4')
                    {
                        char value1 = result[6];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        bar_s4.Value = value1_converted;
                        lbl_aci4.Text = Convert.ToString(value1_converted);
                    }
                    else if (result[3] == '5')
                    {
                        char value1 = result[6];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        bar_s5.Value = value1_converted;
                        lbl_aci5.Text = Convert.ToString(value1_converted);
                    }
                    else if (result[3] == '6')
                    {
                        char value1 = result[6];
                        int value1_converted = (int)Char.GetNumericValue(value1);
                        bar_s6.Value = value1_converted;
                        lbl_aci6.Text = Convert.ToString(value1_converted);
                    }

                }
                else if (result[0] == '-')
                {
                    // basınc durumu
                }
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                timer1.Stop();
            }
        }

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
            change_color(btn_s1_sol);
        }

        private void btn_s1_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("a");
            change_color(btn_s1_sag);
        }

        private void btn_s2_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("e");
            change_color(btn_s2_sol);
        }

        private void btn_s2_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("s");
            change_color(btn_s2_sag);
        }

        private void btn_s3_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("r");
            change_color(btn_s3_sol);
        }

        private void btn_s3_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("d");
            change_color(btn_s3_sag);
        }

        private void btn_s4_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("t");
            change_color(btn_s4_sol);
        }

        private void btn_s4_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("f");
            change_color(btn_s4_sag);
        }

        private void btn_s5_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("y");
            change_color(btn_s5_sol);
        }

        private void btn_s5_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("g");
            change_color(btn_s5_sag);
        }

        private void btn_s6_sol_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("u");
            change_color(btn_s6_sol);
        }

        private void btn_s6_sag_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("h");
            change_color(btn_s6_sag);
        }

        private void change_color(Button x)
        {
            x.BackColor = Color.Green;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btn_s1_sol.BackColor = default(Color);
            btn_s1_sag.BackColor = default(Color);
            btn_s2_sol.BackColor = default(Color);
            btn_s2_sag.BackColor = default(Color);
            btn_s3_sol.BackColor = default(Color);
            btn_s3_sag.BackColor = default(Color);
            btn_s4_sol.BackColor = default(Color);
            btn_s4_sag.BackColor = default(Color);
            btn_s5_sol.BackColor = default(Color);
            btn_s5_sag.BackColor = default(Color);
            btn_s6_sol.BackColor = default(Color);
            btn_s6_sag.BackColor = default(Color);
        }

        private void btn_motor_yenile_Click(object sender, EventArgs e)
        {
            bar_s1.Value = 90;
            bar_s2.Value = 90;
            bar_s3.Value = 90;
            bar_s4.Value = 90;
            bar_s5.Value = 90;
            bar_s6.Value = 90;
        }

        private void btn_manuel_com3_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM3";
        }

        private void btn_manuel_com5_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM5";
        }
    }
}
