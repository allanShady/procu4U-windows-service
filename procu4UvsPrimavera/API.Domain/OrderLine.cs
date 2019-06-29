using System;

namespace procu4UvsPrimavera.API.Domain
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; } = 0;
        public double VatPercentage { get; set; }
        public double ApprovedQuantity { get; set; }
        //public int ApprovedBy { get; set; }
        public DateTime DeliveredDate { get; set; }
        //Get the same unit of the products currentLine
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public ProductSize ProductSize { get; set; }
        public int ProductSizeId { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        //This field is fullfilled with product mutching property
        public string Brand { get; set; }
        //This field is fullfilled with product mutching property
        public string Model { get; set; }
        //This field is fullfilled with product mutching property
        public string PartNumber { get; set; }
        public double Total { get; set; }
        public double VAT { get; set; } = 0;
        public bool IsApproved { get; set; } = false;
        public bool? Exported { get; set; } = false;
        public DateTime? ExportedDate { get; }
    }
}
