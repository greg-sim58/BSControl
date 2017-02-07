using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSControl.Models
{
    public class User
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public virtual Role Role { get; set; }
    }
}
