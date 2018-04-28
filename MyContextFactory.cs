using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern
{
    /// <summary>
    /// A factory to create an instance of the StudentsContext 
    /// </summary>
    public static class MyContextFactory
    {
        public static MyContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);

            // Ensure that the SQLite database and sechema is created!
            var context = new MyContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}