using DIORPG.RPGCharacters;
namespace DIORPG
{
    class Program
    {
        static void Main()
        {
            Hunter Dean = new Hunter("Dean Winchester");
            Dean.Atack(AtackWith.Gun);
            Console.WriteLine(Dean.Name);

        }
    }
}