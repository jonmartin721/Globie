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
            askGlobie = new TabPage();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // b_Clear
            // 
            b_Clear.Location = new Point(492, 553);
            b_Clear.Name = "b_Clear";
            b_Clear.Size = new Size(75, 23);
            b_Clear.TabIndex = 0;
            b_Clear.Text = "Clear";
            b_Clear.UseVisualStyleBackColor = true;
            // 
            // b_Send
            // 
            b_Send.ForeColor = Color.Green;
            b_Send.Location = new Point(654, 553);
            b_Send.Name = "b_Send";
            b_Send.Size = new Size(136, 23);
            b_Send.TabIndex = 1;
            b_Send.Text = "Send";
            b_Send.UseVisualStyleBackColor = true;
            // 
            // b_Stop
            // 
            b_Stop.ForeColor = Color.Red;
            b_Stop.Location = new Point(573, 553);
            b_Stop.Name = "b_Stop";
            b_Stop.Size = new Size(75, 23);
            b_Stop.TabIndex = 2;
            b_Stop.Text = "Stop";
            b_Stop.UseVisualStyleBackColor = true;
            // 
            // l_topDesc
            // 
            l_topDesc.AutoSize = true;
            l_topDesc.Location = new Point(12, 13);
            l_topDesc.Name = "l_topDesc";
            l_topDesc.Size = new Size(311, 75);
            l_topDesc.TabIndex = 4;
            l_topDesc.Text = "Hi, I'm Globie! \r\n\r\nYou can ask me questions about Global Shop, or upload\r\ncode files for me to analyze. Use the tabs below to choose\r\nand I'll see what I can do!\r\n";
            l_topDesc.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(349, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 82);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // l_statusDesc
            // 
            l_statusDesc.AutoSize = true;
            l_statusDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            l_statusDesc.Location = new Point(14, 102);
            l_statusDesc.Name = "l_statusDesc";
            l_statusDesc.Size = new Size(57, 20);
            l_statusDesc.TabIndex = 8;
            l_statusDesc.Text = "Status:";
            l_statusDesc.Click += label1_Click_1;
            // 
            // l_Status
            // 
            l_Status.AutoSize = true;
            l_Status.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            l_Status.Location = new Point(77, 102);
            l_Status.Name = "l_Status";
            l_Status.Size = new Size(97, 20);
            l_Status.TabIndex = 9;
            l_Status.Text = "CurrentStatus";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(codeAnalyzer);
            tabControl1.Controls.Add(askGlobie);
            tabControl1.Location = new Point(14, 134);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(755, 205);
            tabControl1.TabIndex = 10;
            // 
            // codeAnalyzer
            // 
            codeAnalyzer.Location = new Point(4, 24);
            codeAnalyzer.Name = "codeAnalyzer";
            codeAnalyzer.Padding = new Padding(3);
            codeAnalyzer.Size = new Size(747, 177);
            codeAnalyzer.TabIndex = 0;
            codeAnalyzer.Text = "Code Analyzer";
            codeAnalyzer.UseVisualStyleBackColor = true;
            // 
            // askGlobie
            // 
            askGlobie.Location = new Point(4, 24);
            askGlobie.Name = "askGlobie";
            askGlobie.Padding = new Padding(3);
            askGlobie.Size = new Size(747, 177);
            askGlobie.TabIndex = 1;
            askGlobie.Text = "Ask Globie!";
            askGlobie.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(18, 345);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(747, 185);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // f_main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(802, 588);
            Controls.Add(richTextBox1);
            Controls.Add(tabControl1);
            Controls.Add(l_Status);
            Controls.Add(l_statusDesc);
            Controls.Add(pictureBox1);
            Controls.Add(l_topDesc);
            Controls.Add(b_Stop);
            Controls.Add(b_Send);
            Controls.Add(b_Clear);
            Name = "f_main";
            Text = "Globie - GSS AI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
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
    }
}