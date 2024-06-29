using FarmaciaWindowsForms.Controllers;
using FarmaciaWindowsForms.Models;
using static System.Diagnostics.Activity;

namespace FamaciaWindowsForms
{
    public partial class Farmacia : Form
    {
        public PedidosController objPedido;
        public bool CrearEncabezado;

        private int objDistribuidor;
        private List<int> objSucursal;
        private string objNombreMedicamento;
        private string objTipoMedicamento;
        private int objCantidadMedicamento;
        public Farmacia()
        {
            this.objPedido = new PedidosController();
            this.CrearEncabezado = true;
            this.objSucursal = new List<int>();
            InitializeComponent();
        }

        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString(" yyyy - MM - dd HH:mm");
        }

        private void Farmacia_Load(object sender, EventArgs e)
        {
            IniciarDistribuidores();
            IniciarTiposMedicamentos();
            tmrFechaHora.Interval = 1000;
            tmrFechaHora.Enabled = true;

        }

        private void AgregarMedicamento()
        {
            int medicamentoId = 0;
            PedidoEncabezadoModel encabezadoPedido;
            if (CrearEncabezado)
            {
                int encabezadoId = objPedido.pedidoEncabezado.Count() <= 0 ? 1 : objPedido.pedidoEncabezado.Last().Id + 1;
                encabezadoPedido = AgregarProveedorSucursal(encabezadoId);
                objPedido.pedidoEncabezado.Add(encabezadoPedido);
                CrearEncabezado = false;
            }
            else
            {
                encabezadoPedido = objPedido.pedidoEncabezado.LastOrDefault();
            }
            string nombreProducto = txtNombreMedicamento.Text;
            string tipoProducto = (string)cbTipoMedicamento.SelectedText;
            TipoMedicamentoModel tipoMedicamento = objPedido.ObtenerTipoMedicamentoDesc(tipoProducto);
            int cantidadProducto = (int)nmCantidadProducto.Value;
            if (objPedido.pedidoDetalle.Count() < 0)
            {
                medicamentoId = 1;
            }
            else
            {
                medicamentoId = objPedido.pedidoDetalle.Count() + 1;
            }
            PedidoDetalleModel dt = this.objPedido.ConsultarDetallePorEncabezado(encabezadoPedido);
            if (dt.Id < 0)
            {
                dt = new PedidoDetalleModel();
                dt.Id = this.objPedido.pedidoDetalle.Count() + 1;
                dt.Encabezado = encabezadoPedido;
                this.objPedido.pedidoDetalle.Add(dt);
            }
            MedicamentoModel medicamento = new MedicamentoModel();
            dt.Medicamentos = new List<MedicamentoModel>();
            medicamento.Id = medicamentoId;
            medicamento.Descripcion = nombreProducto;
            medicamento.TipoMedicamento = tipoMedicamento;
            medicamento.Cantidad = cantidadProducto;

            dt.Medicamentos.Add(medicamento);
            this.AgregarRegistrosTablaProductos(dt.Encabezado.Id);
            this.nmCantidadProducto.Value = 0;
            this.txtNombreMedicamento.Text = String.Empty;
            this.cbTipoMedicamento.SelectedIndex = -1;
            this.chkPrincipal.Checked = false;
            this.chkSecundaria.Checked = false;

        }

        private PedidoEncabezadoModel AgregarProveedorSucursal(int encabezadoId)
        {
            string distribuidorSeleccionado = "";
            string sucursalSeleccionada = "";
            List<int> idSucursalSeleccionada = new List<int>();

            string distribuidor = pnlDistribuidor.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text != null ? pnlDistribuidor.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text : String.Empty;
            if (this.chkPrincipal.Checked)
            {
                sucursalSeleccionada = this.chkPrincipal.Text;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                int idSucursal = objPedido.sucursal.Find(x => x.Distribuidor.Descripcion == distribuidor && x.Descripcion == "Principal").Id;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                idSucursalSeleccionada.Add(idSucursal);
            }
            if (this.chkSecundaria.Checked)
            {
                if (!sucursalSeleccionada.Equals(""))
                {
                    sucursalSeleccionada += ", ";
                }
                sucursalSeleccionada += this.chkSecundaria.Text;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                int idSucursal = objPedido.sucursal.Find(x => x.Distribuidor.Descripcion == distribuidor && x.Descripcion == "Secundaria").Id;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                idSucursalSeleccionada.Add(idSucursal);
            }
            this.lblDistribuidor.Text = distribuidor;
            this.lblSucursal.Text = sucursalSeleccionada;
            PedidoEncabezadoModel objEncabezado = new PedidoEncabezadoModel();
            objEncabezado.Sucursales = new List<SucursalModel>();
            objEncabezado.Id = encabezadoId;
            foreach (var s in idSucursalSeleccionada)
            {
                objEncabezado.Sucursales.Add(objPedido.ObtenerSucursalPorId(s));
            }
            return objEncabezado;
        }


        public void AgregarRegistrosTablaProductos(int encabezadoId)
        {
            this.objPedido.pedidoDetalle.ForEach(dp =>
            {
                if (dp.Encabezado.Id == encabezadoId)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    dp.Medicamentos.ForEach(medicamento =>
                    {

                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = medicamento.TipoMedicamento.Descripcion });
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = medicamento.Descripcion });
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = medicamento.Cantidad });

                    });
                    tblProductos.Rows.Add(fila);
                }

            });

        }

        private void IniciarDistribuidores()
        {
            for (int i = 0; i < objPedido.distribuidor.Count(); i++)
            {
                RadioButton radioButton1 = new RadioButton();
                radioButton1.Text = objPedido.distribuidor[i].Descripcion;
                radioButton1.Location = new Point(10, 20 * i);
                radioButton1.Name = "Distribuidor";
                pnlDistribuidor.Controls.Add(radioButton1);
            };
        }

        private void IniciarTiposMedicamentos()
        {
            cbTipoMedicamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoMedicamento.Items.Add(new ClassItems("Seleccionar", -1, false));
            objPedido.tipoMedicamento.ForEach(objTipoMedicamento =>
            {
                cbTipoMedicamento.Items.Add(new ClassItems(objTipoMedicamento.Descripcion, objTipoMedicamento.Id));
            });
        }

        private void txtNombreMedicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cbTipoMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoMedicamento.SelectedItem != null &&
                !((ClassItems)cbTipoMedicamento.SelectedItem).Selectable)
            {
                // Deselecciona el elemento no seleccionable
                cbTipoMedicamento.SelectedIndex = -1;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            this.AgregarMedicamento();
        }
    }



}
