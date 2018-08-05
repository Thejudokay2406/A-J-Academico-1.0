using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_AreaAcademica
    {
        private int _Idarea;
        private string _Area;
        private string _Año;
        private string _Estado;
        private string _Descripcion;

        private string _Auto;
        private string _Filtro;

        public int Idarea
        {
            get
            {
                return _Idarea;
            }

            set
            {
                _Idarea = value;
            }
        }

        public string Area
        {
            get
            {
                return _Area;
            }

            set
            {
                _Area = value;
            }
        }

        public string Año
        {
            get
            {
                return _Año;
            }

            set
            {
                _Año = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public string Auto
        {
            get
            {
                return _Auto;
            }

            set
            {
                _Auto = value;
            }
        }

        public string Filtro
        {
            get
            {
                return _Filtro;
            }

            set
            {
                _Filtro = value;
            }
        }

        public Conexion_Sistema_AreaAcademica()
        {

        }

        public Conexion_Sistema_AreaAcademica(string auto, int idarea, string area, string estado, string año, string descripcion)
        {
            //Datos Basicos
            this.Idarea = idarea;
            this.Area = area;
            this.Auto = auto;
            this.Año = año;
            this.Estado = estado;
            this.Descripcion = descripcion;
        }
        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Sistema_AreaAcademica Area)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.AJ_AreasAcademica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcurso = new SqlParameter();
                ParIdcurso.ParameterName = "@Idarea";
                ParIdcurso.SqlDbType = SqlDbType.Int;
                ParIdcurso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcurso);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Area.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParArea = new SqlParameter();
                ParArea.ParameterName = "@Area";
                ParArea.SqlDbType = SqlDbType.VarChar;
                ParArea.Size = 20;
                ParArea.Value = Area.Area;
                SqlCmd.Parameters.Add(ParArea);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 10;
                ParAño.Value = Area.Año;
                SqlCmd.Parameters.Add(ParAño);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 1;
                ParEstado.Value = Area.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 200;
                ParDescripcion.Value = Area.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Registrar";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
    }
}

