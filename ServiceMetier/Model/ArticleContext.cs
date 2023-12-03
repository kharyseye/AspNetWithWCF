using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiceMetier.Model
{
    public class ArticleContext : DbContext
    {
        public ArticleContext() : base("BoutiqueConnection")
        {
        }
        public DbSet<Article> Articles { get; set; }
    }
}