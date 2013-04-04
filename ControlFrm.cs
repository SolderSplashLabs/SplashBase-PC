using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace SplashBaseControl
{
    public partial class ControlFrm : Form
    {
        const int REMOTE_PORT_NO = 11028;
        SplashBaseControl MyParent;
        Boolean BroadcastUpdatingFlag = false;

        enum ColourModes
        {
            MODE_OFF,
            MODE_CYCLING,
            MODE_PULSING,
            MODE_STATIC,
            MODE_RANDOM
        }

        public ControlFrm()
        {
            InitializeComponent();
        }

        public void SetParent(SplashBaseControl callingObject)
        {
            MyParent = callingObject;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();

            cmbColourMode.SelectedIndex = 0;
            coms.Ping(IPAddress.Parse(textBox1.Text));
        }

        public void SetMacAndIp( string MAC, string Ip )
        {
            textBox1.Text = Ip;
            
            this.Text = "[SolderSplash LABS] PWM, RGB & Relay Control - " + MAC;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            byte[] slider = new byte[4];

            if (false == BroadcastUpdatingFlag)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                data[0] = (byte)CommandNo.SSC_PWM_DUTY_ALL; 
                slider = BitConverter.GetBytes(trackBar1.Value);
                data[1] = slider[0];
                data[2] = slider[1];

                slider = BitConverter.GetBytes(trackBar2.Value);
                data[3] = slider[0];
                data[4] = slider[1];

                slider = BitConverter.GetBytes(trackBar3.Value);
                data[5] = slider[0];
                data[6] = slider[1];
                data[7] = 0;

                server.SendTo(data, data.Length, SocketFlags.None, ipep);
            }
            lblPwm2.Text = trackBar3.Value.ToString();
            lblPwm1.Text = trackBar2.Value.ToString();
            lblPwm0.Text = trackBar1.Value.ToString();
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            byte[] slider = new byte[4];

            if (false == BroadcastUpdatingFlag)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                data[0] = (byte)CommandNo.SSC_PWM_FREQ; 
                slider = BitConverter.GetBytes(trackBar4.Value);
                data[1] = slider[0];
                data[2] = slider[1];

                server.SendTo(data, data.Length, SocketFlags.None, ipep);
            }

            trackBar1.Maximum = trackBar4.Value-1;
            trackBar2.Maximum = trackBar4.Value-1;
            trackBar3.Maximum = trackBar4.Value-1;

            lblPwm2.Text = trackBar3.Value.ToString();
            lblPwm1.Text = trackBar2.Value.ToString();
            lblPwm0.Text = trackBar1.Value.ToString();


            lblPwm3.Text = trackBar4.Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[3];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            data[0] = 0x30;
            data[1] = 1;
            data[2] = 2;

            server.SendTo(data, data.Length, SocketFlags.None, ipep);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[3];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            data[0] = 0x30;
            data[1] = 0;
            data[2] = 2;

            server.SendTo(data, data.Length, SocketFlags.None, ipep);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[3];
  
            System.Windows.Forms.Button buttonpressed = (Button)sender;

            //IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
            //Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            data[0] = 10;

            data[1] = Convert.ToByte(buttonpressed.Tag);
            data[2] = Convert.ToByte(buttonpressed.Tag);

            //server.SendTo(data, data.Length, SocketFlags.None, ipep);

            SplashBaseComs coms = new SplashBaseComs();
            coms.Command(data, data.Length, IPAddress.Parse(textBox1.Text));
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[3];
            System.Windows.Forms.Button buttonpressed = (Button)sender;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            data[0] = 10;
            data[1] = 0;
            data[2] = Convert.ToByte(buttonpressed.Tag);

            server.SendTo(data, data.Length, SocketFlags.None, ipep);
        }

        private void butBroadcast_Click(object sender, EventArgs e)
        {
            /*
            byte[] data = new byte[6];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Broadcast, 11028);
            UdpClient BcastClient = new UdpClient(AddressFamily.InterNetwork);

            listRemotesFound.Items.Clear();

            data[0] = 1;
            data[1] = Convert.ToByte('H');
            data[2] = Convert.ToByte('e');
            data[3] = Convert.ToByte('l');
            data[4] = Convert.ToByte('l');
            data[5] = Convert.ToByte('o');

            BcastClient.EnableBroadcast = true;
            BcastClient.Send(data, data.Length, ipep);
             * */
        }

        // Recv UDP Reply Code ..
        /*

        public delegate void ShowMessage(byte[] message);
        public ShowMessage myDelegate;
        UdpClient udpClient = new UdpClient(11029);
        Thread thread;

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

        

        private void ShowMessageMethod(byte[] message)
        {
            string IpAddr;
            string MacAddr;
            string UnitName;
            ListViewItem currentRow;

            if (message.Length == 52)
            {
                BroadcastUpdatingFlag = true;

                IpAddr = message[4].ToString() + "." + message[3].ToString() + "." + message[2].ToString() + "." + message[1].ToString();
                MacAddr = message[10].ToString() + ":" + message[9].ToString() + ":" + message[8].ToString() + ":" + message[7].ToString() + ":" + message[6].ToString() + ":" + message[5].ToString();
   
                MacAddr = BitConverter.ToString(message,5,6);
                MacAddr = MacAddr.Replace("-", ":");
                
                // TODO : Check Length
                UnitName = System.Text.ASCIIEncoding.ASCII.GetString(message, 31, message[30]);
                   
                currentRow = listRemotesFound.Items.Add(IpAddr);
                currentRow.SubItems.Add(MacAddr);
                currentRow.SubItems.Add(UnitName);

                trackBar4.Value = BitConverter.ToUInt16(message, 20);
                trackBar1.Value = BitConverter.ToUInt16(message, 14);
                trackBar2.Value = BitConverter.ToUInt16(message, 16);
                trackBar3.Value = BitConverter.ToUInt16(message, 18);
            }

            BroadcastUpdatingFlag = false;
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            myDelegate = new ShowMessage(ShowMessageMethod);
            thread = new Thread(new ThreadStart(ReceiveMessage));
            thread.IsBackground = true;
            thread.Start();
        }
        */

        public void BroadcastRecieved(byte[] message)
        {
            string tmpString;

            try
            {
                if (message[0] == (byte)CommandNo.SSC_REPLY_PING)
                {
                    if (message.Length == 118)
                    {
                        BroadcastUpdatingFlag = true;

                        trackBar4.Value = BitConverter.ToUInt16(message, 51);
                        trackBar1.Value = BitConverter.ToUInt16(message, 45);
                        trackBar2.Value = BitConverter.ToUInt16(message, 47);
                        trackBar3.Value = BitConverter.ToUInt16(message, 49);
                        /*
                        cmbColourMode.SelectedIndex = (int)message[22];

                        if (cmbColourMode.SelectedIndex == (int)ColourModes.MODE_RANDOM)
                        {
                            updateSetColour((int)message[23], (int)message[24], (int)message[25], (int)faderTrack.Maximum);
                        }
                        */

                        // Relay buttons
                        if ((message[44] & 0x01) == 0x01)
                        {
                            listRelays.Items[0].Checked = true;
                        }
                        else
                        {
                            listRelays.Items[0].Checked = false;
                        }

                        if ((message[44] & (byte)0x02) == 0x02)
                        {
                            listRelays.Items[1].Checked = true;
                        }
                        else
                        {
                            listRelays.Items[1].Checked = false;
                        }

                        if ((message[44] & 0x04) == 0x04)
                        {
                            listRelays.Items[2].Checked = true;
                        }
                        else
                        {
                            listRelays.Items[2].Checked = false;
                        }

                        if ((message[44] & 0x08) == 0x08)
                        {
                            listRelays.Items[3].Checked = true;
                        }
                        else
                        {
                            listRelays.Items[3].Checked = false;
                        }

                        tmpString = System.Text.ASCIIEncoding.ASCII.GetString(message, 66, 12);
                        if (tmpString != listRelays.Items[0].Text) listRelays.Items[0].Text = tmpString;

                        tmpString = System.Text.ASCIIEncoding.ASCII.GetString(message, 78, 12);
                        if (tmpString != listRelays.Items[1].Text) listRelays.Items[1].Text = tmpString;

                        tmpString = System.Text.ASCIIEncoding.ASCII.GetString(message, 90, 12);
                        if (tmpString != listRelays.Items[2].Text) listRelays.Items[2].Text = tmpString;

                        tmpString = System.Text.ASCIIEncoding.ASCII.GetString(message, 102, 12);
                        if (tmpString != listRelays.Items[3].Text) listRelays.Items[3].Text = tmpString;

                        //listRelays.Items[0].SubItems[1].Text = System.Text.ASCIIEncoding.ASCII.GetString(message, 51, 10);
                        //listRelays.Items[1].SubItems[1].Text = System.Text.ASCIIEncoding.ASCII.GetString(message, 61, 10);
                        //listRelays.Items[2].SubItems[1].Text = System.Text.ASCIIEncoding.ASCII.GetString(message, 71, 10);
                        //listRelays.Items[3].SubItems[1].Text = System.Text.ASCIIEncoding.ASCII.GetString(message, 81, 10);


                    }
                }
           
            }
            finally
            {
                BroadcastUpdatingFlag = false; 
            }
            
            
        }

        private void listRemotesFound_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            /*
            if (listRemotesFound.SelectedItems.Count > 0)
            {
                GrpControl.Text = "Control : " + listRemotesFound.SelectedItems[0].Text;
                textBox1.Text = listRemotesFound.SelectedItems[0].Text;
                GrpControl.Enabled = true;
            }
            else
            {
                GrpControl.Enabled = false;
            }
             */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            byte[] data = new byte[3];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            data[0] = 0x30;
            data[1] = 1;
            data[2] = 1;

            server.SendTo(data, data.Length, SocketFlags.None, ipep);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            byte[] data = new byte[3];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            data[0] = 0x30;
            data[1] = 0;
            data[2] = 1;

            server.SendTo(data, data.Length, SocketFlags.None, ipep);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void colorWheel1_MouseUp(object sender, MouseEventArgs e)
        {

        }
        public void UpdateHex()
        {
            /*
            byte red = BitConverter.(RedTxt.Text);
            byte green = CInt(GreenTxt.Text);
            byte blue = CInt(BlueTxt.Text);

            if (Hex(red).Length = 1) 
            {
                HexTxt.Text = "0" & Hex(red);
            }
            else
            {
                HexTxt.Text = Hex(red);
            }

            if (Hex(green).Length = 1) 
            {
                HexTxt.Text = HexTxt.Text & "0" & Hex(green);
            }
            else
            {
                HexTxt.Text = HexTxt.Text & Hex(green);
            }

            if (Hex(blue).Length = 1) 
            {
                HexTxt.Text = HexTxt.Text & "0" & Hex(blue);
            }
            else
            {
                HexTxt.Text = HexTxt.Text & Hex(blue);
            }
             */
        }

        private void colorWheel1_ColorChanged(object sender, EventArgs e)
        {
            if (!colourUpdating)
            {
                updateSetColour(colorWheel1.HsvColor.ToRgb().Red, colorWheel1.HsvColor.ToRgb().Green, colorWheel1.HsvColor.ToRgb().Blue, (int)faderTrack.Maximum);
            }
            /*
            colourSelectRed.Value = colorWheel1.HsvColor.ToRgb().Red;
            colourSelectGreen.Value = colorWheel1.HsvColor.ToRgb().Green;
            colourSelectBlue.Value = colorWheel1.HsvColor.ToRgb().Blue;
            //AlphaTxt.Text = AlphaTrackBar.Value;

            RedTrack.Value = colorWheel1.HsvColor.ToRgb().Red;
            GreenTrack.Value = colorWheel1.HsvColor.ToRgb().Green;
            BlueTrack.Value = colorWheel1.HsvColor.ToRgb().Blue;

            faderTrack.Value = colorWheel1.HsvColor.Value;

            UpdateHex();

            if (optAddjustTop.Checked)
            {
                try
                {
                    topRed.Value = Convert.ToByte(colourSelectRed.Value);
                    topGreen.Value = Convert.ToByte(colourSelectGreen.Value);
                    topBlue.Value = Convert.ToByte(colourSelectBlue.Value);

                    butSend_Click(null, null);
                }
                catch (Exception)
                {

                }
            }
            else if (optAddjustBottom.Checked)
            {
                try
                {
                    bottomRed.Value = Convert.ToByte(colourSelectRed.Value);
                    bottomGreen.Value = Convert.ToByte(colourSelectGreen.Value);
                    bottomBlue.Value = Convert.ToByte(colourSelectBlue.Value);

                    butSend_Click(null, null);
                }
                catch (Exception)
                {

                }
            }
            */
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[11];
            byte[] stepCount;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            data[0] = (byte)CommandNo.SSC_PWM_COLOUR_MODE;
            data[1] = Convert.ToByte(cmbColourMode.SelectedIndex);
            data[2] = Convert.ToByte(panelTopRGB.BackColor.R);
            data[3] = Convert.ToByte(panelTopRGB.BackColor.G);
            data[4] = Convert.ToByte(panelTopRGB.BackColor.B);
            data[5] = Convert.ToByte(panelBottomRGB.BackColor.R);
            data[6] = Convert.ToByte(panelBottomRGB.BackColor.G);
            data[7] = Convert.ToByte(panelBottomRGB.BackColor.B);
            data[8] = Convert.ToByte(ticksPerStep.Value);

            stepCount = BitConverter.GetBytes((int)noOfSteps.Value);
            data[9] = stepCount[0];
            data[10] = stepCount[1];


            server.SendTo(data, data.Length, SocketFlags.None, ipep);
        }

        bool colourUpdating = false;

        // Updates all controls with the supplied colour
        public void updateSetColour ( int red, int green, int blue, int faderVal )
        {
            if (!BroadcastUpdatingFlag)
            {
                PaintDotNet.HsvColor newHsv = new PaintDotNet.HsvColor();
                PaintDotNet.RgbColor newRgb = new PaintDotNet.RgbColor();

                // Set a global flag to inidcate to all controls we are updating there values so they 
                // dont fire try and update other controls in turn
                colourUpdating = true;

                lblColourSelectorRgb.Text = red.ToString() + "," + green.ToString() + "," + blue.ToString();

                RedTrack.Value = red;
                GreenTrack.Value = green;
                BlueTrack.Value = blue;

                faderTrack.Value = faderVal;


                newRgb.Red = red;
                newRgb.Green = green;
                newRgb.Blue = blue;

                newHsv = newRgb.ToHsv();
                newHsv.Value = faderTrack.Value;
                lblColourSelectorHsv.Text = newHsv.Hue.ToString() + "," + newHsv.Saturation.ToString() + "," + newHsv.Value.ToString();
                colorWheel1.HsvColor = newHsv;


                if (optAddjustTop.Checked)
                {
                    try
                    {
                        lblTopRGB.Text = red.ToString() + "," + green.ToString() + "," + blue.ToString();
                        panelTopRGB.BackColor = Color.FromArgb(red, green, blue);
                    }
                    catch (Exception)
                    {

                    }
                }
                else if (optAddjustBottom.Checked)
                {
                    try
                    {
                        lblBottomRGB.Text = red.ToString() + "," + green.ToString() + "," + blue.ToString();
                        panelBottomRGB.BackColor = Color.FromArgb(red, green, blue);

                    }
                    catch (Exception)
                    {

                    }
                }

                // Send the message if auto send is ticked
                if (chkAutoSend.Checked) butSend_Click(null, null);

                colourUpdating = false;
            }
        }
        
        private void faderTrack_ValueChanged(object sender, EventArgs e)
        {
            if (!colourUpdating)
            {
                PaintDotNet.HsvColor newHsv = new PaintDotNet.HsvColor();
                newHsv.Value = faderTrack.Value;
                newHsv.Hue = colorWheel1.HsvColor.Hue;
                newHsv.Saturation = colorWheel1.HsvColor.Saturation;

                updateSetColour(newHsv.ToRgb().Red, newHsv.ToRgb().Green, newHsv.ToRgb().Blue, faderTrack.Value);

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();

            coms.Ping(IPAddress.Parse(textBox1.Text));
         
            //coms.BroadcastPing();

            //byte[] data = new byte[6];
            //IPEndPoint ipep = new IPEndPoint(IPAddress.Broadcast, 11028);
            //UdpClient BcastClient = new UdpClient(AddressFamily.InterNetwork);

            //data[0] = 1;
            //data[1] = Convert.ToByte('H');
            //data[2] = Convert.ToByte('e');
            //data[3] = Convert.ToByte('l');
            //data[4] = Convert.ToByte('l');
            //data[5] = Convert.ToByte('o');

            //BcastClient.EnableBroadcast = true;
            //BcastClient.Send(data, data.Length, ipep);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            optAddjustTop.Checked = true;

            updateSetColour(panelTopRGB.BackColor.R, panelTopRGB.BackColor.G, panelTopRGB.BackColor.B, (int)faderTrack.Maximum);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            optAddjustBottom.Checked = true;
            updateSetColour(panelBottomRGB.BackColor.R, panelBottomRGB.BackColor.G, panelBottomRGB.BackColor.B, (int)faderTrack.Maximum);
        }

        private void ControlFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyParent.WindowState = FormWindowState.Normal;
        }

        enum COLOUR_MODES
        {
            OFF = 0,
            CYCLE,
            BOUNCE,
            STATIC,
            BOUNCE_RND
        };

        private void cmbColourMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ( cmbColourMode.SelectedIndex )
            {
                case (int)COLOUR_MODES.OFF :
                    ticksPerStep.Enabled = false;
                    noOfSteps.Enabled = false;
                    //butSelectTop.Enabled = false;
                    //butSelectBottom.Enabled = false;
                break;

                case (int)COLOUR_MODES.CYCLE :
                    ticksPerStep.Enabled = true;
                    noOfSteps.Enabled = true;

                    //butSelectTop.Enabled = false;
                    //butSelectBottom.Enabled = false;
                break;

                case (int)COLOUR_MODES.BOUNCE :
                    ticksPerStep.Enabled = true;
                    noOfSteps.Enabled = true;

                    //butSelectTop.Enabled = true;
                    //butSelectBottom.Enabled = true;
                break;

                case (int)COLOUR_MODES.STATIC :
                    ticksPerStep.Enabled = false;
                    noOfSteps.Enabled = false;

                    //butSelectTop.Enabled = true;
                    //butSelectBottom.Enabled = false;
                break;

                case (int)COLOUR_MODES.BOUNCE_RND :
                    ticksPerStep.Enabled = true;
                    noOfSteps.Enabled = true;

                    //butSelectTop.Enabled = false;
                    //butSelectBottom.Enabled = false;
                break;

                
            }

            if (chkAutoSend.Checked) butSend_Click(null, null);
        }


        private void BlueTrack_ValueChanged(object sender, EventArgs e)
        {
            if (!colourUpdating)
            {
                updateSetColour(RedTrack.Value, GreenTrack.Value, BlueTrack.Value, (int)faderTrack.Maximum);
            }
        }

        private void ticksPerStep_ValueChanged(object sender, EventArgs e)
        {
            if (chkAutoSend.Checked) butSend_Click(null, null);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panelTopRGB_Click(object sender, EventArgs e)
        {
            optAddjustTop.Checked = true;

            updateSetColour(panelTopRGB.BackColor.R, panelTopRGB.BackColor.G, panelTopRGB.BackColor.B, (int)faderTrack.Maximum);
        }

        private void panelBottomRGB_Click(object sender, EventArgs e)
        {
            optAddjustBottom.Checked = true;
            updateSetColour(panelBottomRGB.BackColor.R, panelBottomRGB.BackColor.G, panelBottomRGB.BackColor.B, (int)faderTrack.Maximum);
        }

        private void optAddjustBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (optAddjustTop.Checked)
            {
                butSelectBottom.Enabled = true;
                butSelectTop.Enabled = false;
                butSelectBottom.Text = "Select";
                butSelectTop.Text = "Selected";
                updateSetColour(panelTopRGB.BackColor.R, panelTopRGB.BackColor.G, panelTopRGB.BackColor.B, (int)faderTrack.Maximum);
            }
            else
            {
                butSelectBottom.Enabled = false;
                butSelectTop.Enabled = true;
                butSelectBottom.Text = "Selected";
                butSelectTop.Text = "Select";
                updateSetColour(panelBottomRGB.BackColor.R, panelBottomRGB.BackColor.G, panelBottomRGB.BackColor.B, (int)faderTrack.Maximum);
            }
        }

        private void butAutoRefresh_Click(object sender, EventArgs e)
        {
            if (tmrAutoRefresh.Enabled)
            {
                tmrAutoRefresh.Enabled = false;
                butAutoRefresh.Text = "Auto Refresh : Off";
            }
            else
            {
                tmrAutoRefresh.Enabled = true;
                butAutoRefresh.Text = "Auto Refresh : On";
            }
        }

        private void ControlFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrAutoRefresh.Enabled = false;
        }

        private void tmrAutoRefresh_Tick(object sender, EventArgs e)
        {
            button3_Click_1(null, null);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            byte[] data = new byte[3];

            if (BroadcastUpdatingFlag == false)
            {
                //if (listView1.SelectedItems.Count > 0)
                //{
                data[0] = 10;

                if (e.NewValue == CheckState.Checked)
                {
                    data[1] = Convert.ToByte(listRelays.Items[e.Index].Tag);
                }
                else
                {
                    data[1] = Convert.ToByte(0);
                }

                data[2] = Convert.ToByte(listRelays.Items[e.Index].Tag);

                SplashBaseComs coms = new SplashBaseComs();
                coms.Command(data, data.Length, IPAddress.Parse(textBox1.Text));
                //}
            }
        }

        private void renameRelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listRelays.SelectedItems.Count > 0)
            {
                listRelays.LabelEdit = true;
                listRelays.SelectedItems[0].BeginEdit();
                //listRelays.LabelEdit = false;
            }
        }

        private void listRelays_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if ((!e.CancelEdit) && ( e.Label != null))
            {
                // User has changed a Relay name

                byte[] data = new byte[14];

                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(textBox1.Text), REMOTE_PORT_NO);
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                //byte[] byteString = System.Text.Encoding.ASCII.GetBytes(listRelays.SelectedItems[0].Text);
                byte[] byteString = System.Text.Encoding.ASCII.GetBytes(e.Label);

                // Command no
                data[0] = (byte)CommandNo.SSC_SET_RELAY_NAME;

                // Relay no
                data[1] = (byte)(e.Item + 1);

                // Length of string
                if (byteString.Length > 10)
                {
                    data[2] = 10;
                }
                else
                {
                    data[2] = (byte)byteString.Length;
                }

                System.Buffer.BlockCopy(byteString, 0, data, 3, data[2]);

                server.SendTo(data, data.Length, SocketFlags.None, ipep);
            }
        }
    }
}
