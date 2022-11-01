using Microsoft.AspNetCore.Hosting;

namespace Lanches;
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args).
        ConfigureWebHostDefaults(x => x.UseStartup<Startup>());
    }
}