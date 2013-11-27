using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Net;
using System.Net.Sockets;

namespace SplashBaseControl
{
    public partial class LogicControlFrm : Form
    {
        SplashBaseControl MyParent;

        string MacAddr;
        string IpAddr;

        const int LOGIC_COND_CNT = 24;
        const int LOGIC_ACT_CNT = 24;
        const int LOGIC_EVENT_CNT = 24;

        enum LOGIC_CONDITION_TYPE
        {
            L_EVENT_INVALID = 0,

            L_EVENT_GPIO_RAISING,
            L_EVENT_GPIO_FALLING,
            L_EVENT_GPIO_HIGH,
            L_EVENT_GPIO_LOW,

            L_EVENT_ADC_ABOVE,
            L_EVENT_ADC_BELOW,
            L_EVENT_ADC_BETWEEN,

            L_EVENT_REG_EQUAL,
            L_EVENT_REG_ABOVE,
            L_EVENT_REG_BELOW,

            L_EVENT_DATE_AFTER,
            L_EVENT_DATE_BEFORE,
            L_EVENT_DATE_BETWEEN,
            L_EVENT_TIME_AFTER,
            L_EVENT_TIME_BEFORE,
            L_EVENT_TIME_BETWEEN,

            L_EVENT_NET_DISCONNECT,
            L_EVENT_NET_CONNECT,

            L_EVENT_BOOT,
            L_EVENT_EVERY_TICK,

            L_EVENT_TEMP_ABOVE,
            L_EVENT_TEMP_BELOW,

            L_EVENT_MAX
        };

        enum LOGIC_ACTION_TYPE
        {
            L_ACTION_INVALID = 0,
            L_ACTION_GPIO_SET,
            L_ACTION_PWM_DUTY,
            L_ACTION_INCREMENT_REG,
            L_ACTION_DECREMENT_REG,
            L_ACTION_CLEAR_REG,
            L_ACTION_SET_REG,
            L_ACTION_NET_MSG,
            L_ACTION_CONTROL_RELAY,
            L_ACTION_RGB,
            L_ACTION_SERIAL_MSG,
            L_ACTION_SERVO_POS,
            L_ACTION_SEND_COSM,
            L_ACTION_MAX
        };

        public readonly string[] LOGIC_CONDITION_NAMES = 
        { 
            "None",
		    "GPIO Rising Edge",
		    "GPIO Falling Edge",
            "GPIO High",
		    "GPIO Low",

		    "ADC Above",
		    "ADC Below",
            "ADC Between",

            "Register Equal",
		    "Register Above",
		    "Register Below",

            "Date After",
		    "Date Before",
            "Date Between",
            "Time After",
		    "Time Before",
            "Time Between",
	
		    "Ethernet Disconnected",
		    "Ethernet Connected",
            "On Boot",
            "Every Tick (10ms)",

		    "Board Temperature Above",
		    "Board Temperature Below",
        };

        public readonly string[] LOGIC_ACTION_NAMES = 
        {
            "None",
            "GPIO Set",
		    "PWM Duty",
		    "Increment REG",
		    "Decrement REG",
		    "Clear REG",
		    "Set REG",
		    "NET MSG",
		    "Control Relay"/*,
            "RGB",
            "SERIAL MSG",
		    "Move Servo",
		    "SEND COSM"*/
        };

        public void ActionTableRecvd(byte[] actionTable)
        {
            for (int i = 0; (i < LOGIC_ACT_CNT); i++)
            {
                if (actionTable[14 + i] < (byte)LOGIC_ACTION_TYPE.L_ACTION_MAX)
                {
                    ActionListView.Items[i].SubItems[1].Text = LOGIC_ACTION_NAMES[actionTable[14 + i]];
                    ActionListView.Items[i].SubItems[4].Text = actionTable[14 + i].ToString();
                }
                else
                {
                    ActionListView.Items[i].SubItems[1].Text = LOGIC_ACTION_NAMES[0];
                    ActionListView.Items[i].SubItems[4].Text = "0";
                }

                ActionListView.Items[i].SubItems[2].Text = BitConverter.ToUInt32( actionTable, (38 + (i*4)) ).ToString();
                ActionListView.Items[i].SubItems[3].Text = BitConverter.ToUInt32( actionTable, (134 + (i*4)) ).ToString();
            }
        }

        public void ConditionTableRecvd(byte[] conditionTable)
        {
            for (int i = 0; (i < LOGIC_COND_CNT); i++)
            {
                if (conditionTable[14 + i] < (byte)LOGIC_CONDITION_TYPE.L_EVENT_MAX)
                {
                    ConditionListView.Items[i].SubItems[1].Text = LOGIC_CONDITION_NAMES[conditionTable[14 + i]];
                    ConditionListView.Items[i].SubItems[4].Text = conditionTable[14 + i].ToString();
                }
                else
                {
                    ConditionListView.Items[i].SubItems[1].Text = LOGIC_CONDITION_NAMES[0];
                    ConditionListView.Items[i].SubItems[4].Text = "0";
                }

                ConditionListView.Items[i].SubItems[2].Text = BitConverter.ToUInt32(conditionTable, (38 + (i * 4))).ToString();
                ConditionListView.Items[i].SubItems[3].Text = BitConverter.ToUInt32(conditionTable, (134 + (i * 4))).ToString();
            }
        }

