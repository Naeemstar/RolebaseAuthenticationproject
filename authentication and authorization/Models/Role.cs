using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace authentication_and_authorization.Models
{
    public class Role
    { [Key]
        public int ROLEID { get; set; }
        public string name { get; set; }
    }
}