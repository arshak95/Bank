using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProjectOOP
{
    public interface Ecanomy
    {
          int ID { get; set; }
        void RichMoney();

    }
    public interface Arjuyt 
     
    {
        int Money { get; set; }
    }
    public class Bank :Ecanomy, Arjuyt
    {
        private int transfer;
        public int Trasfer
        {
            set
            {
                transfer = value;
            }
            get
            {
                return  transfer;
            }
        }
       public int ID { get; set; } = 55224488;
       public int Money { get; set; } = 50000;
       public void RichMoney()
        {
            
            if (Trasfer >= 500)
            {
                Money += Trasfer;
            }
            else
            {
                Console.WriteLine("Bavakan che poxancum katarelu hamar ");




            }
          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Console.WriteLine("=============Convers bank============= ");
            Console.WriteLine($"Dzer depozity kazmum e {bank.Money}");
            Console.WriteLine("Poxancman gumari qanaky greq" );
            Console.WriteLine("hastatvox minimal arjeqn e 500 $");
            bank.Trasfer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Duq katareciq poxancum");
            bank.RichMoney();
            Console.WriteLine($"Dzer gumary kazmum e {bank.Money} $");

        }
    }
}
