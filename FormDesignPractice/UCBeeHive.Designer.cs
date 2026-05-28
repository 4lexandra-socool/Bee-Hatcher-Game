namespace FormDesignPractice
{
    partial class UCBeeHive
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBeeHive));
            beeImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)beeImg).BeginInit();
            SuspendLayout();
            // 
            // beeImg
            // 
            beeImg.Image = (Image)resources.GetObject("beeImg.Image");
            beeImg.ImageLocation = "";
            beeImg.Location = new Point(0, 0);
            beeImg.Name = "beeImg";
            beeImg.Size = new Size(86, 104);
            beeImg.TabIndex = 0;
            beeImg.TabStop = false;
            beeImg.Click += pictureBox1_Click;
            // 
            // UCBeeHive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(beeImg);
            Name = "UCBeeHive";
            Size = new Size(86, 104);
            Load += UCBeeHive_Load;
            ((System.ComponentModel.ISupportInitialize)beeImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox beeImg;
    }
}
