using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3;
using System.Reflection.Metadata;
using OpenAI.GPT3.Interfaces;
using System.Text.RegularExpressions;
using Globie.Properties;

namespace Globie
{

    public partial class f_main : Form
    {
        codeFile file = new codeFile();
        string preppedTraining;

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
            l_Status.Text = "Waiting on Globey...";
            l_Status.ForeColor = Color.Fuchsia;
            b_Send.Enabled = false;

            string chatResponse = "";
            int selectedIndex = tabControl1.SelectedIndex;

            if (selectedIndex == 1)
            {

                if (rt_askGlobey.Text.Contains("best CEO"))
                {
                    System.Threading.Thread.Sleep(2000);
                    chatResponse = Properties.Resources.dustyInitial.ToString();
                } else if (rt_askGlobey.Text.Contains("summarize")) {
                    chatResponse = "Dusty Alexander is the best CEO!";
                    System.Threading.Thread.Sleep(1000);

                } else if (rt_askGlobey.Text.Contains("bad debt"))
                {
                    preppedTraining = Properties.Resources.AR_WriteOffBadDebt_PDF.ToString();
                    preppedTraining += "Can you summarize the above along with my question step by step: ";
                    string question = preppedTraining + rt_askGlobey.Text;
                    var chatGpt = new ChatGPT();

                    var completionResult = await chatGpt.OpenAIService.ChatCompletion.CreateCompletion
                           (new ChatCompletionCreateRequest()
                           {
                               Messages = new List<ChatMessage>(new ChatMessage[]
                                        { new ChatMessage("user", question) }),
                               Model = Models.ChatGpt3_5Turbo,
                               Temperature = 1.0F,
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
                else if (rt_askGlobey.Text.Contains("credit card vendor"))
                {
                    preppedTraining = Properties.Resources.AP_AddInvtoCCVend.ToString();
                    preppedTraining += "Can you summarize the above along with my question step by step: ";
                    string question = preppedTraining += rt_askGlobey.Text;

                    var chatGpt = new ChatGPT();

                    var completionResult = await chatGpt.OpenAIService.ChatCompletion.CreateCompletion
                           (new ChatCompletionCreateRequest()
                           {
                               Messages = new List<ChatMessage>(new ChatMessage[]
                                        { new ChatMessage("user", question) }),
                               Model = Models.ChatGpt3_5Turbo,
                               Temperature = 1.0F,
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
                else { 
                
                    string question = rt_askGlobey.Text;

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

                if (selectedIndex == 0)
                {
                    string question = "Analyze this code, tell me about any problems along with a summary of what it does: " + file.CodeText;
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