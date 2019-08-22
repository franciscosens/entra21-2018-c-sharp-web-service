using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class SistemaContexto : DbContext
    {

        public SistemaContexto(DbContextOptions<SistemaContexto> options) : base(options)
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
