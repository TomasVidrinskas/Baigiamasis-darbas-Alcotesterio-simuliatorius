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

namespace Baigiamasis_darbas_Alcotesterio_simuliatorius
{
    public partial class Main_Form1 : Form
    {
        public Main_Form1()
        {
            InitializeComponent();
            StartUpFunction();
        }

        string currentComPort = "";
        string currentBoudRate = "";

        //private void btnok_click(object sender, eventargs e)
        //{
        //    if (cmbserialports.selectedindex > -1)
        //    {
        //        messagebox.show(string.format("you selected port '{0}'", cmbserialports.selecteditem));
        //        connect(cmbserialports.selecteditem.tostring());
        //    }
        //    else
        //    {
        //        messagebox.show("please select a port first");
        //    }
        //}

        //private void connect(string portname)
        //{
        //    var port = new serialport(portname);
        //    if (!port.isopen)
        //    {
        //        port.baudrate = 19200;
        //        port.open();
        //        //continue here....
        //    }
        //}

        private void comPort_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             currentComPort = comPort_comboBox1.SelectedItem.ToString();
        }

        private void on_checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        void StartUpFunction()
        {
            ComP Pimas = new ComP();

            string[] pippas = Pimas.PortsSelection();
            foreach (string i in pippas)
            {
                comPort_comboBox1.Items.Add(i);
            }
            comPort_comboBox1.SelectedIndex = 0;
        } 
    }
}
