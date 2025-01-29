using CRUD_Basico.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Basico.Controllers
{
    public class LibrosController : Controller
    {
        // GET: Libros
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            { 
                return View(context.libros.ToList());
            }
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.libros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
                return View();
            
        }

        // POST: Libros/Create
        [HttpPost]
        public ActionResult Create(libros libros)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.libros.Add(libros);
                    context.SaveChanges();
                }
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libros/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.libros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Libros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, libros libros)
        {
            try
            {
                using (DbModels context = new DbModels())
                { 
                    context.Entry(libros).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libros/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.libros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Libros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                
                using (DbModels context = new DbModels())
                {
                    libros libro = context.libros.Where(x => x.id == id).FirstOrDefault();
                    context.libros.Remove(libro);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
