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

        const int LOGIC_COND_CNT = 24;
        const int LOGIC_ACT_CNT = 24;
        const int LOGIC_EVENT_CNT = 24;

        enum LOGIC_CONDITION_TYPE
        {
            L_EVENT_INVALID = 0,
            L_EVENT_GPIO_RAISING,
            L_EVENT_GPIO_FALLING,
            L_EVENT_ADC_ABOVE,
            L_EVENT_ADC_BELOW,
            L_EVENT_NET_DISCONNECT,
            L_EVENT_NET_CONNECT,
            L_EVENT_TEMP_ABOVE,
            L_EVENT_TEMP_BELOW,
            L_EVENT_REG_EQUAL,
            L_EVENT_REG_ABOVE,
            L_EVENT_REG_BELOW,
            L_EVENT_REPEAT_TIMER,
            L_EVENT_GPIO_RAISING_DB,
            L_EVENT_GPIO_FALLING_DB,
            L_EVENT_BOOT,
            L_EVENT_EVERY_TICK,
            L_EVENT_DATE_AFTER,
            L_EVENT_DATE_BEFORE,
            L_EVENT_TIME_AFTER,
            L_EVENT_TIME_BEFORE,
            L_EVENT_NET_MSG,
            L_EVENT_GPIO_HIGH,
            L_EVENT_GPIO_LOW,
            L_EVENT_MAX
        };

        enum LOGIC_ACTION_TYPE
        {
            L_ACTION_INVALID = 0,
            L_ACTION_GPIO_HIGH,
            L_ACTION_GPIO_LOW,
            L_ACTION_PWM_DUTY,
            L_ACTION_INCREMENT_REG,
            L_ACTION_DECREMENT_REG,
            L_ACTION_CLEAR_REG,
            L_ACTION_SET_REG,
            L_ACTION_NET_MSG,
            L_ACTION_SERIAL_MSG,
            L_ACTION_CONTROL_RELAY,
            L_ACTION_SERVO_POS,
            L_ACTION_RGB,
            L_ACTION_SEND_COSM,
            L_ACTION_MAX
        };

        public readonly string[] LOGIC_CONDITION_NAMES = 
        { 
            "None",
		    "GPIO Raised",
		    "GPIO Lowered",
		    "ADC Above",
		    "ADC Below",
		    "Ethernet Disconnected",
		    "Ethernet Connected",
		    "Temp Above",
		    "Temp Below",
		    "REG Equal",
		    "REG Above",
		    "REG Below",
		    "REPEAT TIMER",
		    "GPIO Raised Debounced",
		    "GPIO Lowered Debounced",
		    "On Boot",
		    "Every Tick",
		    "Date After",
		    "Date Before",
		    "Time After",
		    "Time Before",
		    "NET MSG",
		    "GPIO High",
		    "GPIO Low",
        };

        public readonly string[] LOGIC_ACTION_NAMES = 
        {
            "None",
		    "Set GPIO High",
		    "Set GPIO Low",
		    "PWM Duty",
		    "Increment REG",
		    "Decrement REG",
		    "Clear REG",
		    "Set REG",
		    "NET MSG",
		    "SERIAL MSG",
		    "Control Relay",
		    "Move Servo",
		    "RGB",
		    "SEND COSM"
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

            this.Text = "[SolderSplash LABS] Logic Control - " + MAC;
        }

        private void LogicControlFrm_Load(object sender, EventArgs e)
        {
            
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

                    CmbConditionList.SelectedIndex = CmbConditionList.FindStringExact(LOGIC_CONDITION_NAMES[Convert.ToInt32(ConditionListView.SelectedItems[0].SubItems[4].Text.ToString())]);
                    UpDownCondParam1.Value = Convert.ToInt32(ConditionListView.SelectedItems[0].SubItems[2].Text.ToString());
                    UpDownCondParam2.Value = Convert.ToInt32(ConditionListView.SelectedItems[0].SubItems[3].Text.ToString());
                }
                catch (Exception)
                {
                    UpDownCondParam1.Value = 0;
                    UpDownCondParam2.Value = 0;
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

                    CmbAction.SelectedIndex = CmbAction.FindStringExact(LOGIC_ACTION_NAMES[Convert.ToInt32(ActionListView.SelectedItems[0].SubItems[4].Text.ToString())]);
                    UpDownActParam1.Value = Convert.ToInt32(ActionListView.SelectedItems[0].SubItems[2].Text.ToString());
                    UpDownActParam2.Value = Convert.ToInt32(ActionListView.SelectedItems[0].SubItems[3].Text.ToString());
                }
                catch (Exception)
                {
                    CmbAction.SelectedIndex = 0;
                    ActionListView.SelectedItems[0].SubItems[2].Text = "0";
                    ActionListView.SelectedItems[0].SubItems[3].Text = "0";
                    UpDownActParam1.Value = 0;
                    UpDownActParam2.Value = 0;
                }
            }
        }

        private void ButUpdateAction_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[11];

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

        private void CmbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblActionNo.Text = CmbAction.SelectedIndex.ToString();
        }

        private void ButUpdateCondition_Click(object sender, EventArgs e)
        {
            SplashBaseComs coms = new SplashBaseComs();
            byte[] dataBytes = new byte[11];

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

                ConditionListView.Items[Convert.ToInt32(LblCondIdx.Text)].SubItems[1].Text = LOGIC_CONDITION_NAMES[Convert.ToInt32(LblCondNo.Text)];
                ConditionListView.Items[ Convert.ToInt32(LblCondIdx.Text) ].SubItems[2].Text = UpDownCondParam1.Value.ToString();
                ConditionListView.Items[ Convert.ToInt32(LblCondIdx.Text) ].SubItems[3].Text = UpDownCondParam2.Value.ToString();
                ConditionListView.Items[ Convert.ToInt32(LblCondIdx.Text) ].SubItems[4].Text = LblCondNo.Text;
            }
            catch (Exception)
            {

            }
        }

        private void CmbConditionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblCondNo.Text = CmbConditionList.SelectedIndex.ToString();
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
                ButUpdateLogic.Enabled = false;
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
            for (int i = 0; i < ActionListView.Items.Count; i++)
            {
                if (ActionListView.Items[i].Checked)
                {
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
            for (i = 0; (i < (int)LOGIC_CONDITION_TYPE.L_EVENT_MAX); i++)
            {
                CmbConditionList.Items.Add(LOGIC_CONDITION_NAMES[i]);
            }

            for (i = 0; (i < (int)LOGIC_ACTION_TYPE.L_ACTION_MAX); i++)
            {
                CmbAction.Items.Add(LOGIC_ACTION_NAMES[i]);
            }

            i = 0;
        }

    }
}
