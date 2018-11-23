namespace Monopoly.Forms
{
    partial class DiceForm
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
            this.oDice1 = new System.Windows.Forms.PictureBox();
            this.oDice2 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // oDice1
            // 
            this.oDice1.Location = new System.Drawing.Point(12, 12);
            this.oDice1.Name = "oDice1";
            this.oDice1.Size = new System.Drawing.Size(100, 100);
            this.oDice1.TabIndex = 0;
            this.oDice1.TabStop = false;
            // 
            // oDice2
            // 
            this.oDice2.Location = new System.Drawing.Point(118, 12);
            this.oDice2.Name = "oDice2";
            this.oDice2.Size = new System.Drawing.Size(100, 100);
            this.oDice2.TabIndex = 1;
            this.oDice2.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(12, 119);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(206, 23);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // DiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 153);
            this.ControlBox = false;
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.oDice2);
            this.Controls.Add(this.oDice1);
            this.Name = "DiceForm";
            this.Text = "DiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.oDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDice2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox oDice1;
        private System.Windows.Forms.PictureBox oDice2;
        private System.Windows.Forms.Button btnRoll;
    }
}