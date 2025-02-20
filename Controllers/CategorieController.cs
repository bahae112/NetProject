﻿using EcommApp.Data;
using EcommApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommApp.Controllers
{
    public class CategorieController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategorieController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Categorie> categoryList = _db.Categories.ToList();
            return View(categoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Categorie obj)

        {
            if (obj.Nom == "test")
            {
                ModelState.AddModelError("Nom", "Test est une valeur invalide");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View();
        }
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Categorie obj = _db.Categories.Find(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(obj);
        //}
        public IActionResult Edit(Categorie obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Categorie obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Categorie obj = _db.Categories.Find(id);
            if (obj == null)
                return NotFound();
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
