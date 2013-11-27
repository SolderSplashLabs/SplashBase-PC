using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace SplashBaseControl
{
    enum CommandNo
    {
        SSC_PING = 1,						// Check the Unit is there
        SSC_EXTENDED_PING,					// Get Extended Info
        SSC_RELAY_CON = 10,					// Control it's relays
        SSC_PWM_DUTY,						// Duty for a single PWM
        SSC_PWM_DUTY_ALL,					// Duty for a PWMs
        SSC_PWM_FREQ,						// Set Freq of the PWMs masked
        SSC_PWM_COLOUR_MODE,				// Use a colour mode to control the PWMs
        SSC_SET_UNIT_NAME = 0x20,
        SSC_SET_RELAY_NAME,					// Set the supplied relay no's name
        SSC_SET_CONFIG,
        SSC_SAVE_CONFIG,
        SSC_OUTPUTS_ON_OFF = 0x30,			// Control all outputs, turn if on/off
        SSC_SPLASHPIXEL_FBSET = 0x45,		// Set the SplashPixel Framebuffer
        SSC_MANUAL_GPIO_DIR = 0x50, 		// Set gpio direction, 1 output
        SSC_MANUAL_GPIO_DATA = 0x51, 		// set gpio outputs high or low
        SSC_MANUAL_GPIO_CONF = 0x52, 		// set gpio dir and outputs
        SSC_GET_ALL_GPIO = 0x53,
        SSC_INIT_GPIO_CONF = 0x54, 		    // set init gpio dir and outputs
        SSC_INIT_GPIO_RUN = 0x55,
        SSC_LOGIC_COMMAND = 0x60,
        SSC_LOGIC_INSERT_CON = 0x61,		// Insert a command
        SSC_LOGIC_EDT_ACT = 0x62,		    // Add/Edit an action
        SSC_LOGIC_EDT_COND = 0x63,          // Add/Edit a condition
        SSC_LOGIC_EDT_EVENT = 0x64,         // Add/Edit an event

        SSC_LOGIC_READ_ACTION = 0x65,
        SSC_LOGIC_READ_CONDTION = 0x66,
        SSC_LOGIC_READ_EVENTS = 0x67,
        SSC_LOGIC_READ = 0x68,

        SSC_BRIDGE_SCAN = 0x80,
        SSC_SB_SERVOPOS = 0x90,

        SSC_REPLY_PING = 0xE1,
        SSC_REPLY_CONFIG = 0xE2,
        SSC_REPLY_ALL_GPIO = 0xE3,

        SSC_REPLY_LOGIC_ACT = 0xE4,
        SSC_REPLY_LOGIC_COND = 0xE5,
        SSC_REPLY_LOGIC_EVENTS = 0xE6,

        SSC_RESET = 0xFF
    }

    class SplashBaseComs
    {
        const int REMOTE_PORT_NO = 11028;

        public bool TestUDPMEssage(byte[] buffer, int size, IPAddress address, int port)
        {
            IPEndPoint ipep = new IPEndPoint(address, port);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            server.SendTo(buffer, size, SocketFlags.None, ipep);

            return true;
        }

        public bool Command(byte[] buffer, int size, IPAddress address)
        {
            IPEndPoint ipep = new IPEndPoint(address, REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            server.SendTo(buffer, size, SocketFlags.None, ipep);

            return true;
        }

        public bool Ping(IPAddress address)
        {
            byte[] buffer = new byte[6];

            buffer[0] = 1;
            buffer[1] = Convert.ToByte('H');
            buffer[2] = Convert.ToByte('e');
            buffer[3] = Convert.ToByte('l');
            buffer[4] = Convert.ToByte('l');
            buffer[5] = Convert.ToByte('o');

            IPEndPoint ipep = new IPEndPoint(address, REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            server.SendTo(buffer, buffer.Length, SocketFlags.None, ipep);

            return true;
        }

        public bool ExtendedPing(IPAddress address)
        {
            byte[] buffer = new byte[6];

            buffer[0] = 2;
            buffer[1] = Convert.ToByte('H');
            buffer[2] = Convert.ToByte('e');
            buffer[3] = Convert.ToByte('l');
            buffer[4] = Convert.ToByte('l');
            buffer[5] = Convert.ToByte('o');

            IPEndPoint ipep = new IPEndPoint(address, REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            server.SendTo(buffer, buffer.Length, SocketFlags.None, ipep);

            return true;
        }

        public bool BroadcastPing()
        {
            byte[] data = new byte[6];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Broadcast, REMOTE_PORT_NO);
            UdpClient BcastClient;

            //listRemotesFound.Items.Clear();

            data[0] = 1;
            data[1] = Convert.ToByte('H');
            data[2] = Convert.ToByte('e');
            data[3] = Convert.ToByte('l');
            data[4] = Convert.ToByte('l');
            data[5] = Convert.ToByte('o');

            // Broadcasting with multiple network adapters doesn't work, you need to broadcast on each one
            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netif.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties properties = netif.GetIPProperties();
                    foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                    {
                        // Only looking for IPv4 links at the moment
                        if (unicast.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            Console.WriteLine(unicast.Address);

                            BcastClient = new UdpClient(new IPEndPoint(unicast.Address, 11028));

                            BcastClient.EnableBroadcast = true;
                            BcastClient.Send(data, data.Length, ipep);

                            BcastClient.Close();
                        }
                    }
                }
            }

            return true;
        }
    }
}
