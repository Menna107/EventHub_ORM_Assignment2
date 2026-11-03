using ORM_Assignment2.Context;

namespace ORM_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using DBContext dbContext = new DBContext();

            dbContext.Database.EnsureCreated();
        }
    }
}
