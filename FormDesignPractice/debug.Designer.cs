namespace FormDesignPractice
{
    partial class debug
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
            label1 = new Label();
            infinitehoney = new Button();
            infinitepolen = new Button();
            button3 = new Button();
            freeitemrobux = new Button();
            button5 = new Button();
            button6 = new Button();
            btntriplet = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 0;
            label1.Text = "Debug menu";
            // 
            // infinitehoney
            // 
            infinitehoney.Location = new Point(12, 56);
            infinitehoney.Name = "infinitehoney";
            infinitehoney.Size = new Size(175, 103);
            infinitehoney.TabIndex = 1;
            infinitehoney.Text = "+1billion honey";
            infinitehoney.UseVisualStyleBackColor = true;
            infinitehoney.Click += infinitehoney_Click;
            // 
            // infinitepolen
            // 
            infinitepolen.Location = new Point(206, 56);
            infinitepolen.Name = "infinitepolen";
            infinitepolen.Size = new Size(175, 103);
            infinitepolen.TabIndex = 2;
            infinitepolen.Text = "+1 billion polen";
            infinitepolen.UseVisualStyleBackColor = true;
            infinitepolen.Click += infinitepolen_Click;
            // 
            // button3
            // 
            button3.Location = new Point(206, 165);
            button3.Name = "button3";
            button3.Size = new Size(175, 103);
            button3.TabIndex = 4;
            button3.Text = "add 50 to blue boost";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // freeitemrobux
            // 
            freeitemrobux.Location = new Point(12, 165);
            freeitemrobux.Name = "freeitemrobux";
            freeitemrobux.Size = new Size(175, 103);
            freeitemrobux.TabIndex = 3;
            freeitemrobux.Text = "infinite item";
            freeitemrobux.UseVisualStyleBackColor = true;
            freeitemrobux.Click += freeitemrobux_Click;
            // 
            // button5
            // 
            button5.Location = new Point(206, 274);
            button5.Name = "button5";
            button5.Size = new Size(175, 103);
            button5.TabIndex = 6;
            button5.Text = "add 50 to red boost";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 274);
            button6.Name = "button6";
            button6.Size = new Size(175, 103);
            button6.TabIndex = 5;
            button6.Text = "add 50 to none boost";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btntriplet
            // 
            btntriplet.Location = new Point(206, 383);
            btntriplet.Name = "btntriplet";
            btntriplet.Size = new Size(175, 103);
            btntriplet.TabIndex = 8;
            btntriplet.Text = "triplest t summon button";
            btntriplet.UseVisualStyleBackColor = true;
            btntriplet.Click += btntriplet_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 383);
            button8.Name = "button8";
            button8.Size = new Size(175, 103);
            button8.TabIndex = 7;
            button8.Text = "add 50 to  croisant";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // debug
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(393, 502);
            Controls.Add(btntriplet);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(freeitemrobux);
            Controls.Add(infinitepolen);
            Controls.Add(infinitehoney);
            Controls.Add(label1);
            Name = "debug";
            Text = "debug";
            Load += debug_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button infinitehoney;
        private Button infinitepolen;
        private Button button3;
        private Button freeitemrobux;
        private Button button5;
        private Button button6;
        private Button btntriplet;
        private Button button8;
    }
}