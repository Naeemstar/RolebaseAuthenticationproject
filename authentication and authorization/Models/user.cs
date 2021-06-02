using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace authentication_and_authorization.Models
{
    public class user
    {[Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; } 
     

        public int ROLEID { get; set; }
        public Role Roles{ get; set; }
    }
}