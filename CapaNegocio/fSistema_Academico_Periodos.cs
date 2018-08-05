﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Academico_Periodos
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string periodo, string año, string estado, string descripcion)
        {
            Conexion_Sistema_Periodos Obj = new Conexion_Sistema_Periodos();
            //Datos Basicos
            Obj.Auto = auto;
            Obj.Periodo = periodo;
            Obj.Año = año;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static DataTable Mostrar()
        {
            return new Conexion_Sistema_Periodos().Mostrar();
        }

    }
}
