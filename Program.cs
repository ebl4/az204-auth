using System.Threading.Tasks;
using Microsoft.Identity.Client;

var _clientId = "APPLICATION_CLIENT_ID";
var _tenantId = "DIRECTORY_TENANT_ID";

var app = PublicClientApplicationBuilder
    .Create(_clientId)
    .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
    .WithRedirectUri("http://localhost")
    .Build();

string[] scopes = { "user.read" };
AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

Console.WriteLine($"Token:\t{result.AccessToken}");