namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in dd | MM | yyyy format");
            string input = Console.ReadLine();

            try
            {
                var date = DateTime.ParseExact(input, "dd | MM | yyyy", null);
                Console.WriteLine("Date: " + date.ToString("dd | MM | yyyy"));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            } 
        }
    }
}