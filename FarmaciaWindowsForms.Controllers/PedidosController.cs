using FarmaciaWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaWindowsForms.Controllers
{
    public class PedidosController
    {
        public List<SucursalModel> sucursal;
        public List<DistribuidorModel> distribuidor;
        public MedicamentoModel medicamento;
        public List<TipoMedicamentoModel> tipoMedicamento;
        public List<PedidoDetalleModel> pedidoDetalle;
        public List<PedidoEncabezadoModel> pedidoEncabezado;
        public PedidosController()
        {
            sucursal = new List<SucursalModel>();
            distribuidor = new List<DistribuidorModel>();
            medicamento = new MedicamentoModel();
            tipoMedicamento = new List<TipoMedicamentoModel>();
            pedidoDetalle = new List<PedidoDetalleModel>();
            pedidoEncabezado = new List<PedidoEncabezadoModel>();

            this.CrearDatos();
        }


        public List<SucursalModel> SucursalesPorDistribuidor(DistribuidorModel _distribuidor)
        {
            List<SucursalModel> _sucursalesFiltradas = new List<SucursalModel>();
            foreach(SucursalModel _obj in sucursal)
            {
                if (_distribuidor.Id == _obj.Distribuidor.Id)
                {
                    _sucursalesFiltradas.Add(_obj);
                }
            }
            return _sucursalesFiltradas;

        }

        private void CrearDatos()
        {
            TipoMedicamentoModel analgesico = new TipoMedicamentoModel();
            analgesico.Id = 1;
            analgesico.Descripcion = "Analgésico";
            this.tipoMedicamento.Add(analgesico);

            TipoMedicamentoModel analeptico = new TipoMedicamentoModel();
            analeptico.Id = 2;
            analeptico.Descripcion = "Analéptico";
            this.tipoMedicamento.Add(analeptico);

            TipoMedicamentoModel anestesico = new TipoMedicamentoModel();
            anestesico.Id = 3;
            anestesico.Descripcion = "Anestésico";
            this.tipoMedicamento.Add(anestesico);

            TipoMedicamentoModel antiacido = new TipoMedicamentoModel();
            antiacido.Id = 4;
            antiacido.Descripcion = "Antiácido";
            this.tipoMedicamento.Add(antiacido);

            TipoMedicamentoModel antidepresivo = new TipoMedicamentoModel();
            antidepresivo.Id = 5;
            antidepresivo.Descripcion = "Antidepresivo";
            this.tipoMedicamento.Add(antidepresivo);

            TipoMedicamentoModel antibioticos = new TipoMedicamentoModel();
            antibioticos.Id = 6;
            antibioticos.Descripcion = "Antibióticos";
            this.tipoMedicamento.Add(antidepresivo);

            DistribuidorModel confarma = new DistribuidorModel();
            confarma.Id = 1;
            confarma.Descripcion = "Confarma";
            this.distribuidor.Add(confarma);

            DistribuidorModel empsephar = new DistribuidorModel();
            empsephar.Id = 2;
            empsephar.Descripcion = "Empsephar";
            this.distribuidor.Add(empsephar);

            DistribuidorModel cemefar = new DistribuidorModel();
            cemefar.Id = 3;
            cemefar.Descripcion = "Cemefar";
            this.distribuidor.Add(cemefar);

            SucursalModel principalConfarma = new SucursalModel();
            principalConfarma.Id = 1;
            principalConfarma.Descripcion = "Principal";
            principalConfarma.Direccion = "Calle de la Rosa n. 28";
            principalConfarma.Distribuidor = confarma;
            this.sucursal.Add(principalConfarma);

            SucursalModel secundariaConfarma = new SucursalModel();
            secundariaConfarma.Id = 2;
            secundariaConfarma.Descripcion = "Secundaria";
            secundariaConfarma.Direccion = "Calle Alcazabilla n. 3";
            secundariaConfarma.Distribuidor = confarma;
            this.sucursal.Add(secundariaConfarma);


            SucursalModel principalEmpsephar = new SucursalModel();
            principalEmpsephar.Id = 3;
            principalEmpsephar.Descripcion = "Principal";
            principalEmpsephar.Direccion = "Calle de la Rosa n. 28";
            principalEmpsephar.Distribuidor = empsephar;
            this.sucursal.Add(principalEmpsephar);

            SucursalModel secundariaEmpsephar = new SucursalModel();
            secundariaEmpsephar.Id = 4;
            secundariaEmpsephar.Descripcion = "Secundaria";
            secundariaEmpsephar.Direccion = "Calle Alcazabilla n. 3";
            secundariaEmpsephar.Distribuidor = empsephar;
            this.sucursal.Add(secundariaEmpsephar);

            SucursalModel principalCemefar = new SucursalModel();
            principalCemefar.Id = 5;
            principalCemefar.Descripcion = "Principal";
            principalCemefar.Direccion = "Calle de la Rosa n. 28";
            principalCemefar.Distribuidor = cemefar;
            this.sucursal.Add(principalCemefar);


            SucursalModel secundariaCemefar = new SucursalModel();
            secundariaCemefar.Id = 6;
            secundariaCemefar.Descripcion = "Secundaria";
            secundariaCemefar.Direccion = "Calle Alcazabilla n. 3";
            secundariaCemefar.Distribuidor = cemefar;
            this.sucursal.Add(secundariaCemefar);
        }

        public PedidoEncabezadoModel CrearEncabezadoPedido(SucursalModel sucursal)
        {
            int idEncabezado = this.pedidoEncabezado.Count() > 0 ? this.pedidoEncabezado.Count() + 1 : 1;
            PedidoEncabezadoModel obj = new PedidoEncabezadoModel();
            obj.Id = idEncabezado;
            obj.Sucursales.Add(sucursal);
            this.pedidoEncabezado.Add(obj);
            return obj;
        }

        public int CrearDetallePedido(PedidoEncabezadoModel encabezado, MedicamentoModel medicamento)
        {
            int idDetalle = this.pedidoDetalle.Count() > 0 ? this.pedidoDetalle.Count() + 1 : 1;
            PedidoDetalleModel obj = new PedidoDetalleModel();
            obj.Id = idDetalle;
            obj.Encabezado = encabezado;
            obj.Medicamentos.Add(medicamento);
            this.pedidoDetalle.Add(obj);
            return obj.Id;
        }

        public PedidoDetalleModel ConsultarDetallePorEncabezado(PedidoEncabezadoModel _encabezado)
        {
            foreach (var obj in this.pedidoDetalle)
            {
                if (obj.Encabezado.Id == _encabezado.Id)
                {
                    return obj;
                }
            }
            return new PedidoDetalleModel() { Id = -1 };
        }

        public SucursalModel? ObtenerSucursalPorId(int sucursalId)
        {
            foreach (var s in this.sucursal)
            {
                if (s.Id == sucursalId)
                {
                    return s;
                }
            }
            return this.sucursal.Count() > 0 ? this.sucursal?.FirstOrDefault() : new SucursalModel() { Id = -1 };
        }

        public TipoMedicamentoModel? ObtenerTipoMedicamentoDesc(String tipoMedicamentoDesc)
        {
            foreach (var s in this.tipoMedicamento)
            {
                if (s.Descripcion.Contains(tipoMedicamentoDesc))
                {
                    return s;
                }
            }
            return this.tipoMedicamento.Count() > 0 ? this.tipoMedicamento.FirstOrDefault() : new TipoMedicamentoModel() { Id = -1 } ;
        }

    }


}
