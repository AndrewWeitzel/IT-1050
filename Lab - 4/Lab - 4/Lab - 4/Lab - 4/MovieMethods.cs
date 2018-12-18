using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___4
{
    class MovieMethods
    {
        static double total = 0;
        public bool loop = true;
        static double discountTotal = 0;
        public bool more;

        #region Tickets
        public void TicketBuy(PurchaseItem mat1, PurchaseItem mat2, PurchaseItem mat3, PurchaseItem eve1, PurchaseItem eve2, PurchaseItem eve3)
        {
            TicketTime(mat1, mat2, mat3, eve1, eve2, eve3);
        }

        public void TicketTime(PurchaseItem mat1, PurchaseItem mat2, PurchaseItem mat3, PurchaseItem eve1, PurchaseItem eve2, PurchaseItem eve3)
        {

            int choice1 = 0;
            bool valid1 = false;
            while (valid1 == false)
            {

                System.Console.WriteLine("What type of movie ticket would you like to buy?");
                System.Console.WriteLine("1) Matinee");
                System.Console.WriteLine("2) Evening");
                System.Console.WriteLine("...");
                System.Console.WriteLine();

                try
                {
                    choice1 = int.Parse(System.Console.ReadLine());
                    System.Console.Clear();

                    if (choice1 == 1)
                    {
                        valid1 = true;
                        this.TicketType(mat1, mat2, mat3);
                        this.PurchaseMore("tickets");
                        if (more == true)
                        {
                            valid1 = false;
                            continue;
                        }
                        if (more == false)
                        {
                            valid1 = true;
                            break;
                        }
                    }
                    if (choice1 == 2)
                    {
                        valid1 = true;
                        this.TicketType(eve1, eve2, eve3);
                        this.PurchaseMore("tickets");
                        if (more == true)
                        {
                            valid1 = false;
                            continue;
                        }
                        if (more == false)
                        {
                            valid1 = true;
                            break;
                        }
                    }
                    else
                    {
                        valid1 = false;
                        System.Console.WriteLine("Please select a valid ticket type");
                        System.Console.WriteLine("");
                        continue;
                    }
                }
                catch (System.FormatException qtyError)
                {
                    System.Console.WriteLine(qtyError.Message);
                    System.Console.WriteLine("You entered a non-numerical value. Please enter a valid numerical quantity...");
                    valid1 = false;
                    continue;
                }
            }
        }

        public void TicketType(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3)
        {
            System.Console.WriteLine("What type of ticket would you like?");
            System.Console.WriteLine("1) " + item1.name);
            System.Console.WriteLine("2) " + item2.name);
            System.Console.WriteLine("3) " + item3.name);

            bool valid2 = false;
            int choice2 = 0;

            while (valid2 == false)
            {
                try
                {
                    choice2 = int.Parse(System.Console.ReadLine());
                    System.Console.Clear();

                    if (choice2 == 1)
                    {
                        PurchaseItemQty(item1);
                        break;
                    }
                    if (choice2 == 2)
                    {
                        PurchaseItemQty(item2);
                        break;
                    }
                    if (choice2 == 3)
                    {
                        PurchaseItemQty(item3);
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("You entered an invalid numerical value. Please enter a valid numerical option...");
                        valid2 = false;
                        continue;
                    }
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                    System.Console.WriteLine("You entered a non-numerical value. Please enter a valid numerical option...");
                    valid2 = false;
                    continue;
                }
            }
        }
        #endregion

        #region Concessions

        public void Concessions(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5)
        {

            bool valid3 = false;

            while (valid3 == false)
            {
                System.Console.Clear();
                System.Console.WriteLine("Would you like anything from our concessions while you enjoy your movie?  (yes/no)");
                string yesOrNo = System.Console.ReadLine().ToUpper().Substring(0, 1);

                try
                {
                    if (yesOrNo == "Y")
                    {

                        valid3 = true;
                        ////////////////////
                        WantsConcessions(item1, item2, item3, item4, item5);
                        ////////////////////
                        break;
                    }
                    if (yesOrNo == "N")
                    {
                        valid3 = true;
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Our appologies. Please try again.");
                        valid3 = false;
                        continue;
                    }
                }
                catch (FormatException)
                {
                    valid3 = false;
                    System.Console.WriteLine("Our appologies. Please try again.");
                }
            }

        }

        void WantsConcessions(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5)
        {
            bool wantsConcessions = true;

            while (wantsConcessions == true)
            {

                try
                {
                    System.Console.Clear();
                    System.Console.WriteLine("What would you like?");
                    System.Console.WriteLine(("1) " + item1.name.PadRight(20, '.') + "$" + item1.cost.ToString("0.00")));
                    System.Console.WriteLine(("2) " + item2.name.PadRight(20, '.') + "$" + item2.cost.ToString("0.00")));
                    System.Console.WriteLine(("3) " + item3.name.PadRight(20, '.') + "$" + item3.cost.ToString("0.00")));
                    System.Console.WriteLine(("4) " + item4.name.PadRight(20, '.') + "$" + item4.cost.ToString("0.00")));
                    System.Console.WriteLine(("5) " + item5.name.PadRight(20, '.') + "$" + item5.cost.ToString("0.00")));


                    this.ConcessionSelectionLoop(item1, item2, item3, item4, item5);
                    this.PurchaseMore("snacks");
                    if (more == true)
                    {
                        wantsConcessions = true;
                        continue;
                    }
                    if (more == false)
                    {
                        wantsConcessions = false;
                        System.Console.WriteLine("Thank you very much for your selection!");
                        break;
                    }
                    break;

                }
                catch (FormatException)
                {
                    //System.Console.WriteLine();
                }
            }
        }

        void ConcessionSelectionLoop(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5)
        {
            bool buyingBool = false;

            int concessionChoice = 0;

            while (buyingBool == false)
            {
                concessionChoice = int.Parse(System.Console.ReadLine());
                try
                {
                    if (concessionChoice == 1)
                    {
                        PurchaseItemQty(item1);
                        break;
                    }
                    if (concessionChoice == 2)
                    {
                        PurchaseItemQty(item2);
                        break;
                    }
                    if (concessionChoice == 3)
                    {
                        PurchaseItemQty(item3);
                        break;
                    }
                    if (concessionChoice == 4)
                    {
                        PurchaseItemQty(item4);
                        break;
                    }
                    if (concessionChoice == 5)
                    {
                        PurchaseItemQty(item5);
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Please enter a valid selection.");
                        continue;
                    }
                }
                catch
                {

                }
            }
        }

        #endregion

        #region Reusable Loops

        void PurchaseItemQty(PurchaseItem item)
        {
            bool qtyValid = false;
            string yesOrNo = "";
            while (qtyValid == false)
            {
                System.Console.WriteLine("How many " + item.name + "s would you like?");
                try
                {
                    item.qty += int.Parse(System.Console.ReadLine());
                    System.Console.Clear();
                    System.Console.WriteLine("So you would like " + item.qty.ToString() + " " + item.name + "(s)?");
                    System.Console.WriteLine("Is that correct?");
                    System.Console.WriteLine("...");
                    yesOrNo = System.Console.ReadLine().ToUpper().Substring(0, 1);
                    if (yesOrNo == "Y")
                    {
                        total += (item.qty * item.cost);
                        System.Console.WriteLine("Thank you for your selection!");
                        qtyValid = true;
                        break;

                    }
                    if (yesOrNo == "N")
                    {
                        System.Console.WriteLine("Sorry please try agian?");
                        item.qty = 0;
                        qtyValid = false;
                        continue;
                    }
                    else
                    {
                        System.Console.WriteLine("Sorry please try again?");
                        qtyValid = false;
                        continue;
                    }
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("You entered a non-numerical value. Please enter a valid numerical quantity...");
                    qtyValid = false;
                    continue;
                }
            }
        }

        void PurchaseMore(string itemCategory)
        {
            System.Console.Clear();
            string yesNo = "";
            System.Console.WriteLine("Would you to purchase any more " + itemCategory + "?");
            yesNo = System.Console.ReadLine().ToUpper().Substring(0, 1);
            if (yesNo == "Y")
            {
                more = true;
            }
            if (yesNo == "N")
            {
                more = false;
            }
            if (yesNo != "Y" && yesNo != "N")
            {
                System.Console.Clear();
                PurchaseMore(itemCategory);
            }
            System.Console.Clear();
        }
        #endregion

        #region Conclusion
        public void Reciept(double taxRate, PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5, PurchaseItem item6, PurchaseItem item7, PurchaseItem item8, PurchaseItem item9, PurchaseItem item10, PurchaseItem item11)
        {
            System.Console.Clear();
            System.Console.WriteLine(("").PadLeft(10) + ("").PadRight(96, '-'));
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(37) + ("CLASSIC MOVIE THEATER").PadRight(58) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");

            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(10) + ("Cashier: Andrew").PadRight(20) + ("Date: " + System.DateTime.Now).PadRight(65) + ("|"));

            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(20) + ("ITEM").PadRight(30) + ("QTY").PadRight(15) + ("PRICE").PadRight(15) + ("COST").PadRight(15) + ("|"));
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            ///////////////////////////////////////////////////////////////////////////////////////////
            RecieptItem(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);
            ///////////////////////////////////////////////////////////////////////////////////////////
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            Discount(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);
            ///////////////////////////////////////////////////////////////////////////////////////////
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(50) + (("SUB-TOTAL: ").PadRight(15, '.') + (("$") + (total - discountTotal).ToString("0.00")).PadRight(30) + ("|")));
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(50) + (("TAX: ").PadRight(17, '.') + ((taxRate * 100).ToString("0.00") + "%").PadRight(28) + ("|")));
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(50) + ("TOTAL: ").PadRight(15, '.') + (("$") + ((total - discountTotal) + (taxRate * total)).ToString("0.00").PadRight(29) + ("|")));


            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(43) + "THANK YOU".PadRight(52) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(95) + "|");
            System.Console.WriteLine(("").PadLeft(10) + ("").PadRight(96, '-'));


            System.Console.WriteLine();

            System.Console.ReadLine();
        }

        void RecieptItem(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5, PurchaseItem item6, PurchaseItem item7, PurchaseItem item8, PurchaseItem item9, PurchaseItem item10, PurchaseItem item11)
        {
            if (item1.qty != 0)
            {
                RecieptCalculation(item1);
            }
            if (item2.qty != 0)
            {
                RecieptCalculation(item2);
            }
            if (item3.qty != 0)
            {
                RecieptCalculation(item3);
            }
            if (item4.qty != 0)
            {
                RecieptCalculation(item4);
            }
            if (item5.qty != 0)
            {
                RecieptCalculation(item5);
            }
            if (item6.qty != 0)
            {
                RecieptCalculation(item6);
            }
            if (item7.qty != 0)
            {
                RecieptCalculation(item7);
            }
            if (item8.qty != 0)
            {
                RecieptCalculation(item8);
            }
            if (item9.qty != 0)
            {
                RecieptCalculation(item9);
            }
            if (item10.qty != 0)
            {
                RecieptCalculation(item10);
            }
            if (item11.qty != 0)
            {
                RecieptCalculation(item11);
            }
        }

        void RecieptCalculation(PurchaseItem item)
        {
            //System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(10) + ("ITEM").PadRight(40) + ("QTY").PadRight(15) + ("PRICE").PadRight(15) + ("COST").PadRight(15) + ("|"));
            Console.WriteLine(("").PadLeft(10) + "|".PadRight(20) + (item.name).PadRight(30) + (item.qty.ToString()).PadRight(15) + ("$" + item.cost.ToString("0.00")).PadRight(15) + ("$" + (item.cost * item.qty).ToString("0.00")).PadRight(15) + ("|"));
        }

        void Discount(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5, PurchaseItem item6, PurchaseItem item7, PurchaseItem item8, PurchaseItem item9, PurchaseItem item10, PurchaseItem item11)
        {
            DiscountNo1(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);
            DiscountNo2(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);
            DiscountNo3(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);
        }
        void DiscountNo1(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5, PurchaseItem item6, PurchaseItem item7, PurchaseItem item8, PurchaseItem item9, PurchaseItem item10, PurchaseItem item11)
        {

            int min1 = System.Math.Min(item8.qty, item10.qty);

            int min2 = System.Math.Min(min1, (item1.qty + item2.qty + item3.qty + item4.qty + item5.qty + item6.qty));
            double discount = (min2 * 2);
            discountTotal += (min2 * 2.0);

            if (discount >= 2)
            {
                System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(20) + ("POPCORN & SODA PROMO").PadRight(30) + (min2.ToString()).PadRight(15) + ("").PadRight(15) + (("-") + (discount.ToString("0.00"))).PadRight(15) + ("|"));
            }
        }
        void DiscountNo2(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5, PurchaseItem item6, PurchaseItem item7, PurchaseItem item8, PurchaseItem item9, PurchaseItem item10, PurchaseItem item11)
        {

            int qtyOfDiscount = (item2.qty + item4.qty + item6.qty) / 3;
            double discount = item10.cost;
            discountTotal += (item10.cost * qtyOfDiscount);

            if ((item2.qty + item4.qty + item6.qty) >= 3 && item10.qty >= 1)
            {
                System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(20) + ("FREE POPCORN PROMO").PadRight(30) + (qtyOfDiscount.ToString()).PadRight(15) + ("").PadRight(15) + (("-$") + (discount.ToString("0.00"))).PadRight(15) + ("|"));
            }
        }
        void DiscountNo3(PurchaseItem item1, PurchaseItem item2, PurchaseItem item3, PurchaseItem item4, PurchaseItem item5, PurchaseItem item6, PurchaseItem item7, PurchaseItem item8, PurchaseItem item9, PurchaseItem item10, PurchaseItem item11)
        {
            int qtyOfDiscount = (item11.qty / 4);
            discountTotal = (item11.qty / 4) * 1.99;
            double discount = (item11.qty / 4);

            if (qtyOfDiscount >= 1)
            {

                System.Console.WriteLine(("").PadLeft(10) + "|".PadRight(20) + ("BUY 3 GET 1 FREE PROMO").PadRight(30) + (qtyOfDiscount.ToString()).PadRight(15) + ("").PadRight(15) + (("-") + (discount.ToString("0.00"))).PadRight(15) + ("|"));
            }
        }

        #endregion
    }
}

