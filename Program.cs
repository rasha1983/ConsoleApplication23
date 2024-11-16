using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication23
{
    class UserAccount
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        UserAccount(UserAccount account)
        {
            Email = account.Email;
            Username = account.Username;
            Password = account.Password;

        }
        public UserAccount(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
        }
    }
    class Program
    {
        static void Main()
        {
            ArrayList accounts = new ArrayList();
            accounts.Add(new UserAccount("user1@ ex.com", "user1", "pass1"));
            accounts.Add(new UserAccount("user2@ ex.com", "user2", "pass2"));

            Console.WriteLine("enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("enter password:");
            string password = Console.ReadLine();

            bool isAuthenticated = false;
            foreach (object obj in accounts)
            {
                UserAccount account = obj as UserAccount;
                if (account != null)
                {

                    if (account.Username == username && account.Password == password)
                    {
                        isAuthenticated = true;
                        break;
                    }
                    }
                }
                if (isAuthenticated)
                {
                    Console.WriteLine("Correct credentials");
                }
                else
                {
                    Console.WriteLine(" lnvaild credentials");
                }
            }
        }
    }





        
    

