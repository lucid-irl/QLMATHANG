using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMATHANG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mATHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mATHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void mATHANGBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mATHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            loadData();
        }

        DataAccess data = new DataAccess();
        String query;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            query = "insert into MATHANG (MAHANG, TENHANG, NGAYNHAP, SOLUONG, MANCC) values ('" + txtMaHang.Text + "', '" + txtTenHang.Text +"', '" + timeNhap.Value +"', '" + txtSoLuong.Text.ToString() +"', '"+ cbNCC.Text +"' )";
            data.setData(query);
            clearAll();
            loadData();
        }

        public void loadData()
        {
            List<Item> itemList = data.getAllItems();
            mATHANGDataGridView.DataSource = itemList;
        }

        public void clearAll()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            timeNhap.Refresh();
            txtSoLuong.Clear();
            cbNCC.SelectedIndex = -1;
        }

        public void getDataToCB()
        {
            try
            {
                string query = "select MANCC, TENNCC from NCC";
                data.fillDataToComboBox(query);
                DataSet ds = new DataSet();
                cbNCC.DisplayMember = "TENNCC";
                cbNCC.ValueMember = "MANCC";
                cbNCC.DataSource = ds.Tables["NCC"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!");
            }
        }
    }
}
