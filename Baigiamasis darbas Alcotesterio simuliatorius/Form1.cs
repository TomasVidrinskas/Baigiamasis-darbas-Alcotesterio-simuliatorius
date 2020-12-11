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
            connectDisconnect = true;
        }

        string currentComPort = "";
        string currentBoudRate = "";
        public bool connectDisconnect;
        private SerialPort port;


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
        

        public void connect_button1_Click(object sender, EventArgs e)
        {

            ConnectButtonStatusHandler(port);

            //int boud = int.Parse(currentBoudRate);
            //SerialPort port1 = new SerialPort(currentComPort, boud, Parity.None, 8, StopBits.One);
            //port1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            //port1.Open();
            //Application.Run();


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

        void ConnectButtonStatusHandler(SerialPort port)
        {
            try
            {


                if (connectDisconnect)
                {
                    DateTime dt = DateTime.Now;
                    String dtShort = dt.ToShortTimeString();
                    port = new SerialPort();
                    connect_button1.Text = "Disconnect";
                    portOpen(out port);
                    txtReceive.AppendText("[" + dtShort + "] " + "Connected\n");
                    port.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
                    connectDisconnect = false;
                }
                else
                {
                    connect_button1.Text = "Connect";
                    portClose(port);
                    connectDisconnect = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }




        //=====Portas========================================================
        SerialPort initializeSerialPort()
        {
            int boud = int.Parse(currentBoudRate);
            port = new SerialPort(currentComPort, boud, Parity.None, 8, StopBits.One);
            return port;
        }

        //void SerialPortProgram()
        //{
        //    SerialPort port = initializeSerialPort();

        //    //Console.WriteLine("Incoming Data:");

        //    // Attach a method to be called when there
        //    // is data waiting in the port's buffer
        //    port.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);

            
        //    port.Open();

        //    // Enter an application loop to keep this thread alive
        //    //Application.Run(SerialPortProgram());
        //}
        void portOpen(out SerialPort port)
        {
            // Begin communications
            port = initializeSerialPort();
            port.Open();
        }

        void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            DateTime dt = DateTime.Now;
            String dtShort = dt.ToShortTimeString();

            //txtReceive.AppendText("[" + dtShort + "] " + "Received: " + port.ReadExisting() + "\n");
            txtReceive.AppendText($"[{dtShort}] Reveived: {port.ReadExisting()} \n");

        }
        void portClose(SerialPort port)
        {
            //SerialPort port = initializeSerialPort();
            port.Close();
        }


    }
}
