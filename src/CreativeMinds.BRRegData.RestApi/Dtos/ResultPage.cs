using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.BRRegData.RestApi.Dtos {

	public class ResultPage {
		[JsonPropertyName("size")]
		public Int32 Size { get; set; }
		[JsonPropertyName("totalElements")]
		public Int32 Count { get; set; }
		[JsonPropertyName("totalPages")]
		public Int32 PageCount { get; set; }
		[JsonPropertyName("number")]
		public Int32 Index { get; set; }
	}
}
