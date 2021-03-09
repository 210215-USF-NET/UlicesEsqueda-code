using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToHModels;

namespace ToHMVC.Models
{
    /// <summary>
    /// Hero view model for creating and reading heroes.
    /// </summary>
    public class HeroCRVM
    {
        [DisplayName("Hero Name")]
        [Required]
        public string HeroName { get; set; }

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Hp should be positive!")]
        public int HP { get; set; }

        [DisplayName("Element")]
        [Required]
        public Element ElementType { get; set; }

        [DisplayName("Name of hero superpower")]
        [Required]
        public String SuperPowerName { get; set; }

        [DisplayName("Description of hero's superpower")]
        [Required]
        public String Description { get; set; }

        [DisplayName("Damage of hero's superpower")]
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Damage should be non-negative!")]
        public int Damage { get; set; }
        
    }
}
