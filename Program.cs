using ConsoleApp2.Models;
class Program
{
    static void Main(string[] args)
    {
        var context = new CarDBContext();
        var owner = new Owner
        {
        };
        Console.WriteLine("Ievadiet vārdu:");
        owner.Name = Console.ReadLine();
        Console.WriteLine("Ievadiet uzvārdu:");
        owner.Surname = Console.ReadLine();
        Console.WriteLine("Ievadiet adresi:");
        owner.Address = Console.ReadLine();

        context.Owners.Add(owner);
        context.SaveChanges();



        Console.WriteLine($ "Owner {owner.Name} {owner.Surname} added successfully with ID {owner.Id}.");
    }
}