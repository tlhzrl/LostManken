using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostManken.Model
{
    public class AuthenticatedUserVM
    {
        public string UserName { get; set; }
        public bool Authenticated { get; set; }
    }
}
