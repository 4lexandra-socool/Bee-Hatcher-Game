namespace FormDesignPractice
{
    partial class areaShop
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
            progressBar1 = new ProgressBar();
            lblTotalHoney = new Label();
            lbHoney = new Label();
            btnBack = new Button();
            btnForward = new Button();
            label2 = new Label();
            label3 = new Label();
            imgItem = new PictureBox();
            lblHoneyCost = new Label();
            lblBlueBerryCost = new Label();
            lblStrawberryCost = new Label();
            lblSeedCost = new Label();
            btnBuy = new Button();
            lblItemName = new Label();
            lblTicketCost = new Label();
            ((System.ComponentModel.ISupportInitialize)imgItem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(473, 63);
            label1.TabIndex = 0;
            label1.Text = "New Bee's Shop";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(595, 69);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 1;
            // 
            // lblTotalHoney
            // 
            lblTotalHoney.AutoSize = true;
            lblTotalHoney.BackColor = Color.White;
            lblTotalHoney.Location = new Point(623, 75);
            lblTotalHoney.Name = "lblTotalHoney";
            lblTotalHoney.Size = new Size(38, 15);
            lblTotalHoney.TabIndex = 2;
            lblTotalHoney.Text = "label2";
            // 
            // lbHoney
            // 
            lbHoney.AutoSize = true;
            lbHoney.BackColor = Color.White;
            lbHoney.Location = new Point(620, 48);
            lbHoney.Name = "lbHoney";
            lbHoney.Size = new Size(42, 15);
            lbHoney.TabIndex = 3;
            lbHoney.Text = "Honey";
            lbHoney.Click += lbHoney_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(96, 200);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 115);
            btnBack.TabIndex = 5;
            btnBack.Text = "<<<<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnForward
            // 
            btnForward.Location = new Point(312, 200);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(75, 115);
            btnForward.TabIndex = 6;
            btnForward.Text = ">>>>";
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 23F, FontStyle.Bold);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(557, 117);
            label2.Name = "label2";
            label2.Size = new Size(178, 40);
            label2.TabIndex = 9;
            label2.Text = "Buy cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 23F, FontStyle.Bold);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(143, 117);
            label3.Name = "label3";
            label3.Size = new Size(216, 40);
            label3.TabIndex = 10;
            label3.Text = "Item Name";
            // 
            // imgItem
            // 
            imgItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            imgItem.Location = new Point(177, 203);
            imgItem.Name = "imgItem";
            imgItem.Size = new Size(129, 112);
            imgItem.SizeMode = PictureBoxSizeMode.StretchImage;
            imgItem.TabIndex = 11;
            imgItem.TabStop = false;
            imgItem.UseWaitCursor = true;
            imgItem.Click += imgItem_Click;
            // 
            // lblHoneyCost
            // 
            lblHoneyCost.AutoSize = true;
            lblHoneyCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoneyCost.ForeColor = Color.YellowGreen;
            lblHoneyCost.Location = new Point(556, 181);
            lblHoneyCost.Name = "lblHoneyCost";
            lblHoneyCost.Size = new Size(64, 21);
            lblHoneyCost.TabIndex = 11;
            lblHoneyCost.Text = "Honey:";
            // 
            // lblBlueBerryCost
            // 
            lblBlueBerryCost.AutoSize = true;
            lblBlueBerryCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBlueBerryCost.ForeColor = Color.YellowGreen;
            lblBlueBerryCost.Location = new Point(555, 203);
            lblBlueBerryCost.Name = "lblBlueBerryCost";
            lblBlueBerryCost.Size = new Size(100, 21);
            lblBlueBerryCost.TabIndex = 12;
            lblBlueBerryCost.Text = "Blueberries:";
            // 
            // lblStrawberryCost
            // 
            lblStrawberryCost.AutoSize = true;
            lblStrawberryCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStrawberryCost.ForeColor = Color.YellowGreen;
            lblStrawberryCost.Location = new Point(555, 223);
            lblStrawberryCost.Name = "lblStrawberryCost";
            lblStrawberryCost.Size = new Size(109, 21);
            lblStrawberryCost.TabIndex = 13;
            lblStrawberryCost.Text = "Strawberries:";
            // 
            // lblSeedCost
            // 
            lblSeedCost.AutoSize = true;
            lblSeedCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeedCost.ForeColor = Color.YellowGreen;
            lblSeedCost.Location = new Point(556, 242);
            lblSeedCost.Name = "lblSeedCost";
            lblSeedCost.Size = new Size(140, 21);
            lblSeedCost.TabIndex = 14;
            lblSeedCost.Text = "Sunflower Seeds:";
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(561, 293);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(132, 33);
            btnBuy.TabIndex = 15;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.YellowGreen;
            lblItemName.Location = new Point(193, 175);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(91, 21);
            lblItemName.TabIndex = 16;
            lblItemName.Text = "itemName";
            // 
            // lblTicketCost
            // 
            lblTicketCost.AutoSize = true;
            lblTicketCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicketCost.ForeColor = Color.YellowGreen;
            lblTicketCost.Location = new Point(554, 263);
            lblTicketCost.Name = "lblTicketCost";
            lblTicketCost.Size = new Size(63, 21);
            lblTicketCost.TabIndex = 17;
            lblTicketCost.Text = "Tickets";
            // 
            // areaShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(118, 34, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(lblTicketCost);
            Controls.Add(lblItemName);
            Controls.Add(btnBuy);
            Controls.Add(lblSeedCost);
            Controls.Add(imgItem);
            Controls.Add(lblStrawberryCost);
            Controls.Add(lblBlueBerryCost);
            Controls.Add(lblHoneyCost);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Controls.Add(lbHoney);
            Controls.Add(lblTotalHoney);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "areaShop";
            Text = "Form1";
            Load += areaShop_Load;
            ((System.ComponentModel.ISupportInitialize)imgItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Label lblTotalHoney;
        private Label lbHoney;
        private Button btnBack;
        private Button btnForward;
        private Label label2;
        private Label label3;
        private PictureBox imgItem;
        private Label lblHoneyCost;
        private Label lblBlueBerryCost;
        private Label lblStrawberryCost;
        private Label lblSeedCost;
        private Button btnBuy;
        private Label lblItemName;
        private Label lblTicketCost;
    }
}