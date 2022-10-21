using MicroRecibos.Modelos;


namespace MicroRecibos.Servicios
{
    public interface IReciboApiClient
    {
        Task<List<Recibo>> GetAllRecibos();
        Task<Recibo> GetReciboById(Guid Id);
        Task<Guid> GrabarRecibo(Recibo oRecibo);
        Task<bool> EliminarRecibo(Guid Id);        
    }
}
