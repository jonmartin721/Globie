using OpenAI.GPT3.Managers;
using OpenAI.GPT3;
using OpenAI;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;

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
    public class ChatGPT
    {
        private IConfiguration configuration;

        public OpenAIService OpenAIService { get; set; }

        public ChatGPT()
        {
            IConfiguration configuration = new ConfigurationBuilder()
               .AddJsonFile("secrets.json")
               .Build();
            string apiKey = configuration["OpenAIServiceOptions:ApiKey"];

            OpenAIService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = apiKey
            });
        }

    }
}

