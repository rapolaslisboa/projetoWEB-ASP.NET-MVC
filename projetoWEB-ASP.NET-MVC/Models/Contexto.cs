using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoWEB.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Colaborador> Colaboradores { get; set; }
    }
}