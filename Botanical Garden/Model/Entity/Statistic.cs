using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanicalGarden.Model.Entity
{
    public class Statistic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string LivingСonditions { get; set; }
        [Required]
        public string Сondition { get; set; }
        [Required]
        public int Population { get; set; }
        public int? TreeId { get; set; }
        public virtual Tree Tree { get; set; }

        public int? PlantId { get; set; }
        public virtual Plant Plant { get; set; }

    }
}
