// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
CancellationToken cancellationToken = new CancellationToken();


CreativeMinds.BRRegData.RestApi.BRRegRestApiSearchEngine search = new CreativeMinds.BRRegData.RestApi.BRRegRestApiSearchEngine();

var data = search.SearchForCompanyByNameAsync("fjordmail technologies as", 1, cancellationToken).Result;

String temp = "";