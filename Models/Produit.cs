using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommApp.Models

{
    public class Produit
    {
        public int Id { get; set; }   // Clé primaire
        public required string Nom { get; set; }
        public required int Code { get; set; }
        public required int PrixProduit { get; set; }

        public required string Description { get; set; }
        public int categorieId { get; set; }
        [ForeignKey("categorieId")]
        public Categorie categorie { get; set; }
        [ValidateNever]
        public string imageURL { get; set; }
    }
}
