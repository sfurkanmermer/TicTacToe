using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XoX_Oyunu2
{
    public partial class Form2 : Form
    {

        public int sıra = 1;
        public int kazanma = 0;
        public string mesaj;
        String tarih;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tarih= DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            Thread thdUDPServer = new Thread(new
            ThreadStart(Dinleme));
            thdUDPServer.Start();
            Thread dinleme = new Thread(Dinleme2);
            dinleme.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "" && sıra == 1)
            {
                button1.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("1");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "" && sıra == 1)
            {
                button2.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("2");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "" && sıra == 1)
            {
                button3.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("3");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "" && sıra == 1)
            {
                button4.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("4");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "" && sıra == 1)
            {
                button5.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("5");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "" && sıra == 1)
            {
                button6.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("6");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "" && sıra == 1)
            {
                button7.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("7");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "" && sıra == 1)
            {
                button8.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("8");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "" && sıra == 1)
            {
                button9.Text = "X";
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("9");
                udpClient.Send(senddata, senddata.Length);
                kazanmaControl();
                sıra = 0;

            }
        }
        public delegate void delSetValue(String value);


        public void mthSetValue(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue), value);
            else this.button1.Text = value;
        }
        public void mthSetValue2(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue2), value);
            else this.button2.Text = value;
        }
        public void mthSetValue3(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue3), value);
            else this.button3.Text = value;
        }
        public void mthSetValue4(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue4), value);
            else this.button4.Text = value;
        }
        public void mthSetValue5(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue5), value);
            else this.button5.Text = value;
        }
        public void mthSetValue6(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue6), value);
            else this.button6.Text = value;
        }
        public void mthSetValue7(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue7), value);
            else this.button7.Text = value;
        }
        public void mthSetValue8(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue8), value);
            else this.button8.Text = value;
        }
        public void mthSetValue9(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue9), value);
            else this.button9.Text = value;
        }
        public void mthSetValue10(String value)

        {
            if (this.InvokeRequired) this.Invoke(new delSetValue(mthSetValue10), value);
            else this.listBox1.Items.Add("Rakip : "+value);
        }

        void kazanmaControl()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("kazandınız");
                kazanma = 1;

            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("kazandınız");
                kazanma = 1;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("kazandınız");
                kazanma = 1;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("kazandınız");
                kazanma = 1;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("kazandınız");
                kazanma = 1;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("kazandınız");
                kazanma = 1;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("kazandınız");
                kazanma = 1;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("kazandınız");
                kazanma = 1;
            }
            if (kazanma == 1)
            {
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("localhost", 8080);
                Byte[] senddata = Encoding.ASCII.GetBytes("kaybettiniz");
                udpClient.Send(senddata, senddata.Length);
                string path = @"C:\Users\s10f6\Desktop\2.oyuncu.txt";
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(tarih + ": kazandınız");
                    tw.Close();
                }

            }
        }
        void Dinleme2()
        {
            UdpClient udpClient = new UdpClient(1252);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                mthSetValue10(returnData);
            }

            }
        void Dinleme()
        {

            UdpClient udpClient = new UdpClient(666);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                if (returnData == "1")
                {
                    mthSetValue("O");
                    sıra = 1;

                }
                if (returnData == "2")
                {
                    mthSetValue2("O");
                    sıra = 1;

                }
                if (returnData == "3")
                {
                    mthSetValue3("O");
                    sıra = 1;

                }
                if (returnData == "4")
                {
                    mthSetValue4("O");
                    sıra = 1;

                }
                if (returnData == "5")
                {
                    mthSetValue5("O");
                    sıra = 1;

                }
                if (returnData == "6")
                {
                    mthSetValue6("O");
                    sıra = 1;

                }
                if (returnData == "7")
                {
                    mthSetValue7("O");
                    sıra = 1;

                }
                if (returnData == "8")
                {

                    mthSetValue8("O");
                    sıra = 1;

                }
                if (returnData == "9")
                {
                    mthSetValue9("O");
                    sıra = 1;

                }
                if (returnData == "kaybettiniz")
                {

                    MessageBox.Show(returnData);
                    string path = @"C:\Users\s10f6\Desktop\2.oyuncu.txt";
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(tarih+": kaybettiniz");
                        tw.Close();
                    }

                }
                //MessageBox.Show(returnData);









            }




        }

        private void button10_Click(object sender, EventArgs e)
        {
            mesaj = textBox1.Text;
            textBox1.Text = "";
            UdpClient udpClient = new UdpClient();
            udpClient.Connect("localhost", 1658);
            Byte[] senddata = Encoding.ASCII.GetBytes(mesaj);
            udpClient.Send(senddata, senddata.Length);
            listBox1.Items.Add("Ben : "+mesaj);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            kazanma = 0;
        }
    }

}