using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3;
using System.Reflection.Metadata;


namespace Globie
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void askGlobie_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void f_main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void b_Clear_Click(object sender, EventArgs e)
        {
            int selectedIndex = tabControl1.SelectedIndex;
            if (selectedIndex == 0)
            {
                rt_response.Clear();
            }
            else if (selectedIndex == 1)
            {
                rt_response.Clear();
                rt_askGlobey.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void l_codeAnalyzerTop_Click(object sender, EventArgs e)
        {

        }

        private async void b_Send_Click(object sender, EventArgs e)
        {
            string error = "";
            string chatResponse = "";
            int selectedIndex = tabControl1.SelectedIndex;

            if (selectedIndex == 1)
            {
                string question = rt_askGlobey.Text;

                var chatGpt = new ChatGPT();

                var completions = chatGpt.OpenAIService.Completions.CreateCompletionAsStream
                                              (new CompletionCreateRequest()
                                              {
                                                  Prompt = question,
                                                  Model = Models.Davinci,
                                                  Temperature = 0.5F,
                                                  MaxTokens = 100,
                                                  N = 3
                                              });

                await foreach (var completion in completions)
                {
                    if (completion.Successful)
                    {
                        chatResponse += completion.Choices[0].Text;
                    }
                    else
                    {
                        if (completion.Error == null)
                        {
                            throw new Exception("Unknown Error");
                        }
                        error = ($"{completion.Error.Code}: {completion.Error.Message}");
                    }
                }
            }
            rt_response.Text = chatResponse;
        }

    }
}