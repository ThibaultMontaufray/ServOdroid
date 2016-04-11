namespace ServOdroid.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TobiViewModel
    {
        public string tobiOutput { get; set; }
        public string tobiInput { get; set; }
        
        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le prénom est obligatoire")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "L'adresse mail est obligatoire")]
        public string Email { get; set; }
    }
}