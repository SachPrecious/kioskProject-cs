using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    class Program
    {
        static void Main(string[] args)
        {
            const string mainMenuChoice = "1";
            const string purchaseMenuChoice = "2";
            const string maintenanceMenuChoice = "3";
            const string kioskResultsChoice = "4";
            const string purchaseItemChoice = "5";
            const string detailedBillChoice = "6";
            const string addKioskItemChoice = "7";
            const string addKioskRawMatl = "8";
            const string clearKioskChoice = "9";
            const string updateKioskRawMatlQty = "10";
            const string quitApp = "999";


            string menuChoice = string.Empty;
            Console.WriteLine("Enter Menu Choice");
            menuChoice= Convert.ToString(Console.ReadLine());
            while(menuChoice != quitApp)
            {
                if (menuChoice == mainMenuChoice)
                {
                    Console.WriteLine("MAIN MENU");
                    Console.WriteLine("==========");
                    Console.WriteLine("1. Purchase");
                    Console.WriteLine("2. Maintenance");
                    Console.WriteLine("3. Kiosk Results");
                    Console.WriteLine("Q. Quit");

                    Console.WriteLine("Enter Your Choice");
                    var choice = Console.ReadLine();
                    if (choice == "1")
                        menuChoice = purchaseMenuChoice;
                    else if (choice == "2")
                        menuChoice = maintenanceMenuChoice;
                    else if (choice == "3")
                        menuChoice = kioskResultsChoice;
                    else if (choice == "Q" || choice == "q")
                        menuChoice = quitApp;
                }
                else if (menuChoice == maintenanceMenuChoice) 
                {

                    Console.WriteLine("MAINTENANCE");
                    Console.WriteLine("============");
                    Console.WriteLine("1. Add item to kiosk");
                    Console.WriteLine("2. Add raw material to kiosk");
                    Console.WriteLine("3. Clear kiosk");
                    Console.WriteLine("4. Update raw material quantity");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "1") 
                        menuChoice = addKioskItemChoice;
                    else if (choice == "2")
                        menuChoice = addKioskRawMatl;
                    else if (choice == "3")
                        menuChoice = clearKioskChoice;
                    else if (choice == "4") 
                        menuChoice = updateKioskRawMatlQty;
                    else if (choice == "Q" || choice == "q") 
                        menuChoice = mainMenuChoice;
                    
                }
                else if (menuChoice == purchaseMenuChoice)
                {
                    Console.WriteLine("PURCHASE");
                    Console.WriteLine("============");
                    Console.WriteLine("1. Purchase Item");
                    Console.WriteLine("2. Detailed Bill");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "1")
                        menuChoice = purchaseItemChoice;
                    else if (choice == "2") 
                        menuChoice = detailedBillChoice;
                    else if (choice == "3")
                        menuChoice = quitApp;
                    else if (choice == "Q" || choice == "q") 
                        menuChoice = mainMenuChoice;
                }
                else if (menuChoice == purchaseItemChoice)
                {
                    Console.WriteLine("PURCHASE ITEM");
                    Console.WriteLine("=============");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "Q" || choice == "q")
                        menuChoice = purchaseMenuChoice;
                }
                else if (menuChoice == detailedBillChoice)
                {
                    Console.WriteLine("DETAILED BILL");
                    Console.WriteLine("=============");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "Q" || choice == "q")
                        menuChoice = purchaseMenuChoice;
                }
                else if (menuChoice == addKioskItemChoice)
                {
                    Console.WriteLine("ADD KIOSK ITEM");
                    Console.WriteLine("==============");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "Q" || choice == "q")
                        menuChoice = maintenanceMenuChoice;
                }
                else if (menuChoice == addKioskRawMatl)
                {
                    Console.WriteLine("ADD RAW MATERIAL");
                    Console.WriteLine("================");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "Q" || choice == "q") 
                        menuChoice = maintenanceMenuChoice;
                }
                else if (menuChoice == clearKioskChoice)
                {
                    Console.WriteLine("CLEAR KIOSK");
                    Console.WriteLine("===========");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "Q" || choice == "q") 
                        menuChoice = maintenanceMenuChoice;
                }
                else if (menuChoice == updateKioskRawMatlQty)
                {
                    Console.WriteLine("UPDATE RAW MATERIALS");
                    Console.WriteLine("====================");
                    Console.WriteLine("Q. Quit");
                    Console.Write("Enter your choice: ");
                    var choice = Console.ReadLine();
                    if (choice == "Q" || choice == "q") 
                        menuChoice = maintenanceMenuChoice;
                }

            }



        }
    }
}
