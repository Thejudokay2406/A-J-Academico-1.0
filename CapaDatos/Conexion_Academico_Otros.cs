using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Academico_Otros
    {
        //Llaves primarias
        private int _Idotros;
        private int _CodigoID;

        //Campos Auxiliares
        private string _Auto;
        private string _Filtro;

        //Otros Datos
        private string _InstitutoAnterior;
        private string _NombreInstituto;
        private string _UltimoCurso;
        private string _UltimaJornada;
        private string _Documento1;
        private string _Documento2;
        private string _Documento3;
        private string _Documento4;
        private string _Documento5;
        private string _Documento6;
        private string _Documento7;
        private string _Documento8;
        private string _Documento9;
        private string _Documento10;
        private string _Documento11;
        private string _Documento12;
        private string _Documento13;
        private string _Documento14;
        private string _Documento15;
        private string _Documento16;
        private string _Documento17;
        private string _Documento18;
        private string _Documento19;
        private string _Documento20;

        public int Idotros
        {
            get
            {
                return _Idotros;
            }

            set
            {
                _Idotros = value;
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

        public string InstitutoAnterior
        {
            get
            {
                return _InstitutoAnterior;
            }

            set
            {
                _InstitutoAnterior = value;
            }
        }

        public string NombreInstituto
        {
            get
            {
                return _NombreInstituto;
            }

            set
            {
                _NombreInstituto = value;
            }
        }

        public string UltimoCurso
        {
            get
            {
                return _UltimoCurso;
            }

            set
            {
                _UltimoCurso = value;
            }
        }

        public string UltimaJornada
        {
            get
            {
                return _UltimaJornada;
            }

            set
            {
                _UltimaJornada = value;
            }
        }

        public string Documento1
        {
            get
            {
                return _Documento1;
            }

            set
            {
                _Documento1 = value;
            }
        }

        public string Documento2
        {
            get
            {
                return _Documento2;
            }

            set
            {
                _Documento2 = value;
            }
        }

        public string Documento3
        {
            get
            {
                return _Documento3;
            }

            set
            {
                _Documento3 = value;
            }
        }

        public string Documento4
        {
            get
            {
                return _Documento4;
            }

            set
            {
                _Documento4 = value;
            }
        }

        public string Documento5
        {
            get
            {
                return _Documento5;
            }

            set
            {
                _Documento5 = value;
            }
        }

        public string Documento6
        {
            get
            {
                return _Documento6;
            }

            set
            {
                _Documento6 = value;
            }
        }

        public string Documento7
        {
            get
            {
                return _Documento7;
            }

            set
            {
                _Documento7 = value;
            }
        }

        public string Documento8
        {
            get
            {
                return _Documento8;
            }

            set
            {
                _Documento8 = value;
            }
        }

        public string Documento9
        {
            get
            {
                return _Documento9;
            }

            set
            {
                _Documento9 = value;
            }
        }

        public string Documento10
        {
            get
            {
                return _Documento10;
            }

            set
            {
                _Documento10 = value;
            }
        }

        public string Documento11
        {
            get
            {
                return _Documento11;
            }

            set
            {
                _Documento11 = value;
            }
        }

        public string Documento12
        {
            get
            {
                return _Documento12;
            }

            set
            {
                _Documento12 = value;
            }
        }

        public string Documento13
        {
            get
            {
                return _Documento13;
            }

            set
            {
                _Documento13 = value;
            }
        }

        public string Documento14
        {
            get
            {
                return _Documento14;
            }

            set
            {
                _Documento14 = value;
            }
        }

        public string Documento15
        {
            get
            {
                return _Documento15;
            }

            set
            {
                _Documento15 = value;
            }
        }

        public string Documento16
        {
            get
            {
                return _Documento16;
            }

            set
            {
                _Documento16 = value;
            }
        }

        public string Documento17
        {
            get
            {
                return _Documento17;
            }

            set
            {
                _Documento17 = value;
            }
        }

        public string Documento18
        {
            get
            {
                return _Documento18;
            }

            set
            {
                _Documento18 = value;
            }
        }

        public string Documento19
        {
            get
            {
                return _Documento19;
            }

            set
            {
                _Documento19 = value;
            }
        }

        public string Documento20
        {
            get
            {
                return _Documento20;
            }

            set
            {
                _Documento20 = value;
            }
        }

        public int CodigoID
        {
            get
            {
                return _CodigoID;
            }

            set
            {
                _CodigoID = value;
            }
        }

        //Constructor Vacio
        public Conexion_Academico_Otros()
        {

        }
        //Constructor con todos los parametros
        public Conexion_Academico_Otros(
            
            //Otros Datos
            int codigoid,int idotros, string institutoanterior, string nombreinstituto, string ultimocurso, string ultimajornada,
            string documento1, string documento2, string documento3, string documento4, string documento5, string documento6, string documento7, string documento8, string documento9,
            string documento10, string documento11, string documento12, string documento13, string documento14, string documento15, string documento16, string documento17, string documento18, string documento19, string documento20,

            //Filtros de Busquda
            string filtro

            )
        {
            this.CodigoID = codigoid;
            //Otros Datos
            this.InstitutoAnterior = institutoanterior;
            this.NombreInstituto = nombreinstituto;
            this.UltimoCurso = ultimocurso;
            this.UltimaJornada = ultimajornada;
            this.Documento1 = documento1;
            this.Documento2 = documento2;
            this.Documento3 = documento3;
            this.Documento4 = documento4;
            this.Documento5 = documento5;
            this.Documento6 = documento6;
            this.Documento7 = documento7;
            this.Documento8 = documento8;
            this.Documento9 = documento9;
            this.Documento10 = documento10;
            this.Documento11 = documento11;
            this.Documento12 = documento12;
            this.Documento13 = documento13;
            this.Documento14 = documento14;
            this.Documento15 = documento15;
            this.Documento16 = documento16;
            this.Documento17 = documento17;
            this.Documento18 = documento18;
            this.Documento19 = documento19;
            this.Documento20 = documento20;

            //Filtros de Busquda
            this.Filtro = filtro;
        }

        public string Guardar_Otros(Conexion_Academico_Otros Otros)
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
                SqlCmd.CommandText = "Academico.AJ_Otros";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdalumno_Ot = new SqlParameter();
                ParIdalumno_Ot.ParameterName = "@Idotros";
                ParIdalumno_Ot.SqlDbType = SqlDbType.Int;
                ParIdalumno_Ot.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdalumno_Ot);

                SqlParameter ParCodigoID = new SqlParameter();
                ParCodigoID.ParameterName = "@CodigoID";
                ParCodigoID.SqlDbType = SqlDbType.Int;
                ParCodigoID.Value = Otros.CodigoID;
                SqlCmd.Parameters.Add(ParCodigoID);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.VarChar;
                ParAuto.Size = 1;
                ParAuto.Value = Otros.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParInstitutoAnterior = new SqlParameter();
                ParInstitutoAnterior.ParameterName = "@InstitutoAnterior";
                ParInstitutoAnterior.SqlDbType = SqlDbType.VarChar;
                ParInstitutoAnterior.Size = 50;
                ParInstitutoAnterior.Value = Otros.InstitutoAnterior;
                SqlCmd.Parameters.Add(ParInstitutoAnterior);

                SqlParameter ParInstituto = new SqlParameter();
                ParInstituto.ParameterName = "@Instituto";
                ParInstituto.SqlDbType = SqlDbType.VarChar;
                ParInstituto.Size = 50;
                ParInstituto.Value = Otros.NombreInstituto;
                SqlCmd.Parameters.Add(ParInstituto);

                SqlParameter ParCurso_Ot = new SqlParameter();
                ParCurso_Ot.ParameterName = "@Curso";
                ParCurso_Ot.SqlDbType = SqlDbType.VarChar;
                ParCurso_Ot.Size = 20;
                ParCurso_Ot.Value = Otros.UltimoCurso;
                SqlCmd.Parameters.Add(ParCurso_Ot);

                SqlParameter ParJornada_Ot = new SqlParameter();
                ParJornada_Ot.ParameterName = "@Jornada";
                ParJornada_Ot.SqlDbType = SqlDbType.VarChar;
                ParJornada_Ot.Size = 20;
                ParJornada_Ot.Value = Otros.UltimaJornada;
                SqlCmd.Parameters.Add(ParJornada_Ot);

                SqlParameter ParDocumento1 = new SqlParameter();
                ParDocumento1.ParameterName = "@Documento1";
                ParDocumento1.SqlDbType = SqlDbType.VarChar;
                ParDocumento1.Size = 20;
                ParDocumento1.Value = Otros.Documento1;
                SqlCmd.Parameters.Add(ParDocumento1);

                SqlParameter ParDocumento2 = new SqlParameter();
                ParDocumento2.ParameterName = "@Documento2";
                ParDocumento2.SqlDbType = SqlDbType.VarChar;
                ParDocumento2.Size = 20;
                ParDocumento2.Value = Otros.Documento2;
                SqlCmd.Parameters.Add(ParDocumento2);

                SqlParameter ParDocumento3 = new SqlParameter();
                ParDocumento3.ParameterName = "@Documento3";
                ParDocumento3.SqlDbType = SqlDbType.VarChar;
                ParDocumento3.Size = 20;
                ParDocumento3.Value = Otros.Documento3;
                SqlCmd.Parameters.Add(ParDocumento3);

                SqlParameter ParDocumento4 = new SqlParameter();
                ParDocumento4.ParameterName = "@Documento4";
                ParDocumento4.SqlDbType = SqlDbType.VarChar;
                ParDocumento4.Size = 20;
                ParDocumento4.Value = Otros.Documento4;
                SqlCmd.Parameters.Add(ParDocumento4);

                SqlParameter ParDocumento5 = new SqlParameter();
                ParDocumento5.ParameterName = "@Documento5";
                ParDocumento5.SqlDbType = SqlDbType.VarChar;
                ParDocumento5.Size = 20;
                ParDocumento5.Value = Otros.Documento5;
                SqlCmd.Parameters.Add(ParDocumento5);

                SqlParameter ParDocumento6 = new SqlParameter();
                ParDocumento6.ParameterName = "@Documento6";
                ParDocumento6.SqlDbType = SqlDbType.VarChar;
                ParDocumento6.Size = 20;
                ParDocumento6.Value = Otros.Documento6;
                SqlCmd.Parameters.Add(ParDocumento6);

                SqlParameter ParDocumento7 = new SqlParameter();
                ParDocumento7.ParameterName = "@Documento7";
                ParDocumento7.SqlDbType = SqlDbType.VarChar;
                ParDocumento7.Size = 20;
                ParDocumento7.Value = Otros.Documento7;
                SqlCmd.Parameters.Add(ParDocumento7);

                SqlParameter ParDocumento8 = new SqlParameter();
                ParDocumento8.ParameterName = "@Documento8";
                ParDocumento8.SqlDbType = SqlDbType.VarChar;
                ParDocumento8.Size = 100;
                ParDocumento8.Value = Otros.Documento8;
                SqlCmd.Parameters.Add(ParDocumento8);

                SqlParameter ParDocumento9 = new SqlParameter();
                ParDocumento9.ParameterName = "@Documento9";
                ParDocumento9.SqlDbType = SqlDbType.VarChar;
                ParDocumento9.Size = 20;
                ParDocumento9.Value = Otros.Documento9;
                SqlCmd.Parameters.Add(ParDocumento9);

                SqlParameter ParDocumento10 = new SqlParameter();
                ParDocumento10.ParameterName = "@Documento10";
                ParDocumento10.SqlDbType = SqlDbType.VarChar;
                ParDocumento10.Size = 20;
                ParDocumento10.Value = Otros.Documento10;
                SqlCmd.Parameters.Add(ParDocumento10);

                SqlParameter ParDocumento11 = new SqlParameter();
                ParDocumento11.ParameterName = "@Documento11";
                ParDocumento11.SqlDbType = SqlDbType.VarChar;
                ParDocumento11.Size = 20;
                ParDocumento11.Value = Otros.Documento11;
                SqlCmd.Parameters.Add(ParDocumento11);

                SqlParameter ParDocumento12 = new SqlParameter();
                ParDocumento12.ParameterName = "@Documento12";
                ParDocumento12.SqlDbType = SqlDbType.VarChar;
                ParDocumento12.Size = 20;
                ParDocumento12.Value = Otros.Documento12;
                SqlCmd.Parameters.Add(ParDocumento12);

                SqlParameter ParDocumento13 = new SqlParameter();
                ParDocumento13.ParameterName = "@Documento13";
                ParDocumento13.SqlDbType = SqlDbType.VarChar;
                ParDocumento13.Size = 20;
                ParDocumento13.Value = Otros.Documento13;
                SqlCmd.Parameters.Add(ParDocumento13);

                SqlParameter ParDocumento14 = new SqlParameter();
                ParDocumento14.ParameterName = "@Documento14";
                ParDocumento14.SqlDbType = SqlDbType.VarChar;
                ParDocumento14.Size = 20;
                ParDocumento14.Value = Otros.Documento14;
                SqlCmd.Parameters.Add(ParDocumento14);

                SqlParameter ParDocumento15 = new SqlParameter();
                ParDocumento15.ParameterName = "@Documento15";
                ParDocumento15.SqlDbType = SqlDbType.VarChar;
                ParDocumento15.Size = 20;
                ParDocumento15.Value = Otros.Documento15;
                SqlCmd.Parameters.Add(ParDocumento15);

                SqlParameter ParDocumento16 = new SqlParameter();
                ParDocumento16.ParameterName = "@Documento16";
                ParDocumento16.SqlDbType = SqlDbType.VarChar;
                ParDocumento16.Size = 20;
                ParDocumento16.Value = Otros.Documento16;
                SqlCmd.Parameters.Add(ParDocumento16);

                SqlParameter ParDocumento17 = new SqlParameter();
                ParDocumento17.ParameterName = "@Documento17";
                ParDocumento17.SqlDbType = SqlDbType.VarChar;
                ParDocumento17.Size = 20;
                ParDocumento17.Value = Otros.Documento17;
                SqlCmd.Parameters.Add(ParDocumento17);

                SqlParameter ParDocumento18 = new SqlParameter();
                ParDocumento18.ParameterName = "@Documento18";
                ParDocumento18.SqlDbType = SqlDbType.VarChar;
                ParDocumento18.Size = 20;
                ParDocumento18.Value = Otros.Documento18;
                SqlCmd.Parameters.Add(ParDocumento18);

                SqlParameter ParDocumento19 = new SqlParameter();
                ParDocumento19.ParameterName = "@Documento19";
                ParDocumento19.SqlDbType = SqlDbType.VarChar;
                ParDocumento19.Size = 20;
                ParDocumento19.Value = Otros.Documento19;
                SqlCmd.Parameters.Add(ParDocumento19);

                SqlParameter ParDocumento20 = new SqlParameter();
                ParDocumento20.ParameterName = "@Documento20";
                ParDocumento20.SqlDbType = SqlDbType.VarChar;
                ParDocumento20.Size = 20;
                ParDocumento20.Value = Otros.Documento20;
                SqlCmd.Parameters.Add(ParDocumento20);


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
