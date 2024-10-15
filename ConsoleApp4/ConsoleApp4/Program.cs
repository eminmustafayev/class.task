namespace cc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook Samsung = new Notebook("Samsung", "yaxsidi", 33, 2391, 8, 512);
            Samsung.ShowFullData();
            Notebook Asus = new Notebook("Asus", "eladi", 14, 1121, 8, 512);
           Asus.ShowFullData();
            Notebook Hp = new Notebook("Hp", "pisdi", 10, 1311, 8, 512);
            Hp.ShowFullData();
        }
        class Product
        {
            public string Name;
            public string Comment;
            public int Count;
            public bool IsStock = true;
            public double Price;

            public Product(string name, string comment, int count, double price)
            {
                Name = name;
               Comment = comment;
                Count = count;
                Price = price;
            }

            public void Sale(string name, string comment, int count, double price)
            {

                Name = name;
               Comment = comment;
                Count = count;
                Price = price;
            }
            public void ShowFullData()
            {
                Console.WriteLine("Name " + Name +  "Comment" + Comment + "Price" +   Price +    "Count"  + Count + "Price" + Price);
            }

        }
        class Notebook : Product
        {
            public byte Ram;
            public int Storage;
            public Notebook(string name, string comment, int count, double price, byte ram, int storage) : base(name, comment, count, price)
            {
                if (string.IsNullOrEmpty(name) || count == ' ' || price == ' ' || ram == ' ')
                {
                    Console.WriteLine("verilen yoxdur");
                }
                else if (count == 0)
                {
                    Console.WriteLine("bitib");
                }
                Ram = ram;
                Storage = storage;

            }
            public void ShowFullData()
            {
                base.ShowFullData();
                Console.WriteLine("ram : " + Ram + "storage" + Storage);
            }

        }
    }
}