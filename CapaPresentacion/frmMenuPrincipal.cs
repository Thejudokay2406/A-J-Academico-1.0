using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public string Idempleado = "";
        public string Empleado = "";
        public string Cede = "";
        public string BaseDeDatos = "";

        public string UsuarioLogueado = "";
        //Menu Principal
        public string MenuArchivo = "";
        public string MenuAcademico = "";
        public string MenuBiblioteca = "";
        public string MenuAlmacen = "";
        public string MenuDotacion = "";
        public string MenuConsultas = "";
        public string MenuPagos = "";
        public string MenuReportes = "";
        public string MenuReciclaje = "";
        public string MenuVentas = "";

        //Sub Menu Archivo

        public string SubMTrabajador = "";
        public string SubMServicios = "";
        public string SubMUsuarios = "";

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.toolStripLabel3.Text = Empleado;
            this.toolStripLabel7.Text = Cede;
        }

        private void GestionDeUsuarios()
        {

        }

        private void datosDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracion_DatosDeSeguridad frmConfiguracion_DatosDeSeguridad = new frmConfiguracion_DatosDeSeguridad();
            frmConfiguracion_DatosDeSeguridad.MdiParent = this;
            frmConfiguracion_DatosDeSeguridad.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Alumnos frmAcademico_Alumnos = frmAcademico_Alumnos.GetInstancia();
            frmAcademico_Alumnos.MdiParent = this;
            frmAcademico_Alumnos.Show();
        }

        private void cursosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Cursos frmSistemaAcademico_Cursos = new frmSistemaAcademico_Cursos();
            frmSistemaAcademico_Cursos.MdiParent = this;
            frmSistemaAcademico_Cursos.Show();
        }

        private void añoElectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_AñoElectivo frmSistemaAcademico_AñoElectivo = new frmSistemaAcademico_AñoElectivo();
            frmSistemaAcademico_AñoElectivo.MdiParent = this;
            frmSistemaAcademico_AñoElectivo.Show();
        }

        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Jornada frmSistemaAcademico_Jornada = new frmSistemaAcademico_Jornada();
            frmSistemaAcademico_Jornada.MdiParent = this;
            frmSistemaAcademico_Jornada.Show();
        }

        private void periodosAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Periodos frmSistemaAcademico_Periodos = new frmSistemaAcademico_Periodos();
            frmSistemaAcademico_Periodos.MdiParent = this;
            frmSistemaAcademico_Periodos.Show();
        }

        private void aulasDeClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Aula frmSistemaAcademico_Aula = new frmSistemaAcademico_Aula();
            frmSistemaAcademico_Aula.MdiParent = this;
            frmSistemaAcademico_Aula.Show();
        }

        private void areasAcademicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_AreaAcademica frmSistemaAcademico_AreaAcademica = new frmSistemaAcademico_AreaAcademica();
            frmSistemaAcademico_AreaAcademica.MdiParent = this;
            frmSistemaAcademico_AreaAcademica.Show();
        }

        private void familiaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Familias frmAcademico_Familias = new frmAcademico_Familias();
            frmAcademico_Familias.MdiParent = this;
            frmAcademico_Familias.Show();
        }

        private void ordenDeMatriculaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTesoreria_OrdenDeMatricula frmAcademico_Familias = frmTesoreria_OrdenDeMatricula.GetInstancia();
            frmAcademico_Familias.MdiParent = this;
            frmAcademico_Familias.Show();
        }

        private void valoresAcademicosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTesoreria_ValoresAcademicos frmFinanciera_ValoresAcademicos = new frmTesoreria_ValoresAcademicos();
            frmFinanciera_ValoresAcademicos.MdiParent = this;
            frmFinanciera_ValoresAcademicos.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Bitacora frmAcademico_Bitacora = frmAcademico_Bitacora.GetInstancia();
            frmAcademico_Bitacora.MdiParent = this;
            frmAcademico_Bitacora.Show();
        }

        private void matriculaAcademicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Matricula frmAcademico_Matricula = new frmAcademico_Matricula();
            frmAcademico_Matricula.MdiParent = this;
            frmAcademico_Matricula.Show();
        }

        private void boletinesAcademicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGestionHumana_Empleados frmGestionHumana_Empleados = new frmGestionHumana_Empleados();
            frmGestionHumana_Empleados.MdiParent = this;
            frmGestionHumana_Empleados.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBiblioteca_Libros frmBiblioteca_Libros = new frmBiblioteca_Libros();
            frmBiblioteca_Libros.MdiParent = this;
            frmBiblioteca_Libros.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion_Productos frmProduccion_Productos = new frmProduccion_Productos();
            frmProduccion_Productos.MdiParent = this;
            frmProduccion_Productos.Show();
        }

        private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduccion_Proveedor frmProduccion_Proveedor = new frmProduccion_Proveedor();
            frmProduccion_Proveedor.MdiParent = this;
            frmProduccion_Proveedor.Show();
        }

        private void ingresosToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmProduccion_IngresosDeBodega frmProduccion_IngresosDeBodega = new frmProduccion_IngresosDeBodega();
            frmProduccion_IngresosDeBodega.MdiParent = this;
            frmProduccion_IngresosDeBodega.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion_Bodegas frmProduccion_Bodegas = new frmProduccion_Bodegas();
            frmProduccion_Bodegas.MdiParent = this;
            frmProduccion_Bodegas.Show();
        }

        private void salidasDeBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion_SalidaDeProductos frmProduccion_SalidaDeProductos = new frmProduccion_SalidaDeProductos();
            frmProduccion_SalidaDeProductos.MdiParent = this;
            frmProduccion_SalidaDeProductos.Show();
        }

        private void trasladosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void impuestosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProduccion_Impuestos frmProduccion_Impuestos = new frmProduccion_Impuestos();
            frmProduccion_Impuestos.MdiParent = this;
            frmProduccion_Impuestos.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcademico_Asistencia frmAcademico_Asistencia = new frmAcademico_Asistencia();
            frmAcademico_Asistencia.MdiParent = this;
            frmAcademico_Asistencia.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBiblioteca_Prestamos frmBiblioteca_Prestamos = frmBiblioteca_Prestamos.GetInstancia();
            frmBiblioteca_Prestamos.MdiParent = this;
            frmBiblioteca_Prestamos.Show();
        }

        private void codigoDeRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_CodigoID frmSistemaAcademico_CodigoID = new frmSistemaAcademico_CodigoID();
            frmSistemaAcademico_CodigoID.MdiParent = this;
            frmSistemaAcademico_CodigoID.Show();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void datosDeSeguridadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmConfiguracion_DatosDeSeguridad frmConfiguracion_DatosDeSeguridad = new frmConfiguracion_DatosDeSeguridad();
            frmConfiguracion_DatosDeSeguridad.MdiParent = this;
            frmConfiguracion_DatosDeSeguridad.Show();
        }

        private void plantelToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeBitacorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemaAcademico_Bitacora frmSistemaAcademico_Bitacora = new frmSistemaAcademico_Bitacora();
            frmSistemaAcademico_Bitacora.MdiParent = this;
            frmSistemaAcademico_Bitacora.Show();
        }
    }
}
