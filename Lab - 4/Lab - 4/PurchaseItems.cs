namespace Lab___4
{
    class PurchaseItem
    {
        public double cost = 0;
        public string name = "";
        public int qty = 0;

        public PurchaseItem(string itemName, double itemCost, int itemQty)
        {
            name = itemName;
            cost = itemCost;
            qty = itemQty;
        }



    }
}
