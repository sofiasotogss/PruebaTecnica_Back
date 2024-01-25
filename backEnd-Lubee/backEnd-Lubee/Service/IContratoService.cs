namespace backEnd_Lubee.Service
{
    public interface IContratoService
    {
        Task<List<string>> ObtenerInformacionContratoDetalles(int contratoId);

    }
}
