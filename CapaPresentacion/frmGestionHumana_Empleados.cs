using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmGestionHumana_Empleados : Form
    {
        private bool IsNuevo = false;

        private DataTable dtDetalle_Experiencias;
        private DataTable dtDetalle_Formacion;
        private DataTable dtDetalle_Referencia;
        
        public frmGestionHumana_Empleados()
        {
            InitializeComponent();
        }

        private void frmPlantel_Empleados_Load(object sender, EventArgs e)
        {
            this.Botones();
            this.Habilitar();

            this.CBIdentificacion.SelectedIndex = 0;
            this.CBHorasExtras.SelectedIndex = 0;
            this.CBAdelantos.SelectedIndex = 0;

        }

        private void ColoresDeBotones()
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;

            btnAgregar_Experiencia.BackgroundImage = Properties.Resources.BV_Agregar;
            btnAgregar_Formacion.BackgroundImage = Properties.Resources.BV_Agregar;
            btnAgregar_Referencia.BackgroundImage = Properties.Resources.BV_Agregar;
            btnEliminar_Experiencia.BackgroundImage = Properties.Resources.BV_Eliminar;
            btnEliminar_Formacion.BackgroundImage = Properties.Resources.BV_Eliminar;
            btnEliminar_Referencia.BackgroundImage = Properties.Resources.BV_Eliminar;

            this.PanelFoto.Image = global::CapaPresentacion.Properties.Resources.A_J_Academico;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                //Datos Basicos
                this.TBNombre.ReadOnly = true;
                this.TBNombre.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProfesion.ReadOnly = true;
                this.TBProfesion.BackColor = Color.FromArgb(187, 222, 251);
                this.CBIdentificacion.Enabled = false;
                this.CBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBIdentificacion.ReadOnly = true;
                this.TBIdentificacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBExpedicion.ReadOnly = true;
                this.TBExpedicion.BackColor = Color.FromArgb(187, 222, 251);
                this.DTFechaExpedicion.Enabled = false;
                this.DTFechaExpedicion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBEmail.ReadOnly = true;
                this.TBEmail.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono.ReadOnly = true;
                this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDireccion.ReadOnly = true;
                this.TBDireccion.BackColor = Color.FromArgb(187, 222, 251);
                this.DTFechaDeIngreso.Enabled = false;
                this.DTFechaDeIngreso.BackColor = Color.FromArgb(187, 222, 251);
                this.DTFechadesalida.Enabled = false;
                this.DTFechadesalida.BackColor = Color.FromArgb(187, 222, 251);

                //Experiencia
                this.TBEntidad_Experiencias.ReadOnly = true;
                this.TBEntidad_Experiencias.BackColor = Color.FromArgb(187, 222, 251);
                this.TBCargo_Experiencias.ReadOnly = true;
                this.TBCargo_Experiencias.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTiempo_Experiencias.ReadOnly = true;
                this.TBTiempo_Experiencias.BackColor = Color.FromArgb(187, 222, 251);

                //Formacion
                this.TBEntidad_Formacion.ReadOnly = true;
                this.TBEntidad_Formacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProfesion_Formacion.ReadOnly = true;
                this.TBProfesion_Formacion.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTiempo_Formacion.ReadOnly = true;
                this.TBTiempo_Formacion.BackColor = Color.FromArgb(187, 222, 251);

                //Referencias
                this.TBEntidad_Referencias.ReadOnly = true;
                this.TBEntidad_Referencias.BackColor = Color.FromArgb(187, 222, 251);
                this.TBProfesion_Referencias.ReadOnly = true;
                this.TBProfesion_Referencias.BackColor = Color.FromArgb(187, 222, 251);
                this.TBTelefono_Referencias.ReadOnly = true;
                this.TBTelefono_Referencias.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBNombre.ReadOnly = false;
                this.TBNombre.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProfesion.ReadOnly = false;
                this.TBProfesion.BackColor = Color.FromArgb(32, 178, 170);
                this.CBIdentificacion.Enabled = true;
                this.CBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBIdentificacion.ReadOnly = false;
                this.TBIdentificacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBExpedicion.ReadOnly = false;
                this.TBExpedicion.BackColor = Color.FromArgb(32, 178, 170);
                this.DTFechaExpedicion.Enabled = true;
                this.DTFechaExpedicion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBEmail.ReadOnly = false;
                this.TBEmail.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono.ReadOnly = false;
                this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
                this.CBBEstado.Enabled = true;
                this.CBBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDireccion.ReadOnly = false;
                this.TBDireccion.BackColor = Color.FromArgb(32, 178, 170);
                this.DTFechaDeIngreso.Enabled = true;
                this.DTFechaDeIngreso.BackColor = Color.FromArgb(32, 178, 170);
                this.DTFechadesalida.Enabled = true;
                this.DTFechadesalida.BackColor = Color.FromArgb(32, 178, 170);

                //Experiencia
                this.TBEntidad_Experiencias.ReadOnly = false;
                this.TBEntidad_Experiencias.BackColor = Color.FromArgb(32, 178, 170);
                this.TBCargo_Experiencias.ReadOnly = false;
                this.TBCargo_Experiencias.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTiempo_Experiencias.ReadOnly = false;
                this.TBTiempo_Experiencias.BackColor = Color.FromArgb(32, 178, 170);

                //Formacion Academica
                this.TBEntidad_Formacion.ReadOnly = false;
                this.TBEntidad_Formacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProfesion_Formacion.ReadOnly = false;
                this.TBProfesion_Formacion.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTiempo_Formacion.ReadOnly = false;
                this.TBTiempo_Formacion.BackColor = Color.FromArgb(32, 178, 170);

                //Referencia
                this.TBEntidad_Referencias.ReadOnly = false;
                this.TBEntidad_Referencias.BackColor = Color.FromArgb(32, 178, 170);
                this.TBProfesion_Referencias.ReadOnly = false;
                this.TBProfesion_Referencias.BackColor = Color.FromArgb(32, 178, 170);
                this.TBTelefono_Referencias.ReadOnly = false;
                this.TBTelefono_Referencias.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            //
            this.TBNombre.Text = string.Empty;
            this.TBProfesion.Text = string.Empty;
            this.CBIdentificacion.Text = string.Empty;
            this.TBIdentificacion.Text = string.Empty;
            this.TBExpedicion.Text = string.Empty;
            this.DTFechaExpedicion.Text = string.Empty;
            this.TBEmail.Text = string.Empty;
            this.TBTelefono.Text = string.Empty;
            this.CBBEstado.Text = string.Empty;
            this.TBDireccion.Text = string.Empty;
            this.DTFechaDeIngreso.Text = string.Empty;
            this.DTFechadesalida.Text = string.Empty;

            //Experiencia
            this.TBEntidad_Experiencias.Text = string.Empty;
            this.TBProfesion.Text = string.Empty;
            this.TBTiempo_Experiencias.Text = string.Empty;

            //Formacion Academica
            this.TBEntidad_Formacion.Text = string.Empty;
            this.TBProfesion_Formacion.Text = string.Empty;
            this.TBTiempo_Formacion.Text = string.Empty;

            //Referencia
            this.TBEntidad_Referencias.Text = string.Empty;
            this.TBProfesion_Referencias.Text = string.Empty;
            this.TBTelefono_Referencias.Text = string.Empty;
        }


        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
                this.btnAgregar_Experiencia.Visible = true;
                this.btnAgregar_Formacion.Visible = true;
                this.btnAgregar_Referencia.Visible = true;

                this.btnEliminar_Experiencia.Visible = true;
                this.btnEliminar_Formacion.Visible = true;
                this.btnEliminar_Referencia.Visible = true;
            }

            else
            {
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;

                this.btnAgregar_Experiencia.Visible = false;
                this.btnAgregar_Formacion.Visible = false;
                this.btnAgregar_Referencia.Visible = false;

                this.btnEliminar_Experiencia.Visible = false;
                this.btnEliminar_Formacion.Visible = false;
                this.btnEliminar_Referencia.Visible = false;
            }
        }


        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "A&J Academico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "A&J Academico - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Crea la tabla de Detalle 
        private void CrearTabla_Experiencias()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle_Experiencias = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle_Experiencias.Columns.Add("CodigoID", System.Type.GetType("System.String"));
            this.dtDetalle_Experiencias.Columns.Add("Empresa", System.Type.GetType("System.String"));
            this.dtDetalle_Experiencias.Columns.Add("Cargo", System.Type.GetType("System.String"));
            this.dtDetalle_Experiencias.Columns.Add("Tiempo", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGExperiencias.DataSource = this.dtDetalle_Experiencias;

            lblTotalExperiencia.Text = "Datos a Registrar: " + Convert.ToString(DGExperiencias.Rows.Count);

        }

        private void CrearTabla_Formacion()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle_Formacion = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle_Formacion.Columns.Add("CodigoID", System.Type.GetType("System.String"));
            this.dtDetalle_Formacion.Columns.Add("Entidad", System.Type.GetType("System.String"));
            this.dtDetalle_Formacion.Columns.Add("Carrera", System.Type.GetType("System.String"));
            this.dtDetalle_Formacion.Columns.Add("Año", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGFormacion.DataSource = this.dtDetalle_Formacion;

            lblTotalFormacion.Text = "Datos a Registrar: " + Convert.ToString(DGFormacion.Rows.Count);

        }

        private void CrearTabla_Referencias()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle_Referencia = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle_Referencia.Columns.Add("CodigoID", System.Type.GetType("System.String"));
            this.dtDetalle_Referencia.Columns.Add("Referencia", System.Type.GetType("System.String"));
            this.dtDetalle_Referencia.Columns.Add("Profesion", System.Type.GetType("System.String"));
            this.dtDetalle_Referencia.Columns.Add("Telefono", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGReferencia.DataSource = this.dtDetalle_Referencia;

            lblTotalReferencia.Text = "Datos a Registrar: " + Convert.ToString(DGReferencia.Rows.Count);

        }

        private void limpiarDetalle()
        {
            //Datos Basicos
            this.TBNombre.Text = string.Empty;
            this.TBProfesion.Text = string.Empty; ;
            this.TBIdentificacion.Text = string.Empty;
            this.TBExpedicion.Text = string.Empty;
            this.TBEmail.Text = string.Empty;
            this.TBTelefono.Text = string.Empty; ;
            this.TBDireccion.Text = string.Empty;

            this.TBCodigoID.Text = string.Empty;

            //Datos de Formacion
            this.TBEntidad_Formacion.Text = string.Empty;
            this.TBProfesion_Formacion.Text = string.Empty; ;
            this.TBTiempo_Formacion.Text = string.Empty;

            //Datos de referencia
            this.TBEntidad_Referencias.Text = string.Empty;
            this.TBProfesion_Referencias.Text = string.Empty; ;
            this.TBTelefono_Referencias.Text = string.Empty;

            //Datos de Experiencia
            this.TBEntidad_Experiencias.Text = string.Empty;
            this.TBCargo_Experiencias.Text = string.Empty; ;
            this.TBTiempo_Experiencias.Text = string.Empty;
            
        }

        private void Combobox()
        {
            try
            {
                CBRol.DataSource = fSistema_Gestion_Roles.Mostrar();
                CBRol.ValueMember = "Idrol";
                CBRol.DisplayMember = "Rol";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CBIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBIdentificacion.SelectedIndex == 0)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void PanelFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.PanelFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.PanelFoto.Image = Image.FromFile(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.IsNuevo = true;
                this.Botones();
                this.Habilitar();

                this.CrearTabla_Experiencias();
                this.CrearTabla_Formacion();
                this.CrearTabla_Referencias();
                this.limpiarDetalle();
                this.Combobox();
                this.TBNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";
                string rptaDatosPersonales = "";
                string rptaDatosMedicos = "";
                //string rptaExperiencia = "";
                //string rptaFormacion = "";
                //string rptaReferencia = "";

                //Datos Basicos
                if (this.TBNombre.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBNombre.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBProfesion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBProfesion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBIdentificacion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBIdentificacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBIdentificacion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBIdentificacion.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fGestion_Empleados.Guardar_DatosBasicos("1", Convert.ToInt32(this.CBRol.SelectedValue), this.TBCodigoID.Text, this.CBBEstado.Text, this.TBNombre.Text, this.TBProfesion.Text, this.CBIdentificacion.Text, this.TBIdentificacion.Text, this.TBExpedicion.Text, this.DTFechaExpedicion.Value, this.TBEmail.Text, this.TBTelefono.Text, this.TBDireccion.Text, this.DTFechaDeIngreso.Value, this.DTFechadesalida.Value, dtDetalle_Experiencias, dtDetalle_Formacion, dtDetalle_Referencia);
                        rptaDatosMedicos = fGestion_DatosMedicos.Guardar_DatosBasicos(Convert.ToInt32("1"), this.TBCodigoID.Text, "1", this.CBRh.Text, this.CBEps.Text, this.TBAlimentos.Text, this.TBAnimales.Text, this.TBInsectos.Text, this.TBMedicamentos.Text, this.TBPlantas.Text, this.TBIndicaciones.Text);
                        rptaDatosPersonales = fGestion_DatosPersonales.Guardar_DatosBasicos(Convert.ToInt32("1"), this.TBCodigoID.Text, "1", this.TBProfesionprincipal.Text, this.CBPension.Text, this.CBFondo.Text, this.CBContrato.Text, this.TBSueldo.Text, this.CBAdelantos.Text, this.CBHorasExtras.Text, this.CBBanco.Text, this.CBCuenta.Text, TBNumerodecuenta.Text, this.CBPago.Text, this.CBMoneda.Text, this.TBRecomendado.Text, this.DTNacimiento.Value, this.TBHijos.Text, this.TBHijosPlantel.Text, this.CBCivil.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK") && rptaDatosMedicos.Equals("OK") && rptaDatosPersonales.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Empleado Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnAgregar_Experiencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TBEntidad_Experiencias.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Campos, Estos Seran Remarcados");
                    TBEntidad_Experiencias.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCargo_Experiencias.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Campos, Estos Seran Remarcados");
                    TBCargo_Experiencias.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBTiempo_Experiencias.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Campos, Estos Seran Remarcados");
                    TBTiempo_Experiencias.BackColor = Color.FromArgb(250, 235, 215);
                }
                
                else
                {
                    //Agregamos el detalle a la tabla

                    DataRow row = this.dtDetalle_Experiencias.NewRow();
                    row["CodigoID"] = this.TBCodigoID.Text;
                    row["Empresa"] = this.TBEntidad_Experiencias.Text;
                    row["Cargo"] = this.TBCargo_Experiencias.Text;
                    row["Tiempo"] = this.TBTiempo_Experiencias.Text;
                    this.dtDetalle_Experiencias.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Experiencia_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = DGExperiencias.CurrentRow.Index;
                DGExperiencias.Rows.RemoveAt(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Formacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TBEntidad_Formacion.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Campos, Estos Seran Remarcados");
                    TBEntidad_Formacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBProfesion_Formacion.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Campos, Estos Seran Remarcados");
                    TBProfesion_Formacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBTiempo_Formacion.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Campos, Estos Seran Remarcados");
                    TBTiempo_Formacion.BackColor = Color.FromArgb(250, 235, 215);
                }
                
                else
                {
                    //Agregamos el detalle a la tabla

                    DataRow row = this.dtDetalle_Formacion.NewRow();
                    row["CodigoID"] = this.TBCodigoID.Text;
                    row["Entidad"] = this.TBEntidad_Formacion.Text;
                    row["Carrera"] = this.TBProfesion_Formacion.Text;
                    row["Año"] = this.TBTiempo_Formacion.Text;
                    this.dtDetalle_Formacion.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Formacion_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = DGFormacion.CurrentRow.Index;
                DGFormacion.Rows.RemoveAt(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Referencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TBEntidad_Referencias.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Campos, Estos Seran Remarcados");
                    TBEntidad_Referencias.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBProfesion_Referencias.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Articulos, Estos Seran Remarcados");
                    TBProfesion_Referencias.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBTelefono_Referencias.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Algunos Articulos, Estos Seran Remarcados");
                    TBTelefono_Referencias.BackColor = Color.FromArgb(250, 235, 215);
                }
                
                else
                {
                    //Agregamos el detalle a la tabla

                    DataRow row = this.dtDetalle_Referencia.NewRow();
                    row["CodigoID"] = this.TBCodigoID.Text;
                    row["Referencia"] = this.TBEntidad_Referencias.Text;
                    row["Profesion"] = this.TBProfesion_Referencias.Text;
                    row["Telefono"] = this.TBTelefono_Referencias.Text;
                    this.dtDetalle_Referencia.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Referencia_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = DGReferencia.CurrentRow.Index;
                DGReferencia.Rows.RemoveAt(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGExperiencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Delete))
                {
                    int fila = DGExperiencias.CurrentRow.Index;
                    DGExperiencias.Rows.RemoveAt(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGFormacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Delete))
                {
                    int fila = DGFormacion.CurrentRow.Index;
                    DGFormacion.Rows.RemoveAt(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Delete))
                {
                    int fila = DGReferencia.CurrentRow.Index;
                    DGReferencia.Rows.RemoveAt(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void btnNuevo_MouseDown(object sender, MouseEventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
        }

        private void btnNuevo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNuevo.BackgroundImage = Properties.Resources.BR_Nuevo;
        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            btnGuardar.BackgroundImage = Properties.Resources.BR_Guardar;
        }

        private void btnAgregar_Experiencia_MouseDown(object sender, MouseEventArgs e)
        {
            btnAgregar_Experiencia.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void btnAgregar_Experiencia_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar_Experiencia.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void btnAgregar_Experiencia_MouseMove(object sender, MouseEventArgs e)
        {
            btnAgregar_Experiencia.BackgroundImage = Properties.Resources.BR_Agregar;
        }

        private void btnEliminar_Experiencia_MouseDown(object sender, MouseEventArgs e)
        {
            btnEliminar_Experiencia.BackgroundImage = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_Experiencia_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar_Experiencia.BackgroundImage = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_Experiencia_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminar_Experiencia.BackgroundImage = Properties.Resources.BR_Eliminar;
        }

        private void btnAgregar_Formacion_MouseDown(object sender, MouseEventArgs e)
        {
            btnAgregar_Formacion.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void btnAgregar_Formacion_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar_Formacion.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void btnAgregar_Formacion_MouseMove(object sender, MouseEventArgs e)
        {
            btnAgregar_Formacion.BackgroundImage = Properties.Resources.BR_Agregar;
        }

        private void btnEliminar_Formacion_MouseDown(object sender, MouseEventArgs e)
        {
            btnEliminar_Formacion.BackgroundImage = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_Formacion_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar_Formacion.BackgroundImage = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_Formacion_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminar_Formacion.BackgroundImage = Properties.Resources.BR_Eliminar;
        }

        private void btnAgregar_Referencia_MouseDown(object sender, MouseEventArgs e)
        {
            btnAgregar_Referencia.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void btnAgregar_Referencia_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar_Referencia.BackgroundImage = Properties.Resources.BV_Agregar;
        }

        private void btnAgregar_Referencia_MouseMove(object sender, MouseEventArgs e)
        {
            btnAgregar_Referencia.BackgroundImage = Properties.Resources.BR_Agregar;
        }

        private void btnEliminar_Referencia_MouseDown(object sender, MouseEventArgs e)
        {
            btnEliminar_Referencia.BackgroundImage = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_Referencia_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar_Referencia.BackgroundImage = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_Referencia_MouseMove(object sender, MouseEventArgs e)
        {
            btnEliminar_Referencia.BackgroundImage = Properties.Resources.BR_Eliminar;
        }
                
    }
}
