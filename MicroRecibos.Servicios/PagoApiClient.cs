using MicroRecibos.Modelos;
using System.Net.Http.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


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
