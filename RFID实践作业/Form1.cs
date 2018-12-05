using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ISO15693DLL;
//毛小帅
namespace RFID实验ISO15693第一课
{
    public partial class Form1 : Form
    {
        ISO15693DLL.Reader reader = new Reader();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPort();
            Cmb_Reset.SelectedIndex = 0;
        }

        private void RefreshPort()
        {
            Cmb_Port.Items.Clear();
            Cmb_Port.Text = "";
            Cmb_Baud.Text = "115200";
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach (var item in Ports)
            {
                Cmb_Port.Items.Add(item);
            }
            //默认选择下拉列表第一个
            if (Ports.Length > 0)
            {
                Cmb_Port.SelectedIndex = 0;
            }
            Btn_Close.Enabled = false;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshPort();
            Btn_Close.Enabled = true;
        }
        
        private void Btn_Open_Click(object sender, EventArgs e)
        {
            if (Cmb_Port.SelectedIndex < 0)
            {
                ShowList("打开失败,请选择串口");
                return;
            }
            //打开串口
            byte value = reader.OpenSerialPort(Cmb_Port.Text, Convert.ToInt32(Cmb_Baud.Text));
            if (value == 0x00)
            {
                Btn_Open.Enabled = false;
                Btn_Close.Enabled = true;
                ShowList(string.Format("Port:[{0}],Open Successed,Baud:[{1}]", Cmb_Port.Text, Cmb_Baud.Text));
            }
            else 
            {
                ShowList(string.Format("Port:[{0}],OpenFail", Cmb_Port.Text));
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            byte value = reader.CloseSerialPort();
            if (value == 0x00)
            {
                ShowList(string.Format("Port[{0}],CloseSucced", Cmb_Port.Text));
            }
            else
            {
                ShowList(string.Format("Port[{0}],CloseFail", Cmb_Port.Text));
            }

            Btn_Open.Enabled = true;
        }

        private delegate void AddList(string msg);
        private void ShowList(string msg)
        {
            if (Lbx_OutputInfo.InvokeRequired)
            {
                AddList d = new AddList(ShowList);
                Lbx_OutputInfo.Invoke(d, msg);
            }
            else
            {
                Lbx_OutputInfo.Items.Insert(0, DateTime.Now.ToLongTimeString() + ":" + msg);
            }
        }

        int IsCommand;
        private int TagCount = 0;
        private string[] TagNumber = null;
        private List<string> _listTag = new List<string>();
        private void Btn_Run_Click(object sender, EventArgs e)
        {
            Byte value;
            if (reader.IsOpen)
            {
                switch (IsCommand)
                {
                        //单寻卡
                    case 0:
                        //寻卡，获取场区内卡片的卡号；
                        value = reader.Inventory(ModulateMethod.ASK,InventoryModel.Single,ref TagCount,ref TagNumber);
                        if (value == 0x00)
                        {
                           ShowList(string.Format("TagCount:{0},Tagnumber:{1}",TagCount,TagNumber[0])) ;
                            if(!_listTag.Contains(TagNumber[0]))
                            {
                                _listTag.Add(TagNumber[0]);
                                cmb_Tags.Items.Add(TagNumber[0]);
                                cmb_Tags.SelectedIndex = 0;
                            }
                        }
                        else
                        {
                            ShowList("Invertory Lose!No Tagnumber");
                        }
                        break;

                    case 1:
                        if (cmb_Tags.Text != "")
                        {
                            if (txt_StartAddress.Text == "")
                            {
                                MessageBox.Show("请填写要查看的地址快!");
                                return;
                            }
                            Byte[] BlockData = null;
                            value = reader.ReadSingleBlock(cmb_Tags.Text, BlockLength.ShortBlock4Byte, Convert.ToByte(txt_StartAddress.Text.Trim(), 16), ref BlockData);
                            if (value == 0x00)
                            {
                                StringBuilder sb = new StringBuilder();
                                for (int i = 0; i < BlockData.Length; i++)
                                {
                                    sb.Append(BlockData[i].ToString("X2"));
                                }
                                txt_Result.Text = sb.ToString();
                                ShowList(string.Format("Reader:[{0}],Address;[{1}],ReaderData:{2}", cmb_Tags.Text, txt_StartAddress.Text.Trim(), ByteArrayToString(BlockData)));
                            }
                            txt_BlockCount.ReadOnly = false;
                            txt_BlockSize.ReadOnly = false;
                            Txt_WriteData.ReadOnly = false;
                        }
                        else
                        {
                            ShowList("请先寻到一张或多张卡片!");
                            txt_BlockCount.ReadOnly = false;
                            txt_BlockSize.ReadOnly = false;
                            Txt_WriteData.ReadOnly = false;
                        }
                        break;

                    case 2:
                        if (cmb_Tags.Text != "")
                        {
                            if (Txt_WriteData.Text.Trim() == ""||txt_BlockSize.Text.Trim()=="")
                            {
                                MessageBox.Show("请填写需要写入字节数或者数据");
                                return;
                            }
                            Byte[] DataForWrite = new Byte[Convert.ToInt32(txt_BlockSize.Text.Trim())];
                            String strForWrite = Txt_WriteData.Text.Trim();
                            try
                            {
                                for (byte i = 0; i < DataForWrite.Length; i++)
                                {
                                    DataForWrite[i] = Convert.ToByte(strForWrite.Substring(i * 2, 2), 16);
                                }
                            }
                            catch (System.ArgumentOutOfRangeException)
                            {
                                ShowList(string.Format("错误:写入的数据长度不够或超过{0}Byte！", Convert.ToInt32(txt_BlockSize.Text.Trim())));
                                Txt_WriteData.SelectAll();
                                Txt_WriteData.Focus();
                                return;

                            }
                            catch (System.FormatException)
                            {
                                ShowList(string.Format("错误：请填写{0}Byte的16进制数据！", Convert.ToInt32(txt_BlockSize.Text.Trim())));
                                Txt_WriteData.SelectAll();
                                Txt_WriteData.Focus();
                                return;
                            }
                            value = reader.WriteSingleBlock(cmb_Tags.Text, BlockLength.ShortBlock4Byte,Convert.ToByte(txt_StartAddress.Text.Trim(),16),DataForWrite);
                            if (value == 0x00)
                            {
                                ShowList(string.Format("Succeed!Address:[{0}],WriteData:[{1}]", txt_StartAddress.Text, Txt_WriteData.Text));
                            }
                            else
                            {
                                ShowList(string.Format("Lose!Address:[{0}],WriteData:[{1}]", txt_StartAddress.Text, Txt_WriteData.Text));

                            }
                            txt_BlockCount.ReadOnly = false;
                        }
                        else
                        {
                            ShowList("请先寻到一张或多张卡片!");
                            txt_BlockCount.ReadOnly = false;
                        }
                        break;

                    case 3:
                        {
                            if (cmb_Tags.Text != "")
                            {
                                Byte[] BlockDataMore = null;
                                int count = 0;
                                if (int.TryParse(txt_BlockCount.Text.Trim(), out count))
                                {
                                    int Address = 0;
                                    if (int.TryParse(txt_StartAddress.Text.Trim(), out Address))
                                    {
                                        value = reader.ReadMultiBlock(cmb_Tags.Text, BlockLength.ShortBlock4Byte, (byte)Address, (byte)count, ref BlockDataMore);
                                        if (value == 0x00)
                                        {
                                            StringBuilder sb = new StringBuilder();
                                            for (int i = 0; i < BlockDataMore.Length; i++)
                                            {
                                                sb.Append(BlockDataMore[i].ToString("X2"));
                                            }
                                            txt_Result.Text = sb.ToString();
                                            Txt_WriteData.Text = txt_Result.Text;
                                            ShowList(String.Format("reader[{0}],Address:{1},ReaderCount:{3},Data:{2}", cmb_Tags.Text, txt_StartAddress.Text.Trim(), ByteArrayToString(BlockDataMore), count));


                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("请填写正确的数据的大小");
                                }

                            }
                        }
                        break;

                    case 4:
                            if (cmb_Tags.Text != "")
                            {
                                value = reader.StayQuiet(cmb_Tags.Text);
                                if (value == 0x00)
                                {
                                    ShowList(string.Format("命令执行成功，卡片[{0}]静默成功", cmb_Tags.Text));
                                }
                                else
                                {
                                    ShowList(string.Format("命令执行成功,卡片[{0}]静默失败", cmb_Tags.Text));
                                }

                            }
                            else
                            {
                                ShowList("请先寻到一张或多张卡片");
                            }
                        break;

                    case 5:
                        if (Cmb_Reset.SelectedIndex != 0)
                        {
                            switch (Cmb_Reset.SelectedIndex)
                            {
                                case 1:
                                    value = reader.ResetToReady(ResetMode.RstAllQuiet);
                                    break;
                                case 2:
                                    value = reader.ResetToReady(ResetMode.RstAllSelected); break;
                                case 3:
                                    value = reader.ResetToReady(ResetMode.RstSpecificQuiet, cmb_Tags.Text); break;
                                case 4:
                                    value = reader.ResetToReady(ResetMode.RstSpecificSelected, cmb_Tags.Text); break;
                                default:
                                    value = reader.ResetToReady(ResetMode.RstAllQuiet); break;
                            }
                            if (value == 0x00)
                            {
                                switch (Cmb_Reset.SelectedIndex)
                                {
                                    case 1:
                                        ShowList("重置所有静默卡片命令执行成功！");
                                        break;
                                    case 2:
                                        ShowList("重置所有选中卡片命令执行成功！");
                                        break;
                                    case 3:
                                        ShowList(string.Format("重置静默卡片[{0}]执行成功！", cmb_Tags.Text));
                                        break;
                                    case 4:
                                        ShowList(string.Format("重置选中D卡片[{0}]执行成功！", cmb_Tags.Text));
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                switch (Cmb_Reset.SelectedIndex)
                                {
                                    case 1:
                                        ShowList("重置所有静默卡片命令执行失败！");
                                        break;
                                    case 2:
                                        ShowList("重置所有选中卡片命令执行失败！");
                                        break;
                                    case 3:
                                        ShowList(string.Format("重置静默卡片[{0}]执行失败！", cmb_Tags.Text));
                                        break;
                                    case 4:
                                        ShowList(string.Format("重置选中卡片[{0}]执行失败！", cmb_Tags.Text));
                                        break;
                                    default:
                                        break;
                                }
                            }

                        }
                        else
                        {
                            ShowList("请选择一种静默方式才可以执行");
                        }
                        break;

                    case 6:
                        value = reader.Inventory(ModulateMethod.ASK, InventoryModel.Multiple, ref TagCount, ref TagNumber);
                        if (value == 0x00)
                        {

                            for (int i = 0; i < TagNumber.Length; i++)
                            {
                                ShowList(String.Format("TagCount:{0}，TagNumber：{1}", TagCount, TagNumber[i]));

                                if (!_listTag.Contains(TagNumber[i]))
                                {
                                    _listTag.Add(TagNumber[i]);
                                    cmb_Tags.Items.Add(TagNumber[i]);
                                    cmb_Tags.SelectedIndex = 0;
                                }
                            }
                        }
                        else
                        {
                            ShowList("Inventory Lose!No TagNumber");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                ShowList("串口未打开,请打开串口!");
                txt_BlockCount.ReadOnly = false;
                txt_BlockSize.ReadOnly = false;
                Txt_WriteData.ReadOnly = false;
            }
        }

        private string ByteArrayToString(Byte[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Byte a in array)
            {
                sb = sb.Append(a.ToString("X2"));
            }
            return sb.ToString();
        }

        //private string ByteArrayToString(byte[] array, int StartPos, int Length)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int index = StartPos; index < StartPos + Length; index++)
        //    {
        //        sb = sb.Append(array[index].ToString("X2"));
        //    }
        //    return sb.ToString();
        //}
        

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Lbx_OutputInfo.Items.Clear();
            txt_Result.Text = "";
            Txt_WriteData.Text = "";
        }

        private void Rbtn_Inventory_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_Inventory.Checked)
            {
                IsCommand = 0;
            }
        }
        
        private void Rbtn_ReadSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_ReadSingle.Checked)
            {
                IsCommand = 1;
                txt_BlockCount.ReadOnly = true;
                txt_BlockSize.ReadOnly = true;
                Txt_WriteData.ReadOnly = true;
            }
        }
        private void Rbtn_WriteSingleBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_WriteSingleBlock.Checked)
            {
                IsCommand = 2;
                txt_BlockCount.ReadOnly = true;
            }
        }
        
        private void Rbtn_ReadMuti_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_ReadMuti.Checked)
            {
                IsCommand = 3;       
            }
        }

        private void Rbtn_StayQuiet_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_StayQuiet.Checked)
            {
                IsCommand = 4;
            }
        }

        private void Rbtn_ResetToReady_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_ResetToReady.Checked)
            {
                IsCommand = 5;
            }
        }

        private void Rbtn_Multilnventory_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_Multilnventory.Checked)
            {
                IsCommand = 6;
            }
        }
        
        private delegate void AddItem(string tag);
        private void AddCmbTagNumber(string tag)
        {
            if (cmb_Tags.InvokeRequired)
            {
                AddItem additem = new AddItem(AddCmbTagNumber);
                cmb_Tags.Invoke(additem, tag);
            }
            else
            {
                cmb_Tags.Items.Add(tag);
                cmb_Tags.SelectedIndex = 0;
            }
        }

        private Boolean IsStop = false;
        private void AutoRun()
        {
            Byte value;
            while (IsStop)
            {
                value = reader.Inventory(ModulateMethod.ASK, InventoryModel.Multiple, ref TagCount, ref TagNumber);
                if (value == 0)
                {
                    for (int i = 0; i < TagNumber.Length; i++)
                    {
                        ShowList(String.Format("TagCout:{0},TagNumber:{1}", TagCount, TagNumber[i]));
                        if (!_listTag.Contains(TagNumber[i]))
                        {
                            _listTag.Add(TagNumber[i]);
                            AddCmbTagNumber(TagNumber[i]);
                        }
                    }
                }
                else
                {
                    ShowList("Inventory Lose!No TagNumber");
                }
            }
        }
        
        private void Btn_AutoRun_Click(object sender, EventArgs e)
        {
            Thread th_AutoRun = new Thread(AutoRun);
            th_AutoRun.IsBackground = true;
            if (Btn_AutoRun.Text == "AutoRun")
            {
                IsStop = true;
                Btn_AutoRun.Text = "StopRun";
                th_AutoRun.Start();
            }
            else
            {
                IsStop = false;
                Btn_AutoRun.Text = "AutoRun";
            }
        }
        private void Cmb_Port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_StartAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_BlockSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Lbx_OutputInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_BlockCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
