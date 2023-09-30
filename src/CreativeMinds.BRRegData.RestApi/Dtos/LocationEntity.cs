using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.BRRegData.RestApi.Dtos {

	public class LocationEntity {
		[JsonPropertyName("land")]
		public String Country { get; set; }
		[JsonPropertyName("landkode")]
		public String CountryCode { get; set; }
		[JsonPropertyName("postnummer")]
		public String PostalCode { get; set; }
		[JsonPropertyName("poststed")]
		public String Location { get; set; }
		[JsonPropertyName("adresse")]
		public String[] Address { get; set; }
		[JsonPropertyName("kommune")]
		public String Municipal { get; set; }
		[JsonPropertyName("kommunenummer")]
		public String MunicipalNumber{ get; set; }
	}
}
