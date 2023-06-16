
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
            this.sendMailTxtBox = new System.Windows.Forms.RichTextBox();
            this.topicTxtBox = new System.Windows.Forms.TextBox();
            this.rcvMailTxtBox = new System.Windows.Forms.RichTextBox();
            this.usersTxtBox = new System.Windows.Forms.TextBox();
            this.sendLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendMailTxtBox
            // 
            this.sendMailTxtBox.Location = new System.Drawing.Point(102, 274);
            this.sendMailTxtBox.Name = "sendMailTxtBox";
            this.sendMailTxtBox.Size = new System.Drawing.Size(216, 110);
            this.sendMailTxtBox.TabIndex = 0;
            this.sendMailTxtBox.Text = "";
            // 
            // topicTxtBox
            // 
            this.topicTxtBox.Location = new System.Drawing.Point(102, 225);
            this.topicTxtBox.Name = "topicTxtBox";
            this.topicTxtBox.Size = new System.Drawing.Size(185, 20);
            this.topicTxtBox.TabIndex = 1;
            // 
            // rcvMailTxtBox
            // 
            this.rcvMailTxtBox.Location = new System.Drawing.Point(605, 228);
            this.rcvMailTxtBox.Name = "rcvMailTxtBox";
            this.rcvMailTxtBox.Size = new System.Drawing.Size(236, 135);
            this.rcvMailTxtBox.TabIndex = 2;
            this.rcvMailTxtBox.Text = "";
            this.rcvMailTxtBox.TextChanged += new System.EventHandler(this.rcvMailTxtBox_TextChanged);
            // 
            // usersTxtBox
            // 
            this.usersTxtBox.Location = new System.Drawing.Point(102, 161);
            this.usersTxtBox.Name = "usersTxtBox";
            this.usersTxtBox.Size = new System.Drawing.Size(201, 20);
            this.usersTxtBox.TabIndex = 3;
            // 
            // sendLbl
            // 
            this.sendLbl.AutoSize = true;
            this.sendLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendLbl.Location = new System.Drawing.Point(103, 85);
            this.sendLbl.Name = "sendLbl";
            this.sendLbl.Size = new System.Drawing.Size(118, 25);
            this.sendLbl.TabIndex = 4;
            this.sendLbl.Text = "Send Email!";
            this.sendLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Receive Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome ";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(456, 25);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(64, 25);
            this.nameLbl.TabIndex = 7;
            this.nameLbl.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recepients:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Topic:";
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.Location = new System.Drawing.Point(279, 413);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(75, 23);
            this.sendMailBtn.TabIndex = 11;
            this.sendMailBtn.Text = "Send";
            this.sendMailBtn.UseVisualStyleBackColor = true;
            this.sendMailBtn.Click += new System.EventHandler(this.sendMailBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mail:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendMailBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendLbl);
            this.Controls.Add(this.usersTxtBox);
            this.Controls.Add(this.rcvMailTxtBox);
            this.Controls.Add(this.topicTxtBox);
            this.Controls.Add(this.sendMailTxtBox);
            this.Name = "Form1";
            this.Text = "Receive Email!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox sendMailTxtBox;
        private System.Windows.Forms.TextBox topicTxtBox;
        private System.Windows.Forms.RichTextBox rcvMailTxtBox;
        private System.Windows.Forms.TextBox usersTxtBox;
        private System.Windows.Forms.Label sendLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendMailBtn;
        private System.Windows.Forms.Label label5;
    }
}

