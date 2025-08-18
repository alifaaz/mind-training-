using System;
using System.Diagnostics.Contracts;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.IO;
namespace ShoppingCart
{
    public class User
    {

        public string userName { set; get; }
        public string userPassword { set; get; }
        public string userPhoneNum { set; get; }
        public static List<User> usersList = new List<User>();
        // public User(string name, string phone, string pass)
        // {
        //     userName = name;
        //     userPhoneNum = phone;
        //     userPassword = pass;

        // }
        public void CreateAccount()
        {
            Console.WriteLine("Enter Your Name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number:");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            String password = Console.ReadLine();
            string pattren = @"^077|078\d{8}$";
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name!.");
                return;
            }
            if (!Regex.IsMatch(phone, pattren))
            {
                return;
            }
            if (password.Length < 8)
            {
                return;
            }
            foreach (User user in usersList)
            {
                if (user.userPhoneNum == phone)
                {
                    Console.WriteLine("the user is registered.");
                    return;
                }
            }
            usersList.Add(new User { userName = name, userPassword = password, userPhoneNum = phone });
            Console.WriteLine("Account created successfully!");
        }
        public void SaiveUserToFile()
        {
            using (StreamWriter sw = new StreamWriter("users.txt"))
            {
                foreach (User user in usersList)
                {
                    sw.WriteLine($"{user.userName} , {user.userPhoneNum} , {user.userPassword}");
                }
            }
        }
        public void LoadUsersFromFile()
        {
            usersList.Clear();
            if (File.Exists("users.txt"))
            {
                string[] lines = File.ReadAllLines("users.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        usersList.Add(new User());
                    }
                }
            }
        }
        public void showUsers()
        {
            foreach (User user in usersList)
            {
                Console.WriteLine($"{user.userName}, {user.userPhoneNum}, {user.userPassword}");
            }
        }
        public bool LogIn(string phone, string password)
        {
            foreach (var user in usersList)
            {
                if (phone == user.userPhoneNum && password == user.userPassword)
                {
                    Console.WriteLine($"Welcome:{user.userName}");
                    return true;
                }
            }
            Console.WriteLine("Login Failed.");
            return false;
        }
        public bool LogOut()
        {
            return false;

        }

    }
}

