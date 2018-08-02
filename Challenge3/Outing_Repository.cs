using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
   public class Outing_Repository
    {
        public List<Outing> ListOfOutings = new List<Outing>();
        
        //Methods
        public void showMenu()
        {
            Console.WriteLine($"1.) Display list of all the outings\n" + "2.) Add indvidual outings to the list\n" + "3.) Calcuations\n");
        } 
        public void addOutingToTheList(Outing outing)
        {
            ListOfOutings.Add(outing);
        }

        public void removeOutingFromTheList(Outing outing)
        {
            ListOfOutings.Remove(outing);
        }

        public List<Outing> showListOfOuting()
        {
            return ListOfOutings;
        }
    }
}
