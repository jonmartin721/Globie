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
            if (MessageBox.Show("Sure to clear?", "Clear Response", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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
        }
    }
}