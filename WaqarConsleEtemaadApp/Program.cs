
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


            program.UserType();

        

            Console.ReadLine();
        }



        public void UserType()
        {


            Console.WriteLine("Please Select Your User Type \n\n\n" +
                              "Press 1 for Admin\n" +
                              "Press 2 for Customer\n"

            );



            var Usertype = int.Parse(Console.ReadLine());





            switch (Usertype)
            {

                case 1: // Admin


                    LoginView("Admin");

                    break;

                case 2: // Customer

                    bool isUserExist = LoginView("Customer");

                    if (isUserExist)
                    {
                        CustomerMenu();
                    }

                    break;

            }




        }


        public  bool LoginView(string roleName)
        {
            Console.Clear();
            Console.WriteLine($"\n\t\t {roleName}, Welcome To Etemaad Store\n\n");


            Console.Write("Please Enter UserName :");
            var UserName = Console.ReadLine();


            Console.Write("\n\nPlease Enter Password :");
            var password = Console.ReadLine();


            List<Login> LoginList = loginService.SelectAll();


            var isUserExist = LoginList.Any(x => x.UserName.ToLower() == UserName.ToLower() && x.Password == password);


            if (isUserExist)
            {
                Console.Clear();
                Console.WriteLine("Welcome in Etemaad Store");
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" Sorry!!! UserName & Password does not Exist !!!");
                return false;
            }

        }


        public void CustomerMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n Press 1 for Checking Items\n" +
                              " Press 2 for Buying Items ");


            var customerMenuOptions = int.Parse(Console.ReadLine());





            switch (customerMenuOptions)
            {

                case 1: // Checking Items


                    CheckItems();

                    break;

                case 2: // Buying Items


                    BuyingItems();


                    break;


            }










        }

        public void CheckItems()
        {
            Console.Clear();
            string[] products = new string[4] {"Daal", "Cheeni", "Ata", "Dahi"};

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(products[i]);
            }


        }


        public void BuyingItems()
        {
            Console.Clear();
            string[] products = new string[4] { "Daal", "Cheeni", "Ata", "Dahi" };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Press {i + 1 } for {products[i]}  " );
            }


            var SelcectProduct = int.Parse(Console.ReadLine());





            switch (SelcectProduct)
            {

                case 1: // Daal

                    Console.Clear();

                    Console.WriteLine("You Selected Daal \n\n\n ");

                    Console.WriteLine("How much quantity do you want to Buy : ");
                    var quantity = int.Parse(Console.ReadLine());


                    break;


                case 2: // Cheeeni

                    break;

                case 3: // Ata

                    break;

                case 4: // Dahi

                    break;

               


            }




        }


    

    }
}
