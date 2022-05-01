using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Thanh
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private string tenDevice;
        private string deviceFullFilePath;
        private int soLuongBanSaoLuu;
        private string strRestore;
        private int backupsetId;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThamSoThoiGian_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (btnThamSoThoiGian.Checked == true)
            {
                MessageBox.Show("Chức năng dùng để phục hồi lại dữ liệu sau khi delete,insert, update lỗi ", "", MessageBoxButtons.OK);
                txtInfoPhucHoi.Visible = true;
                dtpDate.Visible = true;
                dtptTimeStop.Visible = true;
                lblinfo.Visible = true;
                ckiNit.Visible = false;
            }
            else
            {
                txtInfoPhucHoi.Visible = false;
                dtpDate.Visible = false;
                dtptTimeStop.Visible = false;
                lblinfo.Visible = false;
                ckiNit.Visible = true;


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtptTimeStop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckiNit_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RestoreDiaglog(String dtStopAt)
        {
            soLuongBanSaoLuu = int.Parse(((DataRowView)bdsBackup[0])["position"].ToString());
            DialogResult rsdiaglog = MessageBox.Show("Thời gian phục hồi: " + dtStopAt, Program.Db + " - Restore dialog", MessageBoxButtons.OKCancel);
            if (rsdiaglog == DialogResult.OK)
            {
                String strFullPathBackLog = Program.defaultDeviceFilePath + Program.Db + ".TRN";
                strRestore += "BACKUP LOG " + Program.Db + " TO DISK='" + strFullPathBackLog + "' WITH INIT, NORECOVERY; \n "
                   + "RESTORE DATABASE " + Program.Db + " FROM " + tenDevice + " WITH FILE= " + soLuongBanSaoLuu + ", NORECOVERY; \n "
                    + "RESTORE DATABASE " + Program.Db + " FROM DISK='" + strFullPathBackLog + "' WITH STOPAT='" + dtStopAt
                    + "'\n ALTER DATABASE " + Program.Db + " SET MULTI_USER";
                int checkErr = Program.ExecSqlNonQuery(strRestore, Program.connstr, "lỗi phục hồi cơ sở dữ liệu");
                if (checkErr == 0)
                {
                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 20;
                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        this.PrgLoad.Value = i;
                        PrgLoad.PerformStep();
                        Thread.Sleep(10);

                    }
                    PrgLoad.Visible = false;
                    MessageBox.Show(" Phục hồi thời gian lúc " + dtStopAt + " Thành công!", "", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(" Phục hồi thất bại ", "", MessageBoxButtons.OK);
                   
                }
            }

            else
            {
                return;
            }
        }
        private void taoDevice()
        {
            tenDevice = "DEVICE_" + Program.Db;
            deviceFullFilePath = Program.defaultDeviceFilePath + tenDevice + ".BAK";

            String query = "USE master\n EXEC sp_addumpdevice '" + Program.device_type + "', '" + tenDevice + "','" + deviceFullFilePath + "'";
            try
            {

                Program.myreader = Program.ExecSqlDataReader(query);
                if (Program.myreader != null)
                {

                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 10;

                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        PrgLoad.Value = i;

                        PrgLoad.PerformStep();
                        Thread.Sleep(10);

                    }

                    PrgLoad.Visible = false;

                    MessageBox.Show(" Tạo Device thành công!", "", MessageBoxButtons.OK);
                    this.backup_devicesTableAdapter.Fill(this.tempdbDataSet.backup_devices);
                    btnTaoDevice.Enabled = false;
                    btnSaoLuu.Enabled = true;
                    txbTenDevice.Text = tenDevice;
                }
                else MessageBox.Show(" Tạo Device thất bại!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                return;
            }

            Program.conn.Close();

        }

        private void loadbansaoluu()
        {

            if (Program.Db.Trim() == "") return;
            try
            {
                this.dataTable1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.dataTable1TableAdapter.Fill(this.tempdbDataSet.DataTable1, Program.Db);
                if (bdsBackup.Count == 0)
                    txtSL.Text = "0";
                else
                {
                    soLuongBanSaoLuu = int.Parse(((DataRowView)bdsBackup[0])["position"].ToString());

                    txtSL.Text = soLuongBanSaoLuu.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
         
            this.backup_devicesTableAdapter.Fill(this.tempdbDataSet.backup_devices);
           
            this.databaseNameTableAdapter.Fill(this.tempdbDataSet.databaseName);
            this.databaseNameTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;

            btnTaoDevice.Enabled = btnPhucHoi.Enabled = btnSaoLuu.Enabled = false;
            this.PrgLoad.Visible = false;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Program.Db = ((DataRowView)bdsListDatabase[bdsListDatabase.Position])["name"].ToString().Trim();
            txbTenDB.Text = Program.Db;
            tenDevice = "DEVICE_" + Program.Db;
            deviceFullFilePath = Program.defaultDeviceFilePath + tenDevice + ".BAK";
            int checkTrungDevice = bdsDevice.Find("name", tenDevice);

            if (checkTrungDevice == -1)
            {
                this.txbTenDevice.Text = "Chưa có Device";
                this.btnTaoDevice.Enabled = true;
                this.btnSaoLuu.Enabled = false;
            }
            else
            {
                this.txbTenDevice.Text = ((DataRowView)bdsDevice[checkTrungDevice])["name"].ToString().Trim();
                this.btnTaoDevice.Enabled = false;
                this.btnSaoLuu.Enabled = true;
                this.btnPhucHoi.Enabled = true;
                this.btnThamSoThoiGian.Enabled = true;
            }
            loadbansaoluu();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnTaoDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Directory.Exists(Program.defaultDeviceFilePath) == true)
            {
                taoDevice();
            }
            else {
                MessageBox.Show("Đường dẫn thư mục không tồn tại !");
            }
        }

        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Program.Db.Trim() == "" || tenDevice == "") return;

            String strBackup = "BACKUP DATABASE " + Program.Db + " TO " + tenDevice;
            if (ckiNit.Checked == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa các sao lưu cũ ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    strBackup = strBackup + " WITH INIT";
                else
                {
                    return;
                }
            }

            try
            {

                Program.myreader = Program.ExecSqlDataReader(strBackup);

                if (Program.myreader != null)
                {
                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 10;
                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        PrgLoad.Value = i;
                        PrgLoad.PerformStep();
                        Thread.Sleep(10);
                    }
                    PrgLoad.Visible = false;
                    MessageBox.Show(" Tạo Backup thành công!", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show(" Tạo Backup thất bại!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                return;
            }
            Program.conn.Close();
            loadbansaoluu();
        }

        private void txtInfoPhucHoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            int err;
            if (this.bdsBackup.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu nào để phục hồi", "!", MessageBoxButtons.OK);
                return;
            }
            if (soLuongBanSaoLuu == 0)
            {
                MessageBox.Show("Vui lòng chọn bản sao lưu phục hồi ", "!", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            if (txbTenDB.Text.Trim() == "" || tenDevice == "") return;
            strRestore = "ALTER DATABASE " + txbTenDB.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + "USE tempdb ";
            if (btnThamSoThoiGian.Checked == false)
            {
                strRestore += "RESTORE DATABASE " + txbTenDB.Text + " FROM " + tenDevice + " WITH FILE= " + soLuongBanSaoLuu + ",REPLACE " + "ALTER DATABASE " + Program.Db + " SET MULTI_USER";
                
                err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "lỗi phục hồi cơ sở dữ liệu");
                if (err == 0)
                {
                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 20;
                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        this.PrgLoad.Value = i;

                        PrgLoad.PerformStep();
                        Thread.Sleep(10);
                    }
                    PrgLoad.Visible = false;
                    MessageBox.Show(" Phục hồi thành công!", "", MessageBoxButtons.OK);

                }
            }
            else
            {
                DateTime ngaygioBK = (DateTime)((DataRowView)bdsBackup[0])["backup_start_date"];
                DateTime dateStop = dtpDate.Value.Date + dtptTimeStop.Value.TimeOfDay;
                String dt = dtpDate.Value.ToString("yyyy-MM-dd") + " " + dtptTimeStop.Value.ToString("HH:mm:ss");
                if ((dtpDate.Value.Date < ngaygioBK.Date) || (dtpDate.Value.Date == ngaygioBK.Date && dtptTimeStop.Value.Ticks < ngaygioBK.TimeOfDay.Ticks))
                {
                    MessageBox.Show(" Thời điểm muốn phục hồi phải sau thời điểm sao lưu đã chọn", "", MessageBoxButtons.OK);
                    return;

                }
                if (DateTime.Now < dateStop)
                {
                    MessageBox.Show(" Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (Directory.Exists(Program.defaultDeviceFilePath) == true)
                    {
                        RestoreDiaglog(dt);
                    }
                }
            }
        }

     

        private void gridView2_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
         
            backupsetId = int.Parse(((DataRowView)bdsBackup[bdsBackup.Position])["backup_set_id"].ToString());
            soLuongBanSaoLuu = int.Parse(((DataRowView)bdsBackup[bdsBackup.Position])["position"].ToString());
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int err;
            if (MessageBox.Show("Bạn có muốn xóa bản sao lưu này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string deleteQuery = " EXEC [dbo].[sp_delete_backuptalbe] " + backupsetId;
                err = Program.ExecSqlNonQuery(deleteQuery, Program.connstr, "lỗi xóa bản backup cơ sở dữ liệu");
                if (err == 0)
                {
                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 20;
                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        this.PrgLoad.Value = i;

                        PrgLoad.PerformStep();
                        Thread.Sleep(10);
                    }
                    PrgLoad.Visible = false;
                    MessageBox.Show(" Xóa bản backup thành công!", "", MessageBoxButtons.OK);
                    loadbansaoluu();
                }
              
            else
            {
                return;
            }
            
            }
           

        }

        private void txbTenDB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}