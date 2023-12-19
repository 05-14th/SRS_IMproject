namespace SRS_IMproject
{
    partial class Student
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
            this.groupBox_attri = new System.Windows.Forms.GroupBox();
            this.textBox_stdsearch = new System.Windows.Forms.TextBox();
            this.button_stdsearch = new System.Windows.Forms.Button();
            this.button_stdprint = new System.Windows.Forms.Button();
            this.textBox_stdid = new System.Windows.Forms.TextBox();
            this.label_stdid = new System.Windows.Forms.Label();
            this.button_stdadd = new System.Windows.Forms.Button();
            this.button_stdrefresh = new System.Windows.Forms.Button();
            this.button_stdupdate = new System.Windows.Forms.Button();
            this.button_stsdelete = new System.Windows.Forms.Button();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.textBox_contactno = new System.Windows.Forms.TextBox();
            this.textBox_stdgender = new System.Windows.Forms.TextBox();
            this.textBox_stdmi = new System.Windows.Forms.TextBox();
            this.textBox_stdlname = new System.Windows.Forms.TextBox();
            this.textBox_stdfname = new System.Windows.Forms.TextBox();
            this.label_stdadd = new System.Windows.Forms.Label();
            this.label_stdcontactNo = new System.Windows.Forms.Label();
            this.label_stdgender = new System.Windows.Forms.Label();
            this.label_stdmi = new System.Windows.Forms.Label();
            this.label_stdlname = new System.Windows.Forms.Label();
            this.label_stdfname = new System.Windows.Forms.Label();
            this.pictureBox_std = new System.Windows.Forms.PictureBox();
            this.dataGridView_std = new System.Windows.Forms.DataGridView();
            this.groupBox_attri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_std)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_attri
            // 
            this.groupBox_attri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_attri.Controls.Add(this.textBox_stdsearch);
            this.groupBox_attri.Controls.Add(this.button_stdsearch);
            this.groupBox_attri.Controls.Add(this.button_stdprint);
            this.groupBox_attri.Controls.Add(this.textBox_stdid);
            this.groupBox_attri.Controls.Add(this.label_stdid);
            this.groupBox_attri.Controls.Add(this.button_stdadd);
            this.groupBox_attri.Controls.Add(this.button_stdrefresh);
            this.groupBox_attri.Controls.Add(this.button_stdupdate);
            this.groupBox_attri.Controls.Add(this.button_stsdelete);
            this.groupBox_attri.Controls.Add(this.textBox_add);
            this.groupBox_attri.Controls.Add(this.textBox_contactno);
            this.groupBox_attri.Controls.Add(this.textBox_stdgender);
            this.groupBox_attri.Controls.Add(this.textBox_stdmi);
            this.groupBox_attri.Controls.Add(this.textBox_stdlname);
            this.groupBox_attri.Controls.Add(this.textBox_stdfname);
            this.groupBox_attri.Controls.Add(this.label_stdadd);
            this.groupBox_attri.Controls.Add(this.label_stdcontactNo);
            this.groupBox_attri.Controls.Add(this.label_stdgender);
            this.groupBox_attri.Controls.Add(this.label_stdmi);
            this.groupBox_attri.Controls.Add(this.label_stdlname);
            this.groupBox_attri.Controls.Add(this.label_stdfname);
            this.groupBox_attri.Location = new System.Drawing.Point(12, 12);
            this.groupBox_attri.Name = "groupBox_attri";
            this.groupBox_attri.Size = new System.Drawing.Size(471, 251);
            this.groupBox_attri.TabIndex = 0;
            this.groupBox_attri.TabStop = false;
            this.groupBox_attri.Text = "Student Information";
            // 
            // textBox_stdsearch
            // 
            this.textBox_stdsearch.Location = new System.Drawing.Point(330, 218);
            this.textBox_stdsearch.Name = "textBox_stdsearch";
            this.textBox_stdsearch.Size = new System.Drawing.Size(129, 20);
            this.textBox_stdsearch.TabIndex = 21;
            this.textBox_stdsearch.TextChanged += new System.EventHandler(this.textBox_stdsearch_TextChanged);
            // 
            // button_stdsearch
            // 
            this.button_stdsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stdsearch.Location = new System.Drawing.Point(239, 213);
            this.button_stdsearch.Name = "button_stdsearch";
            this.button_stdsearch.Size = new System.Drawing.Size(85, 28);
            this.button_stdsearch.TabIndex = 20;
            this.button_stdsearch.Text = "Search";
            this.button_stdsearch.UseVisualStyleBackColor = true;
            this.button_stdsearch.Click += new System.EventHandler(this.button_stdsearch_Click);
            // 
            // button_stdprint
            // 
            this.button_stdprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stdprint.Location = new System.Drawing.Point(278, 80);
            this.button_stdprint.Name = "button_stdprint";
            this.button_stdprint.Size = new System.Drawing.Size(85, 28);
            this.button_stdprint.TabIndex = 19;
            this.button_stdprint.Text = "Print";
            this.button_stdprint.UseVisualStyleBackColor = true;
            this.button_stdprint.Click += new System.EventHandler(this.button_stdprint_Click);
            // 
            // textBox_stdid
            // 
            this.textBox_stdid.Location = new System.Drawing.Point(88, 218);
            this.textBox_stdid.Name = "textBox_stdid";
            this.textBox_stdid.Size = new System.Drawing.Size(129, 20);
            this.textBox_stdid.TabIndex = 18;
            // 
            // label_stdid
            // 
            this.label_stdid.AutoSize = true;
            this.label_stdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stdid.Location = new System.Drawing.Point(7, 218);
            this.label_stdid.Name = "label_stdid";
            this.label_stdid.Size = new System.Drawing.Size(49, 13);
            this.label_stdid.TabIndex = 17;
            this.label_stdid.Text = "Std Id: ";
            // 
            // button_stdadd
            // 
            this.button_stdadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stdadd.Location = new System.Drawing.Point(278, 46);
            this.button_stdadd.Name = "button_stdadd";
            this.button_stdadd.Size = new System.Drawing.Size(85, 28);
            this.button_stdadd.TabIndex = 15;
            this.button_stdadd.Text = "Add";
            this.button_stdadd.UseVisualStyleBackColor = true;
            this.button_stdadd.Click += new System.EventHandler(this.button_stdadd_Click);
            // 
            // button_stdrefresh
            // 
            this.button_stdrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stdrefresh.Location = new System.Drawing.Point(278, 12);
            this.button_stdrefresh.Name = "button_stdrefresh";
            this.button_stdrefresh.Size = new System.Drawing.Size(85, 28);
            this.button_stdrefresh.TabIndex = 14;
            this.button_stdrefresh.Text = "Refresh";
            this.button_stdrefresh.UseVisualStyleBackColor = true;
            this.button_stdrefresh.Click += new System.EventHandler(this.button_stdrefresh_Click);
            // 
            // button_stdupdate
            // 
            this.button_stdupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stdupdate.Location = new System.Drawing.Point(369, 46);
            this.button_stdupdate.Name = "button_stdupdate";
            this.button_stdupdate.Size = new System.Drawing.Size(85, 28);
            this.button_stdupdate.TabIndex = 13;
            this.button_stdupdate.Text = "Update";
            this.button_stdupdate.UseVisualStyleBackColor = true;
            this.button_stdupdate.Click += new System.EventHandler(this.button_stdupdate_Click);
            // 
            // button_stsdelete
            // 
            this.button_stsdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stsdelete.Location = new System.Drawing.Point(369, 12);
            this.button_stsdelete.Name = "button_stsdelete";
            this.button_stsdelete.Size = new System.Drawing.Size(85, 28);
            this.button_stsdelete.TabIndex = 12;
            this.button_stsdelete.Text = "Delete";
            this.button_stsdelete.UseVisualStyleBackColor = true;
            this.button_stsdelete.Click += new System.EventHandler(this.button_stsdelete_Click);
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(88, 180);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(129, 20);
            this.textBox_add.TabIndex = 11;
            // 
            // textBox_contactno
            // 
            this.textBox_contactno.Location = new System.Drawing.Point(88, 144);
            this.textBox_contactno.Name = "textBox_contactno";
            this.textBox_contactno.Size = new System.Drawing.Size(129, 20);
            this.textBox_contactno.TabIndex = 10;
            // 
            // textBox_stdgender
            // 
            this.textBox_stdgender.Location = new System.Drawing.Point(88, 110);
            this.textBox_stdgender.Name = "textBox_stdgender";
            this.textBox_stdgender.Size = new System.Drawing.Size(129, 20);
            this.textBox_stdgender.TabIndex = 9;
            // 
            // textBox_stdmi
            // 
            this.textBox_stdmi.Location = new System.Drawing.Point(88, 78);
            this.textBox_stdmi.Name = "textBox_stdmi";
            this.textBox_stdmi.Size = new System.Drawing.Size(129, 20);
            this.textBox_stdmi.TabIndex = 8;
            // 
            // textBox_stdlname
            // 
            this.textBox_stdlname.Location = new System.Drawing.Point(88, 43);
            this.textBox_stdlname.Name = "textBox_stdlname";
            this.textBox_stdlname.Size = new System.Drawing.Size(129, 20);
            this.textBox_stdlname.TabIndex = 7;
            // 
            // textBox_stdfname
            // 
            this.textBox_stdfname.Location = new System.Drawing.Point(88, 17);
            this.textBox_stdfname.Name = "textBox_stdfname";
            this.textBox_stdfname.Size = new System.Drawing.Size(129, 20);
            this.textBox_stdfname.TabIndex = 6;
            // 
            // label_stdadd
            // 
            this.label_stdadd.AutoSize = true;
            this.label_stdadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stdadd.Location = new System.Drawing.Point(7, 187);
            this.label_stdadd.Name = "label_stdadd";
            this.label_stdadd.Size = new System.Drawing.Size(60, 13);
            this.label_stdadd.TabIndex = 5;
            this.label_stdadd.Text = "Address :";
            // 
            // label_stdcontactNo
            // 
            this.label_stdcontactNo.AutoSize = true;
            this.label_stdcontactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stdcontactNo.Location = new System.Drawing.Point(7, 147);
            this.label_stdcontactNo.Name = "label_stdcontactNo";
            this.label_stdcontactNo.Size = new System.Drawing.Size(75, 13);
            this.label_stdcontactNo.TabIndex = 4;
            this.label_stdcontactNo.Text = "ContactNo :";
            // 
            // label_stdgender
            // 
            this.label_stdgender.AutoSize = true;
            this.label_stdgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stdgender.Location = new System.Drawing.Point(7, 113);
            this.label_stdgender.Name = "label_stdgender";
            this.label_stdgender.Size = new System.Drawing.Size(56, 13);
            this.label_stdgender.TabIndex = 3;
            this.label_stdgender.Text = "Gender :";
            // 
            // label_stdmi
            // 
            this.label_stdmi.AutoSize = true;
            this.label_stdmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stdmi.Location = new System.Drawing.Point(6, 85);
            this.label_stdmi.Name = "label_stdmi";
            this.label_stdmi.Size = new System.Drawing.Size(33, 13);
            this.label_stdmi.TabIndex = 2;
            this.label_stdmi.Text = "M.I :";
            // 
            // label_stdlname
            // 
            this.label_stdlname.AutoSize = true;
            this.label_stdlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stdlname.Location = new System.Drawing.Point(6, 53);
            this.label_stdlname.Name = "label_stdlname";
            this.label_stdlname.Size = new System.Drawing.Size(75, 13);
            this.label_stdlname.TabIndex = 1;
            this.label_stdlname.Text = "Last Name :";
            // 
            // label_stdfname
            // 
            this.label_stdfname.AutoSize = true;
            this.label_stdfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stdfname.Location = new System.Drawing.Point(7, 23);
            this.label_stdfname.Name = "label_stdfname";
            this.label_stdfname.Size = new System.Drawing.Size(75, 13);
            this.label_stdfname.TabIndex = 0;
            this.label_stdfname.Text = "First Name :";
            // 
            // pictureBox_std
            // 
            this.pictureBox_std.Image = global::SRS_IMproject.Properties.Resources._406946243_679181814337005_5379189340969904211_n;
            this.pictureBox_std.Location = new System.Drawing.Point(489, 12);
            this.pictureBox_std.Name = "pictureBox_std";
            this.pictureBox_std.Size = new System.Drawing.Size(308, 234);
            this.pictureBox_std.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_std.TabIndex = 1;
            this.pictureBox_std.TabStop = false;
            // 
            // dataGridView_std
            // 
            this.dataGridView_std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_std.Location = new System.Drawing.Point(12, 269);
            this.dataGridView_std.Name = "dataGridView_std";
            this.dataGridView_std.Size = new System.Drawing.Size(792, 177);
            this.dataGridView_std.TabIndex = 2;
            this.dataGridView_std.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_std_CellContentClick);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_std);
            this.Controls.Add(this.pictureBox_std);
            this.Controls.Add(this.groupBox_attri);
            this.Name = "Student";
            this.Text = "Student";
            this.groupBox_attri.ResumeLayout(false);
            this.groupBox_attri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_std)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_attri;
        private System.Windows.Forms.Label label_stdcontactNo;
        private System.Windows.Forms.Label label_stdgender;
        private System.Windows.Forms.Label label_stdmi;
        private System.Windows.Forms.Label label_stdlname;
        private System.Windows.Forms.Label label_stdfname;
        private System.Windows.Forms.Label label_stdadd;
        private System.Windows.Forms.TextBox textBox_stdlname;
        private System.Windows.Forms.TextBox textBox_stdfname;
        private System.Windows.Forms.TextBox textBox_stdgender;
        private System.Windows.Forms.TextBox textBox_stdmi;
        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.TextBox textBox_contactno;
        private System.Windows.Forms.PictureBox pictureBox_std;
        private System.Windows.Forms.Button button_stdadd;
        private System.Windows.Forms.Button button_stdrefresh;
        private System.Windows.Forms.Button button_stdupdate;
        private System.Windows.Forms.Button button_stsdelete;
        private System.Windows.Forms.DataGridView dataGridView_std;
        private System.Windows.Forms.TextBox textBox_stdid;
        private System.Windows.Forms.Label label_stdid;
        private System.Windows.Forms.TextBox textBox_stdsearch;
        private System.Windows.Forms.Button button_stdsearch;
        private System.Windows.Forms.Button button_stdprint;
    }
}