namespace Chest.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int PortionSize { get; set; }
        public PortionUnit PortionUnit { get; set; }
        public int Energy { get; set; }
        public double Fat { get; set; }
        public double Saturates { get; set; }
        public double Carbohydrates { get; set; }
        public double Sugars { get; set; }
        public double Protein { get; set; }
        public double Salt { get; set; }
        public int Fiber { get; set; }
    }

}
