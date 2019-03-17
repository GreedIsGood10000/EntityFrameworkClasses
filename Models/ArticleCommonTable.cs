using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkClasses.Models
{
    public class ArticleCommonTable
    {
        [Key]
        public int Id { get; set; }

        public string ArticleTitle { get; set; }

        public string Type { get; set; }

        public ArticleFirstTypeTable ArticleFirstTypeTable { get; set; }

        public ArticleSecondTypeTable ArticleSecondTypeTable { get; set; }
    }
}
