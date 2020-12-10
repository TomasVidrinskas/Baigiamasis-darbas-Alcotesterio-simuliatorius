using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace AlcSimulator.BL
{
    public class ComPort
    {

        //// Create the serial port with basic settings
        //private SerialPort port = new SerialPort("COM1",
        //  9600, Parity.None, 8, StopBits.One);

        //[STAThread]
        //public void Main(string[] args)
        //{
        //    // Instatiate this class
        //    new SerialPortProgram();
        //}

        //public void SerialPortProgram()
        //{
        //    Console.WriteLine("Incoming Data:");

        //    // Attach a method to be called when there
        //    // is data waiting in the port's buffer
        //    port.DataReceived += new
        //      SerialDataReceivedEventHandler(port_DataReceived);

        //    // Begin communications
        //    port.Open();

        //    // Enter an application loop to keep this thread alive
        //    //Application.Run();
        //}

        //private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    // Show all the incoming data in the port's buffer
        //    Console.WriteLine(port.ReadExisting());
        //}
    }
}
