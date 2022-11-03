using MicroRecibos.Modelos;
using System.Net.Http.Json;


namespace MicroRecibos.Servicios
{
    public class PagoApiClient : IPagoApiClient
    {
        private readonly HttpClient _httpClient;

        public PagoApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }


        public async Task<Pago> GetPagos()
        {
            return await _httpClient.GetFromJsonAsync<Pago>($"api/ControlRecibo/leerpagos");
        }
    }
}
