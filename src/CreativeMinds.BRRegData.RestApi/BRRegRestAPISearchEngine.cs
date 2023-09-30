using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CreativeMinds.BRRegData.RestApi.Dtos;
using System.Net.Http.Json;
using System.Web;

namespace CreativeMinds.BRRegData.RestApi {

	public class BRRegRestApiSearchEngine : IBRRegSearchEngine {


		public async Task<SearchResponse> SearchForCompanyByNameAsync(String query, Int32 maxHits, CancellationToken cancellationToken) {
			HttpClient client = new HttpClient();
			client.Timeout = new TimeSpan(0, 0, 0, 0, 5000);
			client.BaseAddress = new Uri("https://data.brreg.no");
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new MediaTypeWithQualityHeaderValue("application/json"));

			try {
				HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"/enhetsregisteret/api/enheter?navn={HttpUtility.UrlEncode(query)}" /*&fraRegistreringsdatoEnhetsregisteret=2017-10-20&tilRegistreringsdatoEnhetsregisteret=2017-10-20&konkurs=false"*/);
				//request.Headers.Add("apikey", this.apiKey);
				//request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
				//request.Content = new StringContent(searchBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.SendAsync(request);

				return await response.Content.ReadFromJsonAsync<SearchResponse>();

				//return new List<Object> {  };

				//return JsonConvert.DeserializeObject(output);

				// TODO: Handle 404, as "no results found".
			}
			catch (Exception ex) {
				throw ex;
			}
		}
	}
}
