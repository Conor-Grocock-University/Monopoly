namespace Monopoly.Forms
{
    partial class PlayerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerView));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPLayerMoney = new System.Windows.Forms.Label();
            this.oPlayerIcon = new System.Windows.Forms.PictureBox();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.btnBuyProperty = new System.Windows.Forms.Button();
            this.oProperties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oPlayerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(9, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(39, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player ";
            // 
            // lblPLayerMoney
            // 
            this.lblPLayerMoney.AutoSize = true;
            this.lblPLayerMoney.Location = new System.Drawing.Point(9, 35);
            this.lblPLayerMoney.Name = "lblPLayerMoney";
            this.lblPLayerMoney.Size = new System.Drawing.Size(71, 13);
            this.lblPLayerMoney.TabIndex = 1;
            this.lblPLayerMoney.Text = "Player Money";
            // 
            // oPlayerIcon
            // 
            this.oPlayerIcon.Image = ((System.Drawing.Image)(resources.GetObject("oPlayerIcon.Image")));
            this.oPlayerIcon.Location = new System.Drawing.Point(172, 13);
            this.oPlayerIcon.Name = "oPlayerIcon";
            this.oPlayerIcon.Size = new System.Drawing.Size(100, 100);
            this.oPlayerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oPlayerIcon.TabIndex = 2;
            this.oPlayerIcon.TabStop = false;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(12, 90);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(100, 23);
            this.btnEndTurn.TabIndex = 3;
            this.btnEndTurn.Text = "End turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnBuyProperty
            // 
            this.btnBuyProperty.Location = new System.Drawing.Point(12, 61);
            this.btnBuyProperty.Name = "btnBuyProperty";
            this.btnBuyProperty.Size = new System.Drawing.Size(100, 23);
            this.btnBuyProperty.TabIndex = 4;
            this.btnBuyProperty.Text = "Buy Property";
            this.btnBuyProperty.UseVisualStyleBackColor = true;
            this.btnBuyProperty.Click += new System.EventHandler(this.btnBuyProperty_Click);
            // 
            // oProperties
            // 
            this.oProperties.FormattingEnabled = true;
            this.oProperties.Location = new System.Drawing.Point(13, 140);
            this.oProperties.Name = "oProperties";
            this.oProperties.Size = new System.Drawing.Size(159, 108);
            this.oProperties.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Properties";
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oProperties);
            this.Controls.Add(this.btnBuyProperty);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.oPlayerIcon);
            this.Controls.Add(this.lblPLayerMoney);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "PlayerView";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.oPlayerIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPlayerName;
        public System.Windows.Forms.Label lblPLayerMoney;

        public void OnPlayerBalanceChanged(int newBalance)
        {
            lblPLayerMoney.Text = newBalance.ToString();
        }

        private System.Windows.Forms.PictureBox oPlayerIcon;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button btnBuyProperty;
        private System.Windows.Forms.ListBox oProperties;
        private System.Windows.Forms.Label label1;
    }
}