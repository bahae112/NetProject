using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EcommApp.Models
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nom de la catégorie")]
        [Required(ErrorMessage = "Veuillez saisir un nom")]
        [MaxLength(50)]
        public string Nom { get; set; }
        [DisplayName("Ordre d'affichage")]
        [Range(1, 10, ErrorMessage = "La valeur doit etre comprise entre 1 et 10")]
        public string OrdreAffichage { get; set; }

    }

}