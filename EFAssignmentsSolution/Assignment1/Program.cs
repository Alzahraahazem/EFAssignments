using Assignment1.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIyDbContext context = new ITIyDbContext();

            context.Database.Migrate();
        }
    }
}
