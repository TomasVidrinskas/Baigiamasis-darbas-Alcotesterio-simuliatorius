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
            //okMessage = true;
        }

        string currentComPort = "";
        string currentBoudRate = "";
        public bool connectDisconnect;
        public bool okMessage;
        private string value;
        private SerialPort port;
        private List<string> listMessages = new List<string>();


        //ComboBox
        private void comPort_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             currentComPort = comPort_comboBox1.SelectedItem.ToString();
        } 
        private void boud_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBoudRate = boud_comboBox2.SelectedItem.ToString();
        }

        // Mygtuku paspaudimas
        public void connect_button1_Click(object sender, EventArgs e)
        {
            CheckBoxHandler();
            ConnectButtonStatusHandler();
        }
        private void send_button1_Click(object sender, EventArgs e)
        {
            SendButtonStatusHandler();
        }
 

        void CheckBoxHandler()
        {
            if (belowAlcLim_checkBox5.Checked == true)
            {

                aboveAlcLim_checkBox4.Enabled = false;
                okMessage = false;
            }
            else
            {
                
                okMessage = true;
                

            }
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

        void ConnectButtonStatusHandler()
        {
            DateTime dt = DateTime.Now;
            string tShort = dt.ToShortTimeString();
            string dShort = dt.ToShortDateString();
            try
            {
                if (connectDisconnect)
                {                 
                    connect_button1.Text = "Disconnect";// port is connected
                    portOpen(out port);
                    richTextBox1.AppendText($"[{dShort} {tShort}] Connected\r\n");

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
            catch (Exception) { MessageBox.Show($"Cannot connect to {currentComPort}","Error"); }
        }

        void SendButtonStatusHandler()
        {
            DateTime dt = DateTime.Now;
            string tShort = dt.ToShortTimeString();
            string dShort = dt.ToShortDateString();
            CheckBoxMessages();
            try
            {
                var messageList = listMessages;
                if (messageList.Any())
                {
                    foreach (string message in messageList)
                    {
                        port.Write(message);
                        richTextBox1.AppendText($"[{dShort} {tShort}] Sent: {message}\r\n");
                    }
                    listMessages.Clear();
                }
                else
                {
                    richTextBox1.AppendText($"[{dShort} {tShort}] NOT ONE CHECK BOX IS SELECTED, NOTHING TO SEND!\r\n");
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }
        void MessageHandler(int checkBox)
        {
            MessageData message = new MessageData();
            var alcData = message.MessageDictionary();
            int checkBoxMessage = checkBox;
            alcData.TryGetValue(checkBoxMessage, out string value1);
            
            listMessages.Add(value1);
            //return value1;
   
        }
        void CheckBoxMessages()
        {
            if (on_checkBox1.Checked == true)
            {
                MessageHandler(1);
            }
            if(blow_checkBox2.Checked == true)
            {
                MessageHandler(2);
            }
            if (aboveDispl_checkBox3.Checked == true)
            {
                MessageHandler(3);
            }
            if (aboveAlcLim_checkBox4.Checked == true)
            {
                MessageHandler(4);
            }
            if (belowAlcLim_checkBox5.Checked == true)
            {
                MessageHandler(5);
            }
            if (value_checkBox6.Checked == true)
            {

            }
            if (errFlow_checkBox7.Checked == true)
            {
                MessageHandler(7);
            }
            if (errTemp_checkBox8.Checked == true)
            {
                MessageHandler(8);
            }
            if (errSuck_checkBox9.Checked == true)
            {
                MessageHandler(9);
            }
            if (errBreathTemp_checkBox1.Checked == true)
            {
                MessageHandler(10);
            }
        }
        //void PridetiPrieNeteisingu(string spejimas, List<string> neteisingiSpejimai)
        //{
        //    neteisingiSpejimai.Add(spejimas);
        //}

            //=====Portas========================================================
        SerialPort initializeSerialPort()
        {
            port = new SerialPort();
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
                string tShort = dt.ToShortTimeString();
                string dShort = dt.ToShortDateString();
                richTextBox1.AppendText($"[{dShort} {tShort}] Reveived: {inData}");
                richTextBox1.ScrollToCaret();
            }));
        }

    }
}