        public void EventTableRecvd(byte[] eventTable)
        {
            for (int i = 0; (i < LOGIC_COND_CNT); i++)
            {
                if (eventTable[14 + i] < LOGIC_COND_CNT)
                {
                    ListEvents.Items[i].SubItems[1].Text = ConditionListView.Items[eventTable[14 + i]].SubItems[1].Text;
                    ListEvents.Items[i].SubItems[4].Text = eventTable[14 + i].ToString();
                }
                else
                {
                    ListEvents.Items[i].SubItems[1].Text = "None";
                    ListEvents.Items[i].SubItems[4].Text = "255";
                }

                if (eventTable[38 + i] < (byte)LOGIC_CONDITION_TYPE.L_EVENT_MAX)
                {
                    ListEvents.Items[i].SubItems[2].Text = ConditionListView.Items[eventTable[38 + i]].SubItems[1].Text;
                    ListEvents.Items[i].SubItems[5].Text = eventTable[38 + i].ToString();
                }
                else
                {
                    ListEvents.Items[i].SubItems[2].Text = "None";
                    ListEvents.Items[i].SubItems[5].Text = "255";
                }

                ListEvents.Items[i].SubItems[3].Text = BitConverter.ToUInt32(eventTable, (62 + (i * 4))).ToString();
            }
        }

        public LogicControlFrm()
        {
            InitializeComponent();
            RefreshActionListview();
            RefreshConditionListview();
            RefreshLogicListview();
        }

        public void SetParent(SplashBaseControl callingObject)
        {
            MyParent = callingObject;
        }

        public void RefreshLogicListview()
        {
            int i = 0;

            for (i = 0; (i < LOGIC_EVENT_CNT); i++)
            {
                if (ListEvents.Items.Count < (i + 1))
                {
                    ListEvents.Items.Add(i.ToString());

                    ListEvents.Items[i].SubItems.Add("");
                    ListEvents.Items[i].SubItems.Add("");
                    ListEvents.Items[i].SubItems.Add("");
                    ListEvents.Items[i].SubItems.Add("");
                    ListEvents.Items[i].SubItems.Add("");
                }
                ListEvents.Items[i].Text = i.ToString();
                ListEvents.Items[i].SubItems[1].Text = LOGIC_CONDITION_NAMES[0];
                ListEvents.Items[i].SubItems[2].Text = LOGIC_CONDITION_NAMES[0];
                ListEvents.Items[i].SubItems[3].Text = "0x00000000";

                // Condition1 Idx
                ListEvents.Items[i].SubItems[4].Text = "0";

                // Condition2 Idx
                ListEvents.Items[i].SubItems[5].Text = "0";

                // Temp - remove
                //ActionListView.Items[i].SubItems[2].Text = i.ToString();
                //ActionListView.Items[i].SubItems[3].Text = (i * 2).ToString();
                //ActionListView.Items[i].SubItems[4].Text = i.ToString();

                if (i >= (int)LOGIC_ACTION_TYPE.L_ACTION_MAX)
                {

                }
                else
                {
                    ActionListView.Items[i].SubItems[1].Text = LOGIC_ACTION_NAMES[0];
                }
            }
        }

        public void RefreshActionListview()
        {
            int i = 0;

            for (i = 0; (i < LOGIC_ACT_CNT); i++)
            {
                if (ActionListView.Items.Count < (i + 1))
                {
                    ActionListView.Items.Add(i.ToString());

                    ActionListView.Items[i].SubItems.Add("");
                    ActionListView.Items[i].SubItems.Add("");
                    ActionListView.Items[i].SubItems.Add("");
                    ActionListView.Items[i].SubItems.Add("");
                }
                ActionListView.Items[i].Text = i.ToString();
                ActionListView.Items[i].SubItems[1].Text = LOGIC_ACTION_NAMES[0];
                ActionListView.Items[i].SubItems[2].Text = "0x00000000";
                ActionListView.Items[i].SubItems[3].Text = "0x00000000";

                ActionListView.Items[i].SubItems[4].Text = "0";

                // Temp - remove
                //ActionListView.Items[i].SubItems[2].Text = i.ToString();
                //ActionListView.Items[i].SubItems[3].Text = (i * 2).ToString();
                //ActionListView.Items[i].SubItems[4].Text = i.ToString();

                if (i >= (int)LOGIC_ACTION_TYPE.L_ACTION_MAX)
                {

                }
                else
                {
                    ActionListView.Items[i].SubItems[1].Text = LOGIC_ACTION_NAMES[0];
                }
            }
        }

