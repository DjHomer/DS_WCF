
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
            this.txtIzraz = new System.Windows.Forms.TextBox();
            this.saberiBtn = new System.Windows.Forms.Button();
            this.txtNumInput = new System.Windows.Forms.TextBox();
            this.txtNumOutput = new System.Windows.Forms.TextBox();
            this.saberiNoKolbekBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIzraz
            // 
            this.txtIzraz.Location = new System.Drawing.Point(91, 201);
            this.txtIzraz.Name = "txtIzraz";
            this.txtIzraz.Size = new System.Drawing.Size(156, 20);
            this.txtIzraz.TabIndex = 0;
            // 
            // saberiBtn
            // 
            this.saberiBtn.Location = new System.Drawing.Point(117, 120);
            this.saberiBtn.Name = "saberiBtn";
            this.saberiBtn.Size = new System.Drawing.Size(75, 23);
            this.saberiBtn.TabIndex = 1;
            this.saberiBtn.Text = "+";
            this.saberiBtn.UseVisualStyleBackColor = true;
            this.saberiBtn.Click += new System.EventHandler(this.saberiBtn_Click);
            // 
            // txtNumInput
            // 
            this.txtNumInput.Location = new System.Drawing.Point(117, 40);
            this.txtNumInput.Name = "txtNumInput";
            this.txtNumInput.Size = new System.Drawing.Size(43, 20);
            this.txtNumInput.TabIndex = 2;
            // 
            // txtNumOutput
            // 
            this.txtNumOutput.Location = new System.Drawing.Point(117, 166);
            this.txtNumOutput.Name = "txtNumOutput";
            this.txtNumOutput.Size = new System.Drawing.Size(82, 20);
            this.txtNumOutput.TabIndex = 3;
            // 
            // saberiNoKolbekBtn
            // 
            this.saberiNoKolbekBtn.Location = new System.Drawing.Point(262, 120);
            this.saberiNoKolbekBtn.Name = "saberiNoKolbekBtn";
            this.saberiNoKolbekBtn.Size = new System.Drawing.Size(113, 35);
            this.saberiNoKolbekBtn.TabIndex = 4;
            this.saberiNoKolbekBtn.Text = "+ Bez Kolbeka";
            this.saberiNoKolbekBtn.UseVisualStyleBackColor = true;
            this.saberiNoKolbekBtn.Click += new System.EventHandler(this.saberiNoKolbekBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saberiNoKolbekBtn);
            this.Controls.Add(this.txtNumOutput);
            this.Controls.Add(this.txtNumInput);
            this.Controls.Add(this.saberiBtn);
            this.Controls.Add(this.txtIzraz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIzraz;
        private System.Windows.Forms.Button saberiBtn;
        private System.Windows.Forms.TextBox txtNumInput;
        private System.Windows.Forms.TextBox txtNumOutput;
        private System.Windows.Forms.Button saberiNoKolbekBtn;
    }
}

