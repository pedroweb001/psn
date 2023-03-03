
namespace psn.forms
{
    partial class frm_login
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
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpwd
            // 
            this.txtpwd.AccessibleName = "senha";
            this.txtpwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtpwd.Location = new System.Drawing.Point(0, 0);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(533, 20);
            this.txtpwd.TabIndex = 1;
            this.txtpwd.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.AccessibleName = "Nome de usuário";
            this.txtuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtuser.Location = new System.Drawing.Point(0, 20);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(533, 20);
            this.txtuser.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_login.Location = new System.Drawing.Point(0, 277);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(533, 15);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpwd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "psn";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btn_login;
    }
}