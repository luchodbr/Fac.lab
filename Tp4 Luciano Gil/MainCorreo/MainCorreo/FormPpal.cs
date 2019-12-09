using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MainCorreo
{
    public partial class FormPpal : Form
    {
        Correo c;
        public FormPpal()
        {
            InitializeComponent();
            this.c = new Correo();
            PaqueteDAO.EventDAOError += this.ErrorSQL;
        }

        /// <summary>
        /// Muestra toda la lista de paquetes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)c);
        }

        /// <summary>
        ///En caso de invocarse el evento EventDAOError, este manejador lanzara un mensaje de error.
        /// </summary>
        /// <param name="mensaje"></param>
        private void ErrorSQL(string mensaje)
        {
            MessageBox.Show(mensaje, "ERROR SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Actualiza los estados de los paquetes.
        /// </summary>

        private void ActualizarEstados()
        {

            this.ClearEstados();

            foreach (Paquete p in c.Paquetes)
            {
                if (p.Estado == Paquete.EEstado.Ingresado)
                {
                    lstEstadoIngresado.Items.Add(p);
                }
                else if (p.Estado == Paquete.EEstado.EnViaje)
                {
                    lstEstadoEnViaje.Items.Add(p);
                }
                else
                {
                    lstEstadoEntregado.Items.Add(p);
                }
            }
        }

        private void ClearEstados()
        {
            this.lstEstadoEntregado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoIngresado.Items.Clear();
        }

        /// <summary>
        /// Cierra el formulario y aborta los hilos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.c.Paquetes.Count > 0)
                this.c.FinEntregas();
        }

        /// <summary>
        /// Muestra la información del elemento y lo guarda en un doc .txt
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!(elemento is null))
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
                try
                {
                    this.rtbMostrar.Text.GuardarString("Correo.txt");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error guardando en el archivo");
                }
            }
        }

        /// <summary>
        /// Actualiza los estados. En caso de no ser el hilo principal, re-llamandose desde el mismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paquete_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(Paquete_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        /// <summary>
        /// Agrega un paquete al Correo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(txtDireccion.Text, mtxTrackingID.Text);
            p.InformaEstado += Paquete_InformaEstado;
            try
            {
                this.c += p;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActualizarEstados();
        }

        /// <summary>
        /// Muestra la información de un paquete 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
