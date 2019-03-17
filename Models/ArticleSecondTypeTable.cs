using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkClasses.Models
{
    public class ArticleSecondTypeTable
    {
        [Key]
        [ForeignKey(nameof(ArticleCommonTable))]
        public int Id { get; set; }

        public string ArticleSecondTypeProperty { get; set; }

        public ArticleCommonTable ArticleCommonTable { get; set; }
    }
}
