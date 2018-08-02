using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Claim Car = new Claim(1, "Car", "Car accident on 465.", 400.00, DateTime.Parse("4/25/18"),DateTime.Parse("4/27/18"), true);
            Claim House = new Claim(2, "House", "House fire in kitchen", 4000.00, DateTime.Parse("4/26/18"), DateTime.Parse("4/28/18"), true);
            Claim Theft = new Claim(3, "Theft", "Stolen pancakes", 4.00, DateTime.Parse("4/27/18"), DateTime.Parse("6/01/18"), false);

            Claim_Repo claimRepo = new Claim_Repo();
            claimRepo.addClaimToList(Car);
            claimRepo.addClaimToList(House);
            claimRepo.addClaimToList(Theft);
            List<Claim> claimItems = claimRepo.showRepoList();
            Console.WriteLine("Welcome to the claims department.");

            string Response = "null";
            while (Response != "4")
            {
                Console.WriteLine("Would you like see our claims menu? (y/n)");
                string Reply1 = Console.ReadLine();
                if (Reply1 == "y")
                {
                    claimRepo.showMenu();
                    Console.WriteLine("Choose a menu item number listed above");
                    int Reply2 = int.Parse(Console.ReadLine());

                    if (Reply2 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("ClaimID\t" + " " + "Claim Type\t" + " " + "Description\t" + " " + "Claim Amount\t" + " " + "Date Of Incident\t" + " " + "Date Of Claim\t" + " " + "Is Valid\t");
                        foreach (Claim item in claimItems)
                        {           
                            Console.WriteLine($"{item.ClaimID}\t" + " " + $"{item.ClaimType}\t" + " " + $"{item.Description}\t" + " " + $"{item.ClaimAmount}\t" + " " + $"{item.DateOfIncident}\t" + " " + $"{item.DateOfClaim}\t" + " " + $"{item.IsValid}\t");
                        }
                    }
                    else if (Reply2 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine($"ClaimID: {Car.ClaimID}\n" + $"ClaimType: {Car.ClaimType}\n" + $"Description: {Car.Description}\n" + $"ClaimAmount: {Car.ClaimAmount}\n" + $"DateOfIncident: {Car.DateOfIncident}\n" + $"DateOfClaim: {Car.DateOfClaim}\n" + $"IsVaild: {Car.IsValid}\n");
                        Console.WriteLine("Do you want to deal with this claim now? (y/n)");
                        string Reply3 = Console.ReadLine();
                        if (Reply3 == "y")
                        {
                            claimRepo.removeClaimFromList(Car);
                        }
                        else if (Reply3 == "n")
                        {
                            Console.Clear();
                            claimRepo.showMenu();
                        }
                    }
                    else if (Reply2 == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter the claim ID:");
                        string ID = Console.ReadLine();
                        Console.WriteLine("Enter the claim type:");
                        string Type = Console.ReadLine();
                        Console.WriteLine("Enter claim description");
                        string description = Console.ReadLine();
                        Console.WriteLine("Date of incident");
                        DateTime incident = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Date of Claim");
                        DateTime claim = DateTime.Parse(Console.ReadLine());
                        TimeSpan span = new TimeSpan(30, 0, 0, 0);
                        if(claim- incident <= span)
                        {
                            Console.WriteLine("Is Valid");
                        }
                        else
                        {
                            Console.WriteLine("is not Valid");
                        }
                    }
                }                
            }           
        }
    }
}
