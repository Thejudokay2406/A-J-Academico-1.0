using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Configuracion_CodigoID
    {
        //Llaves primarias
        private int _Idcodigoid;

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        //Datos Medicos
        private string _Letra_Alumno;
        private string _Simbolo_Alumno;
        private string _Numero_Alumno;

        //Datos Medicos
        private string _Letra_Empleado;
        private string _Simbolo_Empleado;
        private string _Numero_Empleado;

        public int Idcodigoid
        {
            get
            {
                return _Idcodigoid;
            }

            set
            {
                _Idcodigoid = value;
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

        public string Letra_Alumno
        {
            get
            {
                return _Letra_Alumno;
            }

            set
            {
                _Letra_Alumno = value;
            }
        }

        public string Simbolo_Alumno
        {
            get
            {
                return _Simbolo_Alumno;
            }

            set
            {
                _Simbolo_Alumno = value;
            }
        }

        public string Numero_Alumno
        {
            get
            {
                return _Numero_Alumno;
            }

            set
            {
                _Numero_Alumno = value;
            }
        }

        public string Letra_Empleado
        {
            get
            {
                return _Letra_Empleado;
            }

            set
            {
                _Letra_Empleado = value;
            }
        }

        public string Simbolo_Empleado
        {
            get
            {
                return _Simbolo_Empleado;
            }

            set
            {
                _Simbolo_Empleado = value;
            }
        }

        public string Numero_Empleado
        {
            get
            {
                return _Numero_Empleado;
            }

            set
            {
                _Numero_Empleado = value;
            }
        }

        //Constructor Vacio
        public Conexion_Configuracion_CodigoID()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Configuracion_CodigoID(

            //CodigosID
            int idcodigoid, string letra_alumno, string simbolo_alumno, string numero_alumno, string letra_empleado, string simbolo_empleado,
            string numero_empleado,

            //Filtros de Busquda
            string filtro, string auto

            )
        {

            //CodigoID Alumnos
            this.Idcodigoid = idcodigoid;
            this.Letra_Alumno = letra_alumno;
            this.Simbolo_Alumno = simbolo_alumno;
            this.Numero_Alumno = numero_alumno;

            //CodigoID Empleados
            this.Letra_Empleado = letra_empleado;
            this.Simbolo_Empleado = simbolo_empleado;
            this.Numero_Empleado = numero_empleado;

            //Filtros de Busquda
            this.Filtro = filtro;
            this.Auto = auto;
        }

        public string Guardar_Salud(Conexion_Configuracion_CodigoID CodigoID)
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
                SqlCmd.CommandText = "Configuracion.AJ_CodigoID_Alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno = new SqlParameter();
                ParIdalumno.ParameterName = "@Iddatosmedicos";
                ParIdalumno.SqlDbType = SqlDbType.Int;
                ParIdalumno.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.Int;
                ParCodigoID.Value = CodigoID.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = CodigoID.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParRh = new SqlParameter();
                ParRh.ParameterName = "@Rh";
                ParRh.SqlDbType = SqlDbType.VarChar;
                ParRh.Size = 10;
                ParRh.Value = CodigoID.GrupoSanguineo;
                SqlCmd.Parameters.Add(ParRh);

                SqlParameter ParEPS = new SqlParameter();
                ParEPS.ParameterName = "@EPS";
                ParEPS.SqlDbType = SqlDbType.VarChar;
                ParEPS.Size = 20;
                ParEPS.Value = CodigoID.Eps;
                SqlCmd.Parameters.Add(ParEPS);

                SqlParameter ParAlimentos = new SqlParameter();
                ParAlimentos.ParameterName = "@Alimentos";
                ParAlimentos.SqlDbType = SqlDbType.VarChar;
                ParAlimentos.Size = 100;
                ParAlimentos.Value = CodigoID.Alimentos;
                SqlCmd.Parameters.Add(ParAlimentos);

                SqlParameter ParAnimales = new SqlParameter();
                ParAnimales.ParameterName = "@Animales";
                ParAnimales.SqlDbType = SqlDbType.VarChar;
                ParAnimales.Size = 100;
                ParAnimales.Value = CodigoID.Animales;
                SqlCmd.Parameters.Add(ParAnimales);

                SqlParameter ParInsectos = new SqlParameter();
                ParInsectos.ParameterName = "@Insectos";
                ParInsectos.SqlDbType = SqlDbType.VarChar;
                ParInsectos.Size = 100;
                ParInsectos.Value = CodigoID.Insectos;
                SqlCmd.Parameters.Add(ParInsectos);

                SqlParameter ParMedicamentos = new SqlParameter();
                ParMedicamentos.ParameterName = "@Medicamentos";
                ParMedicamentos.SqlDbType = SqlDbType.VarChar;
                ParMedicamentos.Size = 100;
                ParMedicamentos.Value = CodigoID.Medicamentos;
                SqlCmd.Parameters.Add(ParMedicamentos);

                SqlParameter ParPlantas = new SqlParameter();
                ParPlantas.ParameterName = "@Plantas";
                ParPlantas.SqlDbType = SqlDbType.VarChar;
                ParPlantas.Size = 100;
                ParPlantas.Value = CodigoID.Plantas;
                SqlCmd.Parameters.Add(ParPlantas);

                SqlParameter ParOtros = new SqlParameter();
                ParOtros.ParameterName = "@Otros";
                ParOtros.SqlDbType = SqlDbType.VarChar;
                ParOtros.Size = 100;
                ParOtros.Value = Salud.Otros;
                SqlCmd.Parameters.Add(ParOtros);

                SqlParameter ParIndicaciones = new SqlParameter();
                ParIndicaciones.ParameterName = "@Indicaciones";
                ParIndicaciones.SqlDbType = SqlDbType.VarChar;
                ParIndicaciones.Size = 100;
                ParIndicaciones.Value = Salud.Indicaciones;
                SqlCmd.Parameters.Add(ParIndicaciones);



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

        public DataTable AutoCompletar_Alumno()
        {
            DataTable DtResultado = new DataTable("Configuracion.CodigoID_Alumno");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Configuracion.Auto_Alumno";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {

                DtResultado = null;
            }
            return DtResultado;
        }


    }
}
