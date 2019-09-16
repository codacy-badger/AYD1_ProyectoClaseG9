﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Objetos
{
    public class ObjDetMovimiento
    {
        public int cantidad { get; set; }
        public int movimiento_idingreso { get; set; }
        public int producto_idproducto { get; set; }
        public string descripcion { get;set; }

        public ObjDetMovimiento(int cantidad,int movimiento,int producto)
        {
            this.cantidad = cantidad;
            this.movimiento_idingreso = movimiento;
            this.producto_idproducto = producto;
        }

        public ObjDetMovimiento()
        {

        }
    }
}