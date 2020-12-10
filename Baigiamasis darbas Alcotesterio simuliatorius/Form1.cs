using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlcSimulator.BL;
using AlcSimulator.DL;

namespace Baigiamasis_darbas_Alcotesterio_simuliatorius
{
    public partial class Main_Form1 : Form
    {
        public Main_Form1()
        {
            InitializeComponent();
            ListAvailableComPorts();
            ListBoudRate();
        }

        string currentComPort = "";
        string currentBoudRate = "";
        


        private void on_checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void comPort_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             currentComPort = comPort_comboBox1.SelectedItem.ToString();
        } 
        private void boud_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBoudRate = boud_comboBox2.SelectedItem.ToString();
        }
        // Mygtuko paspaudimas
        private void connect_button1_Click(object sender, EventArgs e)
        {
            //ConnectToSelectedComPort();
            //SerialPortProgram();
            int boud = int.Parse(currentBoudRate);
            SerialPort port1 = new SerialPort(currentComPort, boud, Parity.None, 8, StopBits.One);
            port1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port1.Open();

        }
        private void tx_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rx_listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //port_DataReceived();
        }



        void ListAvailableComPorts()
        {
            GetComPortNames port = new GetComPortNames();

            string[] portsArray = port.PortsSelection();
            foreach (string i in portsArray)
            {
                comPort_comboBox1.Items.Add(i);
            }
            comPort_comboBox1.SelectedIndex = 0;
        }
        void ListBoudRate()
        {
            BoudRateData boudRate = new BoudRateData();

            var boudList = boudRate.BoudRateList();
            foreach (int i in boudList)
            {
                boud_comboBox2.Items.Add(i);
            }
            boud_comboBox2.SelectedIndex = 0;
        }
        SerialPort ConnectToSelectedComPort()
        {
            int boud = int.Parse(currentBoudRate);
            SerialPort port1 = new SerialPort(currentComPort, boud, Parity.None, 8, StopBits.One) ;
            return port1;
        }





        //=============================================================

        // Create the serial port with basic settings
        //private SerialPort port = new SerialPort("", 9600, Parity.None, 8, StopBits.One);

        //[STAThread]
        //static void (string[] args)
        //{
        //    // Instatiate this class
        //    new SerialPortProgram();
        //}

        void SerialPortProgram()
        {
            SerialPort port = ConnectToSelectedComPort();

            //Console.WriteLine("Incoming Data:");

            // Attach a method to be called when there
            // is data waiting in the port's buffer
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            // Begin communications
            port.Open();

            // Enter an application loop to keep this thread alive
              //Application.Run();
        }

        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            SerialPort port = ConnectToSelectedComPort();
            port.ReadExisting();
        }


    }
}
