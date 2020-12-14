using System.IO.Ports;

namespace AlcSimulator.BL
{

    public class GetComPortNames
    {
        public string[] PortsSelection()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

    }

}
