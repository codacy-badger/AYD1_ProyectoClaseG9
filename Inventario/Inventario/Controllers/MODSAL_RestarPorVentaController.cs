﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventario.Objetos;

namespace Inventario.Controllers
{
    public class MODSAL_RestarPorVentaController : Controller
    {
        // GET: MODSAL_RestarPorVenta
        public ActionResult vMODSAL_RestarPorVenta()
        {
            return View();
        }

        public static DataTable consultarBD(string Consulta)
        {
            string credenciales = "server=DESKTOP-39C8GSB; database=AnalisisP1 ; integrated security = true";
            SqlConnection conexion = new SqlConnection(credenciales);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable ds = new DataTable();
            try
            {
                conexion.Open();
                SqlCommand sql = new SqlCommand();
                sql.CommandText = Consulta;
                sql.CommandType = CommandType.Text;
                sql.Connection = conexion;

                adaptador.SelectCommand = sql;
                adaptador.Fill(ds);
                conexion.Close();
                return ds;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(Consulta);
                return null;
            }
        }

        public ActionResult mostrandoVentas()
        {
            List<ObjRestaxVenta> listaVentas = new List<ObjRestaxVenta>();
            listaVentas.Add(new ObjRestaxVenta("fecha", "desc", 5.25, 1, "nom", 5));
            //Session["LOG_VENTAS"] = listaVentas;
            return RedirectToAction("vMODSAL_RestarPorVenta", "MODSAL_RestarPorVenta");
        }

        [HttpGet]
        public List<ObjProducto> getProductos()
        {
            List<ObjProducto> lista = new List<ObjProducto>();
            string consulta = "select * from producto;";
            DataTable dt = consultarBD(consulta);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ObjProducto nuevo = new ObjProducto();
                        nuevo.idproducto = Int16.Parse(row["idproducto"].ToString());
                        nuevo.descripcion = row["descripcion"].ToString();
                        nuevo.precio_costo = Double.Parse(row["precio_costo"].ToString());
                        nuevo.precio_venta = Double.Parse(row["precio_venta"].ToString());
                        nuevo.fecha_ingreso = row["fecha_ingreso"].ToString();
                        nuevo.fecha_modificacion = row["fecha_modificacion"].ToString();
                        nuevo.cantidad = Int16.Parse(row["cantidad"].ToString());
                        lista.Add(nuevo);
                    }
                }
            }
            return lista;
        }

        public static object actualizarBD(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public ActionResult vMODSAL_VerProductos()
        {
            return View();
        }

        public ActionResult mostrandoProductos()
        {
            List<ObjProducto> listaP = new List<ObjProducto>();
            listaP = getProductos();
            Session["LOG_PRODUCTOS"] = listaP;
            return RedirectToAction("vMODSAL_VerProductos", "MODSAL_RestarPorVenta");
        }
        
    }
}