namespace LoginFormAssesment
{
    partial class LandingForm
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
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.firstNameShowBox = new System.Windows.Forms.TextBox();
            this.lastNameShowBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ageShow = new System.Windows.Forms.TextBox();
            this.typeShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Location = new System.Drawing.Point(679, 45);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(50, 16);
            this.logoutLink.TabIndex = 16;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "LogOut";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // firstNameShowBox
            // 
            this.firstNameShowBox.Location = new System.Drawing.Point(307, 122);
            this.firstNameShowBox.Name = "firstNameShowBox";
            this.firstNameShowBox.Size = new System.Drawing.Size(286, 22);
            this.firstNameShowBox.TabIndex = 13;
            // 
            // lastNameShowBox
            // 
            this.lastNameShowBox.Location = new System.Drawing.Point(307, 172);
            this.lastNameShowBox.Name = "lastNameShowBox";
            this.lastNameShowBox.Size = new System.Drawing.Size(286, 22);
            this.lastNameShowBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name:";
            // 
            // ageShow
            // 
            this.ageShow.Location = new System.Drawing.Point(307, 221);
            this.ageShow.Name = "ageShow";
            this.ageShow.Size = new System.Drawing.Size(286, 22);
            this.ageShow.TabIndex = 17;
            // 
            // typeShow
            // 
            this.typeShow.Location = new System.Drawing.Point(307, 268);
            this.typeShow.Name = "typeShow";
            this.typeShow.Size = new System.Drawing.Size(286, 22);
            this.typeShow.TabIndex = 18;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.typeShow);
            this.Controls.Add(this.ageShow);
            this.Controls.Add(this.logoutLink);
            this.Controls.Add(this.firstNameShowBox);
            this.Controls.Add(this.lastNameShowBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LandingForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.TextBox firstNameShowBox;
        private System.Windows.Forms.TextBox lastNameShowBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageShow;
        private System.Windows.Forms.TextBox typeShow;
    }
}