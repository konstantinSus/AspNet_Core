using Microsoft.Extensions.Options;
using MongoDB.Driver;
using myProjectApi.IOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myProjectApi.Repository
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database = null;


        public MongoContext(IOptions<MongoSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<PokemonDate> Pokemons => _database.GetCollection<PokemonDate>("Pokemons");

    }
}
