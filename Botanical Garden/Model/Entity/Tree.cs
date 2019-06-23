using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanicalGarden.Model.Entity
{
    public class Tree
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string View { get; set; }

        [Required]
        public string Family { get; set; }

        [Required]
        public string Rod { get; set; }

        public virtual ICollection<Statistic> Statistics { get; set; }

        public Tree()
        {
            Statistics = new List<Statistic>();
        }
    }
}
