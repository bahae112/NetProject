using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcommApp.Models.ViewModels
{
    public class ProduitVM
    {
        public Produit produit { get; set; }
        public IEnumerable<SelectListItem> categorieListe { get; set; }
    }
}
