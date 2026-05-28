namespace FormDesignPractice
{
    partial class UCInventory
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
            pbItemImg = new PictureBox();
            label1 = new Label();
            lblDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)pbItemImg).BeginInit();
            SuspendLayout();
            // 
            // pbItemImg
            // 
            pbItemImg.Location = new Point(0, 0);
            pbItemImg.Name = "pbItemImg";
            pbItemImg.Size = new Size(100, 90);
            pbItemImg.TabIndex = 0;
            pbItemImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Item Name";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(106, 31);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(93, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "item description";
            // 
            // UCInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDesc);
            Controls.Add(label1);
            Controls.Add(pbItemImg);
            Name = "UCInventory";
            Size = new Size(279, 90);
            ((System.ComponentModel.ISupportInitialize)pbItemImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbItemImg;
        private Label label1;
        private Label lblDesc;
    }
}
