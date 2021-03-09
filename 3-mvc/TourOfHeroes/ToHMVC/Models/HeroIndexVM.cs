using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ToHModels;

namespace ToHMVC.Models
{
    /// <summary>
    /// Model for the index view of my ToH app.
    /// </summary>
    public class HeroIndexVM
    {
        // Data annotation
        // Can be used for display purposes and validation.

        [DisplayName("Hero Name")]
        public string HeroName { get; set; }
        public int HP { get; set; }
        [DisplayName("Element")]
        public Element ElementType { get; set; }
    }
}
