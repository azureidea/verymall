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
    
    public partial class OrderRefundlogsInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long RefundId { get; set; }
        public string Operator { get; set; }
        public System.DateTime OperateDate { get; set; }
        public string OperateContent { get; set; }
        public Nullable<int> ApplyNumber { get; set; }
        public Himall.CommonModel.Enum.OrderRefundStep Step { get; set; }
        public string Remark { get; set; }
    }
}
