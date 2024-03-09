namespace Kashanshop.Domain;

public class ProductField:BaseEntity
{
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public Field Field { get; set; }
    public int FieldId { get; set; }
    public FieldValue FieldValue { get; set; }
    public int FieldValueId { get; set; }
}