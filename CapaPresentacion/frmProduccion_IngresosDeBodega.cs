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
    public partial class frmProduccion_IngresosDeBodega : Form
    {
        private DataTable dtDetalle;
        public frmProduccion_IngresosDeBodega()
        {
            InitializeComponent();
        }

        private void frmAlmacen_IngresosDeBodega_Load(object sender, EventArgs e)
        {
            this.CrearTabla();
            this.AutoAjustar_Columnas();
        }

        private void AutoAjustar_Columnas()
        {
            DGDetalles.Columns[0].Width = 70;
            DGDetalles.Columns[1].Width = 375;
            DGDetalles.Columns[2].Width = 70;
            DGDetalles.Columns[3].Width = 70;
            DGDetalles.Columns[4].Width = 70;
            DGDetalles.Columns[5].Width = 70;
        }

        private void CrearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Codigo_ID", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Unidad", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Costo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Total", System.Type.GetType("System.String"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.DGDetalles.DataSource = this.dtDetalle;

            DataRow row = dtDetalle.NewRow();
            row["Codigo_ID"] = "001";
            row["Producto"] = "CAJA DE UNIFORMES DE DIARIO PARA HOMBRES";
            row["Cantidad"] = "1";
            row["Unidad"] = "CAJA";
            row["Costo"] = "20000";
            row["Total"] = "20000";

            dtDetalle.Rows.Add(row);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = DGDetalles.CurrentRow.Index;
                DGDetalles.Rows.RemoveAt(fila);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Bodega_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Proveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
