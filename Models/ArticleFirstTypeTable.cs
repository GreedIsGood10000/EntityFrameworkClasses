using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkClasses.Models
{
    public class ArticleFirstTypeTable
    {
        [Key]
        [ForeignKey(nameof(ArticleCommonTable))]
        public int Id { get; set; }

        public string ArticleFirstTypeProperty { get; set; }

        public ArticleCommonTable ArticleCommonTable { get; set; }
    }
}
