namespace Skole_Administrasjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Idris", 28);
            student1.Info();

            Skole skole1 = new Skole("Gokstad Akademi", 2020);

            skole1.Info();
        }
    }
}