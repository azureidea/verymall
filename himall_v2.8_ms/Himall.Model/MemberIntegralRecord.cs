//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MemberIntegralRecord:BaseModel
    {
        public MemberIntegralRecord()
        {
            this.Himall_MemberIntegralRecordAction = new HashSet<MemberIntegralRecordAction>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long MemberId { get; set; }
        public string UserName { get; set; }
        public MemberIntegral.IntegralType TypeId { get; set; }
        public int Integral { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
        public string ReMark { get; set; }
    
        public virtual UserMemberInfo Himall_Members { get; set; }
        public virtual ICollection<MemberIntegralRecordAction> Himall_MemberIntegralRecordAction { get; set; }
    }
}