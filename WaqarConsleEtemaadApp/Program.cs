
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaqarConsleEtemaadApp.DBServices;
using WaqarConsleEtemaadApp.Entities;

namespace WaqarConsleEtemaadApp
{
    class Program
    {
        private LoginService loginService = new LoginService();



        static void Main(string[] args)
        {
            Program program = new Program();

            program.LoginView();

            Console.ReadLine();
        }



        public  void LoginView()
        {
            Console.WriteLine("\t\tWelcome To Etemaad Store");


            Console.Write("Please Enter UserName :");
            var UserName = Console.ReadLine();


            Console.Write("\n\nPlease Enter Password :");
            var password = Console.ReadLine();


            List<Login> LoginList = loginService.SelectAll();


            var isUserExist = LoginList.Any(x => x.UserName == UserName && x.Password == password);


            if (isUserExist)
            {
                Console.Clear();
                Console.WriteLine("Welcome in Etemaad Store");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" Sorry!!! UserName & Password does not Exist !!!");
            }

        }



    }
}
