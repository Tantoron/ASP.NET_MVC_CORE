using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_MVC_CORE.Models
{
    public class Student
    {
        public int ID { get; set; }
        public String Name{ get; set; }
        public DateTime BirthDay { get; set; }
        public int AddRess_Id { get; set; }
        public String AddRess_Full { get; set; }
    }
    
}
