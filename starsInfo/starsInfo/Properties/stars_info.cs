//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace starsInfo.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class stars_info
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> distance { get; set; }
        public Nullable<int> radius { get; set; }
        public Nullable<int> blind { get; set; }
        public Nullable<int> classId { get; set; }
        public string photo { get; set; }
    
        public virtual spectrum_class spectrum_class { get; set; }
    }
}
