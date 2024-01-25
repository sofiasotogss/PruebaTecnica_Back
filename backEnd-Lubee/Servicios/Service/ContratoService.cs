using backEnd_Lubee.Data;

namespace backEnd_Lubee.Service
{
    public class ContratoService: IContratoService
    {
        private readonly DBContexLubee _DBContexLubee;

        public ContratoService(DBContexLubee dBContexLubee)
        {
            _DBContexLubee = dBContexLubee;
        }

        
        public async Task<List<string>> ObtenerInformacionContratoDetalles(Guid contratoId)
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

            foreach (var detalle in detallesContrato)
            {
                var importe = detalle.Cantidad * detalle.IdProducto.Precio;

                resultado.Add($"- Cantidad: {detalle.Cantidad}, Artículo: {detalle.IdProducto.Nombre}, Precio unitario: {detalle.IdProducto.Precio}, Total: {importe}");
            }

            var totalMonto = detallesContrato.Sum(d => d.Cantidad * d.IdProducto.Precio);
            resultado.Add($"Total: {totalMonto}");
            resultado.Add($"Fecha de entrega: {contrato.FechaEntrega}");

            return resultado;
        }
    }

}
