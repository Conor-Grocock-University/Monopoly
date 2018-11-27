namespace Monopoly
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oChanceCards = new System.Windows.Forms.PictureBox();
            this.oComChest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.oChanceCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oComChest)).BeginInit();
            this.SuspendLayout();
            // 
            // oChanceCards
            // 
            this.oChanceCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oChanceCards.Image = ((System.Drawing.Image)(resources.GetObject("oChanceCards.Image")));
            this.oChanceCards.Location = new System.Drawing.Point(200, 200);
            this.oChanceCards.Name = "oChanceCards";
            this.oChanceCards.Size = new System.Drawing.Size(100, 100);
            this.oChanceCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oChanceCards.TabIndex = 0;
            this.oChanceCards.TabStop = false;
            // 
            // oComChest
            // 
            this.oComChest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oComChest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oComChest.Image = ((System.Drawing.Image)(resources.GetObject("oComChest.Image")));
            this.oComChest.Location = new System.Drawing.Point(700, 700);
            this.oComChest.Name = "oComChest";
            this.oComChest.Size = new System.Drawing.Size(100, 100);
            this.oComChest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oComChest.TabIndex = 1;
            this.oComChest.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(984, 989);
            this.Controls.Add(this.oComChest);
            this.Controls.Add(this.oChanceCards);
            this.MaximumSize = new System.Drawing.Size(1000, 1028);
            this.MinimumSize = new System.Drawing.Size(1000, 1028);
            this.Name = "Form1";
            this.Text = "Monopoly";
            ((System.ComponentModel.ISupportInitialize)(this.oChanceCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oComChest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox oChanceCards;
        private System.Windows.Forms.PictureBox oComChest;
    }
}

