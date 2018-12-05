namespace RFID实验ISO15693第一课
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Baud = new System.Windows.Forms.ComboBox();
            this.Cmb_Port = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_AutoRun = new System.Windows.Forms.Button();
            this.Rbtn_Multilnventory = new System.Windows.Forms.RadioButton();
            this.Cmb_Reset = new System.Windows.Forms.ComboBox();
            this.Lbl_Reset = new System.Windows.Forms.Label();
            this.Rbtn_ResetToReady = new System.Windows.Forms.RadioButton();
            this.Rbtn_StayQuiet = new System.Windows.Forms.RadioButton();
            this.Rbtn_ReadMuti = new System.Windows.Forms.RadioButton();
            this.Rbtn_WriteSingleBlock = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Tags = new System.Windows.Forms.ComboBox();
            this.Rbtn_ReadSingle = new System.Windows.Forms.RadioButton();
            this.Btn_Run = new System.Windows.Forms.Button();
            this.Rbtn_Inventory = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Lbx_OutputInfo = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Txt_WriteData = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_BlockCount = new System.Windows.Forms.TextBox();
            this.txt_BlockSize = new System.Windows.Forms.TextBox();
            this.txt_StartAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Refresh);
            this.groupBox1.Controls.Add(this.Btn_Close);
            this.groupBox1.Controls.Add(this.Btn_Open);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cmb_Baud);
            this.groupBox1.Controls.Add(this.Cmb_Port);
            this.groupBox1.Location = new System.Drawing.Point(18, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(326, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Operate";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(224, 102);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(82, 34);
            this.Btn_Refresh.TabIndex = 1;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(126, 102);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(70, 34);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(12, 102);
            this.Btn_Open.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(74, 34);
            this.Btn_Open.TabIndex = 4;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port：";
            // 
            // Cmb_Baud
            // 
            this.Cmb_Baud.FormattingEnabled = true;
            this.Cmb_Baud.Location = new System.Drawing.Point(226, 39);
            this.Cmb_Baud.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Baud.Name = "Cmb_Baud";
            this.Cmb_Baud.Size = new System.Drawing.Size(78, 26);
            this.Cmb_Baud.TabIndex = 1;
            // 
            // Cmb_Port
            // 
            this.Cmb_Port.FormattingEnabled = true;
            this.Cmb_Port.Location = new System.Drawing.Point(70, 39);
            this.Cmb_Port.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Port.Name = "Cmb_Port";
            this.Cmb_Port.Size = new System.Drawing.Size(72, 26);
            this.Cmb_Port.TabIndex = 0;
            this.Cmb_Port.SelectedIndexChanged += new System.EventHandler(this.Cmb_Port_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_AutoRun);
            this.groupBox2.Controls.Add(this.Rbtn_Multilnventory);
            this.groupBox2.Controls.Add(this.Cmb_Reset);
            this.groupBox2.Controls.Add(this.Lbl_Reset);
            this.groupBox2.Controls.Add(this.Rbtn_ResetToReady);
            this.groupBox2.Controls.Add(this.Rbtn_StayQuiet);
            this.groupBox2.Controls.Add(this.Rbtn_ReadMuti);
            this.groupBox2.Controls.Add(this.Rbtn_WriteSingleBlock);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb_Tags);
            this.groupBox2.Controls.Add(this.Rbtn_ReadSingle);
            this.groupBox2.Controls.Add(this.Btn_Run);
            this.groupBox2.Controls.Add(this.Rbtn_Inventory);
            this.groupBox2.Location = new System.Drawing.Point(18, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(306, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command Operate";
            // 
            // Btn_AutoRun
            // 
            this.Btn_AutoRun.Location = new System.Drawing.Point(9, 398);
            this.Btn_AutoRun.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AutoRun.Name = "Btn_AutoRun";
            this.Btn_AutoRun.Size = new System.Drawing.Size(112, 34);
            this.Btn_AutoRun.TabIndex = 12;
            this.Btn_AutoRun.Text = "AutoRun";
            this.Btn_AutoRun.UseVisualStyleBackColor = true;
            this.Btn_AutoRun.Click += new System.EventHandler(this.Btn_AutoRun_Click);
            // 
            // Rbtn_Multilnventory
            // 
            this.Rbtn_Multilnventory.AutoSize = true;
            this.Rbtn_Multilnventory.Location = new System.Drawing.Point(16, 228);
            this.Rbtn_Multilnventory.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_Multilnventory.Name = "Rbtn_Multilnventory";
            this.Rbtn_Multilnventory.Size = new System.Drawing.Size(159, 22);
            this.Rbtn_Multilnventory.TabIndex = 11;
            this.Rbtn_Multilnventory.TabStop = true;
            this.Rbtn_Multilnventory.Text = "Multilnventory";
            this.Rbtn_Multilnventory.UseVisualStyleBackColor = true;
            this.Rbtn_Multilnventory.CheckedChanged += new System.EventHandler(this.Rbtn_Multilnventory_CheckedChanged);
            // 
            // Cmb_Reset
            // 
            this.Cmb_Reset.FormattingEnabled = true;
            this.Cmb_Reset.Items.AddRange(new object[] {
            "请选择一种静默方式",
            "重置所有静默的卡",
            "重置所有选中的卡",
            "重置特定静默的卡",
            "重置特定选中的卡"});
            this.Cmb_Reset.Location = new System.Drawing.Point(69, 280);
            this.Cmb_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Reset.Name = "Cmb_Reset";
            this.Cmb_Reset.Size = new System.Drawing.Size(180, 26);
            this.Cmb_Reset.TabIndex = 10;
            // 
            // Lbl_Reset
            // 
            this.Lbl_Reset.AutoSize = true;
            this.Lbl_Reset.Location = new System.Drawing.Point(9, 280);
            this.Lbl_Reset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Reset.Name = "Lbl_Reset";
            this.Lbl_Reset.Size = new System.Drawing.Size(62, 18);
            this.Lbl_Reset.TabIndex = 9;
            this.Lbl_Reset.Text = "Reset:";
            // 
            // Rbtn_ResetToReady
            // 
            this.Rbtn_ResetToReady.AutoSize = true;
            this.Rbtn_ResetToReady.Location = new System.Drawing.Point(16, 195);
            this.Rbtn_ResetToReady.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_ResetToReady.Name = "Rbtn_ResetToReady";
            this.Rbtn_ResetToReady.Size = new System.Drawing.Size(159, 22);
            this.Rbtn_ResetToReady.TabIndex = 8;
            this.Rbtn_ResetToReady.Text = "Reset To Ready";
            this.Rbtn_ResetToReady.UseVisualStyleBackColor = true;
            this.Rbtn_ResetToReady.CheckedChanged += new System.EventHandler(this.Rbtn_ResetToReady_CheckedChanged);
            // 
            // Rbtn_StayQuiet
            // 
            this.Rbtn_StayQuiet.AutoSize = true;
            this.Rbtn_StayQuiet.Location = new System.Drawing.Point(16, 162);
            this.Rbtn_StayQuiet.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_StayQuiet.Name = "Rbtn_StayQuiet";
            this.Rbtn_StayQuiet.Size = new System.Drawing.Size(123, 22);
            this.Rbtn_StayQuiet.TabIndex = 7;
            this.Rbtn_StayQuiet.Text = "Stay Quiet";
            this.Rbtn_StayQuiet.UseVisualStyleBackColor = true;
            this.Rbtn_StayQuiet.CheckedChanged += new System.EventHandler(this.Rbtn_StayQuiet_CheckedChanged);
            // 
            // Rbtn_ReadMuti
            // 
            this.Rbtn_ReadMuti.AutoSize = true;
            this.Rbtn_ReadMuti.Location = new System.Drawing.Point(16, 129);
            this.Rbtn_ReadMuti.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_ReadMuti.Name = "Rbtn_ReadMuti";
            this.Rbtn_ReadMuti.Size = new System.Drawing.Size(204, 22);
            this.Rbtn_ReadMuti.TabIndex = 6;
            this.Rbtn_ReadMuti.Text = "Read Multiple Block";
            this.toolTip1.SetToolTip(this.Rbtn_ReadMuti, "需要指定block数量");
            this.Rbtn_ReadMuti.UseVisualStyleBackColor = true;
            this.Rbtn_ReadMuti.CheckedChanged += new System.EventHandler(this.Rbtn_ReadMuti_CheckedChanged);
            // 
            // Rbtn_WriteSingleBlock
            // 
            this.Rbtn_WriteSingleBlock.AutoSize = true;
            this.Rbtn_WriteSingleBlock.Location = new System.Drawing.Point(16, 96);
            this.Rbtn_WriteSingleBlock.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_WriteSingleBlock.Name = "Rbtn_WriteSingleBlock";
            this.Rbtn_WriteSingleBlock.Size = new System.Drawing.Size(195, 22);
            this.Rbtn_WriteSingleBlock.TabIndex = 5;
            this.Rbtn_WriteSingleBlock.Text = "Write Single Block";
            this.toolTip2.SetToolTip(this.Rbtn_WriteSingleBlock, "需要设定写入字节数blocksize\r\n在Writedata中填入数据");
            this.Rbtn_WriteSingleBlock.UseVisualStyleBackColor = true;
            this.Rbtn_WriteSingleBlock.CheckedChanged += new System.EventHandler(this.Rbtn_WriteSingleBlock_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tags:";
            // 
            // cmb_Tags
            // 
            this.cmb_Tags.FormattingEnabled = true;
            this.cmb_Tags.Location = new System.Drawing.Point(69, 324);
            this.cmb_Tags.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Tags.Name = "cmb_Tags";
            this.cmb_Tags.Size = new System.Drawing.Size(180, 26);
            this.cmb_Tags.TabIndex = 3;
            // 
            // Rbtn_ReadSingle
            // 
            this.Rbtn_ReadSingle.AutoSize = true;
            this.Rbtn_ReadSingle.Location = new System.Drawing.Point(16, 63);
            this.Rbtn_ReadSingle.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_ReadSingle.Name = "Rbtn_ReadSingle";
            this.Rbtn_ReadSingle.Size = new System.Drawing.Size(186, 22);
            this.Rbtn_ReadSingle.TabIndex = 2;
            this.Rbtn_ReadSingle.Text = "Read single Block";
            this.toolTip1.SetToolTip(this.Rbtn_ReadSingle, "需要一个有效的Address\r\n");
            this.Rbtn_ReadSingle.UseVisualStyleBackColor = true;
            this.Rbtn_ReadSingle.CheckedChanged += new System.EventHandler(this.Rbtn_ReadSingle_CheckedChanged);
            // 
            // Btn_Run
            // 
            this.Btn_Run.Location = new System.Drawing.Point(176, 390);
            this.Btn_Run.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Run.Name = "Btn_Run";
            this.Btn_Run.Size = new System.Drawing.Size(75, 48);
            this.Btn_Run.TabIndex = 1;
            this.Btn_Run.Text = "Run";
            this.Btn_Run.UseVisualStyleBackColor = true;
            this.Btn_Run.Click += new System.EventHandler(this.Btn_Run_Click);
            // 
            // Rbtn_Inventory
            // 
            this.Rbtn_Inventory.AutoSize = true;
            this.Rbtn_Inventory.Location = new System.Drawing.Point(16, 30);
            this.Rbtn_Inventory.Margin = new System.Windows.Forms.Padding(4);
            this.Rbtn_Inventory.Name = "Rbtn_Inventory";
            this.Rbtn_Inventory.Size = new System.Drawing.Size(114, 22);
            this.Rbtn_Inventory.TabIndex = 0;
            this.Rbtn_Inventory.Text = "Inventory";
            this.Rbtn_Inventory.UseVisualStyleBackColor = true;
            this.Rbtn_Inventory.CheckedChanged += new System.EventHandler(this.Rbtn_Inventory_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Clear);
            this.groupBox3.Controls.Add(this.Lbx_OutputInfo);
            this.groupBox3.Location = new System.Drawing.Point(411, 254);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(886, 447);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Info";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(225, 390);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(84, 48);
            this.Btn_Clear.TabIndex = 1;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Lbx_OutputInfo
            // 
            this.Lbx_OutputInfo.FormattingEnabled = true;
            this.Lbx_OutputInfo.ItemHeight = 18;
            this.Lbx_OutputInfo.Location = new System.Drawing.Point(4, 26);
            this.Lbx_OutputInfo.Margin = new System.Windows.Forms.Padding(4);
            this.Lbx_OutputInfo.Name = "Lbx_OutputInfo";
            this.Lbx_OutputInfo.Size = new System.Drawing.Size(856, 364);
            this.Lbx_OutputInfo.TabIndex = 0;
            this.Lbx_OutputInfo.SelectedIndexChanged += new System.EventHandler(this.Lbx_OutputInfo_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Txt_WriteData);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txt_Result);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_BlockCount);
            this.groupBox4.Controls.Add(this.txt_BlockSize);
            this.groupBox4.Controls.Add(this.txt_StartAddress);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(412, 44);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(532, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameter";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Txt_WriteData
            // 
            this.Txt_WriteData.Location = new System.Drawing.Point(141, 148);
            this.Txt_WriteData.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_WriteData.Name = "Txt_WriteData";
            this.Txt_WriteData.Size = new System.Drawing.Size(342, 28);
            this.Txt_WriteData.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "WriteData:";
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(300, 30);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(182, 102);
            this.txt_Result.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Result:";
            // 
            // txt_BlockCount
            // 
            this.txt_BlockCount.Location = new System.Drawing.Point(140, 111);
            this.txt_BlockCount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BlockCount.Name = "txt_BlockCount";
            this.txt_BlockCount.Size = new System.Drawing.Size(54, 28);
            this.txt_BlockCount.TabIndex = 5;
            this.txt_BlockCount.TextChanged += new System.EventHandler(this.txt_BlockCount_TextChanged);
            // 
            // txt_BlockSize
            // 
            this.txt_BlockSize.Location = new System.Drawing.Point(140, 72);
            this.txt_BlockSize.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BlockSize.Name = "txt_BlockSize";
            this.txt_BlockSize.Size = new System.Drawing.Size(54, 28);
            this.txt_BlockSize.TabIndex = 4;
            this.txt_BlockSize.TextChanged += new System.EventHandler(this.txt_BlockSize_TextChanged);
            // 
            // txt_StartAddress
            // 
            this.txt_StartAddress.Location = new System.Drawing.Point(141, 30);
            this.txt_StartAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StartAddress.Name = "txt_StartAddress";
            this.txt_StartAddress.Size = new System.Drawing.Size(52, 28);
            this.txt_StartAddress.TabIndex = 3;
            this.txt_StartAddress.TextChanged += new System.EventHandler(this.txt_StartAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "BlockCount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "BlockSize:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "StartAddress:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 718);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Read_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Baud;
        private System.Windows.Forms.ComboBox Cmb_Port;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Run;
        private System.Windows.Forms.RadioButton Rbtn_Inventory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.ListBox Lbx_OutputInfo;
        private System.Windows.Forms.RadioButton Rbtn_ReadSingle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Tags;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_BlockCount;
        private System.Windows.Forms.TextBox txt_BlockSize;
        private System.Windows.Forms.TextBox txt_StartAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Rbtn_WriteSingleBlock;
        private System.Windows.Forms.TextBox Txt_WriteData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Rbtn_ReadMuti;
        private System.Windows.Forms.ComboBox Cmb_Reset;
        private System.Windows.Forms.Label Lbl_Reset;
        private System.Windows.Forms.RadioButton Rbtn_ResetToReady;
        private System.Windows.Forms.RadioButton Rbtn_StayQuiet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton Rbtn_Multilnventory;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button Btn_AutoRun;
    }
}

