namespace Klijent
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
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.btnProveri = new System.Windows.Forms.Button();
            this.txtPristup = new System.Windows.Forms.TextBox();
            this.btnPristup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVreme
            // 
            this.txtVreme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVreme.Location = new System.Drawing.Point(12, 12);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(557, 34);
            this.txtVreme.TabIndex = 0;
            // 
            // btnProveri
            // 
            this.btnProveri.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnProveri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveri.Location = new System.Drawing.Point(575, 12);
            this.btnProveri.Name = "btnProveri";
            this.btnProveri.Size = new System.Drawing.Size(130, 34);
            this.btnProveri.TabIndex = 1;
            this.btnProveri.Text = "proveri";
            this.btnProveri.UseVisualStyleBackColor = true;
            this.btnProveri.Click += new System.EventHandler(this.btnProveri_Click);
            // 
            // txtPristup
            // 
            this.txtPristup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPristup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPristup.Location = new System.Drawing.Point(12, 52);
            this.txtPristup.Name = "txtPristup";
            this.txtPristup.Size = new System.Drawing.Size(557, 34);
            this.txtPristup.TabIndex = 0;
            // 
            // btnPristup
            // 
            this.btnPristup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPristup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPristup.Location = new System.Drawing.Point(575, 52);
            this.btnPristup.Name = "btnPristup";
            this.btnPristup.Size = new System.Drawing.Size(130, 34);
            this.btnPristup.TabIndex = 1;
            this.btnPristup.Text = "Pristup";
            this.btnPristup.UseVisualStyleBackColor = true;
            this.btnPristup.Click += new System.EventHandler(this.btnPristup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 113);
            this.Controls.Add(this.btnPristup);
            this.Controls.Add(this.btnProveri);
            this.Controls.Add(this.txtPristup);
            this.Controls.Add(this.txtVreme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.Button btnProveri;
        private System.Windows.Forms.TextBox txtPristup;
        private System.Windows.Forms.Button btnPristup;
    }
}