        public void RefreshConditionListview()
        {
            int i = 0;

            for (i = 0; (i < LOGIC_ACT_CNT); i++)
            {
                if (ConditionListView.Items.Count < (i + 1))
                {
                    ConditionListView.Items.Add(i.ToString());

                    ConditionListView.Items[i].SubItems.Add("");
                    ConditionListView.Items[i].SubItems.Add("");
                    ConditionListView.Items[i].SubItems.Add("");
                    ConditionListView.Items[i].SubItems.Add("");
                }

                ConditionListView.Items[i].Text = i.ToString();
                ConditionListView.Items[i].SubItems[1].Text = LOGIC_CONDITION_NAMES[0];
                ConditionListView.Items[i].SubItems[2].Text = "0x00000000";
                ConditionListView.Items[i].SubItems[3].Text = "0x00000000";
                ConditionListView.Items[i].SubItems[4].Text = "0";

                // temp - remove
                //ConditionListView.Items[i].SubItems[2].Text = i.ToString();
                //ConditionListView.Items[i].SubItems[3].Text = (i * 2).ToString();
                //ConditionListView.Items[i].SubItems[4].Text = i.ToString();

                if (i >= (int)LOGIC_CONDITION_TYPE.L_EVENT_MAX)
                {

                }
                else
                {
                    ConditionListView.Items[i].SubItems[1].Text = LOGIC_CONDITION_NAMES[0];
                }
            }
        }

        public void SetMacAndIp(string MAC, string Ip)
        {
            textBox1.Text = Ip;
            MacAddr = MAC;
            IpAddr = Ip;

            this.Text = "[SolderSplash LABS] Logic Control - " + MAC;
        }

        private void LogicControlFrm_Load(object sender, EventArgs e)
        {
            tabConditions.Size = new Size(242, 110);
            TabActions.SelectedTab = TabActionNo;
            tabConditions.SelectedTab = TabNoParams;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConditionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (ConditionListView.SelectedIndices.Count > 1)
            {
                EdtSelectedConditions.Text = "[" + ConditionListView.SelectedItems[0].Text + "] " + ConditionListView.SelectedItems[0].SubItems[1].Text + " & " + "[" + ConditionListView.SelectedItems[1].Text + "] " + ConditionListView.SelectedItems[1].SubItems[1].Text;
            }
            else if (ConditionListView.SelectedIndices.Count > 0)
            {
                EdtSelectedConditions.Text = "[" + ConditionListView.SelectedItems[0].Text + "] " + ConditionListView.SelectedItems[0].SubItems[1].Text;
            }
            */

            if (ConditionListView.SelectedItems.Count > 0)
            {
                try
                {
                    LblCondIdx.Text = ConditionListView.SelectedItems[0].Text;
                    LblCondNo.Text = ConditionListView.SelectedItems[0].SubItems[4].Text;

                    if (Convert.ToByte(LblCondNo.Text) > (byte)LOGIC_CONDITION_TYPE.L_EVENT_MAX)
                    {
                        LblCondNo.Text = LOGIC_CONDITION_TYPE.L_EVENT_INVALID.ToString();
                    }

                    //CmbConditionList.SelectedIndex = CmbConditionList.FindStringExact(LOGIC_CONDITION_NAMES[Convert.ToInt32(ConditionListView.SelectedItems[0].SubItems[4].Text.ToString())]);
                    UpDownCondParam1.Value = Convert.ToUInt32(ConditionListView.SelectedItems[0].SubItems[2].Text);
                    UpDownCondParam2.Value = Convert.ToUInt32(ConditionListView.SelectedItems[0].SubItems[3].Text);
                    CmbConditionList.SelectedIndex = CmbConditionList.FindStringExact(LOGIC_CONDITION_NAMES[Convert.ToInt32(ConditionListView.SelectedItems[0].SubItems[4].Text.ToString())]);
                    UpdateConditionEditor();
                }
                catch (Exception)
                {
                    UpDownCondParam1.Value = 0;
                    UpDownCondParam2.Value = 0;
                    UpdateConditionEditor();
                }
            }
        }

        private void ActionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;

            //for (i = 0; i < ActionListView.SelectedItems.Count; i++)
            //{
            //    EdtSelectedActions.Text = EdtSelectedActions.Text + "[" + ActionListView.SelectedItems[i].Text + "] " + ActionListView.SelectedItems[i].SubItems[1].Text + " ";
            //}

            if (ActionListView.SelectedItems.Count > 0)
            {
                LblActionIdx.Text = ActionListView.SelectedItems[0].Text;
                LblActionNo.Text = ActionListView.SelectedItems[0].SubItems[4].Text;

                try
                {
                    if (Convert.ToByte(LblActionNo.Text) > (byte)LOGIC_ACTION_TYPE.L_ACTION_MAX)
                    {
                        LblActionNo.Text = LOGIC_ACTION_TYPE.L_ACTION_INVALID.ToString();
                    }

                    UpDownActParam1.Value = Convert.ToUInt32(ActionListView.SelectedItems[0].SubItems[2].Text);
                    UpDownActParam2.Value = Convert.ToUInt32(ActionListView.SelectedItems[0].SubItems[3].Text);
                    CmbAction.SelectedIndex = CmbAction.FindStringExact(LOGIC_ACTION_NAMES[Convert.ToUInt32(ActionListView.SelectedItems[0].SubItems[4].Text)]);
                    UpdateActionEditor();
                }
                catch (Exception)
                {
                    CmbAction.SelectedIndex = 0;
                    ActionListView.SelectedItems[0].SubItems[2].Text = "0";
                    ActionListView.SelectedItems[0].SubItems[3].Text = "0";
                    UpDownActParam1.Value = 0;
                    UpDownActParam2.Value = 0;
                    UpdateActionEditor();
                }
            }
        }

