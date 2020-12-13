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

        }
        private void send_button1_Click(object sender, EventArgs e)
        {
            SendButtonStatusHandler(port);
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
            DateTime dt = DateTime.Now;
            String tShort = dt.ToShortTimeString();
            String dShort = dt.ToShortDateString();
            try
            {
                if (connectDisconnect)
                {
                    
                    port = new SerialPort();

                    connect_button1.Text = "Disconnect";// port is connected
                    portOpen(out port);
                    richTextBox1.AppendText($"[{dShort} {tShort}] Connected\r\n");
                    //port.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
                    
                    port.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
                    connectDisconnect = false;
                }
                else
                {
                    connect_button1.Text = "Connect";//port is disconnected
                    portClose(port);
                    connectDisconnect = true;
                    richTextBox1.AppendText($"[{dShort} {tShort}] Disconnected\r\n");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }
        private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string inData = port.ReadLine(); // ReadLine includes the + "\n"
            displayToWindow(inData);
        }

        private void displayToWindow(string inData)
        {
            BeginInvoke(new EventHandler(delegate
            {
                DateTime dt = DateTime.Now;
                String tShort = dt.ToShortTimeString();
                String dShort = dt.ToShortDateString();
                richTextBox1.AppendText($"[{dShort} {tShort}] Reveived: {inData}");
                richTextBox1.ScrollToCaret();
            }));
        }

        void SendButtonStatusHandler(SerialPort port)
        {
            DateTime dt = DateTime.Now;
            String tShort = dt.ToShortTimeString();
            String dShort = dt.ToShortDateString();

            MessageData message = new MessageData();
            var alcData = message.MessageDictionary();

            if (alcData.TryGetValue(1, out string value))
            {
                port.Write(value);
                richTextBox1.AppendText($"[{dShort} {tShort}] Sent: {value}\r\n");
            }
        }

        //=====Portas========================================================
        SerialPort initializeSerialPort()
        {
            int boud = int.Parse(currentBoudRate);
            port = new SerialPort(currentComPort, boud, Parity.None, 8, StopBits.One);
            return port;
        }
        void portOpen(out SerialPort port)
        {
            // Begin communications
            port = initializeSerialPort();
            port.Open();
        }
        void portClose(SerialPort port)
        {
            port.Close();
        }


    }
}
