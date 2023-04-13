using System.Windows.Forms;

namespace Globie
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
            l_Status.Visible = true;
            l_Status.Text = "Ready!";
            l_Status.ForeColor = Color.Green;

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

        private void l_Status_Click(object sender, EventArgs e)
        {

        }

        private void b_Send_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {




            }

        }
    }
}