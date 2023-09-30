using Microsoft.VisualBasic;
using System;
using System.Text.Json.Serialization;

namespace CreativeMinds.BRRegData.RestApi.Dtos {

	public class CompanyEntity {
		[JsonPropertyName("organisasjonsnummer")]
		public String Id { get; set; }
		[JsonPropertyName("navn")]
		public String Name { get; set; }
		[JsonPropertyName("organisasjonsform")]
		public CompanyTypeEntity Type { get; set; }
		[JsonPropertyName("postadresse")]
		public LocationEntity Location { get; set; }
		[JsonPropertyName("registreringsdatoEnhetsregisteret")]
		public DateTime? RegistrationDate { get; set; }
		[JsonPropertyName("registrertIMvaregisteret")]
		public Boolean TrademarkRegistration { get; set; }
		//[JsonPropertyName("naeringskode1")]
		[JsonPropertyName("antallAnsatte")]
		public Int32 EmployeeCount{ get; set; }
		[JsonPropertyName("forretningsadresse")]
		public LocationEntity BusinessLocation { get; set; }
		[JsonPropertyName("stiftelsesdato")]
		public DateTime? Created { get; set; }
		//[JsonPropertyName("institusjonellSektorkode")]
		//[JsonPropertyName("registrertIForetaksregisteret")]
		//[JsonPropertyName("registrertIStiftelsesregisteret")]

		//[JsonPropertyName("registrertIFrivillighetsregisteret")]
		//[JsonPropertyName("sisteInnsendteAarsregnskap")]
		//[JsonPropertyName("konkurs")]
		//[JsonPropertyName("underAvvikling")]

		//[JsonPropertyName("underTvangsavviklingEllerTvangsopplosning")]
		//[JsonPropertyName("maalform")]
		//[JsonPropertyName("_links")]
	}
}
