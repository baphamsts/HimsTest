using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergyHistory.Domain.Entities
{
    public class AllergenSeverity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Desc { get; set; }
        public int Value { get; set; }
        public int TypeId { get; set; }
    }
}
