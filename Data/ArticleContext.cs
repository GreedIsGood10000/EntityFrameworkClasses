using System.Data.Entity;
using EntityFrameworkClasses.Models;

namespace EntityFrameworkClasses.Data
{
    class ArticleContext : DbContext
    {
        public DbSet<ArticleCommonTable> Article { get; set; }
        public DbSet<ArticleFirstTypeTable> ArticleFirstType { get; set; }
        public DbSet<ArticleSecondTypeTable> ArticleSecondType { get; set; }
    }
}
