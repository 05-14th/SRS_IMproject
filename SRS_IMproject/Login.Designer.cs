namespace SRS_IMproject
{
    partial class Login
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
            this.label_login_user = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_loginClear = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).BeginInit();
            this.SuspendLayout();
            // 
            // label_login_user
            // 
            this.label_login_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_login_user.AutoSize = true;
            this.label_login_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_user.Location = new System.Drawing.Point(281, 176);
            this.label_login_user.Name = "label_login_user";
            this.label_login_user.Size = new System.Drawing.Size(41, 13);
            this.label_login_user.TabIndex = 1;
            this.label_login_user.Text = "User :";
            // 
            // label_pass
            // 
            this.label_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(281, 207);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(42, 13);
            this.label_pass.TabIndex = 2;
            this.label_pass.Text = "Pass :";
            // 
            // textBox_user
            // 
            this.textBox_user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_user.Location = new System.Drawing.Point(328, 173);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(154, 20);
            this.textBox_user.TabIndex = 3;
            this.textBox_user.TextChanged += new System.EventHandler(this.textBox_user_TextChanged);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_pass.Location = new System.Drawing.Point(328, 204);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(154, 20);
            this.textBox_pass.TabIndex = 4;
            // 
            // button_loginClear
            // 
            this.button_loginClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_loginClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loginClear.Location = new System.Drawing.Point(284, 242);
            this.button_loginClear.Name = "button_loginClear";
            this.button_loginClear.Size = new System.Drawing.Size(92, 23);
            this.button_loginClear.TabIndex = 5;
            this.button_loginClear.Text = "Clear";
            this.button_loginClear.UseVisualStyleBackColor = true;
            this.button_loginClear.Click += new System.EventHandler(this.button_loginClear_Click);
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(396, 242);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(86, 23);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox_login
            // 
            this.pictureBox_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox_login.Image = global::SRS_IMproject.Properties.Resources.ci;
            this.pictureBox_login.Location = new System.Drawing.Point(284, 27);
            this.pictureBox_login.Name = "pictureBox_login";
            this.pictureBox_login.Size = new System.Drawing.Size(199, 134);
            this.pictureBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_login.TabIndex = 0;
            this.pictureBox_login.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_loginClear);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_login_user);
            this.Controls.Add(this.pictureBox_login);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_login;
        private System.Windows.Forms.Label label_login_user;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_loginClear;
        private System.Windows.Forms.Button button_login;
    }
}