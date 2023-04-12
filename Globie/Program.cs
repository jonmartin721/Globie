using OpenAI.GPT3.Managers;
using OpenAI.GPT3;

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
            var apiKey = "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";
            // Create an instance of the OpenAIService class
            var gpt3 = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = apiKey
            });
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new f_main());
        }
    }
}