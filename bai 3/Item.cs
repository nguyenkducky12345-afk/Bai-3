namespace bai_3
{
    public class Item
    {
        public string MaVatTu { get; set; }
        public string TenVatTu { get; set; }
        public string DonViTinh { get; set; }
        public decimal DonGiaNhap { get; set; }

        public Item(string maVatTu, string tenVatTu, string donViTinh, decimal donGiaNhap)
        {
            MaVatTu = maVatTu;
            TenVatTu = tenVatTu;
            DonViTinh = donViTinh;
            DonGiaNhap = donGiaNhap;
        }
    }
}
