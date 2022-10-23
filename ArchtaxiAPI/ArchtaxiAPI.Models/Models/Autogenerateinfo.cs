using System;
using System.Collections.Generic;

namespace ArchtaxiAPI.Models.Models
{
    public partial class Autogenerateinfo
    {
        public int Id { get; set; }
        public string? WebServiceName { get; set; }
        public string? TableName { get; set; }
        public string? Datacomponentname { get; set; }
        public string? BusinessComponentname { get; set; }
        public bool? FetchSp { get; set; }
        public bool? InsertSp { get; set; }
        public bool? UpdateSp { get; set; }
        public bool? DeleteSp { get; set; }
        public bool? ReturnDataset { get; set; }
        public bool? ReturnDataReader { get; set; }
        public bool? ReturnDataTable { get; set; }
        public bool? SpuExecuteNonQuery { get; set; }
        public bool? SpuExecuteScalar { get; set; }
        public bool? ReturnXmlReader { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
