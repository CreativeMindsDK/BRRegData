// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
CancellationToken cancellationToken = new CancellationToken();


CreativeMinds.BRRegData.RestApi.BRRegRestApiSearchEngine search = new CreativeMinds.BRRegData.RestApi.BRRegRestApiSearchEngine();

var data = search.SearchForCompanyByNameAsync("skolevisjoner", 1, cancellationToken).Result;

String temp = "";