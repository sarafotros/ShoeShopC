using System;

namespace ShoeShpe
{
    public class ShopFront
    {
        private Store _store;
        public ShopFront()
        {
            _store = new Store();
        }
        public void Open()
        {
            Console.WriteLine("  ...:::  Welcome to the SHOUTIQUE   :::...");
            Console.WriteLine("Please Select one of the following options:");
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("1) List of all the shoes    2) Order your favourite shoe    3) Exit ");
                var selectedOption =  Console.ReadLine();

                switch (selectedOption)
                {
                    case "1" :
                        Console.WriteLine("Please select from the following options:");
                        Console.WriteLine("1> Boots    2> Sneakers    3> Sandals    4> Slippers    5> Oxford");
                        ChooseOneFromList();
                        break;
                    case "2" :
                        IShoe shoe = CreateCustomShoe();
                        PrintShoeDetails(shoe);
                        break;
                    case "3" :
                        Console.WriteLine("GOODBYE");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("You didn't choose a valid option!");
                        break;
                }
            }
            
        }
         private void ChooseOneFromList()
        {
            var selectedShoe = Console.ReadLine();
            Console.WriteLine("What's your shoe size?");
            var sizeSelected = Console.ReadLine();
            IShoe shoe = null;
            
            switch (selectedShoe)
            {
                case "1" :
                    shoe = new Boots(sizeSelected);
                    break;
                case "2" :
                    shoe = new Sneakers(sizeSelected);
                    break;
                case "3" :
                    shoe = new Sandals(sizeSelected);
                    break;
                case "4" : 
                    shoe = new Slippers(sizeSelected);
                    break;
                case "5" :
                    shoe = new Oxford(sizeSelected);
                    break;
                default:
                    Console.WriteLine("You didn't choose a valid option!");
                    break; 
            }

            if (shoe != null)
            {
                PrintShoeDetails(shoe);
            }
        }
        private  IShoe CreateCustomShoe()
        {
            Console.WriteLine("What type of shoes do you want?");
            var customType = Console.ReadLine();
            Console.WriteLine("Which colour do you prefer?");
            var customColour = Console.ReadLine();
            Console.WriteLine("What size?");
            var customSize = Console.ReadLine();
            
            return new CustomShoe(customType, customColour, customSize);
        }
        
        private  void PrintShoeDetails(IShoe shoe)
        {
            Console.WriteLine($"You have Selected a {shoe.Colour} {shoe.Type} of size {shoe.Size} and it will cost you £{shoe.Price}.00");
            Console.WriteLine("Add to basket? [] Y   [] N");
            var buyOrLeave = Console.ReadLine();
            
            switch (buyOrLeave)
            {
               case "y" :
                   AddToBasket(shoe);
                   break;
               case "n" :
                   Console.WriteLine("Thanks for visiting SHOUTIQUE");
                   break;
               default:
                   Console.WriteLine("GOODBYE");
                   break; 
            }
        }

        private  void AddToBasket(IShoe shoe)
        {  
            Console.WriteLine("    <ADD TO CART>");
           _store.ShoppingBasket.Add(shoe);
           decimal total = _store.Checkout();
           Console.WriteLine("Total to Pay: £" + total + ".00 ");
        }
    }
}