namespace ShoeShpe
{
    public class Boots : IShoe
    {
        private string _size;
        public string Type
        {
            get
            {
                return "Boots";
            }
        }

        public string Colour
        {
            get
            {
                return "Brown";
            }
        }

        public string Size
        {
            get
            {
                return _size;
            }
        }

        public decimal Price
        {
            get
            {
                return 59;
            }
        }

        public Boots(string selectedSize)
        {
            _size = selectedSize;
        } 
    }
}