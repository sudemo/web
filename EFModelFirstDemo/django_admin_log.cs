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
    
    public partial class django_admin_log
    {
        public int id { get; set; }
        public System.DateTime action_time { get; set; }
        public string object_id { get; set; }
        public string object_repr { get; set; }
        public int action_flag { get; set; }
        public string change_message { get; set; }
        public Nullable<int> content_type_id { get; set; }
        public int user_id { get; set; }
    
        public virtual auth_user auth_user { get; set; }
        public virtual django_content_type django_content_type { get; set; }
    }
}
