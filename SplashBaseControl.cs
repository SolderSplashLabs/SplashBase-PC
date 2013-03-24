using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.Net.NetworkInformation;

namespace SplashBaseControl
{
    public partial class SplashBaseControl : Form
    {
        ArrayList listOfControlForms = new ArrayList();
        ArrayList listOfLogicForms = new ArrayList();
        
        string[] SolderBridgeNames = {"None", "24 Servo", "DMX Master", "0-10v", "Datalogger", "9Dof"};
        
        // Create a delegate we can call when an incoming messager needs processing
        public delegate void ProcessMessageDelegate(byte[] message);
        public ProcessMessageDelegate myDelegate;

        UdpClient udpClient;
        Thread thread;
        Boolean BroadcastUpdatingFlag = false;

        string SelectedSplashBaseIp = "";

        private void ReceiveMessage()
        {
            while (true)
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] content = udpClient.Receive(ref remoteIPEndPoint);

                if (content.Length > 0)
                {
                    //string message = Encoding.ASCII.GetString(content);

                    this.Invoke(myDelegate, new object[] { content });
                }
            }
        }

        public void SendBroadCastPing()
        {
            byte[] data = new byte[6];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Broadcast, 11028);
            UdpClient BcastClient;

            listRemotesFound.Items.Clear();

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
        }

        private void ProcessMessage(byte[] message)
        {
            string IpAddr;
            string MacAddr;
            string UnitName;
            string swVer;
            ListViewItem currentRow;
            int i = 0;
            ListViewItem listItem;

            // TODO : Search and update
            // TODO : Add last seen column

            if ((message.Length == 118) && (message[0] == (byte)CommandNo.SSC_REPLY_PING))
            {
                IpAddr = message[4].ToString() + "." + message[3].ToString() + "." + message[2].ToString() + "." + message[1].ToString();
                MacAddr = message[10].ToString() + ":" + message[9].ToString() + ":" + message[8].ToString() + ":" + message[7].ToString() + ":" + message[6].ToString() + ":" + message[5].ToString();

                MacAddr = BitConverter.ToString(message, 5, 6);
                MacAddr = MacAddr.Replace("-", ":");

                swVer = BitConverter.ToString(message, 11, 2);
                swVer = message[11].ToString() + "." + message[12].ToString();

                // TODO : Check Length
                UnitName = System.Text.ASCIIEncoding.ASCII.GetString(message, 13, 23);

                listItem = null;

                try
                {
                    listItem = listRemotesFound.FindItemWithText(MacAddr, true, 0);
                }
                catch (Exception)
                {
                    
                }

                if (listItem != null)
                {
 
                    // found it - update it
                    if ( listItem.Text != UnitName ) listItem.Text = UnitName;
                    if (listItem.SubItems[1].Text != IpAddr) listItem.SubItems[1].Text = IpAddr;
                    if (listItem.SubItems[3].Text != swVer) listItem.SubItems[3].Text = swVer;
                    if (listItem.SubItems[4].Text != message[36].ToString()) listItem.SubItems[4].Text = message[36].ToString();

                    listItem.SubItems[5].Text = (BitConverter.ToUInt16(message, 38).ToString());
                    listItem.SubItems[6].Text = (BitConverter.ToUInt16(message, 40).ToString());
                    listItem.SubItems[7].Text = (BitConverter.ToUInt16(message, 42).ToString());
       
                }
                else
                {
                    currentRow = listRemotesFound.Items.Add(UnitName);
                    currentRow.SubItems.Add(IpAddr);
                    currentRow.SubItems.Add(MacAddr);
                    currentRow.SubItems.Add(swVer);
                    // Config
                    currentRow.SubItems.Add(message[36].ToString());            

                    currentRow.SubItems.Add(BitConverter.ToUInt16(message, 38).ToString());
                    currentRow.SubItems.Add(BitConverter.ToUInt16(message, 40).ToString());
                    currentRow.SubItems.Add(BitConverter.ToUInt16(message, 42).ToString());
                }

                foreach (ControlFrm controlFrm in listOfControlForms)
                {
                    if (controlFrm.Text.Contains(MacAddr))
                    {
                        controlFrm.BroadcastRecieved(message);
                        break;
                    }
                }
            }

            if ((message.Length == 68) && (message[0] == (byte)CommandNo.SSC_REPLY_CONFIG))
            {
                IpAddr = message[4].ToString() + "." + message[3].ToString() + "." + message[2].ToString() + "." + message[1].ToString();
                MacAddr = message[10].ToString() + ":" + message[9].ToString() + ":" + message[8].ToString() + ":" + message[7].ToString() + ":" + message[6].ToString() + ":" + message[5].ToString();

                MacAddr = BitConverter.ToString(message, 5, 6);
                MacAddr = MacAddr.Replace("-", ":");

                if (listRemotesFound.Items.Count > 0)
                {
                    listItem = null;
                    try
                    {
                        listItem = listRemotesFound.FindItemWithText(MacAddr, true, 0);
                    }
                    catch (Exception)
                    {
                        
          
                    }

                    if (listItem != null)
                    {
                        // found it - update it
                        listItem.SubItems[1].Text = IpAddr;
                        listItem.SubItems[4].Text = message[11].ToString();

                        EdtSubNetAddr.Text = message[29].ToString() + "." + message[28].ToString() + "." + message[27].ToString() + "." + message[26].ToString();
                        EdtGatewayAddr.Text = message[33].ToString() + "." + message[32].ToString() + "." + message[31].ToString() + "." + message[30].ToString();


                        EdtNtpOffset.Value = (decimal)((decimal)BitConverter.ToUInt16(message, 66) / (decimal)60);

                        if (listItem.Selected)
                        {
                            for (i = 0; i < 5; i++)
                            {
                                try
                                {
                                    if (0xFF == message[13 + i])
                                    {
                                        ListSolderBridges.Items[i].SubItems[1].Text = SolderBridgeNames[0];
                                    }
                                    else
                                    {
                                        ListSolderBridges.Items[i].SubItems[1].Text = SolderBridgeNames[message[13 + i]];
                                    }
                                }
                                catch (global::System.Exception)
                                {
                                    ListSolderBridges.Items[i].SubItems[1].Text = message[13 + i].ToString();
                                }
                            }

                            for (i = 0; i < 8; i++)
                            {
                                ListSolderBridges.Items[i + 5].SubItems[1].Text = message[18 + i].ToString();
                            }

                            UpdateConfigDisplayFlags(message[11]);

                            // Snow NTP Host name :
                            EdNtpServerAddr.Text = System.Text.ASCIIEncoding.ASCII.GetString(message, 34, 32);
                        }
                    }
                    else
                    {
                        // We dont have this unit on the list
                    }
                }
            }

            if (((message.Length == 52) || (message.Length == 99)) && (message[0] == 224))
            {
                BroadcastUpdatingFlag = true;

                IpAddr = message[4].ToString() + "." + message[3].ToString() + "." + message[2].ToString() + "." + message[1].ToString();
                MacAddr = message[10].ToString() + ":" + message[9].ToString() + ":" + message[8].ToString() + ":" + message[7].ToString() + ":" + message[6].ToString() + ":" + message[5].ToString();

                MacAddr = BitConverter.ToString(message, 5, 6);
                MacAddr = MacAddr.Replace("-", ":");

                swVer = BitConverter.ToString(message, 11, 2);
                swVer = message[11].ToString() + "." + message[12].ToString();

                // TODO : Check Length
                UnitName = System.Text.ASCIIEncoding.ASCII.GetString(message, 31, message[30]);


                if ((listRemotesFound.Items.Count > 0) && (listRemotesFound.FindItemWithText(MacAddr, true, 0) != null))
                {
                    // found it - update it
                }
                else
                {
                    currentRow = listRemotesFound.Items.Add(UnitName);
                    currentRow.SubItems.Add(IpAddr);
                    currentRow.SubItems.Add(MacAddr);
                    currentRow.SubItems.Add(swVer);
                    currentRow.SubItems.Add(message[13].ToString());
                }

                /*
                foreach (ControlFrm controlFrm in listOfControlForms)
                {
                    if (controlFrm.Text.Contains(IpAddr))
                    {
                        controlFrm.BroadcastRecieved(message);
                        break;
                    }
                }
                */
            }
            else if (message[0] == 225)
            {
                // Port info

                IpAddr = message[4].ToString() + "." + message[3].ToString() + "." + message[2].ToString() + "." + message[1].ToString();
                MacAddr = message[10].ToString() + ":" + message[9].ToString() + ":" + message[8].ToString() + ":" + message[7].ToString() + ":" + message[6].ToString() + ":" + message[5].ToString();

                MacAddr = BitConverter.ToString(message, 5, 6);
                MacAddr = MacAddr.Replace("-", ":");

                swVer = BitConverter.ToString(message, 11, 2);
                swVer = message[11].ToString() + "." + message[12].ToString();

                // TODO : Check Length
                UnitName = "Unknown";

                if ((listRemotesFound.Items.Count > 0) && (listRemotesFound.FindItemWithText(MacAddr, true, 0) != null))
                {
                    // found it - update it
                }
                else
                {
                    currentRow = listRemotesFound.Items.Add(UnitName);
                    currentRow.SubItems.Add(IpAddr);
                    currentRow.SubItems.Add(MacAddr);
                    currentRow.SubItems.Add(swVer);
                }

                /*
                foreach (ControlFrm controlFrm in listOfControlForms)
                {
                    if (controlFrm.Text.Contains(IpAddr))
                    {
                        controlFrm.BroadcastRecieved(message);
                        break;
                    }
                }
                */
            }

            BroadcastUpdatingFlag = false;
        }

        public SplashBaseControl()
        {
            InitializeComponent();
        }

        private void ButFindSplashBases_Click(object sender, EventArgs e)
        {
            SendBroadCastPing();
        }

        private void SplashBaseControl_Load(object sender, EventArgs e)
        {
            try
            {
                udpClient = new UdpClient(11029);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SplashBaseControl_Shown(object sender, EventArgs e)
        {
            myDelegate = new ProcessMessageDelegate(ProcessMessage);
            thread = new Thread(new ThreadStart(ReceiveMessage));
            thread.IsBackground = true;
            thread.Start();

            SendBroadCastPing();
        }

        /// <summary>
        /// Send off a request for SolderBridges connected & IP Address info
        /// </summary>
        private void UpdateSplashBaseInfo( IPAddress ipAddr )
        {
            SplashBaseComs coms = new SplashBaseComs();
            coms.ExtendedPing(ipAddr);
        }

        private void ClearConfigDisplay()
        {
            int i = 0;

            for (i=0; i<ListSolderBridges.Items.Count; i++)
            {
                ListSolderBridges.Items[i].SubItems[1].Text = "";
            }
            ChkDynamicIp.Checked = false;
            ChkUserGpioInit.Checked = false;
            ChkFourRelay.Checked = false;
            ChkRGBEnabled.Checked = false;
            ChkLogic.Checked = false;
            ChkNtpEnabled.Checked = false;
        }

        private void UpdateConfigDisplayFlags(byte configByte)
        {
            // 0x80 - Static IP if set
            if ((configByte & 0x80) == 0x01)
            {
                ChkDynamicIp.Checked = true;
            }
            else
            {
                ChkDynamicIp.Checked = false;
            }

            // 0x40 - Use Custom NTP Server
            if ((configByte & 0x40) == 0x40)
            {
                ChkNtpEnabled.Checked = true;
            }
            else
            {
                ChkNtpEnabled.Checked = false;
            }

            // 0x20 - User GPIO Init
            if ((configByte & 0x20) == 0x20)
            {
                ChkUserGpioInit.Checked = true;
            }
            else
            {
                ChkUserGpioInit.Checked = false;
            }

            // 0x10 - Four Relay SolderBridge enabled
            if ((configByte & 0x10) == 0x10)
            {
                ChkFourRelay.Checked = true;
            }
            else
            {
                ChkFourRelay.Checked = false;
            }

            // 0x08 - PWM RGB Mode enabled
            if ((configByte & 0x08) == 0x08)
            {
                ChkRGBEnabled.Checked = true;
            }
            else
            {
                ChkRGBEnabled.Checked = false;
            }

            // 0x04 - LOGIC enabled
            if ((configByte & 0x04) == 0x04)
            {
                ChkLogic.Checked = true;
            }
            else
            {
                ChkLogic.Checked = false;
            }

            // 0x02 - NTP enabled
            if ((configByte & 0x02) == 0x02)
            {
                ChkPwmEn.Checked = true;
            }
            else
            {
                ChkPwmEn.Checked = false;
            }

            if ((configByte & 0x01) == 0x01)
            {
                // Spare
            }
            else
            {

            }
        }

        /// <summary>
        /// Update the Display with SplashBase Info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listRemotesFound_MouseClick(object sender, MouseEventArgs e)
        {
            byte configBits = 0;

            ClearConfigDisplay();

            if (listRemotesFound.SelectedItems.Count > 0)
            {
                // Row selected
                GrpSplashBase.Enabled = true;

                try
                {
                    EdtSplashBaseName.Text = listRemotesFound.SelectedItems[0].Text;
                    EdtIpAddr.Text = listRemotesFound.SelectedItems[0].SubItems[1].Text;
                    configBits = Convert.ToByte(listRemotesFound.SelectedItems[0].SubItems[4].Text);

                    SelectedSplashBaseIp = listRemotesFound.SelectedItems[0].SubItems[1].Text;

                    UpdateConfigDisplayFlags(configBits);
                    UpdateSplashBaseInfo(IPAddress.Parse(listRemotesFound.SelectedItems[0].SubItems[1].Text));
                }
                catch (Exception)
                {
                    
                    //throw;
                }
               
            }
            else
            {
                GrpSplashBase.Enabled = false;
                ClearConfigDisplay();
            }
        }

        private void ButRescanBridges_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[2];

            dataBytes[0] = 0x80;
            dataBytes[1] = 0xFF;

            coms.Command(dataBytes, dataBytes.Length, IPAddress.Parse(SelectedSplashBaseIp));
        }

        private void ButRefreshExtendedInfo_Click(object sender, EventArgs e)
        {
            if (listRemotesFound.SelectedItems.Count > 0)
            {
                UpdateSplashBaseInfo(IPAddress.Parse(SelectedSplashBaseIp));
            }
        }

        private void EdtSetName_Click(object sender, EventArgs e)
        {
            byte lengthOfStr = (byte)EdtSplashBaseName.Text.Length;
            SplashBaseComs coms = new SplashBaseComs();

            if (lengthOfStr > 23) lengthOfStr = 23;

            string tempStr = "\0\0" + EdtSplashBaseName.Text;

            byte[] byteString = System.Text.Encoding.ASCII.GetBytes(tempStr);
            int nameLen = byteString.Length;

            byteString[0] = 0x20;
            byteString[1] = lengthOfStr;
            try
            {
                // todo : dont use the listview selection?
                coms.Command(byteString, byteString.Length, IPAddress.Parse(SelectedSplashBaseIp));
            }
            catch (Exception)
            {

            }
        }

        private byte packConfigByte ()
        {
            byte packedConfig = 0;

            if (ChkDynamicIp.Checked == false) packedConfig |= 0x80;
            if (ChkNtpEnabled.Checked) packedConfig |= 0x40;
            if (ChkUserGpioInit.Checked) packedConfig |= 0x20;
            if (ChkFourRelay.Checked) packedConfig |= 0x10;
            if (ChkRGBEnabled.Checked) packedConfig |= 0x08;
            if (ChkLogic.Checked) packedConfig |= 0x04;
            if (ChkPwmEn.Checked) packedConfig |= 0x02;
            //if ( .Checked) packedConfig |= 0x01;

            return (packedConfig);
        }

        private void ButApply_Click(object sender, EventArgs e)
        {
            byte[] comsBytes = new byte[53];
            SplashBaseComs coms = new SplashBaseComs();
            int ntpServerStringLen = EdNtpServerAddr.Text.Length;
            byte[] ntpByteString = System.Text.Encoding.ASCII.GetBytes(EdNtpServerAddr.Text);
            UInt16 ntpOffset;
            IPAddress address;

            comsBytes[0] = 0x22;

            comsBytes[1] = packConfigByte();
            comsBytes[2] = 0;
            comsBytes[3] = 0;

            address = IPAddress.Parse(EdtIpAddr.Text);
            byte[] hostIp = address.GetAddressBytes();
            Buffer.BlockCopy(hostIp, 0, comsBytes, 4, 4);
            /*
            comsBytes[4] = 0;   // IpAddress
            comsBytes[5] = 0;   // IpAddress
            comsBytes[6] = 0;   // IpAddress
            comsBytes[7] = 0;   // IpAddress
            */

            address = IPAddress.Parse(EdtSubNetAddr.Text);
            byte[] subNetIp = address.GetAddressBytes();
            Buffer.BlockCopy(subNetIp, 0, comsBytes, 8, 4);
            /*
            comsBytes[8] = 0;   // Subnet
            comsBytes[9] = 0;   // Subnet
            comsBytes[10] = 0;  // Subnet
            comsBytes[11] = 0;  // Subnet
            */

            address = IPAddress.Parse(EdtGatewayAddr.Text);
            byte[] gatewayIp = address.GetAddressBytes();
            Buffer.BlockCopy(gatewayIp, 0, comsBytes, 12, 4);
            /*
            comsBytes[12] = 0;  // Gateway
            comsBytes[13] = 0;  // Gateway
            comsBytes[14] = 0;  // Gateway
            comsBytes[15] = 0;  // Gateway
            */

            comsBytes[16] = 0;  // Spare
            comsBytes[17] = 0;  // Spare
            comsBytes[18] = 0;  // Spare
            comsBytes[19] = 0;  // Spare

            // Limit String length
            if (ntpServerStringLen > 31) ntpServerStringLen = 31;
            Buffer.BlockCopy(ntpByteString, 0, comsBytes, 20, ntpServerStringLen);
            
            ntpOffset = (UInt16)(EdtNtpOffset.Value * 60);
            Buffer.BlockCopy( BitConverter.GetBytes( ntpOffset ), 0, comsBytes, 51,2);

            try
            {
                // todo : dont use the listview selection?
                coms.Command(comsBytes, comsBytes.Length, IPAddress.Parse(listRemotesFound.SelectedItems[0].SubItems[1].Text));
            }
            catch (Exception)
            {

            }
        }

        private void rebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();

            byte[] byteString = System.Text.Encoding.ASCII.GetBytes( "\0kick" );
            byteString[0] = 0xff;

            coms.Command(byteString, byteString.Length, IPAddress.Parse(SelectedSplashBaseIp));
        }

        private void bootloadModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();

            byte[] byteString = System.Text.Encoding.ASCII.GetBytes("\0reflash");
            byteString[0] = 0xff;

            coms.Command(byteString, byteString.Length, IPAddress.Parse(SelectedSplashBaseIp));
        }

        private void defaultConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();

            byte[] byteString = System.Text.Encoding.ASCII.GetBytes("\0default");
            byteString[0] = 0xff;

            coms.Command(byteString, byteString.Length, IPAddress.Parse(SelectedSplashBaseIp));
        }

        public void ControlRemote(string macaddr, string ipaddr)
        {
            bool foundIt = false;

            foreach (ControlFrm controlFrm in listOfControlForms)
            {
                if (controlFrm.Text.Contains(macaddr))
                {
                    foundIt = true;
                    controlFrm.WindowState = FormWindowState.Normal;
                    controlFrm.SetMacAndIp(macaddr, ipaddr);
                    controlFrm.BringToFront();
                    break;
                }
            }

            if (foundIt == false)
            {
                // Open a control window for the remote
                ControlFrm newFrm = new ControlFrm();
                listOfControlForms.Add(newFrm);
                newFrm.SetMacAndIp(macaddr, ipaddr);
                newFrm.SetParent(this);
                newFrm.Show();
            }
        }

        private void listRemotesFound_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listRemotesFound.SelectedItems.Count > 0)
            {
                ControlRemote(listRemotesFound.SelectedItems[0].SubItems[2].Text, listRemotesFound.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void ButPwm_Click(object sender, EventArgs e)
        {
            if (listRemotesFound.SelectedItems.Count > 0)
            {
                ControlRemote(listRemotesFound.SelectedItems[0].SubItems[2].Text, listRemotesFound.SelectedItems[0].SubItems[1].Text);
            }
        }

    }
}
