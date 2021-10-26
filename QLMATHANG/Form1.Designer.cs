namespace QLMATHANG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAHANGLabel;
            System.Windows.Forms.Label tENHANGLabel;
            System.Windows.Forms.Label nGAYNHAPLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label mANCCLabel;
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.timeNhap = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new QLMATHANG.DataSet();
            this.mATHANGTableAdapter = new QLMATHANG.DataSetTableAdapters.MATHANGTableAdapter();
            this.tableAdapterManager = new QLMATHANG.DataSetTableAdapters.TableAdapterManager();
            this.nCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nCCTableAdapter = new QLMATHANG.DataSetTableAdapters.NCCTableAdapter();
            this.mATHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.mAHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYNHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAHANGLabel = new System.Windows.Forms.Label();
            tENHANGLabel = new System.Windows.Forms.Label();
            nGAYNHAPLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mANCCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHANGLabel
            // 
            mAHANGLabel.AutoSize = true;
            mAHANGLabel.Location = new System.Drawing.Point(64, 100);
            mAHANGLabel.Name = "mAHANGLabel";
            mAHANGLabel.Size = new System.Drawing.Size(49, 13);
            mAHANGLabel.TabIndex = 1;
            mAHANGLabel.Text = "Mã hàng";
            // 
            // tENHANGLabel
            // 
            tENHANGLabel.AutoSize = true;
            tENHANGLabel.Location = new System.Drawing.Point(64, 126);
            tENHANGLabel.Name = "tENHANGLabel";
            tENHANGLabel.Size = new System.Drawing.Size(53, 13);
            tENHANGLabel.TabIndex = 3;
            tENHANGLabel.Text = "Tên hàng";
            // 
            // nGAYNHAPLabel
            // 
            nGAYNHAPLabel.AutoSize = true;
            nGAYNHAPLabel.Location = new System.Drawing.Point(64, 153);
            nGAYNHAPLabel.Name = "nGAYNHAPLabel";
            nGAYNHAPLabel.Size = new System.Drawing.Size(59, 13);
            nGAYNHAPLabel.TabIndex = 5;
            nGAYNHAPLabel.Text = "Ngày nhập";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(64, 178);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(49, 13);
            sOLUONGLabel.TabIndex = 7;
            sOLUONGLabel.Text = "Số lượng";
            // 
            // mANCCLabel
            // 
            mANCCLabel.AutoSize = true;
            mANCCLabel.Location = new System.Drawing.Point(64, 204);
            mANCCLabel.Name = "mANCCLabel";
            mANCCLabel.Size = new System.Drawing.Size(75, 13);
            mANCCLabel.TabIndex = 9;
            mANCCLabel.Text = "Nhà cung cấp";
            // 
            // txtMaHang
            // 
            this.txtMaHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mATHANGBindingSource, "MAHANG", true));
            this.txtMaHang.Location = new System.Drawing.Point(178, 97);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(284, 20);
            this.txtMaHang.TabIndex = 2;
            // 
            // txtTenHang
            // 
            this.txtTenHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mATHANGBindingSource, "TENHANG", true));
            this.txtTenHang.Location = new System.Drawing.Point(178, 123);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(284, 20);
            this.txtTenHang.TabIndex = 4;
            // 
            // timeNhap
            // 
            this.timeNhap.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mATHANGBindingSource, "NGAYNHAP", true));
            this.timeNhap.Location = new System.Drawing.Point(178, 149);
            this.timeNhap.Name = "timeNhap";
            this.timeNhap.Size = new System.Drawing.Size(284, 20);
            this.timeNhap.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mATHANGBindingSource, "SOLUONG", true));
            this.txtSoLuong.Location = new System.Drawing.Point(178, 175);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(284, 20);
            this.txtSoLuong.TabIndex = 8;
            // 
            // cbNCC
            // 
            this.cbNCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mATHANGBindingSource, "MANCC", true));
            this.cbNCC.DataSource = this.nCCBindingSource;
            this.cbNCC.DisplayMember = "TENNCC";
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(178, 201);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(284, 21);
            this.cbNCC.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(495, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(495, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(495, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "DANH SÁCH MẶT HÀNG";
            // 
            // mATHANGBindingSource
            // 
            this.mATHANGBindingSource.DataMember = "MATHANG";
            this.mATHANGBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATHANGTableAdapter
            // 
            this.mATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MATHANGTableAdapter = this.mATHANGTableAdapter;
            this.tableAdapterManager.NCCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLMATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nCCTableAdapter
            // 
            this.nCCTableAdapter.ClearBeforeFill = true;
            // 
            // mATHANGDataGridView
            // 
            this.mATHANGDataGridView.AllowUserToAddRows = false;
            this.mATHANGDataGridView.AllowUserToDeleteRows = false;
            this.mATHANGDataGridView.AutoGenerateColumns = false;
            this.mATHANGDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mATHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mATHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHANGDataGridViewTextBoxColumn,
            this.tENHANGDataGridViewTextBoxColumn,
            this.nGAYNHAPDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.mANCCDataGridViewTextBoxColumn});
            this.mATHANGDataGridView.DataSource = this.mATHANGBindingSource;
            this.mATHANGDataGridView.Location = new System.Drawing.Point(34, 242);
            this.mATHANGDataGridView.Name = "mATHANGDataGridView";
            this.mATHANGDataGridView.ReadOnly = true;
            this.mATHANGDataGridView.Size = new System.Drawing.Size(594, 220);
            this.mATHANGDataGridView.TabIndex = 14;
            // 
            // mAHANGDataGridViewTextBoxColumn
            // 
            this.mAHANGDataGridViewTextBoxColumn.DataPropertyName = "MAHANG";
            this.mAHANGDataGridViewTextBoxColumn.HeaderText = "MAHANG";
            this.mAHANGDataGridViewTextBoxColumn.Name = "mAHANGDataGridViewTextBoxColumn";
            this.mAHANGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENHANGDataGridViewTextBoxColumn
            // 
            this.tENHANGDataGridViewTextBoxColumn.DataPropertyName = "TENHANG";
            this.tENHANGDataGridViewTextBoxColumn.HeaderText = "TENHANG";
            this.tENHANGDataGridViewTextBoxColumn.Name = "tENHANGDataGridViewTextBoxColumn";
            this.tENHANGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYNHAPDataGridViewTextBoxColumn
            // 
            this.nGAYNHAPDataGridViewTextBoxColumn.DataPropertyName = "NGAYNHAP";
            this.nGAYNHAPDataGridViewTextBoxColumn.HeaderText = "NGAYNHAP";
            this.nGAYNHAPDataGridViewTextBoxColumn.Name = "nGAYNHAPDataGridViewTextBoxColumn";
            this.nGAYNHAPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mANCCDataGridViewTextBoxColumn
            // 
            this.mANCCDataGridViewTextBoxColumn.DataPropertyName = "MANCC";
            this.mANCCDataGridViewTextBoxColumn.HeaderText = "MANCC";
            this.mANCCDataGridViewTextBoxColumn.Name = "mANCCDataGridViewTextBoxColumn";
            this.mANCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 484);
            this.Controls.Add(this.mATHANGDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(mAHANGLabel);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(tENHANGLabel);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(nGAYNHAPLabel);
            this.Controls.Add(this.timeNhap);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(mANCCLabel);
            this.Controls.Add(this.cbNCC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource mATHANGBindingSource;
        private DataSetTableAdapters.MATHANGTableAdapter mATHANGTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.DateTimePicker timeNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource nCCBindingSource;
        private DataSetTableAdapters.NCCTableAdapter nCCTableAdapter;
        private System.Windows.Forms.DataGridView mATHANGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYNHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANCCDataGridViewTextBoxColumn;
    }
}

