using System.Collections.Generic;

namespace ShoeShpe
{
    public class Store
    {
        public List<IShoe> ShoesList { get; set; }
        public List<IShoe> ShoppingBasket { get; set; }

        public Store()
        {
            ShoesList = new List<IShoe>();
            ShoppingBasket = new List<IShoe>();
        }

        public decimal Checkout()
        {
            decimal totalPrice = 0;

            foreach (var shoe in ShoppingBasket)
            {
                totalPrice += shoe.Price;
            }
            // ShoppingBasket.Clear();
            return totalPrice;
        }
    }
}