using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
   
        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }


        public class Part
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
   }
