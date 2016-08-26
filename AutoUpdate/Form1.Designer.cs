namespace AutoUpdate
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
            this.groupBoxVersion = new System.Windows.Forms.GroupBox();
            this.radioButtonStable = new System.Windows.Forms.RadioButton();
            this.radioButtonAlpha = new System.Windows.Forms.RadioButton();
            this.radioButtonVersionBeta = new System.Windows.Forms.RadioButton();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lableProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxVersionList = new System.Windows.Forms.GroupBox();
            this.listBoxVersion = new System.Windows.Forms.ListBox();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNowtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSavetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLatest = new System.Windows.Forms.Button();
            this.buttonUpdateLog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.listBoxSource = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxVersion.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBoxVersionList.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVersion
            // 
            this.groupBoxVersion.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxVersion.Controls.Add(this.radioButtonStable);
            this.groupBoxVersion.Controls.Add(this.radioButtonAlpha);
            this.groupBoxVersion.Controls.Add(this.radioButtonVersionBeta);
            this.groupBoxVersion.Location = new System.Drawing.Point(12, 50);
            this.groupBoxVersion.Name = "groupBoxVersion";
            this.groupBoxVersion.Size = new System.Drawing.Size(72, 109);
            this.groupBoxVersion.TabIndex = 0;
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
            // groupBoxInfo
            // 
            this.groupBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInfo.Controls.Add(this.textBox1);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 291);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(435, 98);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "更新进展详细信息";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正毡笔黑简体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "通用软件自动更新系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.lableProgress,
            this.progressBar,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 392);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(459, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "状态信息";
            // 
            // lableProgress
            // 
            this.lableProgress.Name = "lableProgress";
            this.lableProgress.Size = new System.Drawing.Size(56, 17);
            this.lableProgress.Text = "更新进度";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "当前时间：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(141, 17);
            this.toolStripStatusLabel2.Text = "2016年8月26日16:28:23";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel3.Text = "空闲";
            // 
            // groupBoxVersionList
            // 
            this.groupBoxVersionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVersionList.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVersionList.Controls.Add(this.listBoxVersion);
            this.groupBoxVersionList.Location = new System.Drawing.Point(90, 50);
            this.groupBoxVersionList.Name = "groupBoxVersionList";
            this.groupBoxVersionList.Size = new System.Drawing.Size(113, 109);
            this.groupBoxVersionList.TabIndex = 4;
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
            this.listBoxVersion.Size = new System.Drawing.Size(101, 88);
            this.listBoxVersion.TabIndex = 0;
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxControl.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxControl.Controls.Add(this.button1);
            this.groupBoxControl.Controls.Add(this.buttonUpdateLog);
            this.groupBoxControl.Controls.Add(this.buttonLatest);
            this.groupBoxControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxControl.Location = new System.Drawing.Point(303, 50);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(144, 109);
            this.groupBoxControl.TabIndex = 5;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "操作面板";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 120);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "涉及文件列表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFilename,
            this.ColumnNowtime,
            this.ColumnSavetime});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(423, 94);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnFilename
            // 
            this.ColumnFilename.HeaderText = "文件名";
            this.ColumnFilename.Name = "ColumnFilename";
            // 
            // ColumnNowtime
            // 
            this.ColumnNowtime.HeaderText = "当前修改时间";
            this.ColumnNowtime.Name = "ColumnNowtime";
            // 
            // ColumnSavetime
            // 
            this.ColumnSavetime.HeaderText = "库中修改时间";
            this.ColumnSavetime.Name = "ColumnSavetime";
            // 
            // buttonLatest
            // 
            this.buttonLatest.Location = new System.Drawing.Point(6, 17);
            this.buttonLatest.Name = "buttonLatest";
            this.buttonLatest.Size = new System.Drawing.Size(130, 23);
            this.buttonLatest.TabIndex = 0;
            this.buttonLatest.Text = "更新/回退到选定版本";
            this.buttonLatest.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateLog
            // 
            this.buttonUpdateLog.Location = new System.Drawing.Point(6, 46);
            this.buttonUpdateLog.Name = "buttonUpdateLog";
            this.buttonUpdateLog.Size = new System.Drawing.Size(130, 23);
            this.buttonUpdateLog.TabIndex = 1;
            this.buttonUpdateLog.Text = "选定版本的更新日志";
            this.buttonUpdateLog.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "查看本机唯一标识";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSource.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSource.Controls.Add(this.listBoxSource);
            this.groupBoxSource.Location = new System.Drawing.Point(209, 50);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(88, 109);
            this.groupBoxSource.TabIndex = 7;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "更新源";
            // 
            // listBoxSource
            // 
            this.listBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSource.FormattingEnabled = true;
            this.listBoxSource.ItemHeight = 12;
            this.listBoxSource.Location = new System.Drawing.Point(6, 15);
            this.listBoxSource.Name = "listBoxSource";
            this.listBoxSource.Size = new System.Drawing.Size(76, 88);
            this.listBoxSource.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 72);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoUpdate.Properties.Resources.ImageBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 414);
            this.Controls.Add(this.groupBoxSource);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.groupBoxVersionList);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxVersion);
            this.MinimumSize = new System.Drawing.Size(475, 452);
            this.Name = "Form1";
            this.Text = "通用软件自动更新系统 —— 杨宇庆 版权所有";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxVersion.ResumeLayout(false);
            this.groupBoxVersion.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxVersionList.ResumeLayout(false);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSource.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVersion;
        private System.Windows.Forms.RadioButton radioButtonStable;
        private System.Windows.Forms.RadioButton radioButtonAlpha;
        private System.Windows.Forms.RadioButton radioButtonVersionBeta;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lableProgress;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBoxVersionList;
        private System.Windows.Forms.ListBox listBoxVersion;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdateLog;
        private System.Windows.Forms.Button buttonLatest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNowtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSavetime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.ListBox listBoxSource;
    }
}

