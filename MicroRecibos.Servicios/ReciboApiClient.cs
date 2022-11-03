using MicroRecibos.Modelos;
using System.Net.Http.Json;


namespace MicroRecibos.Servicios
{
    public class ReciboApiClient : IReciboApiClient
    {
        private readonly HttpClient _httpClient;

        public ReciboApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        

        public async Task<List<Recibo>> GetAllRecibos()
        {
            return await _httpClient.GetFromJsonAsync<List<Recibo>>($"api/ControlRecibo/search");            
        }


        public async Task<Recibo> GetReciboById(Guid Id)
        {
            return await _httpClient.GetFromJsonAsync<Recibo>($"api/ControlRecibo/{Id}");
        }


        public async Task<Guid> GrabarRecibo(Recibo oRecibo)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ControlRecibo", oRecibo);
            if (response.IsSuccessStatusCode)
            {
                string cuerpo = await response.Content.ReadAsStringAsync();
                cuerpo = cuerpo.Substring(1, 36); 
                Guid vGuid = new Guid(cuerpo);
                return vGuid;
            }
            return Guid.Empty;            
        }


        public async Task<bool> EliminarRecibo(Guid Id)
        {
			var response = await _httpClient.DeleteAsync($"api/ControlRecibo/{Id}");
			if (response.IsSuccessStatusCode)
				return true;
			return false;
		}      

    }
}
