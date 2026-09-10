using ConsoleApp2.Models;
class Program
{
    static void Main(string[] args)
    {
        var context = new CarDBContext();
        var owner = new Owner
        {
        };
        Console.WriteLine("Enter the owner's name:");
        owner.Name = Console.ReadLine();
        Console.WriteLine("Enter the owner's surname:");
        owner.Surname = Console.ReadLine();
        Console.WriteLine("Enter the owner's address:");
        owner.Address = Console.ReadLine();

        context.Owners.Add(owner);
        context.SaveChanges();

    }
}