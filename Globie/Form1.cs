using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3;
using System.Reflection.Metadata;
using OpenAI.GPT3.Interfaces;

namespace Globie
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
            if (l_Status.Text != "Ready!")
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

            if (l_Status.Text == "Ready!")
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

        private void Label2_Click(object sender, EventArgs e)
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
            OpenFileDialog browseDialog = new OpenFileDialog();
            browseDialog.InitialDirectory = "c:\\";
            browseDialog.Filter = "CBL File (*.cbl)|*.CBL|All files (*.*)|*.*";
            DialogResult result = browseDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = browseDialog.FileName;
                tb_fileURL.Text = fileName;
            }




        }

        private void l_codeAnalyzerTop_Click(object sender, EventArgs e)
        {

        }

        private async void b_Send_Click(object sender, EventArgs e)
        {
            string chatResponse = "";
            int selectedIndex = tabControl1.SelectedIndex;

            if (selectedIndex == 1)
            {
                string question = rt_askGlobey.Text;

                var chatGpt = new ChatGPT();

                var completionResult = await chatGpt.OpenAIService.ChatCompletion.CreateCompletion
                       (new ChatCompletionCreateRequest()
                       {
                           Messages = new List<ChatMessage>(new ChatMessage[]
                                    { new ChatMessage("user", question) }),
                           Model = Models.ChatGpt3_5Turbo,
                           Temperature = 0.5F,
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
        }

        private void rt_response_TextChanged(object sender, EventArgs e)
        {
            rt_response.ReadOnly = true;
        }
    }
}