using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Outing Golf = new Outing("Golf", 5, DateTime.Parse("7/12/18"), 20.00, 100.00);
            Outing Bowling = new Outing("Bowling", 5, DateTime.Parse("6/12/18"), 20.00, 100.00);
            Outing Park = new Outing("Park", 5, DateTime.Parse("5/12/18"), 20.00, 100.00);
            Outing Concert = new Outing("Concert", 5, DateTime.Parse("4/12/18"), 20.00, 100.00);

            Outing_Repository outingRepo = new Outing_Repository();
            outingRepo.addOutingToTheList(Golf);
            outingRepo.addOutingToTheList(Bowling);
            outingRepo.addOutingToTheList(Park);
            outingRepo.addOutingToTheList(Concert);

            List<Outing> outingList = outingRepo.showListOfOuting();
            string response = "null";
            while(response != "4")
            {
                outingRepo.showMenu();
                Console.WriteLine("Choose a item number listed above.");
                int reply2 = int.Parse(Console.ReadLine());
                double golfTotal = 0;
                double bowlingTotal = 0;
                double parkTotal = 0;
                double concertTotal = 0;

                if (reply2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Event\t" + "PeopleAttended\t" + "Date\t" + "Cost per person\t" + "Cost per Event");
                    foreach (Outing outing in outingList)
                    {
                        Console.WriteLine($"{outing.EventType}\t" + $"{outing.NumberOfPeopleAttended}\t" + $"{outing.Date}\t" + $"{outing.CostPerPerson}\t" + $"{outing.CostPerEvent}");
                    }
                }
                else if (reply2 == 2)
                {
                    Console.Clear();
                    Console.Write("Enter the event type: ");
                    string eventType = Console.ReadLine();
                    Console.Write("Number of people that attended: ");
                    int attended = int.Parse(Console.ReadLine());
                    Console.Write("Date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Total cost per person for the event: ");
                    double costPerPerson = double.Parse(Console.ReadLine());
                    Console.Write("Total cost for the event: ");
                    double costForTheEvent = double.Parse(Console.ReadLine());
                    Outing outingObject = new Outing(eventType, attended, date, costPerPerson, costForTheEvent);
                    outingRepo.addOutingToTheList(outingObject);
                    foreach (Outing item in outingList)
                    {
                        Console.WriteLine($"{item.EventType}\t" + $"{item.NumberOfPeopleAttended}\t" + $"{item.Date}\t" + $"{item.CostPerPerson}\t" + $"{item.CostPerEvent}");
                    }
                }
                else if(reply2 == 3)
                {
                    foreach(Outing item in outingList)
                    {
                        if(item.EventType == "Golf")
                        {
                            golfTotal = golfTotal + item.CostPerEvent;
                        }
                        else if(item.EventType == "Bowling")
                        {
                            bowlingTotal = bowlingTotal + item.CostPerEvent;
                        }
                        else if(item.EventType == "Park")
                        {
                            parkTotal = parkTotal + item.CostPerEvent;
                        }
                        else if(item.EventType == "Concert")
                        {
                            concertTotal = concertTotal + item.CostPerEvent;
                        }
                    }
                    double total = golfTotal + bowlingTotal + parkTotal + concertTotal;
                    Console.WriteLine("Total of all events: " + total + " , " + "Total of Golf: " + golfTotal + " , " + "Total of Bowling: " + bowlingTotal + " , " + "Total of park: " + parkTotal + " , " + "Total of concert: " + concertTotal);
                }
            }
        }
    }
}
