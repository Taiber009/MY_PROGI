//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sold_Comics
    {
        public int ID { get; set; }
        public int ID_Comics { get; set; }
        public int ID_User { get; set; }
        public int Price { get; set; }
        public System.DateTime Sale_Date { get; set; }
    
        public virtual Comics Comics { get; set; }
        public virtual User User { get; set; }
    }
}
