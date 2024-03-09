namespace Kashanshop.Domain.User;

public class ReceiverAddress : BaseEntity
{
    public User User { get; set; }
    public int UserId { get; set; }
    public string Titel { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string State { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public int PostalCode { get; set; }
    public int PhoneNumber { get; set; }
    
}