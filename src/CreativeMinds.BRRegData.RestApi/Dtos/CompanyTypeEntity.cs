using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.BRRegData.RestApi.Dtos {

	public class CompanyTypeEntity {
		[JsonPropertyName("kode")]
		public String Code { get; set; }
		[JsonPropertyName("beskrivelse")]
		public String Description { get; set; }
		[JsonPropertyName("_links")]
		public Object Links{ get; set; }
	}
}
