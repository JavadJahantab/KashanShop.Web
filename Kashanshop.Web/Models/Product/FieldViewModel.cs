using System.ComponentModel;
using Kashanshop.Domain;
using Microsoft.VisualBasic.FileIO;

namespace Kashanshop.Web.Models.Product;

public class FieldViewModel
{
    public string Titel { get; set; }
    public TypeOfFiled FieldType { get; set; }
    public int? CategoryId { get; set; }
}