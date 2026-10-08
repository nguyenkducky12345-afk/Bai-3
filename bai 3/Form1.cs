namespace bai_3
{
    public partial class Form1 : Form
    {
        private List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();

            // Subscribe to events
            _btnThemMoi.Click += BtnThemMoi_Click;
            _btnCapNhat.Click += BtnCapNhat_Click;
            _btnXoaDong.Click += BtnXoaDong_Click;
            _btnXoaToanBo.Click += BtnXoaToanBo_Click;
            _lvwItems.SelectedIndexChanged += LvwItems_SelectedIndexChanged;
        }

        // Thêm mới item
        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string maVT = _txtMaVT.Text.Trim();

                // Kiểm tra trùng Mã VT
                if (items.Any(i => i.MaVatTu == maVT))
                {
                    MessageBox.Show("Mã vật tư đã tồn tại trong danh sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Item newItem = new Item(
                    _txtMaVT.Text.Trim(),
                    _txtTenVT.Text.Trim(),
                    _cboDonVi.SelectedItem.ToString(),
                    decimal.Parse(_txtDonGia.Text)
                );

                items.Add(newItem);
                AddItemToListView(newItem);
                ClearInputs();
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Cập nhật item
        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (_lvwItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateInput())
            {
                int selectedIndex = _lvwItems.SelectedIndices[0];
                string newMaVT = _txtMaVT.Text.Trim();
                string oldMaVT = items[selectedIndex].MaVatTu;

                // Kiểm tra nếu mã VT mới trùng với mã VT khác
                if (newMaVT != oldMaVT && items.Any(i => i.MaVatTu == newMaVT))
                {
                    MessageBox.Show("Mã vật tư mới đã tồn tại trong danh sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                items[selectedIndex].MaVatTu = newMaVT;
                items[selectedIndex].TenVatTu = _txtTenVT.Text.Trim();
                items[selectedIndex].DonViTinh = _cboDonVi.SelectedItem.ToString();
                items[selectedIndex].DonGiaNhap = decimal.Parse(_txtDonGia.Text);

                _lvwItems.Items[selectedIndex].Text = items[selectedIndex].MaVatTu;
                _lvwItems.Items[selectedIndex].SubItems[1].Text = items[selectedIndex].TenVatTu;
                _lvwItems.Items[selectedIndex].SubItems[2].Text = items[selectedIndex].DonViTinh;
                _lvwItems.Items[selectedIndex].SubItems[3].Text = items[selectedIndex].DonGiaNhap.ToString("N2");

                ClearInputs();
                _lvwItems.SelectedItems[0].Selected = false;
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xóa dòng được chọn
        private void BtnXoaDong_Click(object sender, EventArgs e)
        {
            if (_lvwItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int selectedIndex = _lvwItems.SelectedIndices[0];
                items.RemoveAt(selectedIndex);
                _lvwItems.Items.RemoveAt(selectedIndex);
                ClearInputs();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xóa toàn bộ
        private void BtnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng, không có gì để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                items.Clear();
                _lvwItems.Items.Clear();
                ClearInputs();
                MessageBox.Show("Xóa toàn bộ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Khi chọn 1 dòng trong ListView
        private void LvwItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lvwItems.SelectedItems.Count > 0)
            {
                int selectedIndex = _lvwItems.SelectedIndices[0];
                Item selectedItem = items[selectedIndex];

                _txtMaVT.Text = selectedItem.MaVatTu;
                _txtTenVT.Text = selectedItem.TenVatTu;
                _cboDonVi.SelectedItem = selectedItem.DonViTinh;
                _txtDonGia.Text = selectedItem.DonGiaNhap.ToString("N2");
            }
        }

        // Helper methods
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(_txtMaVT.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vật tư!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtMaVT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(_txtTenVT.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vật tư!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtTenVT.Focus();
                return false;
            }

            if (_cboDonVi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _cboDonVi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(_txtDonGia.Text) || !decimal.TryParse(_txtDonGia.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập đơn giá nhập hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private void AddItemToListView(Item item)
        {
            ListViewItem lvItem = new ListViewItem(item.MaVatTu);
            lvItem.SubItems.Add(item.TenVatTu);
            lvItem.SubItems.Add(item.DonViTinh);
            lvItem.SubItems.Add(item.DonGiaNhap.ToString("N2"));
            _lvwItems.Items.Add(lvItem);
        }

        private void ClearInputs()
        {
            _txtMaVT.Clear();
            _txtTenVT.Clear();
            _cboDonVi.SelectedIndex = -1;
            _txtDonGia.Clear();
            _txtMaVT.Focus();
        }
    }
}
