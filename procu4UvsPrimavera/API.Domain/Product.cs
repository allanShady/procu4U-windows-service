namespace procu4UvsPrimavera.API.Domain
{
    public class Product
    {   
        public int Id { get; set; }
        public string Identifier { get; set; }       
        public string Description { get; set; }     
        public double Price { get; set; }        
        public Currency Currency { get; set; }       
        public double AvailableStock { get; set; }        
        public Unit Unit { get; set; }        
        public Color Color { get; set; }       
        public ProductSize Size { get; set; }       
        public int SizeId { get; set; }    
        public int UnitId { get; set; }     
        public int ColorId { get; set; }
        public int CurrencyId { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }   
        public string PartNumber { get; set; }  
        public double VatPercentage { get; set; }   
        public string CodVAT { get; set; }
    }
}
