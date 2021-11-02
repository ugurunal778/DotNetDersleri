namespace AdoNetSample
{
    public class ProductDto
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string SupplierName { get; set; }
        public int ProductId { get; internal set; }
        public int UnitsInStock { get; set; }
        public int UnitsInOrder { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
