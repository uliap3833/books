
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Namordnick
{

using System;
    using System.Collections.Generic;
    
public partial class books
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public books()
    {

        this.basket = new HashSet<basket>();

    }


    public int id { get; set; }

    public string title { get; set; }

    public string genre { get; set; }

    public string author { get; set; }

    public Nullable<int> countInShop { get; set; }

    public Nullable<int> countInSklad { get; set; }

    public string description { get; set; }

    public string picture { get; set; }

    public Nullable<int> cost { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<basket> basket { get; set; }

}

}
