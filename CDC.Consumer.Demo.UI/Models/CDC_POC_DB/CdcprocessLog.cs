using System;
using System.Collections.Generic;

#nullable disable

namespace CDC.Consumer.Demo.UI.Models.CDC_POC_DB
{
    public partial class CdcprocessLog
    {
        public int ProcessLogId { get; set; }
        public byte[] Lsn { get; set; }
        public string TableName { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
