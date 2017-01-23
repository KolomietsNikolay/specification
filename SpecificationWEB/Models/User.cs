using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpecificationWEB.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string EMail { get; set; }

        public long Balance { get; set; }

        public GroupUsers Group { get; set; }

    }
}