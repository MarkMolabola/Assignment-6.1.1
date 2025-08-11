namespace Assignment_6._1._1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            MyLinkList Neighborhood = new MyLinkList();

            CreateData(Neighborhood);
            Console.WriteLine("Welcome to the Neighborhood! \n---------------------------------");
            
            Console.WriteLine("Enter the House number youd like to see (1-7)");
            int.TryParse(Console.ReadLine(), out int input);
            Neighborhood.Search(input);






        }
        static void CreateData(MyLinkList Neighborhood)
        {
            
            Houses house1 = new Houses("123 Elm St", "Ranch", 1);
            Houses house2 = new Houses("456 Oak St", "Colonial", 2);
            Houses house3 = new Houses("789 Pine St", "Big Ranch", 3);
            Houses house4 = new Houses("101 Maple St", "Small Apt", 4);
            Houses house5 = new Houses("202 Birch St", "Medium Apt", 5);
            Houses house6 = new Houses("303 Cedar St", "Mansion", 6);
            Houses house7 = new Houses("404 Spruce St", "Haunted House", 7);


            Neighborhood.AddFirst(house1);
            Neighborhood.AddLast(house2);
            Neighborhood.AddAnywhere(house3, 2);
            Neighborhood.AddAnywhere(house4, 1);
            Neighborhood.AddAnywhere(house5, 3);
            Neighborhood.AddAnywhere(house6, 5);
            Neighborhood.AddAnywhere(house7, 4);
           
        }
    }
    
}
