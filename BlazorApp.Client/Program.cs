using BlazorApp.Client;
using BlazorApp.Shared;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTkxMjEwQDMxMzkyZTM0MmUzMFdzc1hqK1drclFZb0hkZWwzVWZNUmljUDFncndDUUZ3YTRMcUEyQnQrbnM9;NTkxMjExQDMxMzkyZTM0MmUzMGRRMzB3amRRTlpreFlCVWdlT3pDeVdaM05PQjZLVGF5UWZ3RHNoL0VWK1k9;NTkxMjEyQDMxMzkyZTM0MmUzMFJDcTRESGZKZVZrZXFxaUROcndjT3EvUDB2dERNL0I0czhBU0FYbktCcDA9;NTkxMjEzQDMxMzkyZTM0MmUzMFBwZkFFNXFXSENqMXBrRVI1V0xKR2JTcTdMR0s0bWNPc1B0OUFaR2dtZXc9;NTkxMjE0QDMxMzkyZTM0MmUzMFI4UkxaTXZKa21ua3JFWEhaeTFZVWZSZkJ6Uk8zV0V5WG1jWDYrN3Jka3c9;NTkxMjE1QDMxMzkyZTM0MmUzMEQ1N3BnblgxelBtSzJxZHJxZTFYbkVHNUMrM1RMaFNRamNNZWNMeUltWmM9;NTkxMjE2QDMxMzkyZTM0MmUzMFVpTzFCaWt1Z3IxOE96VGRFY25BM0Jqd1gxQ3Z0c1ZvelNsS1o2aGoyZW89;NTkxMjE3QDMxMzkyZTM0MmUzMFMvcUJUdHowY04vRjNjS3RYeENTc1ZvOGdkVnoya3V2ZFdwajBETmdsSkU9;NTkxMjE4QDMxMzkyZTM0MmUzMExMenJxZENJY01QQnJyT041NkgzSm5yYmIzRzFEdnU1c3NFdDdYbXRxRkU9;NTkxMjE5QDMxMzkyZTM0MmUzMENJNitUZmg2cSs1cUdmbEZWN3JqeWdxRG94c29QTW92ZUY3REJzMm53ZTQ9;NTkxMjIwQDMxMzkyZTM0MmUzMElncU9DQmp2TTJnL20zOS9nak04dFUzT2V0Uk4xcDNOeFVnODM3bTRiTDA9");

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>("head::after");

var appSettings = new Settings();

builder.Services.AddOptions();

builder.Services.AddAuthorizationCore();

builder.Services.AddApiAuthorization();

builder.Services.AddBlazoredLocalStorage();

builder.Configuration.Bind(appSettings);

builder.Services.AddSingleton(appSettings);

builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

builder.Services.AddScoped<ICookie, Cookie>();

builder.Services.AddSyncfusionBlazor();

builder.Services.AddScoped<DialogService>();

builder.Services.AddScoped<NotificationService>();

builder.Services.AddScoped<TooltipService>();

await builder.Build().RunAsync();
