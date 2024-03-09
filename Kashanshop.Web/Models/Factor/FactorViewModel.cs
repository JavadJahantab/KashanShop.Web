

using Kashanshop.Domain.Factor;

namespace Kashanshop.Web.Models.Factor;

public class FactorViewModel
{
    public int Code { get; set; }
    public int UserId { get; set; } 
    public decimal Total { get; set; }
    public decimal Discount { get; set; }
    public decimal PricePaid { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string PhoneNumber { get; set; }
    public FactorStatus FactorStatus { get; set; }
    public PayWay PayWay { get; set; } 
    public DateTime CreationDate { get ; set; }

}