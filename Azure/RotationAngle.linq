<Query Kind="Statements">
  <NuGetReference>RestSharp</NuGetReference>
  <Namespace>RestSharp</Namespace>
</Query>

var client = new RestClient("http://20.185.99.189:80/score");
var request = new RestRequest(Method.POST);
request.RequestFormat = DataFormat.Json;

var imageData = File.ReadAllBytes(@"C:\Temp\wahrf-rotated-small.png");
var payload = "{\"data\": \"" + Convert.ToBase64String(imageData) +  "\"}";
request.AddParameter("application/json", payload, ParameterType.RequestBody);

var response = client.Execute(request);


Console.WriteLine(response.Content);