using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_aes_data_encrytion.Entity
{
    public partial class User
    {
        public User()
        { 
        }
         
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; }
        
    }
}
