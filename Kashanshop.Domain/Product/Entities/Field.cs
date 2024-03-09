using System.ComponentModel;
using Microsoft.VisualBasic.FileIO;

namespace Kashanshop.Domain;

public class Field:BaseEntity
{
    public string Titel { get; set; }
    public TypeOfFiled FieldType { get; set; }
    public ProductCategory? Category { get; set; }
    public int? CategoryId { get; set; }
    public List<ProductField> ProductFields { get; set; }
    public List<FieldValue> FieldValues { get; set; }
}