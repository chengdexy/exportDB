using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace exportDB
{
    public partial class frmMain : Form
    {
        private List<Record> list = new List<Record>();

        internal List<Record> List { get => list; set => list = value; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void chkStopOther_CheckedChanged(object sender, EventArgs e)
        {
            chkConfig.Enabled = chkStopOther.Checked;
            btnShowConfigFile.Enabled = chkStopOther.Checked;
            chkBackup.Enabled = chkStopOther.Checked;
            chkConfig.Checked = false;
            chkBackup.Checked = false;

            if (chkStopOther.Checked)
            {
                //选中时
                AddExportResult("用户已确认: 禁止此程序之外的任何人/程序操作数据库");
            }
            else
            {
                //未选中
                AddExportResult("用户已放弃: 禁止此程序之外的任何人/程序操作数据库");
            }
        }

        /// <summary>
        /// 向lstExportResult中加入内容
        /// </summary>
        /// <param name="result">内容</param>
        private void AddExportResult(string result)
        {
            lstExportResult.Items.Add(result);
            lstExportResult.SelectedIndex = lstExportResult.Items.Count - 1;
        }

        private void chkConfig_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfig.Checked)
            {
                //选中
                AddExportResult("用户已确认: 已正确修改配置文件中的连接字符串");
                string msSqlCnnStr = System.Configuration.ConfigurationManager.AppSettings["conStrMSSQL"].ToString();
                string[] splitArray = msSqlCnnStr.Split(';');
                for (int i = 0; i < splitArray.Length; i++)
                {
                    AddExportResult("..." + splitArray[i]);
                }
            }
            else
            {
                //未选中
                AddExportResult("用户已放弃: 已正确修改配置文件中的连接字符串");
            }
        }

        private void chkExport_CheckedChanged(object sender, EventArgs e)
        {
            btnExport.Enabled = chkExport.Checked;
        }

        private void chkTestConnectSrcDB_CheckedChanged(object sender, EventArgs e)
        {
            btnTestConnectSrcDB.Enabled = chkTestConnectSrcDB.Checked;
            chkExport.Enabled = chkTestConnectSrcDB.Checked;
            chkExport.Checked = false;
        }

        private void chkBackup_CheckedChanged(object sender, EventArgs e)
        {
            btnSrcBackPath.Enabled = chkBackup.Checked;
            btnTarBackPath.Enabled = chkBackup.Checked;
            chkTestConnectSrcDB.Enabled = chkBackup.Checked;
            chkTestConnectSrcDB.Checked = false;

            if (chkBackup.Checked)
            {
                //选中
                AddExportResult("用户已确认: 已备份源/目标数据库");
            }
            else
            {
                AddExportResult("用户已放弃: 已备份源/目标数据库");
            }
        }

        private void btnShowConfigFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", AppDomain.CurrentDomain.BaseDirectory + "\\App.config");
        }

        private void btnSrcBackPath_Click(object sender, EventArgs e)
        {
            ofdMain.FileName = "";
            ofdMain.Filter = "MDF文件(*.mdf)|*.mdf";
            ofdMain.Title = "备份的MDF文件";
            ofdMain.ShowDialog();
            if (!string.IsNullOrEmpty(ofdMain.FileName.Trim()))
            {
                AddExportResult("用户已确认MDF文件位置: " + ofdMain.FileName);
                txtSrcBackPath.Text = ofdMain.FileName;
            }
            ofdMain.FileName = "";
            ofdMain.Filter = "LDF文件(*.ldf)|*.ldf";
            ofdMain.Title = "备份的LDF文件";
            ofdMain.ShowDialog();
            if (!string.IsNullOrEmpty(ofdMain.FileName.Trim()))
            {
                AddExportResult("用户已确认LDF文件位置: " + ofdMain.FileName);
                txtSrcBackPath.Text += ";" + ofdMain.FileName;
            }
        }

        private void btnTarBackPath_Click(object sender, EventArgs e)
        {
            ofdMain.FileName = "";
            ofdMain.Filter = "SQL文件(*.sql)|*.sql";
            ofdMain.Title = "备份的SQL文件";
            ofdMain.ShowDialog();
            if (!string.IsNullOrEmpty(ofdMain.FileName.Trim()))
            {
                AddExportResult("用户已确认SQL文件位置: " + ofdMain.FileName);
                txtTarBackPath.Text = ofdMain.FileName;
            }
        }

        private void btnTestConnectSrcDB_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["conStrMSSQL"].ToString());
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from article where classid=1", cnn);
                string resultCount = cmd.ExecuteScalar().ToString();
                MessageBox.Show($"测试连接成功: 找到合法数据{resultCount}条.");
                lblTestConnectSrcResult.Text = $"找到{resultCount}条.";
                AddExportResult($"测试连接成功: 找到合法数据{resultCount}条.");
            }
            catch (Exception err)
            {
                MessageBox.Show($"连接失败[{err.Source}]:{err.Message}");
            }
            finally
            {
                if (cnn.State!=System.Data.ConnectionState.Closed)
                {
                    cnn.Close();
                    cnn.Dispose();
                }
            }
        }
    }
}
