using SQLite;

namespace Login_MAUI.Models
{
    public class ProductInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
