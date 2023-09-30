using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.BRRegData.RestApi.Dtos {

	public class SearchResponse {
		[JsonPropertyName("_embedded")]
		public SearchResult SearchResult { get; set; }
		[JsonPropertyName("_links")]
		public Object Links { get; set; }
		[JsonPropertyName("page")]
		public ResultPage Page { get; set; }
	}
}
