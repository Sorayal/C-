using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Filter.Models
{
    public class FilterRule
    {
        public int FilterId { get; set; }
        public string RemoteIpAddress { get; set; }
        public string FilterPort { get; set; }
        public string FilterProtocol { get; set; }
        public string MailRecipient { get; set; }
    }
}
