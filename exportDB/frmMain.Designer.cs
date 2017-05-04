namespace exportDB
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowConfigFile = new System.Windows.Forms.Button();
            this.chkConfig = new System.Windows.Forms.CheckBox();
            this.lstExportResult = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkExport = new System.Windows.Forms.CheckBox();
            this.lblTestConnectSrcResult = new System.Windows.Forms.Label();
            this.btnTestConnectSrcDB = new System.Windows.Forms.Button();
            this.chkTestConnectSrcDB = new System.Windows.Forms.CheckBox();
            this.btnTarBackPath = new System.Windows.Forms.Button();
            this.btnSrcBackPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarBackPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSrcBackPath = new System.Windows.Forms.TextBox();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.chkStopOther = new System.Windows.Forms.CheckBox();
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.chkReadyImport = new System.Windows.Forms.CheckBox();
            this.lstImportResult = new System.Windows.Forms.ListBox();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.btnGetAuthorID = new System.Windows.Forms.Button();
            this.chkAuthorID = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowConfigFile);
            this.groupBox1.Controls.Add(this.chkConfig);
            this.groupBox1.Controls.Add(this.lstExportResult);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.chkExport);
            this.groupBox1.Controls.Add(this.lblTestConnectSrcResult);
            this.groupBox1.Controls.Add(this.btnTestConnectSrcDB);
            this.groupBox1.Controls.Add(this.chkTestConnectSrcDB);
            this.groupBox1.Controls.Add(this.btnTarBackPath);
            this.groupBox1.Controls.Add(this.btnSrcBackPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTarBackPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSrcBackPath);
            this.groupBox1.Controls.Add(this.chkBackup);
            this.groupBox1.Controls.Add(this.chkStopOther);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导出前必尽事宜";
            // 
            // btnShowConfigFile
            // 
            this.btnShowConfigFile.Enabled = false;
            this.btnShowConfigFile.Location = new System.Drawing.Point(34, 75);
            this.btnShowConfigFile.Name = "btnShowConfigFile";
            this.btnShowConfigFile.Size = new System.Drawing.Size(105, 23);
            this.btnShowConfigFile.TabIndex = 15;
            this.btnShowConfigFile.Text = "查看配置文件";
            this.btnShowConfigFile.UseVisualStyleBackColor = true;
            this.btnShowConfigFile.Click += new System.EventHandler(this.btnShowConfigFile_Click);
            // 
            // chkConfig
            // 
            this.chkConfig.AutoSize = true;
            this.chkConfig.Enabled = false;
            this.chkConfig.Location = new System.Drawing.Point(6, 49);
            this.chkConfig.Name = "chkConfig";
            this.chkConfig.Size = new System.Drawing.Size(284, 19);
            this.chkConfig.TabIndex = 14;
            this.chkConfig.Text = "我已正确修改配置文件中的连接字符串";
            this.chkConfig.UseVisualStyleBackColor = true;
            this.chkConfig.CheckedChanged += new System.EventHandler(this.chkConfig_CheckedChanged);
            // 
            // lstExportResult
            // 
            this.lstExportResult.FormattingEnabled = true;
            this.lstExportResult.HorizontalScrollbar = true;
            this.lstExportResult.ItemHeight = 15;
            this.lstExportResult.Location = new System.Drawing.Point(368, 24);
            this.lstExportResult.Name = "lstExportResult";
            this.lstExportResult.Size = new System.Drawing.Size(608, 274);
            this.lstExportResult.TabIndex = 13;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Location = new System.Drawing.Point(34, 276);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(81, 34);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "立即导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkExport
            // 
            this.chkExport.AutoSize = true;
            this.chkExport.Enabled = false;
            this.chkExport.Location = new System.Drawing.Point(7, 250);
            this.chkExport.Name = "chkExport";
            this.chkExport.Size = new System.Drawing.Size(179, 19);
            this.chkExport.TabIndex = 11;
            this.chkExport.Text = "准备就绪导出源库数据";
            this.chkExport.UseVisualStyleBackColor = true;
            this.chkExport.CheckedChanged += new System.EventHandler(this.chkExport_CheckedChanged);
            // 
            // lblTestConnectSrcResult
            // 
            this.lblTestConnectSrcResult.AutoSize = true;
            this.lblTestConnectSrcResult.Location = new System.Drawing.Point(115, 223);
            this.lblTestConnectSrcResult.Name = "lblTestConnectSrcResult";
            this.lblTestConnectSrcResult.Size = new System.Drawing.Size(0, 15);
            this.lblTestConnectSrcResult.TabIndex = 10;
            // 
            // btnTestConnectSrcDB
            // 
            this.btnTestConnectSrcDB.Enabled = false;
            this.btnTestConnectSrcDB.Location = new System.Drawing.Point(34, 219);
            this.btnTestConnectSrcDB.Name = "btnTestConnectSrcDB";
            this.btnTestConnectSrcDB.Size = new System.Drawing.Size(75, 23);
            this.btnTestConnectSrcDB.TabIndex = 9;
            this.btnTestConnectSrcDB.Text = "点击测试";
            this.btnTestConnectSrcDB.UseVisualStyleBackColor = true;
            this.btnTestConnectSrcDB.Click += new System.EventHandler(this.btnTestConnectSrcDB_Click);
            // 
            // chkTestConnectSrcDB
            // 
            this.chkTestConnectSrcDB.AutoSize = true;
            this.chkTestConnectSrcDB.Enabled = false;
            this.chkTestConnectSrcDB.Location = new System.Drawing.Point(7, 193);
            this.chkTestConnectSrcDB.Name = "chkTestConnectSrcDB";
            this.chkTestConnectSrcDB.Size = new System.Drawing.Size(179, 19);
            this.chkTestConnectSrcDB.TabIndex = 8;
            this.chkTestConnectSrcDB.Text = "测试连接源数据库成功";
            this.chkTestConnectSrcDB.UseVisualStyleBackColor = true;
            this.chkTestConnectSrcDB.CheckedChanged += new System.EventHandler(this.chkTestConnectSrcDB_CheckedChanged);
            // 
            // btnTarBackPath
            // 
            this.btnTarBackPath.Enabled = false;
            this.btnTarBackPath.Location = new System.Drawing.Point(278, 163);
            this.btnTarBackPath.Name = "btnTarBackPath";
            this.btnTarBackPath.Size = new System.Drawing.Size(75, 23);
            this.btnTarBackPath.TabIndex = 7;
            this.btnTarBackPath.Text = "浏览...";
            this.btnTarBackPath.UseVisualStyleBackColor = true;
            this.btnTarBackPath.Click += new System.EventHandler(this.btnTarBackPath_Click);
            // 
            // btnSrcBackPath
            // 
            this.btnSrcBackPath.Enabled = false;
            this.btnSrcBackPath.Location = new System.Drawing.Point(278, 134);
            this.btnSrcBackPath.Name = "btnSrcBackPath";
            this.btnSrcBackPath.Size = new System.Drawing.Size(75, 23);
            this.btnSrcBackPath.TabIndex = 6;
            this.btnSrcBackPath.Text = "浏览...";
            this.btnSrcBackPath.UseVisualStyleBackColor = true;
            this.btnSrcBackPath.Click += new System.EventHandler(this.btnSrcBackPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "目标库备份文件位置:";
            // 
            // txtTarBackPath
            // 
            this.txtTarBackPath.Location = new System.Drawing.Point(172, 160);
            this.txtTarBackPath.Name = "txtTarBackPath";
            this.txtTarBackPath.Size = new System.Drawing.Size(100, 25);
            this.txtTarBackPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "源库备份文件位置:";
            // 
            // txtSrcBackPath
            // 
            this.txtSrcBackPath.Location = new System.Drawing.Point(172, 134);
            this.txtSrcBackPath.Name = "txtSrcBackPath";
            this.txtSrcBackPath.Size = new System.Drawing.Size(100, 25);
            this.txtSrcBackPath.TabIndex = 2;
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Enabled = false;
            this.chkBackup.Location = new System.Drawing.Point(6, 104);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(187, 19);
            this.chkBackup.TabIndex = 1;
            this.chkBackup.Text = "我已备份源/目标数据库";
            this.chkBackup.UseVisualStyleBackColor = true;
            this.chkBackup.CheckedChanged += new System.EventHandler(this.chkBackup_CheckedChanged);
            // 
            // chkStopOther
            // 
            this.chkStopOther.AutoSize = true;
            this.chkStopOther.Location = new System.Drawing.Point(6, 24);
            this.chkStopOther.Name = "chkStopOther";
            this.chkStopOther.Size = new System.Drawing.Size(337, 19);
            this.chkStopOther.TabIndex = 0;
            this.chkStopOther.Text = "我已禁止此程序之外的任何人/程序操作数据库";
            this.chkStopOther.UseVisualStyleBackColor = true;
            this.chkStopOther.CheckedChanged += new System.EventHandler(this.chkStopOther_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.chkReadyImport);
            this.groupBox2.Controls.Add(this.lstImportResult);
            this.groupBox2.Controls.Add(this.lblAuthorID);
            this.groupBox2.Controls.Add(this.btnGetAuthorID);
            this.groupBox2.Controls.Add(this.chkAuthorID);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 377);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导入前必尽事宜";
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImport.Location = new System.Drawing.Point(34, 108);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 34);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "开始导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // chkReadyImport
            // 
            this.chkReadyImport.AutoSize = true;
            this.chkReadyImport.Location = new System.Drawing.Point(6, 83);
            this.chkReadyImport.Name = "chkReadyImport";
            this.chkReadyImport.Size = new System.Drawing.Size(210, 19);
            this.chkReadyImport.TabIndex = 4;
            this.chkReadyImport.Text = "准备就绪, 将数据导入新库";
            this.chkReadyImport.UseVisualStyleBackColor = true;
            this.chkReadyImport.CheckedChanged += new System.EventHandler(this.chkReadyImport_CheckedChanged);
            // 
            // lstImportResult
            // 
            this.lstImportResult.FormattingEnabled = true;
            this.lstImportResult.HorizontalScrollbar = true;
            this.lstImportResult.ItemHeight = 15;
            this.lstImportResult.Location = new System.Drawing.Point(368, 24);
            this.lstImportResult.Name = "lstImportResult";
            this.lstImportResult.Size = new System.Drawing.Size(608, 349);
            this.lstImportResult.TabIndex = 3;
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(220, 58);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(0, 15);
            this.lblAuthorID.TabIndex = 2;
            // 
            // btnGetAuthorID
            // 
            this.btnGetAuthorID.Location = new System.Drawing.Point(34, 51);
            this.btnGetAuthorID.Name = "btnGetAuthorID";
            this.btnGetAuthorID.Size = new System.Drawing.Size(179, 23);
            this.btnGetAuthorID.TabIndex = 1;
            this.btnGetAuthorID.Text = "获取专用账户AuthorID";
            this.btnGetAuthorID.UseVisualStyleBackColor = true;
            this.btnGetAuthorID.Click += new System.EventHandler(this.btnGetAuthorID_Click);
            // 
            // chkAuthorID
            // 
            this.chkAuthorID.AutoSize = true;
            this.chkAuthorID.Location = new System.Drawing.Point(7, 25);
            this.chkAuthorID.Name = "chkAuthorID";
            this.chkAuthorID.Size = new System.Drawing.Size(284, 19);
            this.chkAuthorID.TabIndex = 0;
            this.chkAuthorID.Text = "我已在新站中创建导入专用管理员账户";
            this.chkAuthorID.UseVisualStyleBackColor = true;
            this.chkAuthorID.CheckedChanged += new System.EventHandler(this.chkAuthorID_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "数据同步";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstExportResult;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkExport;
        private System.Windows.Forms.Label lblTestConnectSrcResult;
        private System.Windows.Forms.Button btnTestConnectSrcDB;
        private System.Windows.Forms.CheckBox chkTestConnectSrcDB;
        private System.Windows.Forms.Button btnTarBackPath;
        private System.Windows.Forms.Button btnSrcBackPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarBackPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSrcBackPath;
        private System.Windows.Forms.CheckBox chkBackup;
        private System.Windows.Forms.CheckBox chkStopOther;
        private System.Windows.Forms.Button btnShowConfigFile;
        private System.Windows.Forms.CheckBox chkConfig;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetAuthorID;
        private System.Windows.Forms.CheckBox chkAuthorID;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.ListBox lstImportResult;
        private System.Windows.Forms.CheckBox chkReadyImport;
        private System.Windows.Forms.Button btnImport;
    }
}

