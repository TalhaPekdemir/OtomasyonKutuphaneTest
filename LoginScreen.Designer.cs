namespace OtomasyonTest
{
    partial class LoginScreen
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
            this.lblGorevliLogin = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLoginGorevli = new System.Windows.Forms.Button();
            this.lblMisc = new System.Windows.Forms.Label();
            this.pbxMinimize = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGorevliLogin
            // 
            this.lblGorevliLogin.AutoSize = true;
            this.lblGorevliLogin.Location = new System.Drawing.Point(96, 55);
            this.lblGorevliLogin.Name = "lblGorevliLogin";
            this.lblGorevliLogin.Size = new System.Drawing.Size(35, 13);
            this.lblGorevliLogin.TabIndex = 0;
            this.lblGorevliLogin.Text = "label1";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(99, 92);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 20);
            this.tbxId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 95);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "label2";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(58, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(35, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "label3";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(99, 118);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            // 
            // btnLoginGorevli
            // 
            this.btnLoginGorevli.Location = new System.Drawing.Point(99, 160);
            this.btnLoginGorevli.Name = "btnLoginGorevli";
            this.btnLoginGorevli.Size = new System.Drawing.Size(100, 23);
            this.btnLoginGorevli.TabIndex = 5;
            this.btnLoginGorevli.Text = "button1";
            this.btnLoginGorevli.UseVisualStyleBackColor = true;
            this.btnLoginGorevli.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Location = new System.Drawing.Point(96, 29);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(35, 13);
            this.lblMisc.TabIndex = 8;
            this.lblMisc.Text = "label1";
            // 
            // pbxMinimize
            // 
            this.pbxMinimize.BackColor = System.Drawing.Color.Blue;
            this.pbxMinimize.Location = new System.Drawing.Point(194, -1);
            this.pbxMinimize.Name = "pbxMinimize";
            this.pbxMinimize.Size = new System.Drawing.Size(20, 20);
            this.pbxMinimize.TabIndex = 7;
            this.pbxMinimize.TabStop = false;
            this.pbxMinimize.Click += new System.EventHandler(this.pbxMinimize_Click);
            this.pbxMinimize.MouseLeave += new System.EventHandler(this.pbxMinimize_MouseLeave);
            this.pbxMinimize.MouseHover += new System.EventHandler(this.pbxMinimize_MouseHover);
            // 
            // pbxClose
            // 
            this.pbxClose.BackColor = System.Drawing.Color.Red;
            this.pbxClose.Image = global::OtomasyonTest.Properties.Resources.icoClose;
            this.pbxClose.Location = new System.Drawing.Point(214, -1);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(20, 20);
            this.pbxClose.TabIndex = 6;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            this.pbxClose.MouseLeave += new System.EventHandler(this.pbxClose_MouseLeave);
            this.pbxClose.MouseHover += new System.EventHandler(this.pbxClose_MouseHover);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.lblMisc);
            this.Controls.Add(this.pbxMinimize);
            this.Controls.Add(this.pbxClose);
            this.Controls.Add(this.btnLoginGorevli);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblGorevliLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginScreen_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGorevliLogin;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLoginGorevli;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxMinimize;
        private System.Windows.Forms.Label lblMisc;
    }
}

