using EDDBSharp.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EDDBSharp
{
    public class EDDBSharpClient
    {
        private HttpClient _http = new HttpClient();
        public EDDBSharpClient()
        {
            _http.BaseAddress = new Uri("https://eddb.io/archive/v5");
            _http.DefaultRequestHeaders.Add("Accept-Encoding", "deflate");
        }

        public async Task<IEnumerable<PopulatedSystem>> GetPopulatedSystemsAsync()
        {
            var response = await _http.GetStringAsync(new Uri($"{_http.BaseAddress}/systems_populated.json"));
            return JsonConvert.DeserializeObject<IEnumerable<PopulatedSystem>>(response);
        }

        public async Task<IEnumerable<Station>> GetStationsAsync()
        {
            var response = await _http.GetStringAsync(new Uri($"{_http.BaseAddress}/stations.json"));
            return JsonConvert.DeserializeObject<IEnumerable<Station>>(response);
        }

        public async Task<IEnumerable<Module>> GetModulesAsync()
        {
            var response = await _http.GetStringAsync(new Uri($"{_http.BaseAddress}/modules.json"));
            return JsonConvert.DeserializeObject<IEnumerable<Module>>(response);
        }

        public async Task<IEnumerable<Commodity>> GetCommoditiesAsync()
        {
            var response = await _http.GetStringAsync(new Uri($"{_http.BaseAddress}/commodities.json"));
            return JsonConvert.DeserializeObject<IEnumerable<Commodity>>(response);
        }

        public async Task<IEnumerable<PlanetBody>> GetPlanetBodiesAsync()
        {
            var response = await _http.GetStringAsync(new Uri($"{_http.BaseAddress}/bodies_recently.jsonl"));
            response = response.Replace(@"{""id"":", @", {""id"":");
            response = $"[{response}]";
            var data = JsonConvert.DeserializeObject<List<PlanetBody>>(response);
            data.Remove(data.First());
            return data as IEnumerable<PlanetBody>;
        }
    }
}
