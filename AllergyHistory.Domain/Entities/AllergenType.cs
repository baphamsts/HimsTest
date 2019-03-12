using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergyHistory.Domain.Entities
{
    /// <summary>
    /// Maybe in the domain it call Code
    /// </summary>
    public class AllergenType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Desc { get; set; }
        public string Text { get; set; }
        public int Value { get; set; }
        public int TypeId { get; set; }
    }
}
