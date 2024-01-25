using backEnd_Lubee.Data;
using Microsoft.EntityFrameworkCore;

namespace backEnd_Lubee.Service
{
    public class ContratoService: IContratoService
    {
        private readonly IRepositorio<Contrato> _contratoRepositorio;
        private readonly IRepositorio<DetalleContrato> _detalleContratoRepositorio;

        public ContratoService(
            IRepositorio<Contrato> contratoRepositorio,
            IRepositorio<DetalleContrato> detalleContratoRepositorio)
        {
            _contratoRepositorio = contratoRepositorio;
            _detalleContratoRepositorio = detalleContratoRepositorio;
        }


        public async Task<List<string>> ObtenerInformacionContratoDetalles(int contratoId)
        {
            var contrato = await _contratoRepositorio.Consultar(c => c.Id == contratoId).FirstOrDefaultAsync();

            if (contrato == null)
            {
                return null;
            }

            var detallesContrato = await _detalleContratoRepositorio
                .Consultar(d => d.ContratoId == contratoId)
                .Include(d => d.IdProducto) 
                .ToListAsync();

            var resultado = new List<string>
            {
                $"Código de curso: {contrato.CourseCode}",
                $"Fecha de alta: {contrato.FechaAlta}",
                $"Colegio: {contrato.ColegioNombre}",
                $"Nivel: {contrato.ColegioNivel}",
                $"Curso: {contrato.ColegioCurso}",
                $"Localidad: {contrato.ColegioLocalidad}",
                "Pedido: "
            };
            var Cantidad = contrato.CantidadEgresados;


            foreach (var detalle in detallesContrato)
            {
                var importe = Cantidad * detalle.IdProducto.Precio;

                resultado.Add($"- Cantidad: {Cantidad}, Artículo: {detalle.IdProducto.Nombre}, Precio unitario: {detalle.IdProducto.Precio}, Total: {Math.Round(importe, 2)}");
            }

            var totalMonto = detallesContrato.Sum(d => Cantidad * d.IdProducto.Precio);
            resultado.Add($"Total: {Math.Round(totalMonto, 2)}");
            resultado.Add($"Fecha de entrega: {contrato.FechaEntrega}");

            return resultado;
        }
    }

}
