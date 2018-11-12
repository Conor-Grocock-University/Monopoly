namespace Monopoly.Controls
{
    partial class ExtraControl
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
            this.lblName = new System.Windows.Forms.Label();
            this.oPicture = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 2);
            this.lblName.MaximumSize = new System.Drawing.Size(90, 20);
            this.lblName.MinimumSize = new System.Drawing.Size(90, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oPicture
            // 
            this.oPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.oPicture.Location = new System.Drawing.Point(5, 26);
            this.oPicture.Name = "oPicture";
            this.oPicture.Size = new System.Drawing.Size(80, 40);
            this.oPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oPicture.TabIndex = 1;
            this.oPicture.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(0, 69);
            this.lblPrice.MaximumSize = new System.Drawing.Size(90, 20);
            this.lblPrice.MinimumSize = new System.Drawing.Size(90, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(90, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "label2";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExtraControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.oPicture);
            this.Controls.Add(this.lblName);
            this.Name = "ExtraControl";
            this.Size = new System.Drawing.Size(90, 90);
            ((System.ComponentModel.ISupportInitialize)(this.oPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.PictureBox oPicture;
        public System.Windows.Forms.Label lblPrice;
    }
}
