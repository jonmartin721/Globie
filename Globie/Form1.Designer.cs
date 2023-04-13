namespace Globie
{
    partial class f_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            b_Clear = new Button();
            b_Send = new Button();
            l_topDesc = new Label();
            pictureBox1 = new PictureBox();
            l_statusDesc = new Label();
            l_Status = new Label();
            tabControl1 = new TabControl();
            codeAnalyzer = new TabPage();
            l_fileChooser = new Label();
            button2 = new Button();
            b_fileChooser = new Button();
            tb_fileURL = new TextBox();
            l_codeAnalyzerTop = new Label();
            askGlobie = new TabPage();
            l_askGlobeyTop = new Label();
            rt_askGlobey = new RichTextBox();
            rt_response = new RichTextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            codeAnalyzer.SuspendLayout();
            askGlobie.SuspendLayout();
            SuspendLayout();
            // 
            // b_Clear
            // 
            b_Clear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_Clear.Location = new Point(588, 690);
            b_Clear.Name = "b_Clear";
            b_Clear.Size = new Size(75, 23);
            b_Clear.TabIndex = 0;
            b_Clear.Text = "Clear";
            b_Clear.UseVisualStyleBackColor = true;
            // 
            // b_Send
            // 
            b_Send.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_Send.ForeColor = Color.Green;
            b_Send.Location = new Point(669, 690);
            b_Send.Name = "b_Send";
            b_Send.Size = new Size(136, 23);
            b_Send.TabIndex = 1;
            b_Send.Text = "Send";
            b_Send.UseVisualStyleBackColor = true;
            // 
            // l_topDesc
            // 
            l_topDesc.AutoSize = true;
            l_topDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            l_topDesc.Location = new Point(14, 9);
            l_topDesc.Name = "l_topDesc";
            l_topDesc.Size = new Size(306, 60);
            l_topDesc.TabIndex = 4;
            l_topDesc.Text = "Hi, I'm Globey! \r\n\r\nYou can ask me questions about Global Shop, or upload\r\ncode files for me to analyze. Use the tabs below to select \r\n";
            l_topDesc.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pictureBox1.Location = new Point(631, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // l_statusDesc
            // 
            l_statusDesc.AutoSize = true;
            l_statusDesc.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            l_statusDesc.Location = new Point(18, 690);
            l_statusDesc.Name = "l_statusDesc";
            l_statusDesc.Size = new Size(57, 20);
            l_statusDesc.TabIndex = 8;
            l_statusDesc.Text = "Status:";
            l_statusDesc.Click += label1_Click_1;
            // 
            // l_Status
            // 
            l_Status.AutoSize = true;
            l_Status.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            l_Status.Location = new Point(81, 690);
            l_Status.Name = "l_Status";
            l_Status.Size = new Size(97, 20);
            l_Status.TabIndex = 9;
            l_Status.Text = "CurrentStatus";
            l_Status.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(codeAnalyzer);
            tabControl1.Controls.Add(askGlobie);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(14, 187);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(791, 207);
            tabControl1.TabIndex = 10;
            // 
            // codeAnalyzer
            // 
            codeAnalyzer.Controls.Add(l_fileChooser);
            codeAnalyzer.Controls.Add(button2);
            codeAnalyzer.Controls.Add(b_fileChooser);
            codeAnalyzer.Controls.Add(tb_fileURL);
            codeAnalyzer.Controls.Add(l_codeAnalyzerTop);
            codeAnalyzer.Location = new Point(4, 24);
            codeAnalyzer.Name = "codeAnalyzer";
            codeAnalyzer.Padding = new Padding(3);
            codeAnalyzer.Size = new Size(783, 179);
            codeAnalyzer.TabIndex = 0;
            codeAnalyzer.Text = "Code Analyzer";
            codeAnalyzer.UseVisualStyleBackColor = true;
            // 
            // l_fileChooser
            // 
            l_fileChooser.AutoSize = true;
            l_fileChooser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_fileChooser.Location = new Point(6, 49);
            l_fileChooser.Name = "l_fileChooser";
            l_fileChooser.Size = new Size(60, 15);
            l_fileChooser.TabIndex = 17;
            l_fileChooser.Text = "Code File:";
            // 
            // button2
            // 
            button2.Location = new Point(6, 96);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Browse...";
            button2.UseVisualStyleBackColor = true;
            // 
            // b_fileChooser
            // 
            b_fileChooser.Image = (Image)resources.GetObject("b_fileChooser.Image");
            b_fileChooser.Location = new Point(6, 67);
            b_fileChooser.Name = "b_fileChooser";
            b_fileChooser.Size = new Size(27, 23);
            b_fileChooser.TabIndex = 15;
            b_fileChooser.Text = "button1";
            b_fileChooser.UseVisualStyleBackColor = true;
            // 
            // tb_fileURL
            // 
            tb_fileURL.Location = new Point(39, 68);
            tb_fileURL.Name = "tb_fileURL";
            tb_fileURL.Size = new Size(404, 23);
            tb_fileURL.TabIndex = 14;
            // 
            // l_codeAnalyzerTop
            // 
            l_codeAnalyzerTop.AutoSize = true;
            l_codeAnalyzerTop.Location = new Point(6, 10);
            l_codeAnalyzerTop.Name = "l_codeAnalyzerTop";
            l_codeAnalyzerTop.Size = new Size(432, 15);
            l_codeAnalyzerTop.TabIndex = 13;
            l_codeAnalyzerTop.Text = "Upload your code below and click \"Send\" at the bottom right when you're ready.";
            l_codeAnalyzerTop.Click += label2_Click;
            // 
            // askGlobie
            // 
            askGlobie.Controls.Add(l_askGlobeyTop);
            askGlobie.Controls.Add(rt_askGlobey);
            askGlobie.Location = new Point(4, 24);
            askGlobie.Name = "askGlobie";
            askGlobie.Padding = new Padding(3);
            askGlobie.Size = new Size(783, 179);
            askGlobie.TabIndex = 1;
            askGlobie.Text = "Ask Globie!";
            askGlobie.UseVisualStyleBackColor = true;
            askGlobie.Click += askGlobie_Click;
            // 
            // l_askGlobeyTop
            // 
            l_askGlobeyTop.AutoSize = true;
            l_askGlobeyTop.Location = new Point(6, 9);
            l_askGlobeyTop.Name = "l_askGlobeyTop";
            l_askGlobeyTop.Size = new Size(687, 15);
            l_askGlobeyTop.TabIndex = 14;
            l_askGlobeyTop.Text = "Ask me anything about Global Shop Solutions! I'll use some data I've been provided along with general knowledge to do my best.";
            // 
            // rt_askGlobey
            // 
            rt_askGlobey.Location = new Point(6, 31);
            rt_askGlobey.Name = "rt_askGlobey";
            rt_askGlobey.Size = new Size(771, 142);
            rt_askGlobey.TabIndex = 0;
            rt_askGlobey.Text = "";
            // 
            // rt_response
            // 
            rt_response.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rt_response.Location = new Point(14, 440);
            rt_response.Name = "rt_response";
            rt_response.Size = new Size(787, 230);
            rt_response.TabIndex = 11;
            rt_response.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 411);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 12;
            label1.Text = "Response:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // f_main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(816, 722);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(rt_response);
            Controls.Add(tabControl1);
            Controls.Add(l_Status);
            Controls.Add(l_statusDesc);
            Controls.Add(l_topDesc);
            Controls.Add(b_Send);
            Controls.Add(b_Clear);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "f_main";
            Text = "Globey - GSS AI";
            Load += f_main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            codeAnalyzer.ResumeLayout(false);
            codeAnalyzer.PerformLayout();
            askGlobie.ResumeLayout(false);
            askGlobie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Clear;
        private Button b_Send;
        private Button b_Stop;
        private Label l_topDesc;
        private PictureBox pictureBox1;
        private Label l_statusDesc;
        private Label l_Status;
        private TabControl tabControl1;
        private TabPage codeAnalyzer;
        private TabPage askGlobie;
        private RichTextBox rt_response;
        private Label label1;
        private RichTextBox rt_askGlobey;
        private Label l_codeAnalyzerTop;
        private Label l_fileChooser;
        private Button button2;
        private Button b_fileChooser;
        private TextBox tb_fileURL;
        private Label l_askGlobeyTop;
        private OpenFileDialog openFileDialog1;
    }
}