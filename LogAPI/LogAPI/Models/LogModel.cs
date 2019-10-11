using System;

namespace LogAPI.Models
{
    public class LogModel
    {
        public Guid ID { get; set; }
        public DateTime EventDateTime { get; set; }
        public string User { get; set; }
        public string Module { get; set; }
        public string Func { get; set; }
        public string EventDesc { get; set; }


    }
}
