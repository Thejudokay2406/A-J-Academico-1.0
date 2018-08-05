using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Aula
    {
        private int _Idaula;
        private string _Aula;
        private string _Capacidad;
        private string _Curso;
        private string _Año;
        private string _Estado;
        private string _Descrípcion;

        private string _Auto;
        private string _Filtro;

        public int Idaula
        {
            get
            {
                return _Idaula;
            }

            set
            {
                _Idaula = value;
            }
        }

        public string Aula
        {
            get
            {
                return _Aula;
            }

            set
            {
                _Aula = value;
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

        public string Descrípcion
        {
            get
            {
                return _Descrípcion;
            }

            set
            {
                _Descrípcion = value;
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

        public string Capacidad
        {
            get
            {
                return _Capacidad;
            }

            set
            {
                _Capacidad = value;
            }
        }

        public string Curso
        {
            get
            {
                return _Curso;
            }

            set
            {
                _Curso = value;
            }
        }

        public Conexion_Sistema_Aula()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Sistema_Aula(string auto, int idaula, string aula, string capacidad, string curso,string estado, string año, string descripcion)
        { 
            //Datos Basicos
            this.Idaula = idaula;
            this.Auto = auto;
            this.Aula = aula;
            this.Capacidad = capacidad;
            this.Curso = curso;
            this.Año = año;
            this.Estado = estado;
            this.Descrípcion = descripcion;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Sistema_Aula Aula)
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
                SqlCmd.CommandText = "Sistema.AJ_Aula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcurso = new SqlParameter();
                ParIdcurso.ParameterName = "@Idaula";
                ParIdcurso.SqlDbType = SqlDbType.Int;
                ParIdcurso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcurso);

                SqlParameter ParAula = new SqlParameter();
                ParAula.ParameterName = "@Aula";
                ParAula.SqlDbType = SqlDbType.VarChar;
                ParAula.Size = 10;
                ParAula.Value = Aula.Aula;
                SqlCmd.Parameters.Add(ParAula);

                SqlParameter ParCapacidad = new SqlParameter();
                ParCapacidad.ParameterName = "@Capacidad";
                ParCapacidad.SqlDbType = SqlDbType.VarChar;
                ParCapacidad.Size = 10;
                ParCapacidad.Value = Aula.Capacidad;
                SqlCmd.Parameters.Add(ParCapacidad);

                SqlParameter ParCurso = new SqlParameter();
                ParCurso.ParameterName = "@Curso";
                ParCurso.SqlDbType = SqlDbType.VarChar;
                ParCurso.Size = 20;
                ParCurso.Value = Aula.Curso;
                SqlCmd.Parameters.Add(ParCurso);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Aula.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParAño = new SqlParameter();
                ParAño.ParameterName = "@Año";
                ParAño.SqlDbType = SqlDbType.VarChar;
                ParAño.Size = 10;
                ParAño.Value = Aula.Año;
                SqlCmd.Parameters.Add(ParAño);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 1;
                ParEstado.Value = Aula.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 200;
                ParDescripcion.Value = Aula.Descrípcion;
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

