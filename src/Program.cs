using System.Linq;
using ConsoleTables;
using static System.Console;


Clients();


void Clients()
{
    WriteLine("CLIENTS");
    ConsoleTable
        .From<Client>(GetClients())
        .Configure(o => o.NumberAlignment = Alignment.Right)
        .Write(Format.Alternative);
}

System.Collections.Generic.IEnumerable<Client> GetClients()
{
    var ids = 1;
    var faker = new Bogus.Faker("en");
    return Enumerable.Range(1, 5)
        .Select(_ => new Client()
        {
            Id = ids++,
            Name = faker.Name.FullName()
        })
        .ToList();
}

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }

}