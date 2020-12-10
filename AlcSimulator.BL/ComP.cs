using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AlcSimulator.BL
{

    public class ComP
    { 
        public string[] PortsSelection()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }
            
    }
    
}
