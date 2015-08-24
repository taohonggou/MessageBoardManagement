namespace MessageBoard
{
    partial class frmLogin
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labRegister = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.labMsg = new System.Windows.Forms.Label();
            this.ckbManager = new System.Windows.Forms.CheckBox();
            this.labForgetPwd = new System.Windows.Forms.Label();
            this.cmbUserAccount = new System.Windows.Forms.ComboBox();
            this.ckRemebPwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(124, 154);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(140, 26);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Location = new System.Drawing.Point(124, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labRegister
            // 
            this.labRegister.AutoSize = true;
            this.labRegister.BackColor = System.Drawing.Color.Transparent;
            this.labRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labRegister.ForeColor = System.Drawing.Color.Blue;
            this.labRegister.Location = new System.Drawing.Point(281, 119);
            this.labRegister.Name = "labRegister";
            this.labRegister.Size = new System.Drawing.Size(53, 12);
            this.labRegister.TabIndex = 4;
            this.labRegister.Text = "免费注册";
            this.labRegister.Click += new System.EventHandler(this.labRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(376, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labMsg
            // 
            this.labMsg.AutoSize = true;
            this.labMsg.ForeColor = System.Drawing.Color.Red;
            this.labMsg.Location = new System.Drawing.Point(128, 93);
            this.labMsg.Name = "labMsg";
            this.labMsg.Size = new System.Drawing.Size(0, 12);
            this.labMsg.TabIndex = 4;
            // 
            // ckbManager
            // 
            this.ckbManager.AutoSize = true;
            this.ckbManager.BackColor = System.Drawing.Color.Transparent;
            this.ckbManager.Location = new System.Drawing.Point(209, 189);
            this.ckbManager.Name = "ckbManager";
            this.ckbManager.Size = new System.Drawing.Size(60, 16);
            this.ckbManager.TabIndex = 3;
            this.ckbManager.Text = "管理员";
            this.ckbManager.UseVisualStyleBackColor = false;
            // 
            // labForgetPwd
            // 
            this.labForgetPwd.AutoSize = true;
            this.labForgetPwd.BackColor = System.Drawing.Color.Transparent;
            this.labForgetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labForgetPwd.ForeColor = System.Drawing.Color.Blue;
            this.labForgetPwd.Location = new System.Drawing.Point(281, 161);
            this.labForgetPwd.Name = "labForgetPwd";
            this.labForgetPwd.Size = new System.Drawing.Size(53, 12);
            this.labForgetPwd.TabIndex = 5;
            this.labForgetPwd.Text = "忘记密码";
            this.labForgetPwd.Click += new System.EventHandler(this.labForgetPwd_Click);
            // 
            // cmbUserAccount
            // 
            this.cmbUserAccount.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbUserAccount.FormattingEnabled = true;
            this.cmbUserAccount.Location = new System.Drawing.Point(124, 110);
            this.cmbUserAccount.Name = "cmbUserAccount";
            this.cmbUserAccount.Size = new System.Drawing.Size(140, 27);
            this.cmbUserAccount.TabIndex = 0;
            this.cmbUserAccount.SelectedIndexChanged += new System.EventHandler(this.cmbUserAccount_SelectedIndexChanged);
            // 
            // ckRemebPwd
            // 
            this.ckRemebPwd.AutoSize = true;
            this.ckRemebPwd.BackColor = System.Drawing.Color.Transparent;
            this.ckRemebPwd.Location = new System.Drawing.Point(124, 189);
            this.ckRemebPwd.Name = "ckRemebPwd";
            this.ckRemebPwd.Size = new System.Drawing.Size(72, 16);
            this.ckRemebPwd.TabIndex = 3;
            this.ckRemebPwd.Text = "记住密码";
            this.ckRemebPwd.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MessageBoard.Properties.Resources.frmLoginBG;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(399, 300);
            this.Controls.Add(this.cmbUserAccount);
            this.Controls.Add(this.labForgetPwd);
            this.Controls.Add(this.ckRemebPwd);
            this.Controls.Add(this.ckbManager);
            this.Controls.Add(this.labMsg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "留言板登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labMsg;
        private System.Windows.Forms.CheckBox ckbManager;
        private System.Windows.Forms.Label labForgetPwd;
        private System.Windows.Forms.ComboBox cmbUserAccount;
        private System.Windows.Forms.CheckBox ckRemebPwd;
    }
}