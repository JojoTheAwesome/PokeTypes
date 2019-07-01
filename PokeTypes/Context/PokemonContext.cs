using PokeTypes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PokeTypes.Context {
    public class PokemonContext : DbContext {
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}