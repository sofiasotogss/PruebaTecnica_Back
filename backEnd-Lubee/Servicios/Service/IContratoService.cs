using backEnd_Lubee.Data;
using System.Linq.Expressions;

namespace backEnd_Lubee.Service
{
    public interface IContratoService
    {
        Task<List<string>> ObtenerInformacionContratoDetalles(Guid contratoId);

    }
}
