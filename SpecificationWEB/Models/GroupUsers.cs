using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpecificationWEB.Models
{
    public class GroupUsers
    {
        public int ID { get; set; }

        public string NameGroup { get; set; }

        public ICollection<User> Users {get;set;}
    }
}