using System;
using System.Collections.Generic;

namespace procu4UvsPrimavera.API.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
        public double? SubTotal { get; set; }
        public double? Total { get; set; }
        public double TotalVAT { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public User RequestedByUser { get; set; }
        public int RequestedBy { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }
        public User ApprovedByUser { get; set; }
        public int ApprovedBy { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
        public IEnumerable<OrderLine> OrderLines { get; set; }
        public IEnumerable<Attachment> Attachments { get; set; }
        public bool ?Exported {get; set;}
        public DateTime ?ExportedDate { get;}
    }
}
