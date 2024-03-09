using Kashanshop.Domain.User;

namespace Kashanshop.Domain.Factor;

public class Factor: BaseEntity
{
    public int Code { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; } 
    public Decimal Total { get; set; }
    public Decimal Discount { get; set; }
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
    public List<FactorItem> FactorItems { get; set; }
}