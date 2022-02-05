using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPK.DAO;

namespace QLPK.GUI.QuanLyDanhMuc
{
    public partial class frmDanhMucBacSi : Form
    {
        public frmDanhMucBacSi()
        {
            InitializeComponent();
        }

        void hienThiDS()
        {
            this.dgvDanhMucBacSi.DataSource = BacSiDAO.Instance.hienThiDSBacSi();
        }

        private void frmDanhMucBacSi_Load(object sender, EventArgs e)
        {
            hienThiDS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BacSiDAO.Instance.themBacSi(txtMaBacSi.Text, txtHoTen.Text, cmbGioiTinh.Text, txtDiaChi.Text, txtSDT.Text, txtTrinhDo.Text, txtChucVu.Text);
            hienThiDS();
        }

        bool checkSua = false;
        private void btnSua_Click(object sender, EventArgs e)
        {
            checkSua = !checkSua;
            if (checkSua == true)
            {
                this.btnSua.Text = "Lưu";
                this.txtMaBacSi.Enabled = false;
                this.txtHoTen.Enabled = false;
                this.cmbGioiTinh.Enabled = false;
            }
            else
            {
                var kq = MessageBox.Show("Xác nhận sự thay đổi", "Cảnh báo", MessageBoxButtons.OKCancel);
                if (kq == DialogResult.OK)
                {
                    BacSiDAO.Instance.suaBacSi(txtDiaChi.Text, txtSDT.Text, txtTrinhDo.Text, txtChucVu.Text,txtMaBacSi.Text);
                }
                else
                {
                    this.btnSua.Text = "Sửa";
                    this.txtMaBacSi.Enabled = true;
                    this.txtHoTen.Enabled = true;
                    this.cmbGioiTinh.Enabled = true;
                }    
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BacSiDAO.Instance.xoaBacSi(txtMaBacSi.Text);
        }

        private void dgvDanhMucBacSi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dgvDanhMucBacSi.Rows[e.RowIndex].Selected = true;
                txtMaBacSi.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbGioiTinh.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTrinhDo.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChucVu.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSDT.Text = dgvDanhMucBacSi.Rows[e.RowIndex].Cells[6].Value.ToString();
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
