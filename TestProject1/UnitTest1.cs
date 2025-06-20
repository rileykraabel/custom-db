using Microsoft.Extensions.DependencyInjection;

namespace TestProject1
{
    public class UnitTest1
    {
        // Uncomment this once you have scaffolded your library, 
        // then replace instances of 'X' below with your team number

        /*       Team105LibraryContext MakeTinyDB()
               {
                   var contextOptions = new DbContextOptionsBuilder<Team105LibraryContext>()
                   .UseInMemoryDatabase("LibraryControllerTest")
                   .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                   .UseApplicationServiceProvider(NewServiceProvider())
                   .Options;

                   var db = new Team105LibraryContext(contextOptions);

                   db.Database.EnsureDeleted();
                   db.Database.EnsureCreated();

                   Titles t = new Titles();
                   t.Author = "Fake author";
                   t.Title = "Fake title";
                   t.Isbn = "123-5678901234";

                   db.Titles.Add(t);
                   db.SaveChanges();

                   return db;
               }*/


        /*  [Fact]
          public void Test1()
          {
              HomeController c = new HomeController(null);

              Team105LibraryContext db = MakeTinyDB();

              c.UseLibraryContext( db );

              var allTitlesResult = c.AllTitles() as JsonResult;

              dynamic x = allTitlesResult.Value;

              Assert.Equal( 1, x.Length );
              Assert.Equal( "123-5678901234", x[0].isbn );
          }
  */

        private static ServiceProvider NewServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
          .AddEntityFrameworkInMemoryDatabase()
          .BuildServiceProvider();

            return serviceProvider;
        }
    }
}