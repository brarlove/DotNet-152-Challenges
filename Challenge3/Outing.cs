using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public class Outing
    {
        // properties
        public string EventType { get; set; }
        public int NumberOfPeopleAttended { get; set; }
        public DateTime Date { get; set; }
        public double CostPerPerson { get; set; }
        public double CostPerEvent { get; set; }

        //Constructor
        public Outing(string eventType, int numberOfPeopleAttendend, DateTime date, double costPerPerson, double costPerEvent)
        {
            EventType = eventType;
            NumberOfPeopleAttended = numberOfPeopleAttendend;
            Date = date;
            CostPerPerson = costPerPerson;
            CostPerEvent = costPerEvent;
        }
    }
}
