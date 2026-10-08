namespace bai_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // Main container
            GroupBox grpInput = new GroupBox();
            GroupBox grpList = new GroupBox();

            // Input group controls
            Label lblMaVT = new Label();
            TextBox txtMaVT = new TextBox();
            Label lblTenVT = new Label();
            TextBox txtTenVT = new TextBox();
            Label lblDonVi = new Label();
            ComboBox cboDonVi = new ComboBox();
            Label lblDonGia = new Label();
            TextBox txtDonGia = new TextBox();

            // Buttons
            Button btnThemMoi = new Button();
            Button btnCapNhat = new Button();
            Button btnXoaDong = new Button();
            Button btnXoaToanBo = new Button();

            // ListView
            ListView lvwItems = new ListView();
            ColumnHeader colMaVT = new ColumnHeader();
            ColumnHeader colTenVT = new ColumnHeader();
            ColumnHeader colDonVi = new ColumnHeader();
            ColumnHeader colDonGia = new ColumnHeader();

            // Input Group
            grpInput.Text = "Khung nhập liệu";
            grpInput.Location = new Point(10, 10);
            grpInput.Size = new Size(380, 400);
            grpInput.Controls.Add(lblMaVT);
            grpInput.Controls.Add(txtMaVT);
            grpInput.Controls.Add(lblTenVT);
            grpInput.Controls.Add(txtTenVT);
            grpInput.Controls.Add(lblDonVi);
            grpInput.Controls.Add(cboDonVi);
            grpInput.Controls.Add(lblDonGia);
            grpInput.Controls.Add(txtDonGia);
            grpInput.Controls.Add(btnThemMoi);
            grpInput.Controls.Add(btnCapNhat);
            grpInput.Controls.Add(btnXoaDong);
            grpInput.Controls.Add(btnXoaToanBo);

            // Labels and TextBoxes
            lblMaVT.Text = "Mã vật tư:";
            lblMaVT.Location = new Point(10, 20);
            lblMaVT.Size = new Size(80, 20);

            txtMaVT.Location = new Point(100, 20);
            txtMaVT.Size = new Size(260, 20);

            lblTenVT.Text = "Tên vật tư:";
            lblTenVT.Location = new Point(10, 50);
            lblTenVT.Size = new Size(80, 20);

            txtTenVT.Location = new Point(100, 50);
            txtTenVT.Size = new Size(260, 20);

            lblDonVi.Text = "Đơn vị tính:";
            lblDonVi.Location = new Point(10, 80);
            lblDonVi.Size = new Size(80, 20);

            cboDonVi.Location = new Point(100, 80);
            cboDonVi.Size = new Size(260, 20);
            cboDonVi.Items.AddRange(new string[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;

            lblDonGia.Text = "Đơn giá nhập:";
            lblDonGia.Location = new Point(10, 110);
            lblDonGia.Size = new Size(80, 20);

            txtDonGia.Location = new Point(100, 110);
            txtDonGia.Size = new Size(260, 20);

            // Buttons
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.Location = new Point(10, 150);
            btnThemMoi.Size = new Size(85, 30);

            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Location = new Point(105, 150);
            btnCapNhat.Size = new Size(85, 30);

            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.Location = new Point(200, 150);
            btnXoaDong.Size = new Size(85, 30);

            btnXoaToanBo.Text = "Xóa toàn bộ";
            btnXoaToanBo.Location = new Point(295, 150);
            btnXoaToanBo.Size = new Size(85, 30);

            // List Group
            grpList.Text = "Khung danh sách";
            grpList.Location = new Point(400, 10);
            grpList.Size = new Size(410, 400);
            grpList.Controls.Add(lvwItems);

            // ListView
            lvwItems.Location = new Point(10, 20);
            lvwItems.Size = new Size(390, 360);
            lvwItems.View = View.Details;
            lvwItems.FullRowSelect = true;
            lvwItems.GridLines = true;

            colMaVT.Text = "Mã VT";
            colMaVT.Width = 80;
            colTenVT.Text = "Tên VT";
            colTenVT.Width = 120;
            colDonVi.Text = "Đơn vị tính";
            colDonVi.Width = 80;
            colDonGia.Text = "Đơn giá";
            colDonGia.Width = 100;

            lvwItems.Columns.AddRange(new ColumnHeader[] { colMaVT, colTenVT, colDonVi, colDonGia });

            // Store controls as fields
            _txtMaVT = txtMaVT;
            _txtTenVT = txtTenVT;
            _cboDonVi = cboDonVi;
            _txtDonGia = txtDonGia;
            _btnThemMoi = btnThemMoi;
            _btnCapNhat = btnCapNhat;
            _btnXoaDong = btnXoaDong;
            _btnXoaToanBo = btnXoaToanBo;
            _lvwItems = lvwItems;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 420);
            Controls.Add(grpInput);
            Controls.Add(grpList);
            Text = "Quản lý danh mục Vật tư / Linh kiện";
            StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        public TextBox _txtMaVT;
        public TextBox _txtTenVT;
        public ComboBox _cboDonVi;
        public TextBox _txtDonGia;
        public Button _btnThemMoi;
        public Button _btnCapNhat;
        public Button _btnXoaDong;
        public Button _btnXoaToanBo;
        public ListView _lvwItems;
    }
}
