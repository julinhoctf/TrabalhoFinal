using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicMVC.Models
{
    public class SignatureCustomer
    {
        public byte Id { get; set; }
        public String Name { get; set; }
        public byte Bonus { get; set; }
        public byte EndsIn { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}