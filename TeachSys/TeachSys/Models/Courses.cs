//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeachSys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Courses
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Nums { get; set; }
        public int MajorID { get; set; }
        public string Term { get; set; }
        public string Memo { get; set; }
        public int Status { get; set; }
    }
}
