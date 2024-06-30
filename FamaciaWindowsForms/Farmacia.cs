using FarmaciaWindowsForms.Controllers;
using FarmaciaWindowsForms.Models;
using System.Runtime.CompilerServices;
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

        public bool ValidarEntradaProducto()
        {
            bool objValidacionCompleta = true;
            int idDistribuidorSeleccionado = -1;
            string distribuidor = pnlDistribuidor.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text != null ? pnlDistribuidor.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text : String.Empty;

            if (distribuidor == string.Empty)
            {
                objValidacionCompleta = false;
                this.lblValidacionDistribuidor.Text = "Distribuidor requerido.";
                this.lblValidacionDistribuidor.ForeColor = Color.Red;
            }
            else
            {
                idDistribuidorSeleccionado = objPedido.distribuidor.Find(x => x.Descripcion == distribuidor).Id;
                this.objDistribuidor = idDistribuidorSeleccionado;
                this.lblValidacionDistribuidor.Text = "";
            }
            if (!(this.chkPrincipal.Checked || this.chkSecundaria.Checked))
            {
                objValidacionCompleta = false;
                this.lblValidacionSucursal.Text = "Sucursal requerida.";
                this.lblValidacionSucursal.ForeColor = Color.Red;
            }
            else
            {
                this.lblValidacionSucursal.Text = "";
                if (this.chkPrincipal.Checked)
                {
                    this.objSucursal.Add(objPedido.sucursal.Find(x => x.Distribuidor.Descripcion == distribuidor && x.Descripcion == "Principal").Id);
                }
                if (this.chkSecundaria.Checked)
                {
                    this.objSucursal.Add(objPedido.sucursal.Find(x => x.Distribuidor.Descripcion == distribuidor && x.Descripcion == "Secundaria").Id);
                }
            }
            if (txtNombreMedicamento.Text.Equals(""))
            {
                objValidacionCompleta = false;
                this.lblValidacionNombreMedicamento.Text = "Nombre del medicamento requerido.";
                this.lblValidacionNombreMedicamento.ForeColor = Color.Red;
            }
            else
            {
                this.lblValidacionNombreMedicamento.Text = "";
                this.objNombreMedicamento = txtNombreMedicamento.Text;
            }
            ClassItems tipoProducto = (ClassItems)(cbTipoMedicamento.SelectedItem);
            if (tipoProducto == null)
            {
                objValidacionCompleta = false;
                this.lblValidacionTipoMedicamento.Text = "Tipo de medicamento no valido.";
                this.lblValidacionTipoMedicamento.ForeColor = Color.Red;
            }
            else
            {
                this.lblValidacionTipoMedicamento.Text = "";
                this.objTipoMedicamento = tipoProducto.Name;
            }

            if (nmCantidadProducto.Value <= 0)
            {
                objValidacionCompleta = false;
                this.lblValidacionCantidadProducto.Text = "Cantidad de medicamento requerida.";
                this.lblValidacionCantidadProducto.ForeColor = Color.Red;
            }
            else
            {
                this.lblValidacionCantidadProducto.Text = "";
                this.objCantidadMedicamento = (int)nmCantidadProducto.Value;
            }
            return objValidacionCompleta;
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
            if(dt.Medicamentos == null)
            {
                dt.Medicamentos = new List<MedicamentoModel>();
            }
            medicamento.Id = medicamentoId;
            medicamento.Descripcion = nombreProducto;
            medicamento.TipoMedicamento = tipoMedicamento;
            medicamento.Cantidad = cantidadProducto;

            dt.Medicamentos.Add(medicamento);
            this.AgregarRegistrosTablaProductos(dt.Encabezado.Id);
            this.nmCantidadProducto.Value = 0;
            this.txtNombreMedicamento.Text = String.Empty;
            this.cbTipoMedicamento.SelectedIndex = -1;

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
            tblProductos.Rows.Clear();
            this.objPedido.pedidoDetalle.ForEach(dp =>
            {
                if (dp.Encabezado.Id == encabezadoId)
                {

                    dp.Medicamentos.ForEach(medicamento =>
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = medicamento.TipoMedicamento.Descripcion });
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = medicamento.Descripcion });
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = medicamento.Cantidad });
                        tblProductos.Rows.Add(fila);
                    });

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
            if (ValidarEntradaProducto())
            {
                this.AgregarMedicamento();
            }
        }

        public void ReestablecerComponentesFormulario()
        {
            this.VisualizarHistoricoPedido();
            this.MostrarReciboCaja();
            CrearEncabezado = true;
            chkPrincipal.Checked = false;
            chkSecundaria.Checked = false;
            txtNombreMedicamento.Text = "";
            cbTipoMedicamento.SelectedIndex = -1;
            nmCantidadProducto.Value = 0;
            tblProductos.Rows.Clear();
            lblDistribuidor.Text = "";
            lblSucursal.Text = "";
        }


        public void VisualizarHistoricoPedido()
        {
            int totalMedicamentos = 0;
            foreach (var dp in this.objPedido.pedidoDetalle)
            {
                foreach (var obj in dp.Medicamentos)
                {
                    totalMedicamentos += obj.Cantidad;
                }
                String Sucursales = "";
                List<SucursalModel> objS = dp.Encabezado.Sucursales;
                foreach (var s in objS)
                {
                    Sucursales += s.Descripcion + " ";
                }

                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = dp.Encabezado.Sucursales.FirstOrDefault().Distribuidor.Descripcion });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = Sucursales });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = this.lblFechaHora.Text });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = totalMedicamentos });
                tblHistoricoPedidos.Rows.Add(fila);
            }


        }

        public void MostrarReciboCaja()
        {
            PedidoDetalleModel objPedido = this.objPedido.pedidoDetalle.LastOrDefault();
            var obj = new frReciboCaja();
            String sucursales = "";
            String direcciones = "";
            foreach (var t in objPedido.Encabezado.Sucursales)
            {
                sucursales += t.Descripcion + " - ";
                direcciones += t.Direccion + " - ";
            }
            obj.lblDistribuidor.Text = objPedido.Encabezado.Sucursales.LastOrDefault().Distribuidor.Descripcion;
            obj.lblDireccion.Text = direcciones;
            obj.lblSucursal.Text = sucursales;
            obj.lblFechaHora.Text = this.lblFechaHora.Text;

            foreach (var dp in this.objPedido.pedidoDetalle)
            {
                if (dp.Encabezado.Id == objPedido.Encabezado.Id)
                {
                    DataGridViewRow[] filaList = new DataGridViewRow[dp.Medicamentos.Count];
                    int i = 0;
                    foreach (var ob in dp.Medicamentos)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = ob.TipoMedicamento.Descripcion });
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = ob.Descripcion });
                        fila.Cells.Add(new DataGridViewTextBoxCell { Value = ob.Cantidad });
                        filaList[i] = fila;
                        i++;
                        
                    }
                    obj.tblMedicamentos.Rows.AddRange(filaList);
                }
            }
            obj.ShowDialog();
        }

        private void btnTerminarPedido_Click(object sender, EventArgs e)
        {
            ReestablecerComponentesFormulario();
        }
    }



}
