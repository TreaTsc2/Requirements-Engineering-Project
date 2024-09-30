
namespace FitnessCT
{
    partial class frmLoginUser
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
            this.components = new System.ComponentModel.Container();
            this.btnLogin_click = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegisteryFromLogin = new System.Windows.Forms.Button();
            this.lblRegisterFromLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin_click
            // 
            this.btnLogin_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_click.Location = new System.Drawing.Point(274, 213);
            this.btnLogin_click.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin_click.Name = "btnLogin_click";
            this.btnLogin_click.Size = new System.Drawing.Size(95, 30);
            this.btnLogin_click.TabIndex = 3;
            this.btnLogin_click.Text = "Login";
            this.btnLogin_click.UseVisualStyleBackColor = true;
            this.btnLogin_click.Click += new System.EventHandler(this.btnLogin);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEmail.Location = new System.Drawing.Point(151, 129);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 22);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPassword.Location = new System.Drawing.Point(121, 180);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 22);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtEmail
            // 
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtEmail.Location = new System.Drawing.Point(224, 133);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(224, 184);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(199, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // btnRegisteryFromLogin
            // 
            this.btnRegisteryFromLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteryFromLogin.Location = new System.Drawing.Point(497, 332);
            this.btnRegisteryFromLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisteryFromLogin.Name = "btnRegisteryFromLogin";
            this.btnRegisteryFromLogin.Size = new System.Drawing.Size(95, 22);
            this.btnRegisteryFromLogin.TabIndex = 4;
            this.btnRegisteryFromLogin.Text = "Register";
            this.btnRegisteryFromLogin.UseVisualStyleBackColor = true;
            this.btnRegisteryFromLogin.Click += new System.EventHandler(this.btnRegisteryFromLogin_Click);
            // 
            // lblRegisterFromLogin
            // 
            this.lblRegisterFromLogin.AutoSize = true;
            this.lblRegisterFromLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterFromLogin.Location = new System.Drawing.Point(337, 336);
            this.lblRegisterFromLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterFromLogin.Name = "lblRegisterFromLogin";
            this.lblRegisterFromLogin.Size = new System.Drawing.Size(149, 13);
            this.lblRegisterFromLogin.TabIndex = 9;
            this.lblRegisterFromLogin.Text = "Not registered yet? Click here:";
            // 
            // frmLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblRegisterFromLogin);
            this.Controls.Add(this.btnRegisteryFromLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnLogin_click);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLoginUser";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin_click;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegisteryFromLogin;
        private System.Windows.Forms.Label lblRegisterFromLogin;
    }
}

