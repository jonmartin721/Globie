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
            this.b_Clear = new System.Windows.Forms.Button();
            this.b_Send = new System.Windows.Forms.Button();
            this.l_topDesc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_statusDesc = new System.Windows.Forms.Label();
            this.l_Status = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.askGlobie = new System.Windows.Forms.TabPage();
            this.l_askGlobeyTop = new System.Windows.Forms.Label();
            this.rt_askGlobey = new System.Windows.Forms.RichTextBox();
            this.rt_response = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_codeAnalyzerTop = new System.Windows.Forms.Label();
            this.tb_fileURL = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.l_fileChooser = new System.Windows.Forms.Label();
            this.codeAnalyzer = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.askGlobie.SuspendLayout();
            this.codeAnalyzer.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Clear
            // 
            this.b_Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_Clear.Location = new System.Drawing.Point(588, 690);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(75, 23);
            this.b_Clear.TabIndex = 0;
            this.b_Clear.Text = "Clear";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // b_Send
            // 
            this.b_Send.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_Send.ForeColor = System.Drawing.Color.Green;
            this.b_Send.Location = new System.Drawing.Point(669, 690);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(136, 23);
            this.b_Send.TabIndex = 1;
            this.b_Send.Text = "Send";
            this.b_Send.UseVisualStyleBackColor = true;
            // 
            // l_topDesc
            // 
            this.l_topDesc.AutoSize = true;
            this.l_topDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_topDesc.Location = new System.Drawing.Point(14, 9);
            this.l_topDesc.Name = "l_topDesc";
            this.l_topDesc.Size = new System.Drawing.Size(390, 80);
            this.l_topDesc.TabIndex = 4;
            this.l_topDesc.Text = "Hi, I\'m Globey! \r\n\r\nYou can ask me questions about Global Shop, or upload\r\ncode f" +
    "iles for me to analyze. Use the tabs below to select \r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Globie.Properties.Resources.MicrosoftTeams_image__1_;
            this.pictureBox1.Location = new System.Drawing.Point(631, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // l_statusDesc
            // 
            this.l_statusDesc.AutoSize = true;
            this.l_statusDesc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_statusDesc.Location = new System.Drawing.Point(18, 690);
            this.l_statusDesc.Name = "l_statusDesc";
            this.l_statusDesc.Size = new System.Drawing.Size(72, 25);
            this.l_statusDesc.TabIndex = 8;
            this.l_statusDesc.Text = "Status:";
            // 
            // l_Status
            // 
            this.l_Status.AutoSize = true;
            this.l_Status.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_Status.Location = new System.Drawing.Point(81, 690);
            this.l_Status.Name = "l_Status";
            this.l_Status.Size = new System.Drawing.Size(126, 25);
            this.l_Status.TabIndex = 9;
            this.l_Status.Text = "CurrentStatus";
            this.l_Status.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.codeAnalyzer);
            this.tabControl1.Controls.Add(this.askGlobie);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(14, 187);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 207);
            this.tabControl1.TabIndex = 10;
            // 
            // askGlobie
            // 
            this.askGlobie.Controls.Add(this.l_askGlobeyTop);
            this.askGlobie.Controls.Add(this.rt_askGlobey);
            this.askGlobie.Location = new System.Drawing.Point(4, 29);
            this.askGlobie.Name = "askGlobie";
            this.askGlobie.Padding = new System.Windows.Forms.Padding(3);
            this.askGlobie.Size = new System.Drawing.Size(783, 174);
            this.askGlobie.TabIndex = 1;
            this.askGlobie.Text = "Ask Globie!";
            this.askGlobie.UseVisualStyleBackColor = true;
            // 
            // l_askGlobeyTop
            // 
            this.l_askGlobeyTop.AutoSize = true;
            this.l_askGlobeyTop.Location = new System.Drawing.Point(6, 9);
            this.l_askGlobeyTop.Name = "l_askGlobeyTop";
            this.l_askGlobeyTop.Size = new System.Drawing.Size(866, 20);
            this.l_askGlobeyTop.TabIndex = 14;
            this.l_askGlobeyTop.Text = "Ask me anything about Global Shop Solutions! I\'ll use some data I\'ve been provide" +
    "d along with general knowledge to do my best.";
            // 
            // rt_askGlobey
            // 
            this.rt_askGlobey.Location = new System.Drawing.Point(6, 31);
            this.rt_askGlobey.Name = "rt_askGlobey";
            this.rt_askGlobey.Size = new System.Drawing.Size(771, 142);
            this.rt_askGlobey.TabIndex = 0;
            this.rt_askGlobey.Text = "";
            // 
            // rt_response
            // 
            this.rt_response.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rt_response.Location = new System.Drawing.Point(14, 440);
            this.rt_response.Name = "rt_response";
            this.rt_response.Size = new System.Drawing.Size(787, 230);
            this.rt_response.TabIndex = 11;
            this.rt_response.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Response:";
            // 
            // l_codeAnalyzerTop
            // 
            this.l_codeAnalyzerTop.AutoSize = true;
            this.l_codeAnalyzerTop.Location = new System.Drawing.Point(6, 10);
            this.l_codeAnalyzerTop.Name = "l_codeAnalyzerTop";
            this.l_codeAnalyzerTop.Size = new System.Drawing.Size(542, 20);
            this.l_codeAnalyzerTop.TabIndex = 13;
            this.l_codeAnalyzerTop.Text = "Upload your code below and click \"Send\" at the bottom right when you\'re ready.";
            // 
            // tb_fileURL
            // 
            this.tb_fileURL.Location = new System.Drawing.Point(6, 67);
            this.tb_fileURL.Name = "tb_fileURL";
            this.tb_fileURL.Size = new System.Drawing.Size(404, 27);
            this.tb_fileURL.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // l_fileChooser
            // 
            this.l_fileChooser.AutoSize = true;
            this.l_fileChooser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_fileChooser.Location = new System.Drawing.Point(6, 49);
            this.l_fileChooser.Name = "l_fileChooser";
            this.l_fileChooser.Size = new System.Drawing.Size(76, 20);
            this.l_fileChooser.TabIndex = 17;
            this.l_fileChooser.Text = "Code File:";
            // 
            // codeAnalyzer
            // 
            this.codeAnalyzer.Controls.Add(this.l_fileChooser);
            this.codeAnalyzer.Controls.Add(this.button2);
            this.codeAnalyzer.Controls.Add(this.tb_fileURL);
            this.codeAnalyzer.Controls.Add(this.l_codeAnalyzerTop);
            this.codeAnalyzer.Location = new System.Drawing.Point(4, 29);
            this.codeAnalyzer.Name = "codeAnalyzer";
            this.codeAnalyzer.Padding = new System.Windows.Forms.Padding(3);
            this.codeAnalyzer.Size = new System.Drawing.Size(783, 174);
            this.codeAnalyzer.TabIndex = 0;
            this.codeAnalyzer.Text = "Code Analyzer";
            this.codeAnalyzer.UseVisualStyleBackColor = true;
            // 
            // f_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 722);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_response);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.l_Status);
            this.Controls.Add(this.l_statusDesc);
            this.Controls.Add(this.l_topDesc);
            this.Controls.Add(this.b_Send);
            this.Controls.Add(this.b_Clear);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "f_main";
            this.Text = "Globey - GSS AI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.askGlobie.ResumeLayout(false);
            this.askGlobie.PerformLayout();
            this.codeAnalyzer.ResumeLayout(false);
            this.codeAnalyzer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TabPage askGlobie;
        private RichTextBox rt_response;
        private Label label1;
        private Label l_askGlobeyTop;
        private RichTextBox rt_askGlobey;
        private TabPage codeAnalyzer;
        private Label l_fileChooser;
        private Button button2;
        private TextBox tb_fileURL;
        private Label l_codeAnalyzerTop;
    }
}