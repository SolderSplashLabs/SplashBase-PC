using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SplashBaseControl
{
    public partial class GpioControlFrm : Form
    {
        SplashBaseControl MyParent;
        String MacAddr;
        String IpAddr;

        public GpioControlFrm()
        {
            InitializeComponent();
        }

        public void SetParent(SplashBaseControl callingObject)
        {
            MyParent = callingObject;
        }

        public void SetMacAndIp(string MAC, string Ip)
        {
            textBox1.Text = Ip;
            MacAddr = MAC;
            IpAddr = Ip;

            this.Text = "[SolderSplash LABS] GPIO Control - " + MAC;
        }

        private void EdtDirection_TextChanged(object sender, EventArgs e)
        {
            TextBox textboxEdited = (TextBox)sender;

            if ( Regex.IsMatch(textboxEdited.Text, "^0x(?:[0-9A-Fa-f]{4})+$") )
            {
                textboxEdited.BackColor = Color.White; 
            }
            else
            {
                textboxEdited.BackColor = Color.Red; 
            }

        }

        private void ButRefresh_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[1];
            SplashBaseComs coms = new SplashBaseComs();
              
            command[0] =  (byte)CommandNo.SSC_GET_ALL_GPIO;
           
            coms.Command(command, command.Length, IPAddress.Parse(textBox1.Text));

        }

        public void GpioTableRecvd(byte[] newGpioTableMsg)
        {
            int i;

            try 
            {
                if (newGpioTableMsg[0] == (byte)CommandNo.SSC_REPLY_ALL_GPIO)
                {
                    if (newGpioTableMsg.Length == 164)
                    {
                        listGpioList.BeginUpdate();
                        for (i=0; i<15; i++)
                        {
                            if ( listGpioList.Items.Count < (i+1) )
                            {
                                if (i > 6)
                                {
                                    listGpioList.Items.Add(" (" + i.ToString() + ") PORT " + (char)(0x41 + i) + " Ext");
                                }
                                else
                                {
                                    listGpioList.Items.Add(" (" + i.ToString() + ") PORT " + (char)(0x41 + i));
                                }
                                listGpioList.Items[i].SubItems.Add("");
                                listGpioList.Items[i].SubItems.Add("");
                                listGpioList.Items[i].SubItems.Add("");
                                listGpioList.Items[i].SubItems.Add("");
                                listGpioList.Items[i].SubItems.Add("");
                            }

                            listGpioList.Items[i].SubItems[1].Text = string.Format("0x{0:X4}", BitConverter.ToUInt16(newGpioTableMsg, 14 + (i * 10)));
                            listGpioList.Items[i].SubItems[2].Text = string.Format("0x{0:X4}", BitConverter.ToUInt16(newGpioTableMsg, 16 + (i * 10)));

                            listGpioList.Items[i].SubItems[3].Text = string.Format("0x{0:X4}", BitConverter.ToUInt16(newGpioTableMsg, 22 + (i * 10)));

                            listGpioList.Items[i].SubItems[4].Text = string.Format("0x{0:X4}", BitConverter.ToUInt16(newGpioTableMsg, 18 + (i * 10)));
                            listGpioList.Items[i].SubItems[5].Text = string.Format("0x{0:X4}", BitConverter.ToUInt16(newGpioTableMsg, 20 + (i * 10)));

                        }
                        listGpioList.EndUpdate();
                    }
                }
   	        }
	        catch (Exception)
	        {

	        }
        }

        private void GpioControlFrm_Load(object sender, EventArgs e)
        {
            int i = 0;

            for (i = 0; i < 15; i++)
            {
                if (listGpioList.Items.Count < (i + 1))
                {
                    if (i > 6)
                    {
                        listGpioList.Items.Add(" (" + i.ToString() + ") PORT " + (char)(0x41 + i) + " Ext");
                    }
                    else
                    {
                        listGpioList.Items.Add(" (" + i.ToString() + ") PORT " + (char)(0x41 + i));
                    }
                    listGpioList.Items[i].SubItems.Add("");
                    listGpioList.Items[i].SubItems.Add("");
                    listGpioList.Items[i].SubItems.Add("");
                    listGpioList.Items[i].SubItems.Add("");
                    listGpioList.Items[i].SubItems.Add("");
                }
            }
            ButRefresh_Click(null, null);
        }

        private void listRemotesFound_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listGpioList.SelectedItems.Count > 0)
            {
                grpSelectGpio.Text = "Modify GPIO Port : PORT " + (char)(0x41+listGpioList.SelectedItems[0].Index);
                EdtDirection.Text = listGpioList.SelectedItems[0].SubItems[1].Text;
                EdtPortPins.Text = listGpioList.SelectedItems[0].SubItems[2].Text;
                EdtInitDir.Text = listGpioList.SelectedItems[0].SubItems[4].Text;
                EdtInitPortPins.Text = listGpioList.SelectedItems[0].SubItems[5].Text;
                EdtSelectedPort.Text = listGpioList.SelectedItems[0].Index.ToString();

            }
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void ButApply_Click(object sender, EventArgs e)
        {
            UInt16 tempShort = 0;
            byte[] command = new byte[12];
            SplashBaseComs coms = new SplashBaseComs();

            try
            {
                command[0] = (byte)CommandNo.SSC_MANUAL_GPIO_CONF;
                command[1] = Convert.ToByte(EdtSelectedPort.Text);

                command[2] = 0;
                command[3] = 0;

                tempShort = Convert.ToUInt16(EdtDirection.Text, 16);
                Buffer.BlockCopy(BitConverter.GetBytes(tempShort), 0, command, 4, 2);

                tempShort = Convert.ToUInt16(EdtPortPins.Text, 16);
                Buffer.BlockCopy(BitConverter.GetBytes(tempShort), 0, command, 6, 2);
      
                coms.Command(command, command.Length, IPAddress.Parse(textBox1.Text));
            }
            catch (Exception)
            {

            }
        }

        private void ButApplyInitChange_Click(object sender, EventArgs e)
        {
            UInt16 tempShort = 0;
            byte[] command = new byte[12];
            SplashBaseComs coms = new SplashBaseComs();

            try
            {
                command[0] = (byte)CommandNo.SSC_INIT_GPIO_CONF;
                command[1] = Convert.ToByte(EdtSelectedPort.Text);

                command[2] = 0;
                command[3] = 0;

                tempShort = Convert.ToUInt16(EdtInitDir.Text, 16);
                Buffer.BlockCopy(BitConverter.GetBytes(tempShort), 0, command, 4, 2);

                tempShort = Convert.ToUInt16(EdtInitPortPins.Text, 16);
                Buffer.BlockCopy(BitConverter.GetBytes(tempShort), 0, command, 6, 2);

                coms.Command(command, command.Length, IPAddress.Parse(textBox1.Text));
            }
            catch (Exception)
            {

            }
        }

        private void ButGpioInitNow_Click(object sender, EventArgs e)
        {
            byte[] command = new byte[1];
            SplashBaseComs coms = new SplashBaseComs();

            command[0] = (byte)CommandNo.SSC_INIT_GPIO_RUN;

            coms.Command(command, command.Length, IPAddress.Parse(textBox1.Text));
        }

        private void GpioControlFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyParent.removeMeFromGpioFormList(MacAddr);
        }


    }
}
