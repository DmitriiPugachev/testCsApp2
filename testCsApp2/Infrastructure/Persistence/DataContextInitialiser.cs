using Microsoft.EntityFrameworkCore;

namespace testCsApp2.Infrastructure.Persistence
{
    public class DataContextInitialiser
    {
        private readonly DataContext _context;

        public DataContextInitialiser(DataContext context)
        {
            _context = context;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                await _context.Database.MigrateAsync();
            } 
            catch
            {
                Console.WriteLine("Database cannot be initialised");
            }
        }
    }
}