using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjPlanillaVentas
{
    public partial class frmPlanillaDeVentas : Form
    {

        // variables globales 
        int num;
        ListViewItem? item;
        //objeto de la clase 
        Planilla obj = new Planilla();
        public frmPlanillaDeVentas()
        {
            InitializeComponent();
        }

        private void frmPlanillaDeVentas_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            MostrarNboleta();
            lblImporte.Text = (0).ToString();
        }

        private void MostrarNboleta()
        {
            num++;
            lblNfactura.Text = num.ToString("D5");
        }

        private void MostrarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.producto = cboProducto.Text;
            txtPrecio.Text = obj.DeterminarPrecio().ToString("C");
        }

        // Capturando los datos 
        private void CapturarDatos()
        {
            obj.Nboleta = int.Parse(lblNfactura.Text);
            obj.Cliente = txtCliente.Text;
            obj.direcccion = txtdireccion.Text;
            obj.fechacompra = DateTime.Parse(txtFecha.Text);
            obj.nCedula = txtNcedula.Text;
            obj.producto = cboProducto.Text;
            obj.cantidad = int.Parse(txtCantidad.Text);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Valida() == "")
            {
                // Capturar los datos
                CapturarDatos();

                // Determinar los cálculos de la aplicación
                double precio = obj.DeterminarPrecio();
                double importe = obj.CalcularImporte();

                // Imprimir el detalle de la venta
                ImprimirDetalle(precio, importe);

                // Imprimir el total acumulado
                lblImporte.Text = DeterminaTotal().ToString();
            }
            else
                MessageBox.Show("El error se encuentra en " + Valida());
        }

        private object DeterminaTotal()
        {

            double total = 0;
            for (int i = 0; i < lvFactura.Items.Count; i++)
            {
                total += double.Parse(lvFactura.Items[i].SubItems[3].Text);
            }
            return total;
        }

        private void ImprimirDetalle(double precio, double importe)
        {
            ListViewItem fila = new ListViewItem(obj.cantidad.ToString());
            fila.SubItems.Add(obj.producto);
            fila.SubItems.Add(precio.ToString("0.00"));
            fila.SubItems.Add(importe.ToString("0.00"));
            lvFactura.Items.Add(fila);
        }

        private string Valida()
        {

            if (txtCliente.Text.Trim().Length == 0)
            {
                txtCliente.Focus();
                return "nombre del cliente";
            }
            else if (txtdireccion.Text.Trim().Length == 0)
            {
                txtdireccion.Focus();
                return "dirección del cliente";
            }
            else if (txtNcedula.Text.Trim().Length == 0)
            {
                txtNcedula.Focus();
                return "cédula del cliente";
            }
            else if (cboProducto.SelectedIndex == -1)
            {
                cboProducto.Focus();
                return "descripción del producto";
            }
            else if (txtCantidad.Text.Trim().Length == 0)
            {
                txtCantidad.Focus();
                return "cantidad comprada";
            }
            return "";
        }

        private void lvFactura_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            item = lvFactura.GetItemAt(e.X, e.Y);
            string producto = lvFactura.Items[item.Index].SubItems[1].Text;
            DialogResult r = MessageBox.Show("¿Está seguro de eliminar el producto " +
                                             "> " + producto + "?", "Boleta",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                lvFactura.Items.Remove(item);
                lblImporte.Text = DeterminaTotal().ToString();
                MessageBox.Show("¡Detalle eliminado correctamente!");
            }




        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            ListViewItem fila = new ListViewItem(int.Parse(lblNfactura.Text).ToString("D5"));
            fila.SubItems.Add(txtFecha.Text);
            fila.SubItems.Add(TotalCantidad().ToString());
            fila.SubItems.Add(DeterminaTotal().ToString());
            lvEstadisticas.Items.Add(fila);
            LimpiarControles();
        }

        private object TotalCantidad()
        {
            int total = 0;
            for (int i = 0; i < lvFactura.Items.Count; i++)
            {
                total += int.Parse(lvFactura.Items[i].SubItems[0].Text);
            }
            return total;
        }

        private void LimpiarControles()
        {
            num++;
            lblNfactura.Text = num.ToString("D5");
            txtCliente.Clear();
            txtdireccion.Clear();
            txtNcedula.Clear();
            cboProducto.Text = "(Seleccione)";
            txtPrecio.Clear();
            txtCantidad.Clear();
            lblImporte.Text = (0).ToString("C");
            lvFactura.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Boleta",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
