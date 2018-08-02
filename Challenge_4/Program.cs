using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Email LoveBrar = new Email("Love", "Brar", "Current", "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
            Email Mani = new Email("Mani", "Singh", "Past", "It's been a long time since we've heard from you, we want you back");
            Email Akem = new Email("Akem", "Brar", "Potential", "We currently have the lowest rates on Helicopter Insurance!");
        }
    }
}
