﻿namespace Monopoly.Controls
{
    partial class CornerControl
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
            this.oPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.oPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // oPicture
            // 
            this.oPicture.Location = new System.Drawing.Point(-1, -1);
            this.oPicture.MaximumSize = new System.Drawing.Size(90, 90);
            this.oPicture.MinimumSize = new System.Drawing.Size(90, 90);
            this.oPicture.Name = "oPicture";
            this.oPicture.Size = new System.Drawing.Size(90, 90);
            this.oPicture.TabIndex = 0;
            this.oPicture.TabStop = false;
            // 
            // CornerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.oPicture);
            this.Name = "CornerControl";
            this.Size = new System.Drawing.Size(90, 90);
            ((System.ComponentModel.ISupportInitialize)(this.oPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox oPicture;
    }
}
