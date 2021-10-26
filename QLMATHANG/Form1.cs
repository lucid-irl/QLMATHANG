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
            // TODO: This line of code loads data into the 'dataSet1.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.dataSet1.NCC);
            // TODO: This line of code loads data into the 'dataSet.MATHANG' table. You can move, or remove it, as needed.
            this.mATHANGTableAdapter.Fill(this.dataSet.MATHANG);
            loadData();
        }

        DataAccess da = new DataAccess();
        String query;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            query = "insert into MATHANG (MAHANG, TENHANG, NGAYNHAP, SOLUONG, MANCC) values ('" + txtMaHang.Text + "', '" + txtTenHang.Text +"', '" + timeNhap.Value +"', '" + txtSoLuong.Text.ToString() +"', '"+ cbNCC.Text +"' )";
            da.setData(query);
            clearAll();
            loadData();
        }

        public void loadData()
        {
            query = "select * from MATHANG";
            DataSet ds = da.getData(query);
            mATHANGDataGridView.DataSource = ds.Tables[0];
        }

        public void clearAll()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            timeNhap.Refresh();
            txtSoLuong.Clear();
            cbNCC.SelectedIndex = -1;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mATHANGTableAdapter.FillBy(this.dataSet.MATHANG);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mATHANGTableAdapter.FillBy1(this.dataSet.MATHANG);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.mATHANGTableAdapter.FillBy1(this.dataSet1.MATHANG);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
