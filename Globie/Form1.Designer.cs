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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            l_statusDesc = new Label();
            l_Status = new Label();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // b_Clear
            // 
            b_Clear.Location = new Point(490, 415);
            b_Clear.Name = "b_Clear";
            b_Clear.Size = new Size(75, 23);
            b_Clear.TabIndex = 0;
            b_Clear.Text = "Clear";
            b_Clear.UseVisualStyleBackColor = true;
            // 
            // b_Send
            // 
            b_Send.ForeColor = Color.Green;
            b_Send.Location = new Point(652, 415);
            b_Send.Name = "b_Send";
            b_Send.Size = new Size(136, 23);
            b_Send.TabIndex = 1;
            b_Send.Text = "Send";
            b_Send.UseVisualStyleBackColor = true;
            // 
            // b_Stop
            // 
            b_Stop.ForeColor = Color.Red;
            b_Stop.Location = new Point(571, 415);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 134);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(671, 158);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(663, 130);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(663, 130);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // f_main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(803, 457);
            Controls.Add(l_Status);
            Controls.Add(l_statusDesc);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(l_topDesc);
            Controls.Add(b_Stop);
            Controls.Add(b_Send);
            Controls.Add(b_Clear);
            Name = "f_main";
            Text = "Globie - GSS AI";
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Clear;
        private Button b_Send;
        private Button b_Stop;
        private Label l_topDesc;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Label l_statusDesc;
        private Label l_Status;
    }
}