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

namespace ComControllerForHomeAutomation
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //Start serial port protocol 
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM3";
            myport.Open();

            //Enabling all buttons, when started initialization
            BtnOn1.Enabled = true;
            BtnOn2.Enabled = true;
            BtnOn3.Enabled = true;
            BtnOn4.Enabled = true;
            BtnOn5.Enabled = true;
            BtnOn6.Enabled = true;
            BtnOn7.Enabled = true;
            BtnOn8.Enabled = true;

            BtnOff1.Enabled = true;
            BtnOff2.Enabled = true;
            BtnOff3.Enabled = true;
            BtnOff4.Enabled = true;
            BtnOff5.Enabled = true;
            BtnOff6.Enabled = true;
            BtnOff7.Enabled = true;
            BtnOff8.Enabled = true;
        }


        //Turn on speakers
        private void BtnOn1_Click(object sender, EventArgs e)
        {
            myport.WriteLine("Q");
        }

        //Turn on mobile charging
        private void BtnOn2_Click(object sender, EventArgs e)
        {
            myport.WriteLine("W");
        }

        //Turn on second display
        private void BtnOn3_Click(object sender, EventArgs e)
        {
            myport.WriteLine("E");
        }

        //Turn on the lamp
        private void BtnOn4_Click(object sender, EventArgs e)
        {
            myport.WriteLine("R");
        }

        //Turn on the projector
        private void BtnOn5_Click(object sender, EventArgs e)
        {
            myport.WriteLine("T");
        }

        //Turn on Home Server
        private void BtnOn6_Click(object sender, EventArgs e)
        {
            myport.WriteLine("Y");
        }

        //Turn on WEB Server
        private void BtnOn7_Click(object sender, EventArgs e)
        {
            myport.WriteLine("U");
        }

        //Turn on USB File HDD
        private void BtnOn8_Click(object sender, EventArgs e)
        {
            myport.WriteLine("I");
        }

        //Turn on all devices
        private void BtnOn9_Click(object sender, EventArgs e)
        {
            myport.WriteLine("Q");
            myport.WriteLine("W");
            myport.WriteLine("E");
            myport.WriteLine("R");
            myport.WriteLine("T");
            myport.WriteLine("Y");
            myport.WriteLine("U");
            myport.WriteLine("I");
        }
        
        //Turn off speakers
        private void BtnOff1_Click(object sender, EventArgs e)
        {
            myport.WriteLine("A");
        }

        //Turn off mobile charging
        private void BtnOff2_Click(object sender, EventArgs e)
        {
            myport.WriteLine("S");
        }

        //Turn off the monitor
        private void BtnOff3_Click(object sender, EventArgs e)
        {
            myport.WriteLine("D");
        }

        //Turn off the lamp
        private void BtnOff4_Click(object sender, EventArgs e)
        {
            myport.WriteLine("F");
        }

        //Turn off the projector
        private void BtnOff5_Click(object sender, EventArgs e)
        {
            myport.WriteLine("G");
        }

        //Turn off Home Server
        private void BtnOff6_Click(object sender, EventArgs e)
        {
            myport.WriteLine("H");
        }

        //Turn off WEB Server
        private void BtnOff7_Click(object sender, EventArgs e)
        {
            myport.WriteLine("J");
        }

        //Turn off USB File HDD
        private void BtnOff8_Click(object sender, EventArgs e)
        { 
            myport.WriteLine("K");
        }

        //Turn off all devices
        private void BtnOff9_Click(object sender, EventArgs e)
        {
            myport.WriteLine("A");
            myport.WriteLine("S");
            myport.WriteLine("D");
            myport.WriteLine("F");
            myport.WriteLine("G");
            myport.WriteLine("H");
            myport.WriteLine("J");
            myport.WriteLine("K");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
