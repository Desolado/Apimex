using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Apimex.Models;

namespace Apimex.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        

        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empresas E)
        {
            if (!ModelState.IsValid)
                return View();

            try
            {
                using (var db = new ApimexEntities())
                {
                    E.FechaRegistro = DateTime.Now;
                    E.Folio = "FE-"+E.id_Empresa;
                    db.Empresas.Add(E);
                    db.SaveChanges();
                    return RedirectToAction("Create");
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("","Error al registrarse.");
                return View();
            }
        }
    }
}