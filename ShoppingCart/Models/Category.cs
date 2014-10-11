using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for Categories
/// </summary>
public class Category
{
    [ScaffoldColumn(false)]
    public int CategoryID { get; set; }
    
    [Required, StringLength(200), Display(Name="Name")]
    public string CategoryName { get; set; }

    [Display(Name="Product Description")]
    public string Description { get; set; }

    public virtual ICollection<Product> Products { get; set; }

	public Category()
	{
	}
}