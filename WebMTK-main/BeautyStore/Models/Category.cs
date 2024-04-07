//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeautyStore.Models
{
    using System;
    using System.Collections.Generic;
    using BeautyStore.DesignPattern.Prototype;
    
    public partial class Category : CategoryClone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        public CategoryClone Clone()
        {
            Category newcategory = new Category();
            newcategory.CategoryName = CategoryName;
            newcategory.CategoryImage = CategoryImage;
            return newcategory;
        }
    }
    
}
