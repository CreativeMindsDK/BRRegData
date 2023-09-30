using System.Text.Json.Serialization;

namespace CreativeMinds.BRRegData.RestApi.Dtos {

	public class SearchResult {
		[JsonPropertyName("enheter")]
		public CompanyEntity[] Units { get; set; }
	}
}