        private void ButUpdateAction_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[11];
            
            switch ((LOGIC_ACTION_TYPE)CmbAction.SelectedIndex)
            {
                case LOGIC_ACTION_TYPE.L_ACTION_GPIO_SET :
                    UpDownActParam1.Value = ActionGpioPort.SelectedIndex;
                    UpDownActParam2.Value = ((UInt32)ActionGpioMask.Value << 16) | (UInt32)ActionGpioValue.Value;
                break;

                case LOGIC_ACTION_TYPE.L_ACTION_DECREMENT_REG:
                case LOGIC_ACTION_TYPE.L_ACTION_INCREMENT_REG:
                case LOGIC_ACTION_TYPE.L_ACTION_CLEAR_REG:
                case LOGIC_ACTION_TYPE.L_ACTION_SET_REG:
                    UpDownActParam1.Value = ActionRegNo.Value;
                    UpDownActParam2.Value = ActionRegVal.Value;
                break;

                case LOGIC_ACTION_TYPE.L_ACTION_NET_MSG :
                    UpDownActParam1.Value = 0xFFFFFFFF;
                    UpDownActParam2.Value = 0;
                break;

                case LOGIC_ACTION_TYPE.L_ACTION_CONTROL_RELAY :
                    UpDownActParam2.Value = 0;
                    if (ActionRelayMask1.Checked) UpDownActParam2.Value += 1;
                    if (ActionRelayMask2.Checked) UpDownActParam2.Value += 2;
                    if (ActionRelayMask3.Checked) UpDownActParam2.Value += 4;
                    if (ActionRelayMask4.Checked) UpDownActParam2.Value += 8;

                    UpDownActParam1.Value = 0;
                    if (ActionRelay1.Checked) UpDownActParam1.Value += 1;
                    if (ActionRelay2.Checked) UpDownActParam1.Value += 2;
                    if (ActionRelay3.Checked) UpDownActParam1.Value += 4;
                    if (ActionRelay4.Checked) UpDownActParam1.Value += 8;
                break;
            }

