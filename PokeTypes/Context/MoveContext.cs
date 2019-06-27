using PokeTypes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PokeTypes.Context {
    public class MoveContext : DbContext {
        public DbSet<Move> Moves { get; set; }
    }
}