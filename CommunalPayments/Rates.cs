using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalPayments
{
    public class Rates
    {
        public Rates()
        {
            Heating = rand.Next(300, 500);
            Water = rand.Next(150, 300);
            Gas = rand.Next(150, 300);
            CurrentRepairs = rand.Next(100, 150);
        }

        private Random rand = new Random();
        public int Heating { get; set; }
        public int Water { get; set; }
        public int Gas { get; set; }
        public int CurrentRepairs { get; set; }
        public bool IsSeason { get; set; }
        public int Privileges { get; set; }
        public string TypeOfPayment { get; set; }
        public int Summary { get; set; }
        public int Total { get; set; }

        public override string ToString()
        {
           string result =  string.Format($"Type of payment: {TypeOfPayment} \n Summary: {Summary} \n " +
                   $"Privileges: {Privileges} \n Total: {Total} ");

            return result;
        }
    }
}
