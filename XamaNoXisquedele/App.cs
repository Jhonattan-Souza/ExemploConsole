using Microsoft.Extensions.Configuration;
using System;

namespace XamaNoXisquedele
{
    public class App
    {
        public IService Service { get; }
        public IConfiguration Configuration { get; }

        public App(IService service, IConfiguration configuration)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public void Run()
        {
            Console.WriteLine(Service.GetString());
            Console.WriteLine(Configuration["AppConfiguration:Nome"]);
            Console.WriteLine(Service.GetInt());
            Console.WriteLine(Configuration["AppConfiguration:Idade"]);

            Console.ReadKey();
        }
    }
}