﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Inventario.Models;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventario.Controllers
{
    public class MODRES_RestaME : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MODRES_RestaME
        [HttpPost]
        public ActionResult vMODRES_ResME(string producto, int cantidad) //(List<Objetos.ObjRepKardex> lista)
        {/*
            if (txtProducto.Text == "" || txtCantidad.Text == "")

            {
                con.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Show Modal Popup", "alert ('Error no hay conexion');");
            }

            SqlCommand cmd = new SqlCommand("RestaVenta", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Producto", SqlDbType.VarChar).Value = producto;
            cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = cantidad;

            int rowsAffected = cmd.ExecuteNonQuery();


            if (rowsAffected > 0)
            {
                Console.WriteLine("Show Modal Popup", "alert ('Resta Realizada');");
            }
            else
            {
                Console.WriteLine("Show Modal Popup", "alert ('Operacion Denegada');");
            }

            con.Close();
            }*/
            return View();
        }
    }
}
