using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio
{
    public class fSistema_Academico_AreaAcademica
    {
        public static string Guardar_DatosBasicos
            (//Datos Basicos
            string auto, string area, string año, string estado, string descripcion)
        {
            Conexion_Sistema_AreaAcademica Obj = new Conexion_Sistema_AreaAcademica();
            //Datos Basicos
            Obj.Area = area;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;
            Obj.Auto = auto;
            Obj.Año = año;

            return Obj.Guardar_DatosBasicos(Obj);
        }
    }
}
