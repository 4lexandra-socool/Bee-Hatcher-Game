namespace FormDesignPractice
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            areaPlay = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // areaPlay
            // 
            areaPlay.Location = new Point(114, 62);
            areaPlay.Name = "areaPlay";
            areaPlay.Size = new Size(107, 54);
            areaPlay.TabIndex = 0;
            areaPlay.Text = "play my game";
            areaPlay.UseVisualStyleBackColor = true;
            areaPlay.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 37);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Bee Hatcher";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(2, 173);
            button2.Name = "button2";
            button2.Size = new Size(360, 24);
            button2.TabIndex = 2;
            button2.Text = "erase all cathys- wait wrong game i mean erase data lmao";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(364, 199);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(areaPlay);
            Name = "mainMenu";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button areaPlay;
        private Label label1;
        private Button button2;
    }
}