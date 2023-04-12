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
            b_Clear = new Button();
            b_Send = new Button();
            b_Stop = new Button();
            l_topDesc = new Label();
            pictureBox1 = new PictureBox();
            l_statusDesc = new Label();
            l_Status = new Label();
            tabControl1 = new TabControl();
            codeAnalyzer = new TabPage();
            richTextBox2 = new RichTextBox();
            askGlobie = new TabPage();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            codeAnalyzer.SuspendLayout();
            SuspendLayout();
            // 
            // b_Clear
            // 
            b_Clear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_Clear.Location = new Point(507, 690);
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
            // b_Stop
            // 
            b_Stop.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            b_Stop.ForeColor = Color.Red;
            b_Stop.Location = new Point(588, 690);
            b_Stop.Name = "b_Stop";
            b_Stop.Size = new Size(75, 23);
            b_Stop.TabIndex = 2;
            b_Stop.Text = "Stop";
            b_Stop.UseVisualStyleBackColor = true;
            // 
            // l_topDesc
            // 
            l_topDesc.AutoSize = true;
            l_topDesc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            l_topDesc.Location = new Point(14, 9);
            l_topDesc.Name = "l_topDesc";
            l_topDesc.Size = new Size(311, 75);
            l_topDesc.TabIndex = 4;
            l_topDesc.Text = "Hi, I'm Globey! \r\n\r\nYou can ask me questions about Global Shop, or upload\r\ncode files for me to analyze. Use the tabs below to choose\r\nand I'll see what I can do!\r\n";
            l_topDesc.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pictureBox1.Location = new Point(635, 12);
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
            codeAnalyzer.Controls.Add(label2);
            codeAnalyzer.Controls.Add(richTextBox2);
            codeAnalyzer.Location = new Point(4, 24);
            codeAnalyzer.Name = "codeAnalyzer";
            codeAnalyzer.Padding = new Padding(3);
            codeAnalyzer.Size = new Size(783, 179);
            codeAnalyzer.TabIndex = 0;
            codeAnalyzer.Text = "Code Analyzer";
            codeAnalyzer.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 31);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(771, 142);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // askGlobie
            // 
            askGlobie.Location = new Point(4, 24);
            askGlobie.Name = "askGlobie";
            askGlobie.Padding = new Padding(3);
            askGlobie.Size = new Size(783, 179);
            askGlobie.TabIndex = 1;
            askGlobie.Text = "Ask Globie!";
            askGlobie.UseVisualStyleBackColor = true;
            askGlobie.Click += askGlobie_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(18, 440);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(787, 230);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // f_main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(816, 722);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(tabControl1);
            Controls.Add(l_Status);
            Controls.Add(l_statusDesc);
            Controls.Add(l_topDesc);
            Controls.Add(b_Stop);
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
        private RichTextBox richTextBox1;
        private Label label1;
        private RichTextBox richTextBox2;
        private Label label2;
    }
}