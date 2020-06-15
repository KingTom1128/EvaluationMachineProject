namespace EvaluationMachineProject
{
    partial class FormLogin
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
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioManager = new System.Windows.Forms.RadioButton();
            this.groupRole = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(217, 134);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(153, 25);
            this.textUserName.TabIndex = 0;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(217, 189);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(153, 25);
            this.textPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Location = new System.Drawing.Point(18, 24);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(88, 19);
            this.radioUser.TabIndex = 4;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "普通用户";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioManager
            // 
            this.radioManager.AutoSize = true;
            this.radioManager.Location = new System.Drawing.Point(191, 24);
            this.radioManager.Name = "radioManager";
            this.radioManager.Size = new System.Drawing.Size(73, 19);
            this.radioManager.TabIndex = 5;
            this.radioManager.TabStop = true;
            this.radioManager.Text = "管理员";
            this.radioManager.UseVisualStyleBackColor = true;
            // 
            // groupRole
            // 
            this.groupRole.Controls.Add(this.radioUser);
            this.groupRole.Controls.Add(this.radioManager);
            this.groupRole.Location = new System.Drawing.Point(71, 258);
            this.groupRole.Name = "groupRole";
            this.groupRole.Size = new System.Drawing.Size(323, 61);
            this.groupRole.TabIndex = 6;
            this.groupRole.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(176, 356);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(106, 31);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "登陆";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 456);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.groupRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserName);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupRole.ResumeLayout(false);
            this.groupRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioManager;
        private System.Windows.Forms.GroupBox groupRole;
        private System.Windows.Forms.Button buttonLogin;
    }
}