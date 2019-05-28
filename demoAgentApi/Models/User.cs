namespace demoAgentApi.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Idcard { get; set; }
        // public Order Order {get; set;}
    }

    // public class Order
    // {
    //     public int IdOrder { get; set;}
    //     public int Count { get; set;}
    //     public int TotalPrice { get; set;}
    //     public string Date { get; set;}
    //     public string status { get; set;}
    //     public Product Product { get; set;}
    // }
    // public class Product
    // {
    //     public int IdProduct { get; set;}
    //     public string NameProduct { get; set;}
    //     public int Price { get; set;}
    //     public string Type { get; set;}
    // }
}