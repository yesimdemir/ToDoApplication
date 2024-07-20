namespace TodoClient
{
    partial class LoginForm
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
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.LblPwd = new System.Windows.Forms.Label();
            this.LblUsrNm = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(146, 307);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(127, 54);
            this.BtnLogIn.TabIndex = 9;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(344, 209);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(145, 34);
            this.txPassword.TabIndex = 8;
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(140, 212);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(126, 29);
            this.LblPwd.TabIndex = 7;
            this.LblPwd.Text = "Password:";
            // 
            // LblUsrNm
            // 
            this.LblUsrNm.AutoSize = true;
            this.LblUsrNm.Location = new System.Drawing.Point(140, 128);
            this.LblUsrNm.Name = "LblUsrNm";
            this.LblUsrNm.Size = new System.Drawing.Size(135, 29);
            this.LblUsrNm.TabIndex = 6;
            this.LblUsrNm.Text = "UserName:";
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(344, 125);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(145, 34);
            this.txUsername.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 624);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblUsrNm);
            this.Controls.Add(this.txUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.Label LblUsrNm;
        private System.Windows.Forms.TextBox txUsername;
    }
}

