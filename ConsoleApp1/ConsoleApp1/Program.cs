namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in dd/MM/yyyy format: ");
            string input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "dd/MM/yyyy", null);
            DateTime newDate = date.AddDays(30).AddHours(6).AddMinutes(17);
            Console.WriteLine("New date: " + newDate);
        }
    }
}