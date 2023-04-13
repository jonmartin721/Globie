using OpenAI.GPT3.Managers;
using OpenAI.GPT3;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Globie
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new f_main());
        }
    }
    public class AttachGPT{

        IConfiguration configuration = new ConfigurationBuilder()
               .AddJsonFile("secrets.json")
               .Build();
        string apiKey = configuration.GetValue<string>("ApiKey");

        public OpenAIService OpenAIService { get; set; }

        public AttachGPT()
        {
            OpenAIService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = apiKey
            });
        }

    }
}

