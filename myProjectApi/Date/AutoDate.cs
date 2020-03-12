using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myProjectApi.Date
{
    public class AutoDate
    {
        [BsonId]
        public ObjectId Id { get; set; }

        /// <summary>
        /// Название машины
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип машины
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Год машины
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// Класс экологичности машины
        /// </summary>
        public string ClassEcoCar { get; set; }
    }

    public class PokemonDateRedis
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип покемона
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Поколение
        /// </summary>
        public int? Generation { get; set; }

        /// <summary>
        /// Вид покемона
        /// </summary>
        public string KindPokemon { get; set; }


    }
}

