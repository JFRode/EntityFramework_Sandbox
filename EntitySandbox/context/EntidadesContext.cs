using EntitySandbox.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySandbox.context
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
