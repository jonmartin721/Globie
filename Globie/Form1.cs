using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Globie
{

    public partial class f_main : Form
    {
        codeFile file = new codeFile();

        public f_main()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Globey;

            if (!l_Status.Text.Equals("Ready!"))
            {
                rt_askGlobey.Enabled = false;
                codeAnalyzer.Enabled = false;
            }
            else
            {
                rt_askGlobey.Enabled = true;
                codeAnalyzer.Enabled = true;
            }

            l_Status.Visible = true;
            l_Status.Text = "Ready!";
            l_Status.ForeColor = Color.Green;
            rt_response.ReadOnly = true;

            if (l_Status.Text.Equals("Ready!"))
            {
                rt_askGlobey.Enabled = true;
                codeAnalyzer.Enabled = true;
            }
            else
            {
                rt_askGlobey.Enabled = false;
                codeAnalyzer.Enabled = false;
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void askGlobie_ClickAsync(object sender, EventArgs e)
        {

            l_Status.Text = "Training on AP & AR...";
            l_Status.ForeColor = Color.Blue;
            b_Send.Enabled = false;

            string preppedTraining = Properties.Resources.AP___AR_MiniTraining;
            string chatResponse = "";

            var chatGpt = new ChatGPT();

            var completionResult = await chatGpt.OpenAIService.ChatCompletion.CreateCompletion
                   (new ChatCompletionCreateRequest()
                   {
                       Messages = new List<ChatMessage>(new ChatMessage[]
                                { new ChatMessage("user", preppedTraining) }),
                       Model = Models.ChatGpt3_5Turbo,
                       Temperature = 0.4F,
                       MaxTokens = 10000,
                       N = 1
                   });


            if (completionResult.Successful)
            {
                foreach (var choice in completionResult.Choices)
                {
                    chatResponse += choice.Message.Content;
                }
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }
                chatResponse = ($"{completionResult.Error.Code}:{completionResult.Error.Message}");
            }

            rt_response.Text = chatResponse;
            l_Status.Text = "Ready!";
            l_Status.ForeColor = Color.Green;
            b_Send.Enabled = true;

        }


        private void f_main_Load(object sender, EventArgs e)
        {
        }

        private void b_Clear_Click(object sender, EventArgs e)
        {
            int selectedIndex = tabControl1.SelectedIndex;
            if (selectedIndex == 0)
            {
                rt_response.Clear();
                tb_fileURL.Clear();
            }
            else if (selectedIndex == 1)
            {
                rt_response.Clear();
                rt_askGlobey.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseDialog = new OpenFileDialog();
            browseDialog.InitialDirectory = "c:\\";
            browseDialog.Filter = "All files (*.*)|*.*";
            DialogResult result = browseDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                file.Url = browseDialog.FileName;

                try
                {
                    file.CodeText = Regex.Replace(File.ReadAllText(file.Url), @"[\n\r\t]", " ");
                }
                catch
                 (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                    file.FileReadSuccess = false;
                }

                file.FileReadSuccess = true;

                if (file.FileReadSuccess) { tb_fileURL.Text = file.Url; }
            }

        }

        private void l_codeAnalyzerTop_Click(object sender, EventArgs e)
        {

        }

        private async void b_Send_Click(object sender, EventArgs e)
        {
            l_Status.Text = "Waiting on Globie...";
            l_Status.ForeColor = Color.Fuchsia;
            b_Send.Enabled = false;

            string chatResponse = "";
            int selectedIndex = tabControl1.SelectedIndex;

            if (selectedIndex == 1)
            {

                l_Status.Text = "Training on AP & AR...";
                l_Status.ForeColor = Color.Fuchsia;




                string question = rt_askGlobey.Text;

                var chatGpt = new ChatGPT();

                var completionResult = await chatGpt.OpenAIService.ChatCompletion.CreateCompletion
                       (new ChatCompletionCreateRequest()
                       {
                           Messages = new List<ChatMessage>(new ChatMessage[]
                                    { new ChatMessage("user", question) }),
                           Model = Models.ChatGpt3_5Turbo,
                           Temperature = 0.4F,
                           MaxTokens = 10000,
                           N = 1
                       });


                if (completionResult.Successful)
                {
                    foreach (var choice in completionResult.Choices)
                    {
                        chatResponse += choice.Message.Content;
                    }
                }
                else
                {
                    if (completionResult.Error == null)
                    {
                        throw new Exception("Unknown Error");
                    }
                    chatResponse = ($"{completionResult.Error.Code}:{completionResult.Error.Message}");
                }

            }

            if (selectedIndex == 0)
            {
                string question = "Analyze this code for me and tell me about any problems: " + file.CodeText;
                var chatGpt = new ChatGPT();

                var completionResult = await chatGpt.OpenAIService.ChatCompletion.CreateCompletion
                       (new ChatCompletionCreateRequest()
                       {
                           Messages = new List<ChatMessage>(new ChatMessage[]
                                    { new ChatMessage("user", question) }),
                           Model = Models.ChatGpt3_5Turbo,
                           Temperature = 0.4F,
                           MaxTokens = 1000,
                           N = 1
                       });


                if (completionResult.Successful)
                {
                    foreach (var choice in completionResult.Choices)
                    {
                        chatResponse += choice.Message.Content;
                    }
                }
                else
                {
                    if (completionResult.Error == null)
                    {
                        throw new Exception("Unknown Error");
                    }
                    chatResponse = ($"{completionResult.Error.Code}:{completionResult.Error.Message}");
                }

            }

            rt_response.Text = chatResponse;
            l_Status.Text = "Ready!";
            l_Status.ForeColor = Color.Green;
            b_Send.Enabled = true;

        }

        private void rt_response_TextChanged(object sender, EventArgs e)
        {
            rt_response.ReadOnly = true;
        }
    }
}