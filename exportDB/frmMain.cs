using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace exportDB
{
    public partial class frmMain : Form
    {
        private List<Record> recordList = new List<Record>();
        private int authorId;

        internal List<Record> RecordList { get => recordList; set => recordList = value; }
        public int AuthorId { get => authorId; set => authorId = value; }

        public frmMain()
        {
            InitializeComponent();
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

        private void AddImportResult(string result)
        {
            lstImportResult.Items.Add(result);
            lstImportResult.SelectedIndex = lstImportResult.Items.Count - 1;
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
            if (chkExport.Checked)
            {
                //选中
                AddExportResult("用户已确认: 准备就绪导出源库数据");
            }
            else
            {
                //未选中
                AddExportResult("用户已放弃: 准备就绪导出源库数据");
            }
        }

        private void chkTestConnectSrcDB_CheckedChanged(object sender, EventArgs e)
        {
            btnTestConnectSrcDB.Enabled = chkTestConnectSrcDB.Checked;
            chkExport.Enabled = chkTestConnectSrcDB.Checked;
            chkExport.Checked = false;
            if (chkTestConnectSrcDB.Checked)
            {
                //选中
                AddExportResult("用户已确认: 测试连接源数据库成功");
            }
            else
            {
                //未选中
                AddExportResult("用户已放弃: 测试连接源数据库成功");
            }
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
                if (cnn.State != System.Data.ConnectionState.Closed)
                {
                    cnn.Close();
                    cnn.Dispose();
                }
            }
        }

        private void btnGetAuthorID_Click(object sender, EventArgs e)
        {
            //测试连接
            MySqlConnection cnn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["conStrMysql"].ToString());
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("select count(user) from cd_user where user='旧站导入'", cnn);
                int counter = Convert.ToInt32(cmd.ExecuteScalar());
                if (counter != 0)
                {
                    //找到了,获取其id
                    cmd.CommandText = "select id from cd_user where user='旧站导入'";
                    AuthorId = Convert.ToInt32(cmd.ExecuteScalar());
                    lblAuthorID.Text = "Author ID: " + authorId.ToString();
                    MessageBox.Show($"连接成功! 找到专用账户:旧站导入, 其ID为:{authorId.ToString()}");
                    AddImportResult($"连接成功! 找到专用账户:旧站导入, 其ID为:{authorId.ToString()}");
                }
                else
                {
                    MessageBox.Show("连接成功! 但未找到专用账户:旧站导入, 请前往新站后台创建此账户!");
                    AddImportResult("连接成功! 但未找到专用账户:旧站导入, 请前往新站后台创建此账户!");
                }
            }
            catch (Exception err)
            {

                MessageBox.Show($"连接失败[{err.Source}]:{err.Message}");
            }
            finally
            {
                if (cnn.State != System.Data.ConnectionState.Closed)
                {
                    cnn.Close();
                    cnn.Dispose();
                }
            }
        }

        private void chkAuthorID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuthorID.Checked)
            {
                //选中
                AddImportResult("用户已确认: 已在新站中创建导入专用管理员账户");
            }
            else
            {
                //未选中
                AddImportResult("用户已放弃: 已在新站中创建导入专用管理员账户");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //开始导出
            RecordList.Clear();
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["conStrMSSQL"].ToString());
            try
            {
                AddExportResult("导出正式开始...");
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from article where classid=1", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RecordList.Add(new Record()
                    {
                        Title = dr["title"].ToString(),
                        Number = dr["fwzh"].ToString(),
                        Author = dr["author"].ToString(),
                        Content = dr["content"].ToString(),
                        TheDate = Convert.ToDateTime(dr["dateandtime"]),
                        Modifytime = Convert.ToDateTime(dr["dateandtime"]),
                        Authorid = AuthorId,
                        Type = dr["tel"].ToString().Trim() == "印发" ? 3 : 1,
                        Laiyuan = dr["writefrom"].ToString(),
                        Year = Convert.ToDateTime(dr["dateandtime"]).Year,
                    });
                }
                AddExportResult($"导出完成, 共导出{RecordList.Count.ToString()}条记录.");
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
            catch (Exception err)
            {

                MessageBox.Show($"连接失败[{err.Source}]:{err.Message}");
            }
            finally
            {
                if (cnn.State != System.Data.ConnectionState.Closed)
                {
                    cnn.Close();
                    cnn.Dispose();
                }
            }
        }

        private void chkReadyImport_CheckedChanged(object sender, EventArgs e)
        {
            btnImport.Enabled = chkReadyImport.Checked;
            if (chkReadyImport.Checked)
            {
                //选中
                AddImportResult("用户以确认: 准备就绪, 将数据导入新库");
            }
            else
            {
                //未选中
                AddImportResult("用户已放弃: 准备就绪, 将数据导入新库");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["conStrMysql"].ToString());
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                AddImportResult("导入正式开始...");
                cnn.Open();
                cmd.Connection = cnn;

                RecordList.ForEach(r =>
                {
                    string title = r.Title;
                    string number = r.Number;
                    string author = r.Author;
                    string content = r.Content.Replace("'",@"\'");
                    DateTime theDate = r.TheDate;
                    DateTime modifytime = theDate;
                    int authorid = AuthorId;
                    int type = r.Type;
                    int lanmu = r.Lanmu;
                    string laiyuan = r.Laiyuan;
                    int year = r.Year;
                    int views = r.Views;
                    int shanchu = r.Shanchu;

                    string sqlStr = "insert into cd_dsms(title,number,author,content,datetime,modifytime,authorid,type,lanmu,laiyuan,year,views,shanchu)" +
                                                $" values('{title}','{number}','{author}','{content}','{theDate.ToString("yyyy-MM-dd")}','{modifytime.ToString("yyyy-MM-dd")}',{authorid},{type},{lanmu},'{laiyuan}',{year},{views},{shanchu})";
                    cmd.CommandText = sqlStr;
                    cmd.ExecuteNonQuery();
                });

                AddImportResult("导入数据完成, 开始验证导入结果...");
                cmd.CommandText = $"select count(*) from cd_dsms where authorid={AuthorId}";
                int counter = Convert.ToInt32(cmd.ExecuteScalar());
                AddImportResult($"数据验证结束, 共导入了{counter}条记录");
                AddImportResult("数据导入已全部完成, 请访问新网站验证导入结果后, 执行后续必要操作!");
            }
            catch (Exception err)
            {

                MessageBox.Show($"连接失败[{err.Source}]:{err.Message}");
            }
            finally
            {
                if (cnn.State != System.Data.ConnectionState.Closed)
                {
                    cnn.Close();
                    cnn.Dispose();
                }
            }

        }
    }
}
