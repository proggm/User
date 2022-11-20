using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
            new User("user1", "password", "Martynenko", "Viktor", "vik@mail.ru", "+77777777777","Male"),
            new User("user2", "paSSword", "Dorofeev", "Ruslan", "rus@mail.ru", "+71111111111","Female"),
            new User("user3", "PASsword", "Omarova", "Raziyat", "raz@mail.ru", "+78888888888","Female"),
            new User("user4", "passWord", "Abakarov", "Magomed", "mag@mail.ru", "+79999999999", "Male"),
            new User("user5", "PASSword", "Djamalt", "Amir", "ami@mail.ru", "+72222222222", "Male"),
            };
            User user = new User();
            Console.Write("Введите имя пользователя: ");
            user.Username = Console.ReadLine() ?? "";
            Console.Write("Введите пароль: ");
            user.Password = Console.ReadLine() ?? "";
            Console.Write("Введите фамилию: ");
            user.Surname = Console.ReadLine() ?? "";
            Console.Write("Введите имя : ");
            user.Name = Console.ReadLine() ?? "";
            Console.Write("Введите почту: ");
            user.Email = Console.ReadLine() ?? "";
            Console.Write("Введите номер телефона: ");
            user.Phonenumber = Console.ReadLine() ?? "";
            Console.Write("Введите пол: ");
            user.Gender = Console.ReadLine() ?? "";
            User Users = users.FirstOrDefault(item => item.Username == user.Username);
            if (Users != null)
            {
                Console.WriteLine("Такой пользователь существует");
            }
            else
            {
                users.Add(user);
            }
            Console.ReadKey();
        }
    }
}
