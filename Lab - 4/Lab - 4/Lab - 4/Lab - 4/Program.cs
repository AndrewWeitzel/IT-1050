using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___4
{
    class Program
    {
        static void Main(string[] args)
        {//Ticket Types
            PurchaseItem childTixMat = new PurchaseItem("Child Matinee Ticket", 3.99, 0);
            PurchaseItem childTixEve = new PurchaseItem("Child Evening Ticket", 3.99, 0);
            PurchaseItem adultTixMat = new PurchaseItem("Adult Matinee Ticket", 5.99, 0);
            PurchaseItem adultTixEve = new PurchaseItem("Adult Evening Ticket", 10.99, 0);
            PurchaseItem seniorTixMat = new PurchaseItem("Senior Matinee Ticket", 4.50, 0);
            PurchaseItem seniorTixEve = new PurchaseItem("Senior Evening Ticket", 8.50, 0);
            //Concessions
            PurchaseItem smSoda = new PurchaseItem("Small Soda", 3.50, 0);
            PurchaseItem lgSoda = new PurchaseItem("Large Soda", 5.99, 0);
            PurchaseItem hotDog = new PurchaseItem("Hot Dog", 3.99, 0);
            PurchaseItem popcorn = new PurchaseItem("Popcorn", 4.50, 0);
            PurchaseItem candy = new PurchaseItem("Candy", 1.99, 0);




            MovieMethods transation = new MovieMethods();
            transation.TicketBuy(childTixMat, adultTixMat, seniorTixMat, childTixEve, adultTixEve, seniorTixEve);
            transation.Concessions(smSoda, lgSoda, hotDog, popcorn, candy);
            transation.Reciept(0.08, childTixMat, childTixEve, adultTixMat, adultTixEve, seniorTixMat, seniorTixEve, smSoda, lgSoda, hotDog, popcorn, candy);
        }
    }
}
