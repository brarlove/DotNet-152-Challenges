using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
   public class Claim_Repo
    {
        public List<Claim> repoList = new List<Claim>();

        //Methods
        public void showMenu()
        {
            Console.WriteLine($"1. See all claims \n" + "2. Take care of next claim \n" + "3. Enter a new claim \n");
        }

        public void addClaimToList(Claim item)
        {
            repoList.Add(item);
        }

        public void  removeClaimFromList(Claim item)
        {
            repoList.Remove(item);
        }

        public List<Claim> showRepoList()
        {
            return repoList;
        }
    }
}