            try
            {
                dataBytes[0] = (byte)CommandNo.SSC_LOGIC_EDT_ACT;

                // Indx and Command No
                dataBytes[1] = (byte)Convert.ToByte(LblActionIdx.Text, 10);
                dataBytes[2] = (byte)Convert.ToByte(LblActionNo.Text, 10);

                // 2 Parameters ui32
                Buffer.BlockCopy(BitConverter.GetBytes((UInt32)UpDownActParam1.Value), 0, dataBytes, 3, 4);
                Buffer.BlockCopy(BitConverter.GetBytes((UInt32)UpDownActParam2.Value), 0, dataBytes, 7, 4);

                coms.Command(dataBytes, dataBytes.Length, IPAddress.Parse(textBox1.Text));

                ActionListView.Items[Convert.ToInt32(LblActionIdx.Text)].SubItems[1].Text = LOGIC_ACTION_NAMES[Convert.ToInt32(LblActionNo.Text)];
                ActionListView.Items[Convert.ToInt32(LblActionIdx.Text)].SubItems[2].Text = UpDownActParam1.Value.ToString();
                ActionListView.Items[Convert.ToInt32(LblActionIdx.Text)].SubItems[3].Text = UpDownActParam2.Value.ToString();
                ActionListView.Items[Convert.ToInt32(LblActionIdx.Text)].SubItems[4].Text = LblActionNo.Text;
            }
            catch (Exception)
            {

            }
        }

        private void UpdateActionEditor()
        {
            LblActionNo.Text = CmbAction.SelectedIndex.ToString();
            switch ((LOGIC_ACTION_TYPE)CmbAction.SelectedIndex)
            {
                case LOGIC_ACTION_TYPE.L_ACTION_GPIO_SET:

                    TabActions.SelectedTab = TabActionGpio;
          
                    try
                    {
                        ActionGpioPort.SelectedIndex = (int)UpDownActParam1.Value;
                        ActionGpioMask.Value = 0xffff & ((UInt32)(UpDownActParam2.Value) >> 16);
                        ActionGpioValue.Value = 0xffff & (UInt32)UpDownActParam2.Value;
                    }
                    catch (Exception)
                    {

                    }

                    TabActions.Show();
       
                    break;

                case LOGIC_ACTION_TYPE.L_ACTION_DECREMENT_REG :
                case LOGIC_ACTION_TYPE.L_ACTION_INCREMENT_REG :
                case LOGIC_ACTION_TYPE.L_ACTION_CLEAR_REG :
                case LOGIC_ACTION_TYPE.L_ACTION_SET_REG :

                    TabActions.SelectedTab = TabActionRegister;
                    try
                    {
                        ActionRegNo.Value = (int)UpDownActParam1.Value;
                        ActionRegVal.Value = (int)UpDownActParam2.Value;
                    }
                    catch (Exception)
                    {

                    }

                break;

                case LOGIC_ACTION_TYPE.L_ACTION_CONTROL_RELAY :
                    TabActions.SelectedTab = ActionTabRelay;
                    try
                    {
                        if (((UInt32)UpDownActParam2.Value & 0x01) == 0x01) ActionRelayMask1.Checked = true; else ActionRelayMask1.Checked = false;
                        if (((UInt32)UpDownActParam2.Value & 0x02) == 0x02) ActionRelayMask2.Checked = true; else ActionRelayMask2.Checked = false;
                        if (((UInt32)UpDownActParam2.Value & 0x04) == 0x04) ActionRelayMask3.Checked = true; else ActionRelayMask3.Checked = false;
                        if (((UInt32)UpDownActParam2.Value & 0x08) == 0x08) ActionRelayMask4.Checked = true; else ActionRelayMask4.Checked = false;

                        if (((UInt32)UpDownActParam1.Value & 0x01) == 0x01) ActionRelay1.Checked = true; else ActionRelay1.Checked = false;
                        if (((UInt32)UpDownActParam1.Value & 0x02) == 0x02) ActionRelay2.Checked = true; else ActionRelay2.Checked = false;
                        if (((UInt32)UpDownActParam1.Value & 0x04) == 0x04) ActionRelay3.Checked = true; else ActionRelay3.Checked = false;
                        if (((UInt32)UpDownActParam1.Value & 0x08) == 0x08) ActionRelay4.Checked = true; else ActionRelay4.Checked = false;
                    }
                    catch (Exception)
                    {

                    }

                break;

                default:

                    TabActions.SelectedTab = TabActionNo;
                    //tabConditions.Hide();
                    break;
            }
        }

        private void CmbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblActionNo.Text = CmbAction.SelectedIndex.ToString();
            UpdateActionEditor();
        }


        UInt32 EncodePrimaryTime(DateTime SelectedDateTime)
        {
            UInt32 day = 0;
            UInt32 hours = 0;
            UInt32 mins = 0;
            UInt32 result = 0;

            if (TimeDaySun.Checked) day += 1;
            if (TimeDayMon.Checked) day += 2;
            if (TimeDayTue.Checked) day += 4;
            if (TimeDayWed.Checked) day += 8;
            if (TimeDayThur.Checked) day += 16;
            if (TimeDayFri.Checked) day += 32;
            if (TimeDaySat.Checked) day += 64;

            hours = (UInt32)SelectedDateTime.Hour;
            mins = (UInt32)SelectedDateTime.Minute;

            result = (day << 24);
            result |= (hours << 16);
            result |= (mins << 8);

            return (result);
        }

        DateTime DecodeTime(UInt32 TimeValue)
        {
            int day = 0;
            int hours = 0;
            int mins = 0;
            DateTime result;

            day = (int)(0x000000FF & (TimeValue >> 24));
            hours = (int)(0x000000FF & (TimeValue >> 16));
            mins = (int)(0x000000FF & (TimeValue >> 8));

            if ((day & 0x01) == 0x01) TimeDaySun.Checked = true; else TimeDaySun.Checked = false;
            if ((day & 0x02) == 0x02) TimeDayMon.Checked = true; else TimeDayMon.Checked = false;
            if ((day & 0x04) == 0x04) TimeDayTue.Checked = true; else TimeDayTue.Checked = false;
            if ((day & 0x08) == 0x08) TimeDayWed.Checked = true; else TimeDayWed.Checked = false;
            if ((day & 0x10) == 0x10) TimeDayThur.Checked = true; else TimeDayThur.Checked = false;
            if ((day & 0x20) == 0x20) TimeDayFri.Checked = true; else TimeDayFri.Checked = false;
            if ((day & 0x40) == 0x40) TimeDaySat.Checked = true; else TimeDaySat.Checked = false;

            result = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, mins, 0);

            return (result);
        }

        private void ButUpdateCondition_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[11];

            // First take the user input from the correct tab
            // and put it into the value box ready to be used

            switch ((LOGIC_CONDITION_TYPE)CmbConditionList.SelectedIndex)
            {
                case LOGIC_CONDITION_TYPE.L_EVENT_GPIO_RAISING:
                case LOGIC_CONDITION_TYPE.L_EVENT_GPIO_FALLING:
                case LOGIC_CONDITION_TYPE.L_EVENT_GPIO_HIGH:
                case LOGIC_CONDITION_TYPE.L_EVENT_GPIO_LOW:
                    UpDownCondParam2.Value = CondGpioMask.Value;
                    UpDownCondParam1.Value = CondGpioPort.SelectedIndex;
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_DATE_AFTER:
                case LOGIC_CONDITION_TYPE.L_EVENT_DATE_BEFORE:
                    DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
                    TimeSpan span = (CondDate.Value - epoch);
                    UpDownCondParam1.Value = (decimal)((int)span.TotalSeconds);
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_DATE_BETWEEN:

                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_TIME_AFTER:
                case LOGIC_CONDITION_TYPE.L_EVENT_TIME_BEFORE:
                    UpDownCondParam1.Value = EncodePrimaryTime(CondTime.Value);
                    UpDownCondParam2.Value = 0;
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_TIME_BETWEEN:
                    UpDownCondParam1.Value = EncodePrimaryTime(CondTime.Value);
                    // Todo : need second set of controls
                    UpDownCondParam2.Value = EncodePrimaryTime(CondTime.Value);
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_ADC_ABOVE:
                case LOGIC_CONDITION_TYPE.L_EVENT_ADC_BELOW:
                    UpDownCondParam1.Value = CondAdcPort.SelectedIndex;
                    UpDownCondParam2.Value = CondAdcMask.Value;
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_REG_ABOVE:
                case LOGIC_CONDITION_TYPE.L_EVENT_REG_EQUAL:
                case LOGIC_CONDITION_TYPE.L_EVENT_REG_BELOW:
                    UpDownCondParam1.Value = CondRegNo.Value;
                    UpDownCondParam2.Value = CondRegVal.Value;
                break;

                default:
                    UpDownCondParam1.Value = 0;
                    UpDownCondParam2.Value = 0;
                break;
            }

            try
            {
                dataBytes[0] = (byte)CommandNo.SSC_LOGIC_EDT_COND;

                // Indx and Command No
                dataBytes[1] = (byte)Convert.ToByte(LblCondIdx.Text, 10);
                dataBytes[2] = (byte)Convert.ToByte(LblCondNo.Text, 10);

                // 2 Parameters ui32
                Buffer.BlockCopy(BitConverter.GetBytes((UInt32)UpDownCondParam1.Value), 0, dataBytes, 3, 4);
                Buffer.BlockCopy(BitConverter.GetBytes((UInt32)UpDownCondParam2.Value), 0, dataBytes, 7, 4);

                coms.Command(dataBytes, dataBytes.Length, IPAddress.Parse(textBox1.Text));

                ConditionListView.Items[ Convert.ToInt32(LblCondIdx.Text) ].SubItems[1].Text = LOGIC_CONDITION_NAMES[Convert.ToInt32(LblCondNo.Text)];
                ConditionListView.Items[ Convert.ToInt32(LblCondIdx.Text) ].SubItems[2].Text = UpDownCondParam1.Value.ToString();
                ConditionListView.Items[ Convert.ToInt32(LblCondIdx.Text) ].SubItems[3].Text = UpDownCondParam2.Value.ToString();
                ConditionListView.Items[ Convert.ToInt32(LblCondIdx.Text) ].SubItems[4].Text = LblCondNo.Text;
            }
            catch (Exception)
            {

            }
        }

        private void UpdateConditionEditor ()
        {
            LblCondNo.Text = CmbConditionList.SelectedIndex.ToString();
            switch ((LOGIC_CONDITION_TYPE)CmbConditionList.SelectedIndex)
            {
                case LOGIC_CONDITION_TYPE.L_EVENT_GPIO_RAISING:
                case LOGIC_CONDITION_TYPE.L_EVENT_GPIO_FALLING:
                case LOGIC_CONDITION_TYPE.L_EVENT_GPIO_LOW:
                case LOGIC_CONDITION_TYPE.L_EVENT_GPIO_HIGH:
                    tabConditions.SelectedTab = GpioTab;

                    try
                    {
                        CondGpioMask.Value = (int)UpDownCondParam2.Value;
                        CondGpioPort.SelectedIndex = (int)UpDownCondParam1.Value;
                    }
                    catch (Exception)
                    {

                    }

                    tabConditions.Show();
                    CmbConditionList.Focus();
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_DATE_AFTER :
                case LOGIC_CONDITION_TYPE.L_EVENT_DATE_BEFORE:
                    tabConditions.SelectedTab = DateTab;

                    try
                    {
                        DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
                        CondDate.Value = epoch.AddSeconds((int)UpDownCondParam1.Value);
                    }
                    catch (Exception)
                    {
                        CondDate.Value = DateTime.Now;
                    }

                    tabConditions.Show();
                    CmbConditionList.Focus();
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_TIME_AFTER :
                case LOGIC_CONDITION_TYPE.L_EVENT_TIME_BEFORE :
                    tabConditions.SelectedTab = TabTime;
                    CondTime.Value = DecodeTime((UInt32)UpDownCondParam1.Value);
                    tabConditions.Show();
                    CmbConditionList.Focus();
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_ADC_ABOVE :
                case LOGIC_CONDITION_TYPE.L_EVENT_ADC_BELOW :
                    tabConditions.SelectedTab = AdcTab;
                    tabConditions.Show();
                    CmbConditionList.Focus();
                    try
                    {
                        CondAdcPort.SelectedIndex = (int)UpDownCondParam1.Value;
                    }
                    catch (Exception)
                    {
                        CondAdcPort.SelectedIndex = 0;
                    }
        
                    CondAdcMask.Value = (int)UpDownCondParam2.Value;
                break;

                case LOGIC_CONDITION_TYPE.L_EVENT_REG_ABOVE :
                case LOGIC_CONDITION_TYPE.L_EVENT_REG_EQUAL:
                case LOGIC_CONDITION_TYPE.L_EVENT_REG_BELOW:
                    tabConditions.SelectedTab = TabRegister;
                    tabConditions.Show();
                    CmbConditionList.Focus();

                    try
                    {
                        CondRegNo.Value = (int)UpDownCondParam1.Value;
                    }
                    catch (Exception)
                    {
                        CondRegNo.Value = 0;
                    }
                    CondRegVal.Value = (int)UpDownCondParam2.Value;
                break;

                default:
                    tabConditions.SelectedTab = TabNoParams;
                    //tabConditions.Hide();
                break;
            }
        }

        private void CmbConditionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblCondNo.Text = CmbConditionList.SelectedIndex.ToString();
            UpdateConditionEditor();
            
        }

        private void ConditionListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int checkedCnt = 0;
            int cond1 = 0;
            int cond2 = 0;

            for (int i = 0; i < ConditionListView.Items.Count; i++)
            {
                if (ConditionListView.Items[i].Checked)
                {
                    checkedCnt++;
                    ButUpdateLogic.Enabled = true;
                }
            }

            if (checkedCnt > 2)
            {
                e.Item.Checked = false;
            }

            // TODO : this is a bit wastefull
            if (checkedCnt > 0)
            {
                checkedCnt = 0;
                for (int i = 0; i < ConditionListView.Items.Count; i++)
                {
                    if (ConditionListView.Items[i].Checked)
                    {
                        if (checkedCnt == 0)
                        {
                            cond1 = i;
                            EdtIfConditions.Text = "[" + cond1 + "] " + ConditionListView.Items[cond1].SubItems[1].Text;
                            EdtAndConditions.Text = "";
                        }
                        else if (checkedCnt == 1)
                        {
                            cond2 = i;
                            EdtAndConditions.Text = "[" + cond2 + "] " + ConditionListView.Items[cond2].SubItems[1].Text;
                        }

                        checkedCnt++;
                    }
                }
            }
            else
            {
                EdtIfConditions.Text = "None";
                EdtAndConditions.Text = "None";
                //ButUpdateLogic.Enabled = false;
            }

        }

        void ClearSelectedActionsConditions()
        {
            for (int i = 0; i < ConditionListView.Items.Count; i++)
            {
                ConditionListView.Items[i].Checked = false;
                ActionListView.Items[i].Checked = false;
            }
        }

        private void ButClearLogicStatement_Click(object sender, EventArgs e)
        {
            ClearSelectedActionsConditions();
            ListEvents.SelectedIndices.Clear();
        }


        private void ActionListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            EdtSelectedActions.Text = "";
            EdtExecuteActions.Text = "";
            for (int i = 0; i < ActionListView.Items.Count; i++)
            {
                if (ActionListView.Items[i].Checked)
                {
                    EdtExecuteActions.Text = EdtExecuteActions.Text + i.ToString() + ", ";
                    if (Convert.ToByte(ActionListView.Items[i].SubItems[4].Text, 10) < (byte)LOGIC_ACTION_TYPE.L_ACTION_MAX)
                    {
                        EdtSelectedActions.Text = EdtSelectedActions.Text + "[" + ActionListView.Items[i].Index + "] " + ActionListView.Items[i].SubItems[1].Text + "\r\n";
                    }
                }
            }
        }

        private void readLogicListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[1];

            try
            {
                dataBytes[0] = (byte)CommandNo.SSC_LOGIC_READ_EVENTS;
                coms.Command(dataBytes, dataBytes.Length, IPAddress.Parse(textBox1.Text));
            }
            catch (Exception)
            {

            }
        }

        private void readConiditionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[1];

            try
            {
                dataBytes[0] = (byte)CommandNo.SSC_LOGIC_READ_CONDTION;
                coms.Command(dataBytes, dataBytes.Length, IPAddress.Parse(textBox1.Text));
            }
            catch (Exception)
            {

            }
        }

        private void readActionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[1];

            try
            {
                dataBytes[0] = (byte)CommandNo.SSC_LOGIC_READ_ACTION;
                coms.Command(dataBytes, dataBytes.Length, IPAddress.Parse(textBox1.Text));
            }
            catch (Exception)
            {

            }
        }

        void SelectLogicStatementChange()
        {
            int condIndx = 0;
            UInt32 actions = 0;

            if (ListEvents.SelectedItems.Count > 0)
            {
                LblLogicIndx.Text = ListEvents.SelectedIndices[0].ToString();
                ClearSelectedActionsConditions();
                Application.DoEvents();

                // Grab the 2 conditions and check them
                condIndx = Convert.ToInt32(ListEvents.SelectedItems[0].SubItems[4].Text);
                if (condIndx < LOGIC_COND_CNT)
                {
                    ConditionListView.Items[condIndx].Checked = true;
                }

                condIndx = Convert.ToInt32(ListEvents.SelectedItems[0].SubItems[5].Text);
                if (condIndx < LOGIC_COND_CNT)
                {
                    ConditionListView.Items[condIndx].Checked = true;
                }

                // Select all of the actions as well
                try
                {
                    actions = Convert.ToUInt32(ListEvents.SelectedItems[0].SubItems[3].Text);
                    for (int i = 0; i < 24; i++)
                    {
                        // TODO : must be a better way to bit check
                        if ((actions & (1 << i)) == (1 << i))
                        {
                            ActionListView.Items[i].Checked = true;
                        }
                        else
                        {
                            // Already cleared above
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                LblLogicIndx.Text = "None Selected";
            }
        }

        private void ListLogic_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectLogicStatementChange();
        }

        private void ButUpdateLogic_Click(object sender, EventArgs e)
        {
            int logicIndx = 0;
            int checkedCnt = 0;
            UInt32 ActionMask = 0;
            byte[] dataBytes = new byte[9];
            SplashBaseComs coms = new SplashBaseComs();

            if (ListEvents.SelectedItems.Count > 0)
            {

                try
                {
                    logicIndx = Convert.ToInt32(LblLogicIndx.Text);
                }
                catch (Exception)
                {
                    // Find the next free logic statement
                }

                dataBytes[3] = 0xff;
                dataBytes[4] = 0xff;
                ListEvents.SelectedItems[0].SubItems[1].Text = "None";
                ListEvents.SelectedItems[0].SubItems[4].Text = "255";
                ListEvents.SelectedItems[0].SubItems[2].Text = "None";
                ListEvents.SelectedItems[0].SubItems[5].Text = "255";

                for (int i = 0; i < ConditionListView.Items.Count; i++)
                {
                    if (ConditionListView.Items[i].Checked)
                    {
                        if (checkedCnt == 0)
                        {
                            ListEvents.SelectedItems[0].SubItems[1].Text = ConditionListView.Items[i].SubItems[1].Text;
                            ListEvents.SelectedItems[0].SubItems[4].Text = i.ToString();
                            dataBytes[3] = (byte)i;
                        }
                        else if (checkedCnt == 1)
                        {
                            ListEvents.SelectedItems[0].SubItems[2].Text = ConditionListView.Items[i].SubItems[1].Text;
                            ListEvents.SelectedItems[0].SubItems[5].Text = i.ToString();
                            dataBytes[4] = (byte)i;
                        }
                        checkedCnt++;
                    }
                }

                ActionMask = 0;

                for (int i = 0; i < ConditionListView.Items.Count; i++)
                {
                    if (ActionListView.Items[i].Checked)
                    {
                        ActionMask |= (UInt32)1 << i;
                    }
                }

                // Update Action Mask
                ListEvents.SelectedItems[0].SubItems[3].Text = ActionMask.ToString();

                TabConditionList.SelectedIndex = 0;

                try
                {
                    dataBytes[0] = (byte)CommandNo.SSC_LOGIC_EDT_EVENT;

                    // To follow
                    dataBytes[1] = 1;

                    // Indx 
                    dataBytes[2] = (byte)logicIndx;

                    // Condition No's are already set

                    // Action Mask
                    Buffer.BlockCopy(BitConverter.GetBytes(ActionMask), 0, dataBytes, 5, 4);

                    coms.Command(dataBytes, dataBytes.Length, IPAddress.Parse(textBox1.Text));
                }
                catch (Exception)
                {

                }
            }
        }

        private void LogicControlFrm_Shown(object sender, EventArgs e)
        {
            int i = 0;

            LblCondIdx.Text = "0";
            LblCondNo.Text = "0";
            LblActionIdx.Text = "0";
            LblActionNo.Text = "0";

            // Update the dropdowns
            for (i = 0; (i < (int)LOGIC_CONDITION_TYPE.L_EVENT_MAX-2); i++)
            {
                CmbConditionList.Items.Add(LOGIC_CONDITION_NAMES[i]);
            }

            for (i = 0; (i < (int)LOGIC_ACTION_TYPE.L_ACTION_MAX-4); i++)
            {
                CmbAction.Items.Add(LOGIC_ACTION_NAMES[i]);
            }

            i = 0;
            readAllToolStripMenuItem_Click(null, null);
        }

        private void LogicControlFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MyParent.removeMeFromLogicFormList(MacAddr);
        }

        private void readAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[1];

            try
            {
                dataBytes[0] = (byte)CommandNo.SSC_LOGIC_READ;
                coms.Command(dataBytes, dataBytes.Length, IPAddress.Parse(textBox1.Text));
            }
            catch (Exception)
            {

            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

    }
}
