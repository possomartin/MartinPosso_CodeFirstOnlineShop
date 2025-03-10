﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartinPosso_CodeFirstOnlineShop.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}