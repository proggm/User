using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    internal class User
    { 
        public User() { }
        public User(string username, string password, string surname, string name, string email, string phonenumber, string gender)
        {
            Username = username;
            Password = password;
            Surname = surname;
            Name = name;
            Email = email;
            Phonenumber = phonenumber;
            Gender = gender;
        }

        public string Username { get; set; } 
        public string Password { get; set; } 
        public string Surname { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Gender { get; set; }  

            
    }
}
