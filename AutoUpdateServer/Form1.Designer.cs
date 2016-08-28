namespace AutoUpdateServer
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
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxVersion = new System.Windows.Forms.GroupBox();
            this.radioButtonStable = new System.Windows.Forms.RadioButton();
            this.radioButtonAlpha = new System.Windows.Forms.RadioButton();
            this.radioButtonVersionBeta = new System.Windows.Forms.RadioButton();
            this.groupBoxVersionList = new System.Windows.Forms.GroupBox();
            this.listBoxVersion = new System.Windows.Forms.ListBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdateLog = new System.Windows.Forms.Button();
            this.buttonLatest = new System.Windows.Forms.Button();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGitBashList = new System.Windows.Forms.TextBox();
            this.textBoxGitInput = new System.Windows.Forms.TextBox();
            this.tabPageRepair = new System.Windows.Forms.TabPage();
            this.dataGridViewRepairFiles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRepairCheck = new System.Windows.Forms.Button();
            this.buttonRepairSelect = new System.Windows.Forms.Button();
            this.buttonRepair = new System.Windows.Forms.Button();
            this.tabPageSource = new System.Windows.Forms.TabPage();
            this.listBoxSource = new System.Windows.Forms.ListBox();
            this.buttonApplyUpdateSource = new System.Windows.Forms.Button();
            this.labelUpdateSource = new System.Windows.Forms.Label();
            this.buttonGetUpdateSource = new System.Windows.Forms.Button();
            this.tabPageFiles = new System.Windows.Forms.TabPage();
            this.dataGridViewModifyFiles = new System.Windows.Forms.DataGridView();
            this.ColumnSavetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNowtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStartUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelUpdateConfirm = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            label2 = new System.Windows.Forms.Label();
            this.groupBoxVersion.SuspendLayout();
            this.groupBoxVersionList.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepairFiles)).BeginInit();
            this.tabPageSource.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyFiles)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVersion
            // 
            this.groupBoxVersion.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxVersion.Controls.Add(this.radioButtonStable);
            this.groupBoxVersion.Controls.Add(this.radioButtonAlpha);
            this.groupBoxVersion.Controls.Add(this.radioButtonVersionBeta);
            this.groupBoxVersion.Location = new System.Drawing.Point(12, 70);
            this.groupBoxVersion.Name = "groupBoxVersion";
            this.groupBoxVersion.Size = new System.Drawing.Size(72, 109);
            this.groupBoxVersion.TabIndex = 1;
            this.groupBoxVersion.TabStop = false;
            this.groupBoxVersion.Text = "版本分支";
            // 
            // radioButtonStable
            // 
            this.radioButtonStable.AutoSize = true;
            this.radioButtonStable.Checked = true;
            this.radioButtonStable.Location = new System.Drawing.Point(6, 87);
            this.radioButtonStable.Name = "radioButtonStable";
            this.radioButtonStable.Size = new System.Drawing.Size(59, 16);
            this.radioButtonStable.TabIndex = 2;
            this.radioButtonStable.TabStop = true;
            this.radioButtonStable.Text = "Stable";
            this.radioButtonStable.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlpha
            // 
            this.radioButtonAlpha.AutoSize = true;
            this.radioButtonAlpha.Location = new System.Drawing.Point(6, 51);
            this.radioButtonAlpha.Name = "radioButtonAlpha";
            this.radioButtonAlpha.Size = new System.Drawing.Size(53, 16);
            this.radioButtonAlpha.TabIndex = 1;
            this.radioButtonAlpha.Text = "Alpha";
            this.radioButtonAlpha.UseVisualStyleBackColor = true;
            // 
            // radioButtonVersionBeta
            // 
            this.radioButtonVersionBeta.AutoSize = true;
            this.radioButtonVersionBeta.Location = new System.Drawing.Point(6, 15);
            this.radioButtonVersionBeta.Name = "radioButtonVersionBeta";
            this.radioButtonVersionBeta.Size = new System.Drawing.Size(47, 16);
            this.radioButtonVersionBeta.TabIndex = 0;
            this.radioButtonVersionBeta.Text = "Beta";
            this.radioButtonVersionBeta.UseVisualStyleBackColor = true;
            // 
            // groupBoxVersionList
            // 
            this.groupBoxVersionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVersionList.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVersionList.Controls.Add(this.listBoxVersion);
            this.groupBoxVersionList.Location = new System.Drawing.Point(90, 70);
            this.groupBoxVersionList.Name = "groupBoxVersionList";
            this.groupBoxVersionList.Size = new System.Drawing.Size(614, 109);
            this.groupBoxVersionList.TabIndex = 5;
            this.groupBoxVersionList.TabStop = false;
            this.groupBoxVersionList.Text = "版本列表";
            // 
            // listBoxVersion
            // 
            this.listBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxVersion.FormattingEnabled = true;
            this.listBoxVersion.ItemHeight = 12;
            this.listBoxVersion.Location = new System.Drawing.Point(6, 15);
            this.listBoxVersion.Name = "listBoxVersion";
            this.listBoxVersion.Size = new System.Drawing.Size(602, 88);
            this.listBoxVersion.TabIndex = 0;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInfo.Controls.Add(this.textBox1);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 347);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(1014, 153);
            this.groupBoxInfo.TabIndex = 6;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "更新进展详细信息";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1000, 127);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正毡笔黑简体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "通用软件自动更新系统——服务端";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControl.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxControl.Controls.Add(this.button3);
            this.groupBoxControl.Controls.Add(this.buttonPublish);
            this.groupBoxControl.Controls.Add(this.button1);
            this.groupBoxControl.Controls.Add(this.buttonUpdateLog);
            this.groupBoxControl.Controls.Add(this.buttonLatest);
            this.groupBoxControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxControl.Location = new System.Drawing.Point(710, 70);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(316, 109);
            this.groupBoxControl.TabIndex = 11;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "操作面板";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查看本机唯一标识";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateLog
            // 
            this.buttonUpdateLog.Location = new System.Drawing.Point(6, 46);
            this.buttonUpdateLog.Name = "buttonUpdateLog";
            this.buttonUpdateLog.Size = new System.Drawing.Size(153, 23);
            this.buttonUpdateLog.TabIndex = 1;
            this.buttonUpdateLog.Text = "选定版本的更新日志";
            this.buttonUpdateLog.UseVisualStyleBackColor = true;
            // 
            // buttonLatest
            // 
            this.buttonLatest.Location = new System.Drawing.Point(6, 17);
            this.buttonLatest.Name = "buttonLatest";
            this.buttonLatest.Size = new System.Drawing.Size(153, 23);
            this.buttonLatest.TabIndex = 0;
            this.buttonLatest.Text = "更新/回退到选定版本";
            this.buttonLatest.UseVisualStyleBackColor = true;
            // 
            // buttonPublish
            // 
            this.buttonPublish.Location = new System.Drawing.Point(165, 17);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(75, 23);
            this.buttonPublish.TabIndex = 3;
            this.buttonPublish.Text = "发布新版本";
            this.buttonPublish.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "更改存储库路径";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxGitInput);
            this.groupBox1.Controls.Add(this.textBoxGitBashList);
            this.groupBox1.Location = new System.Drawing.Point(437, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Git bash";
            // 
            // textBoxGitBashList
            // 
            this.textBoxGitBashList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGitBashList.Location = new System.Drawing.Point(6, 20);
            this.textBoxGitBashList.Multiline = true;
            this.textBoxGitBashList.Name = "textBoxGitBashList";
            this.textBoxGitBashList.Size = new System.Drawing.Size(575, 101);
            this.textBoxGitBashList.TabIndex = 0;
            // 
            // textBoxGitInput
            // 
            this.textBoxGitInput.Location = new System.Drawing.Point(6, 127);
            this.textBoxGitInput.Name = "textBoxGitInput";
            this.textBoxGitInput.Size = new System.Drawing.Size(575, 21);
            this.textBoxGitInput.TabIndex = 1;
            // 
            // tabPageRepair
            // 
            this.tabPageRepair.Controls.Add(this.buttonRepair);
            this.tabPageRepair.Controls.Add(this.buttonRepairSelect);
            this.tabPageRepair.Controls.Add(this.buttonRepairCheck);
            this.tabPageRepair.Controls.Add(this.dataGridViewRepairFiles);
            this.tabPageRepair.Location = new System.Drawing.Point(4, 22);
            this.tabPageRepair.Name = "tabPageRepair";
            this.tabPageRepair.Size = new System.Drawing.Size(411, 167);
            this.tabPageRepair.TabIndex = 2;
            this.tabPageRepair.Text = "修复";
            this.tabPageRepair.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRepairFiles
            // 
            this.dataGridViewRepairFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRepairFiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewRepairFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepairFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewRepairFiles.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewRepairFiles.Name = "dataGridViewRepairFiles";
            this.dataGridViewRepairFiles.RowTemplate.Height = 23;
            this.dataGridViewRepairFiles.Size = new System.Drawing.Size(411, 138);
            this.dataGridViewRepairFiles.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "库中修改时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "当前修改时间";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "文件名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // buttonRepairCheck
            // 
            this.buttonRepairCheck.Location = new System.Drawing.Point(0, 3);
            this.buttonRepairCheck.Name = "buttonRepairCheck";
            this.buttonRepairCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonRepairCheck.TabIndex = 2;
            this.buttonRepairCheck.Text = "扫描文件";
            this.buttonRepairCheck.UseVisualStyleBackColor = true;
            // 
            // buttonRepairSelect
            // 
            this.buttonRepairSelect.Location = new System.Drawing.Point(80, 3);
            this.buttonRepairSelect.Name = "buttonRepairSelect";
            this.buttonRepairSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonRepairSelect.TabIndex = 3;
            this.buttonRepairSelect.Text = "全选/取消";
            this.buttonRepairSelect.UseVisualStyleBackColor = true;
            // 
            // buttonRepair
            // 
            this.buttonRepair.Location = new System.Drawing.Point(161, 3);
            this.buttonRepair.Name = "buttonRepair";
            this.buttonRepair.Size = new System.Drawing.Size(88, 23);
            this.buttonRepair.TabIndex = 4;
            this.buttonRepair.Text = "修复选中文件";
            this.buttonRepair.UseVisualStyleBackColor = true;
            // 
            // tabPageSource
            // 
            this.tabPageSource.Controls.Add(this.buttonGetUpdateSource);
            this.tabPageSource.Controls.Add(label2);
            this.tabPageSource.Controls.Add(this.labelUpdateSource);
            this.tabPageSource.Controls.Add(this.buttonApplyUpdateSource);
            this.tabPageSource.Controls.Add(this.listBoxSource);
            this.tabPageSource.Location = new System.Drawing.Point(4, 22);
            this.tabPageSource.Name = "tabPageSource";
            this.tabPageSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSource.Size = new System.Drawing.Size(411, 167);
            this.tabPageSource.TabIndex = 1;
            this.tabPageSource.Text = "更新源";
            this.tabPageSource.UseVisualStyleBackColor = true;
            // 
            // listBoxSource
            // 
            this.listBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSource.FormattingEnabled = true;
            this.listBoxSource.ItemHeight = 12;
            this.listBoxSource.Location = new System.Drawing.Point(0, 30);
            this.listBoxSource.Name = "listBoxSource";
            this.listBoxSource.Size = new System.Drawing.Size(411, 136);
            this.listBoxSource.TabIndex = 0;
            // 
            // buttonApplyUpdateSource
            // 
            this.buttonApplyUpdateSource.Location = new System.Drawing.Point(62, 3);
            this.buttonApplyUpdateSource.Name = "buttonApplyUpdateSource";
            this.buttonApplyUpdateSource.Size = new System.Drawing.Size(97, 23);
            this.buttonApplyUpdateSource.TabIndex = 1;
            this.buttonApplyUpdateSource.Text = "改用所选更新源";
            this.buttonApplyUpdateSource.UseVisualStyleBackColor = true;
            // 
            // labelUpdateSource
            // 
            this.labelUpdateSource.AutoSize = true;
            this.labelUpdateSource.Location = new System.Drawing.Point(248, 8);
            this.labelUpdateSource.Name = "labelUpdateSource";
            this.labelUpdateSource.Size = new System.Drawing.Size(17, 12);
            this.labelUpdateSource.TabIndex = 2;
            this.labelUpdateSource.Text = "无";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(165, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 12);
            label2.TabIndex = 3;
            label2.Text = "当前更新源：";
            // 
            // buttonGetUpdateSource
            // 
            this.buttonGetUpdateSource.Location = new System.Drawing.Point(0, 3);
            this.buttonGetUpdateSource.Name = "buttonGetUpdateSource";
            this.buttonGetUpdateSource.Size = new System.Drawing.Size(61, 23);
            this.buttonGetUpdateSource.TabIndex = 4;
            this.buttonGetUpdateSource.Text = "拉取列表";
            this.buttonGetUpdateSource.UseVisualStyleBackColor = true;
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.labelUpdateConfirm);
            this.tabPageFiles.Controls.Add(this.button2);
            this.tabPageFiles.Controls.Add(this.buttonStartUpdate);
            this.tabPageFiles.Controls.Add(this.dataGridViewModifyFiles);
            this.tabPageFiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiles.Size = new System.Drawing.Size(411, 130);
            this.tabPageFiles.TabIndex = 0;
            this.tabPageFiles.Text = "涉及文件列表";
            this.tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // dataGridViewModifyFiles
            // 
            this.dataGridViewModifyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewModifyFiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewModifyFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModifyFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFilename,
            this.ColumnNowtime,
            this.ColumnSavetime});
            this.dataGridViewModifyFiles.Location = new System.Drawing.Point(0, 18);
            this.dataGridViewModifyFiles.Name = "dataGridViewModifyFiles";
            this.dataGridViewModifyFiles.RowTemplate.Height = 23;
            this.dataGridViewModifyFiles.Size = new System.Drawing.Size(357, 112);
            this.dataGridViewModifyFiles.TabIndex = 0;
            // 
            // ColumnSavetime
            // 
            this.ColumnSavetime.HeaderText = "库中修改时间";
            this.ColumnSavetime.Name = "ColumnSavetime";
            // 
            // ColumnNowtime
            // 
            this.ColumnNowtime.HeaderText = "当前修改时间";
            this.ColumnNowtime.Name = "ColumnNowtime";
            // 
            // ColumnFilename
            // 
            this.ColumnFilename.HeaderText = "文件名";
            this.ColumnFilename.Name = "ColumnFilename";
            // 
            // buttonStartUpdate
            // 
            this.buttonStartUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartUpdate.BackgroundImage")));
            this.buttonStartUpdate.Location = new System.Drawing.Point(360, 10);
            this.buttonStartUpdate.Name = "buttonStartUpdate";
            this.buttonStartUpdate.Size = new System.Drawing.Size(48, 48);
            this.buttonStartUpdate.TabIndex = 1;
            this.buttonStartUpdate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(360, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelUpdateConfirm
            // 
            this.labelUpdateConfirm.AutoSize = true;
            this.labelUpdateConfirm.Location = new System.Drawing.Point(0, 3);
            this.labelUpdateConfirm.Name = "labelUpdateConfirm";
            this.labelUpdateConfirm.Size = new System.Drawing.Size(245, 12);
            this.labelUpdateConfirm.TabIndex = 3;
            this.labelUpdateConfirm.Text = "本次更新后，版本号将从0变更为0，请确认：";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageFiles);
            this.tabControl1.Controls.Add(this.tabPageSource);
            this.tabControl1.Controls.Add(this.tabPageRepair);
            this.tabControl1.Location = new System.Drawing.Point(12, 185);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 156);
            this.tabControl1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxVersionList);
            this.Controls.Add(this.groupBoxVersion);
            this.Name = "Form1";
            this.Text = "通用软件自动更新系统 服务端 —— 杨宇庆 版权所有";
            this.groupBoxVersion.ResumeLayout(false);
            this.groupBoxVersion.PerformLayout();
            this.groupBoxVersionList.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageRepair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepairFiles)).EndInit();
            this.tabPageSource.ResumeLayout(false);
            this.tabPageSource.PerformLayout();
            this.tabPageFiles.ResumeLayout(false);
            this.tabPageFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyFiles)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVersion;
        private System.Windows.Forms.RadioButton radioButtonStable;
        private System.Windows.Forms.RadioButton radioButtonAlpha;
        private System.Windows.Forms.RadioButton radioButtonVersionBeta;
        private System.Windows.Forms.GroupBox groupBoxVersionList;
        private System.Windows.Forms.ListBox listBoxVersion;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdateLog;
        private System.Windows.Forms.Button buttonLatest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxGitInput;
        private System.Windows.Forms.TextBox textBoxGitBashList;
        private System.Windows.Forms.TabPage tabPageRepair;
        private System.Windows.Forms.Button buttonRepair;
        private System.Windows.Forms.Button buttonRepairSelect;
        private System.Windows.Forms.Button buttonRepairCheck;
        private System.Windows.Forms.DataGridView dataGridViewRepairFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage tabPageSource;
        private System.Windows.Forms.Button buttonGetUpdateSource;
        private System.Windows.Forms.Label labelUpdateSource;
        private System.Windows.Forms.Button buttonApplyUpdateSource;
        private System.Windows.Forms.ListBox listBoxSource;
        private System.Windows.Forms.TabPage tabPageFiles;
        private System.Windows.Forms.Label labelUpdateConfirm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonStartUpdate;
        private System.Windows.Forms.DataGridView dataGridViewModifyFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNowtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSavetime;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

