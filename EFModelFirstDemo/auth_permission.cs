//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFModelFirstDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class auth_permission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public auth_permission()
        {
            this.auth_group_permissions = new HashSet<auth_group_permissions>();
            this.auth_user_user_permissions = new HashSet<auth_user_user_permissions>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int content_type_id { get; set; }
        public string codename { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auth_group_permissions> auth_group_permissions { get; set; }
        public virtual django_content_type django_content_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auth_user_user_permissions> auth_user_user_permissions { get; set; }
    }
}
