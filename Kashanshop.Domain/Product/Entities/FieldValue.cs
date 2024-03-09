namespace Kashanshop.Domain;

public class FieldValue:BaseEntity
{
    public Field Field { get; set; }
    public int FieldId { get; set; }
    public string ValueOfField { get; set; }
}