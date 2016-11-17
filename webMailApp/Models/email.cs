using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webMailApp.Models
{
    public class email
    {
        public int Id { get; set; }
        public string endereco { get; set; }
        public string assunto { get; set; }
        public string corpo { get; set; }
        public string ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}