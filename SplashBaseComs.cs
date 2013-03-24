using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace SplashBaseControl
{
    class SplashBaseComs
    {
        const int REMOTE_PORT_NO = 11028;

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
