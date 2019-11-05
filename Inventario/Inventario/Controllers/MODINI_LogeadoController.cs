﻿using Inventario.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Controllers
{
    public class MODINI_LogeadoController : Controller
    {
        List<ObjRestaxVenta> carretilla = new List<ObjRestaxVenta>();
        // GET: MODINI_Logeado
        public ActionResult vMODINI_Logeado()
        {
            Session["CARRETILLA"] = carretilla;
            return View();
        }

        public ActionResult Resta()
        {
            return Redirect("/MODSAL_RestaMalEstado.aspx");
        }
    }
}