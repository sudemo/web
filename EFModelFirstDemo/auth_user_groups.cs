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
    
    public partial class auth_user_groups
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int group_id { get; set; }
    
        public virtual auth_group auth_group { get; set; }
        public virtual auth_user auth_user { get; set; }
    }
}
