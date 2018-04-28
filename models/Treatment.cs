
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPattern.models
{
    [Table("treatment")]
    public class Treatment
    {
        [Column("treatmentid")]
        public int Id { get; set; }
        [Column("treatmenttext")]
        public string Text { get; set; }
        [Column("price")]
        public int Price { get; set; }
    }
}