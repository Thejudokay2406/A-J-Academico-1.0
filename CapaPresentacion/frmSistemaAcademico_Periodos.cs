﻿using System;
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
    public partial class frmSistemaAcademico_Periodos : Form
    {
        private bool IsNuevo = false;
        public frmSistemaAcademico_Periodos()
        {
            InitializeComponent();
        }


        private void frmSistemaAcademico_Periodos_Load(object sender, EventArgs e)
        {
            this.ColoresDeBotones();
            this.Habilitar();
            this.Botones();
        }

        private void ColoresDeBotones()
        {
            btnNuevo.BackgroundImage = Properties.Resources.BV_Nuevo;
            btnGuardar.BackgroundImage = Properties.Resources.BV_Guardar;
        }

        private void Habilitar()
        {
            if (IsNuevo == false)
            {
                //Informacion Academica
                this.TBPeriodo.ReadOnly = true;
                this.TBPeriodo.BackColor = Color.FromArgb(187, 222, 251);
                this.TBAño.ReadOnly = true;
                this.TBAño.BackColor = Color.FromArgb(187, 222, 251);
                this.CBEstado.Enabled = true;
                this.CBEstado.BackColor = Color.FromArgb(187, 222, 251);
                this.TBDescripcion.ReadOnly = true;
                this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);
            }

            else if (IsNuevo == true)
            {
                this.TBPeriodo.ReadOnly = false;
                this.TBPeriodo.BackColor = Color.FromArgb(32, 178, 170);
                this.TBAño.ReadOnly = false;
                this.TBAño.BackColor = Color.FromArgb(32, 178, 170);
                this.CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;
                this.CBEstado.BackColor = Color.FromArgb(32, 178, 170);
                this.TBDescripcion.ReadOnly = false;
                this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);
            }
        }

        private void Limpiar()
        {
            this.TBPeriodo.Text = string.Empty;
            this.TBAño.Text = string.Empty;
            this.CBEstado.Text = string.Empty;
            this.TBDescripcion.Text = string.Empty;
        }

        private void Botones()
        {
            if (this.IsNuevo == true)
            {
                this.btnNuevo.Visible = false;
                this.btnGuardar.Visible = true;
            }

            else
            {
                this.btnNuevo.Visible = true;
                this.btnGuardar.Visible = false;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Habilitar();
            this.TBPeriodo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBPeriodo.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBPeriodo.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBAño.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBAño.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBEstado.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    CBEstado.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDescripcion.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBDescripcion.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fSistema_Academico_Periodos.Guardar_DatosBasicos(this.TBAuto.Text, this.TBPeriodo.Text, this.TBAño.Text, this.CBEstado.Text, this.TBDescripcion.Text);
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Periodo Academico Registrado Exitosamente");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
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
    }
}
