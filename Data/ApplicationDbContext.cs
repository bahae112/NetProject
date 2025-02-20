using EcommApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommApp.Data;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Categorie> Categories { get; set; }
    public DbSet<Produit> Produits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorie>().HasData(
        new Categorie { Id = 1, Nom = "Mobile", OrdreAffichage = "1" },
        new Categorie { Id = 2, Nom = "Ordinateur", OrdreAffichage = "2" },
        new Categorie { Id = 3, Nom = "Périphériques", OrdreAffichage = "3" },
        new Categorie { Id = 4, Nom = "Périphériques", OrdreAffichage = "4" }
        );
        modelBuilder.Entity<Produit>().HasData(
        new Produit { Id = 1, Nom = "Iphone 14", Description = "iPhone 14 Pro. Avec un appareil photo principal de 48 MP pour capturer des détails époustouflants. Dynamic Island et l'écran toujours activé, qui offrent une toute nouvelle expérience sur iPhone", PrixProduit = 10000, Code = 123456789, categorieId = 1 , imageURL  = "images/1.jpg" },
        new Produit { Id = 2, Nom = "Imprimante hp deskjet 2710", Description = "Toutes les fonctions de base, désormais faciles à utiliser. Imprimez, numérisez et copiez les documents quotidiens, et profitez d’une connexion simple et sans fil", PrixProduit = 5000, Code = 546456789, categorieId = 3, imageURL = "images/2.jpg" }
        );


    }

}
