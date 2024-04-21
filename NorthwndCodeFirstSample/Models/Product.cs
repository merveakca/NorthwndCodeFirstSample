using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwndCodeFirstSample.Models;
public class Product : BaseModel
{
    [MaxLength(40)]
    public string ProductName { get; set; }

    
    public int? SupplierID { get; set; }
    [ForeignKey("SupplierID")]
    public Supplier? Supplier { get; set; }

    
    public int? CategoryID { get; set; }
    [ForeignKey("CategoryID")]
    public Category? Category { get; set; }

    [MaxLength(20)]
    public string? QuantityPerUnit { get; set; }

    public double? UnitPrice { get; set; }
    public Int16? UnitsInStock { get; set; }
    public Int16? UnitsOnOrder { get; set; }
    public Int16? ReorderLevel { get; set; }
    public Boolean Discontinued { get; set; }

}
