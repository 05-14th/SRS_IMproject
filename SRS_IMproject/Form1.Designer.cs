namespace SRS_IMproject
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
            this.panel_up = new System.Windows.Forms.Panel();
            this.panel_up_side = new System.Windows.Forms.Panel();
            this.label_ciname = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_schname = new System.Windows.Forms.Label();
            this.panel_side = new System.Windows.Forms.Panel();
            this.butto_admissionReqs = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_enollmentrates = new System.Windows.Forms.Button();
            this.button_score = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_teacher = new System.Windows.Forms.Button();
            this.button_std = new System.Windows.Forms.Button();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.panel_up.SuspendLayout();
            this.panel_up_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_up.Controls.Add(this.panel_up_side);
            this.panel_up.Controls.Add(this.label_schname);
            this.panel_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_up.Location = new System.Drawing.Point(0, 0);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(603, 68);
            this.panel_up.TabIndex = 0;
            // 
            // panel_up_side
            // 
            this.panel_up_side.Controls.Add(this.label_ciname);
            this.panel_up_side.Controls.Add(this.pictureBox_logo);
            this.panel_up_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_up_side.Location = new System.Drawing.Point(0, 0);
            this.panel_up_side.Name = "panel_up_side";
            this.panel_up_side.Size = new System.Drawing.Size(180, 68);
            this.panel_up_side.TabIndex = 1;
            // 
            // label_ciname
            // 
            this.label_ciname.AutoSize = true;
            this.label_ciname.Font = new System.Drawing.Font("Broadway", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ciname.Location = new System.Drawing.Point(74, 9);
            this.label_ciname.Name = "label_ciname";
            this.label_ciname.Size = new System.Drawing.Size(76, 42);
            this.label_ciname.TabIndex = 1;
            this.label_ciname.Text = "C.I";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::SRS_IMproject.Properties.Resources.ci;
            this.pictureBox_logo.Location = new System.Drawing.Point(25, 17);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(37, 30);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_schname
            // 
            this.label_schname.AutoSize = true;
            this.label_schname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_schname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_schname.Location = new System.Drawing.Point(265, 23);
            this.label_schname.Name = "label_schname";
            this.label_schname.Size = new System.Drawing.Size(247, 24);
            this.label_schname.TabIndex = 0;
            this.label_schname.Text = "Student Record System";
            this.label_schname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_side.Controls.Add(this.butto_admissionReqs);
            this.panel_side.Controls.Add(this.button_logout);
            this.panel_side.Controls.Add(this.button_enollmentrates);
            this.panel_side.Controls.Add(this.button_score);
            this.panel_side.Controls.Add(this.button_sub);
            this.panel_side.Controls.Add(this.button_teacher);
            this.panel_side.Controls.Add(this.button_std);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 68);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(180, 295);
            this.panel_side.TabIndex = 1;
            // 
            // butto_admissionReqs
            // 
            this.butto_admissionReqs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butto_admissionReqs.Location = new System.Drawing.Point(25, 185);
            this.butto_admissionReqs.Name = "butto_admissionReqs";
            this.butto_admissionReqs.Size = new System.Drawing.Size(125, 32);
            this.butto_admissionReqs.TabIndex = 6;
            this.butto_admissionReqs.Text = "Admission Reqs";
            this.butto_admissionReqs.UseVisualStyleBackColor = true;
            this.butto_admissionReqs.Click += new System.EventHandler(this.butto_admissionReqs_Click);
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.Location = new System.Drawing.Point(25, 246);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(125, 37);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_enollmentrates
            // 
            this.button_enollmentrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enollmentrates.Location = new System.Drawing.Point(25, 147);
            this.button_enollmentrates.Name = "button_enollmentrates";
            this.button_enollmentrates.Size = new System.Drawing.Size(125, 32);
            this.button_enollmentrates.TabIndex = 4;
            this.button_enollmentrates.Text = "EnrollmentRates";
            this.button_enollmentrates.UseVisualStyleBackColor = true;
            this.button_enollmentrates.Click += new System.EventHandler(this.button_enollmentrates_Click);
            // 
            // button_score
            // 
            this.button_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_score.Location = new System.Drawing.Point(25, 114);
            this.button_score.Name = "button_score";
            this.button_score.Size = new System.Drawing.Size(125, 27);
            this.button_score.TabIndex = 3;
            this.button_score.Text = "Score";
            this.button_score.UseVisualStyleBackColor = true;
            this.button_score.Click += new System.EventHandler(this.button_score_Click);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sub.Location = new System.Drawing.Point(25, 80);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(125, 28);
            this.button_sub.TabIndex = 2;
            this.button_sub.Text = "Subject";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_teacher
            // 
            this.button_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_teacher.Location = new System.Drawing.Point(25, 43);
            this.button_teacher.Name = "button_teacher";
            this.button_teacher.Size = new System.Drawing.Size(125, 31);
            this.button_teacher.TabIndex = 1;
            this.button_teacher.Text = "Teacher";
            this.button_teacher.UseVisualStyleBackColor = true;
            this.button_teacher.Click += new System.EventHandler(this.button_teacher_Click);
            // 
            // button_std
            // 
            this.button_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_std.Location = new System.Drawing.Point(25, 6);
            this.button_std.Name = "button_std";
            this.button_std.Size = new System.Drawing.Size(125, 31);
            this.button_std.TabIndex = 0;
            this.button_std.Text = "Student";
            this.button_std.UseVisualStyleBackColor = true;
            this.button_std.Click += new System.EventHandler(this.button_std_Click);
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.Image = global::SRS_IMproject.Properties.Resources.schoolpicc;
            this.pictureBox_main.Location = new System.Drawing.Point(186, 74);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(405, 277);
            this.pictureBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_main.TabIndex = 2;
            this.pictureBox_main.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 363);
            this.Controls.Add(this.pictureBox_main);
            this.Controls.Add(this.panel_side);
            this.Controls.Add(this.panel_up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_up.ResumeLayout(false);
            this.panel_up.PerformLayout();
            this.panel_up_side.ResumeLayout(false);
            this.panel_up_side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Label label_schname;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_enollmentrates;
        private System.Windows.Forms.Button button_score;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_teacher;
        private System.Windows.Forms.Button button_std;
        private System.Windows.Forms.Panel panel_up_side;
        private System.Windows.Forms.Label label_ciname;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Button butto_admissionReqs;
    }
}

