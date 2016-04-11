using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServOdroid.Models
{
    public class DicoBotViewModel
    {
        [Display(Name = "Real")]
        public bool Real { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Class")]
        public string Class { get; set; }

        [Display(Name = "Origin")]
        public string Origin { get; set; }

        [Display(Name = "Constructor")]
        public string Constructor { get; set; }

        [Display(Name = "Serie")]
        public string Serie { get; set; }

        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Size min")]
        public int SizeMin { get; set; }

        [Display(Name = "Size max")]
        public int SizeMax { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "Epoque")]
        public string Epoque { get; set; }

        public List<string> PicturePath { get; set; }
    }
}
