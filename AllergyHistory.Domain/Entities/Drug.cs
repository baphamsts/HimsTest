using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergyHistory.Domain.Entities
{
    /// <summary>
    /// Medication map to drug table
    /// </summary>
    public class Drug
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DrugName { get; set; }
        public string LexiDrugId { get; set; }
    }
}
