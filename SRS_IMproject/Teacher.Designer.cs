namespace SRS_IMproject
{
    partial class Teacher
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
            this.dataGridView_std = new System.Windows.Forms.DataGridView();
            this.textBox_t_Id = new System.Windows.Forms.TextBox();
            this.label_t_Id = new System.Windows.Forms.Label();
            this.button_Tadd = new System.Windows.Forms.Button();
            this.button_Trefresh = new System.Windows.Forms.Button();
            this.button_Tupdate = new System.Windows.Forms.Button();
            this.button_Tdelete = new System.Windows.Forms.Button();
            this.textBox_handleSub = new System.Windows.Forms.TextBox();
            this.textBox_Tcontactno = new System.Windows.Forms.TextBox();
            this.textBox_Tlname = new System.Windows.Forms.TextBox();
            this.textBox_tfname = new System.Windows.Forms.TextBox();
            this.label_handleSub = new System.Windows.Forms.Label();
            this.label_TcontactNo = new System.Windows.Forms.Label();
            this.label_Tlname = new System.Windows.Forms.Label();
            this.label_Tfname = new System.Windows.Forms.Label();
            this.groupBox_attri = new System.Windows.Forms.GroupBox();
            this.textBox_Tsearch = new System.Windows.Forms.TextBox();
            this.button_Tsearch = new System.Windows.Forms.Button();
            this.button_Tprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).BeginInit();
            this.groupBox_attri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_std
            // 
            this.dataGridView_std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_std.Location = new System.Drawing.Point(68, 296);
            this.dataGridView_std.Name = "dataGridView_std";
            this.dataGridView_std.Size = new System.Drawing.Size(792, 177);
            this.dataGridView_std.TabIndex = 5;
            // 
            // textBox_t_Id
            // 
            this.textBox_t_Id.Location = new System.Drawing.Point(99, 149);
            this.textBox_t_Id.Name = "textBox_t_Id";
            this.textBox_t_Id.Size = new System.Drawing.Size(129, 20);
            this.textBox_t_Id.TabIndex = 18;
            // 
            // label_t_Id
            // 
            this.label_t_Id.AutoSize = true;
            this.label_t_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_t_Id.Location = new System.Drawing.Point(24, 149);
            this.label_t_Id.Name = "label_t_Id";
            this.label_t_Id.Size = new System.Drawing.Size(24, 13);
            this.label_t_Id.TabIndex = 17;
            this.label_t_Id.Text = "ID:";
            // 
            // button_Tadd
            // 
            this.button_Tadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tadd.Location = new System.Drawing.Point(274, 50);
            this.button_Tadd.Name = "button_Tadd";
            this.button_Tadd.Size = new System.Drawing.Size(85, 28);
            this.button_Tadd.TabIndex = 15;
            this.button_Tadd.Text = "Add";
            this.button_Tadd.UseVisualStyleBackColor = true;
            this.button_Tadd.Click += new System.EventHandler(this.button_Tadd_Click);
            // 
            // button_Trefresh
            // 
            this.button_Trefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Trefresh.Location = new System.Drawing.Point(274, 16);
            this.button_Trefresh.Name = "button_Trefresh";
            this.button_Trefresh.Size = new System.Drawing.Size(85, 28);
            this.button_Trefresh.TabIndex = 14;
            this.button_Trefresh.Text = "Refresh";
            this.button_Trefresh.UseVisualStyleBackColor = true;
            this.button_Trefresh.Click += new System.EventHandler(this.button_Trefresh_Click);
            // 
            // button_Tupdate
            // 
            this.button_Tupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tupdate.Location = new System.Drawing.Point(361, 50);
            this.button_Tupdate.Name = "button_Tupdate";
            this.button_Tupdate.Size = new System.Drawing.Size(85, 28);
            this.button_Tupdate.TabIndex = 13;
            this.button_Tupdate.Text = "Update";
            this.button_Tupdate.UseVisualStyleBackColor = true;
            this.button_Tupdate.Click += new System.EventHandler(this.button_Tupdate_Click);
            // 
            // button_Tdelete
            // 
            this.button_Tdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tdelete.Location = new System.Drawing.Point(361, 16);
            this.button_Tdelete.Name = "button_Tdelete";
            this.button_Tdelete.Size = new System.Drawing.Size(85, 28);
            this.button_Tdelete.TabIndex = 12;
            this.button_Tdelete.Text = "Delete";
            this.button_Tdelete.UseVisualStyleBackColor = true;
            this.button_Tdelete.Click += new System.EventHandler(this.button_Tdelete_Click);
            // 
            // textBox_handleSub
            // 
            this.textBox_handleSub.Location = new System.Drawing.Point(99, 119);
            this.textBox_handleSub.Name = "textBox_handleSub";
            this.textBox_handleSub.Size = new System.Drawing.Size(129, 20);
            this.textBox_handleSub.TabIndex = 11;
            // 
            // textBox_Tcontactno
            // 
            this.textBox_Tcontactno.Location = new System.Drawing.Point(99, 85);
            this.textBox_Tcontactno.Name = "textBox_Tcontactno";
            this.textBox_Tcontactno.Size = new System.Drawing.Size(129, 20);
            this.textBox_Tcontactno.TabIndex = 10;
            // 
            // textBox_Tlname
            // 
            this.textBox_Tlname.Location = new System.Drawing.Point(99, 49);
            this.textBox_Tlname.Name = "textBox_Tlname";
            this.textBox_Tlname.Size = new System.Drawing.Size(129, 20);
            this.textBox_Tlname.TabIndex = 7;
            // 
            // textBox_tfname
            // 
            this.textBox_tfname.Location = new System.Drawing.Point(99, 16);
            this.textBox_tfname.Name = "textBox_tfname";
            this.textBox_tfname.Size = new System.Drawing.Size(129, 20);
            this.textBox_tfname.TabIndex = 6;
            // 
            // label_handleSub
            // 
            this.label_handleSub.AutoSize = true;
            this.label_handleSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_handleSub.Location = new System.Drawing.Point(7, 119);
            this.label_handleSub.Name = "label_handleSub";
            this.label_handleSub.Size = new System.Drawing.Size(54, 13);
            this.label_handleSub.TabIndex = 5;
            this.label_handleSub.Text = "Subject:";
            // 
            // label_TcontactNo
            // 
            this.label_TcontactNo.AutoSize = true;
            this.label_TcontactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TcontactNo.Location = new System.Drawing.Point(7, 85);
            this.label_TcontactNo.Name = "label_TcontactNo";
            this.label_TcontactNo.Size = new System.Drawing.Size(75, 13);
            this.label_TcontactNo.TabIndex = 4;
            this.label_TcontactNo.Text = "ContactNo :";
            // 
            // label_Tlname
            // 
            this.label_Tlname.AutoSize = true;
            this.label_Tlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tlname.Location = new System.Drawing.Point(6, 53);
            this.label_Tlname.Name = "label_Tlname";
            this.label_Tlname.Size = new System.Drawing.Size(75, 13);
            this.label_Tlname.TabIndex = 1;
            this.label_Tlname.Text = "Last Name :";
            // 
            // label_Tfname
            // 
            this.label_Tfname.AutoSize = true;
            this.label_Tfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tfname.Location = new System.Drawing.Point(7, 23);
            this.label_Tfname.Name = "label_Tfname";
            this.label_Tfname.Size = new System.Drawing.Size(75, 13);
            this.label_Tfname.TabIndex = 0;
            this.label_Tfname.Text = "First Name :";
            // 
            // groupBox_attri
            // 
            this.groupBox_attri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_attri.Controls.Add(this.textBox_Tsearch);
            this.groupBox_attri.Controls.Add(this.button_Tsearch);
            this.groupBox_attri.Controls.Add(this.button_Tprint);
            this.groupBox_attri.Controls.Add(this.textBox_t_Id);
            this.groupBox_attri.Controls.Add(this.label_t_Id);
            this.groupBox_attri.Controls.Add(this.button_Tadd);
            this.groupBox_attri.Controls.Add(this.button_Trefresh);
            this.groupBox_attri.Controls.Add(this.button_Tupdate);
            this.groupBox_attri.Controls.Add(this.button_Tdelete);
            this.groupBox_attri.Controls.Add(this.textBox_handleSub);
            this.groupBox_attri.Controls.Add(this.textBox_Tcontactno);
            this.groupBox_attri.Controls.Add(this.textBox_Tlname);
            this.groupBox_attri.Controls.Add(this.textBox_tfname);
            this.groupBox_attri.Controls.Add(this.label_handleSub);
            this.groupBox_attri.Controls.Add(this.label_TcontactNo);
            this.groupBox_attri.Controls.Add(this.label_Tlname);
            this.groupBox_attri.Controls.Add(this.label_Tfname);
            this.groupBox_attri.Location = new System.Drawing.Point(68, 39);
            this.groupBox_attri.Name = "groupBox_attri";
            this.groupBox_attri.Size = new System.Drawing.Size(452, 251);
            this.groupBox_attri.TabIndex = 3;
            this.groupBox_attri.TabStop = false;
            this.groupBox_attri.Text = "Teachers Information";
            // 
            // textBox_Tsearch
            // 
            this.textBox_Tsearch.Location = new System.Drawing.Point(99, 225);
            this.textBox_Tsearch.Name = "textBox_Tsearch";
            this.textBox_Tsearch.Size = new System.Drawing.Size(129, 20);
            this.textBox_Tsearch.TabIndex = 21;
            // 
            // button_Tsearch
            // 
            this.button_Tsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tsearch.Location = new System.Drawing.Point(10, 223);
            this.button_Tsearch.Name = "button_Tsearch";
            this.button_Tsearch.Size = new System.Drawing.Size(85, 28);
            this.button_Tsearch.TabIndex = 20;
            this.button_Tsearch.Text = "Search";
            this.button_Tsearch.UseVisualStyleBackColor = true;
            this.button_Tsearch.Click += new System.EventHandler(this.button_Tsearch_Click);
            // 
            // button_Tprint
            // 
            this.button_Tprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tprint.Location = new System.Drawing.Point(274, 85);
            this.button_Tprint.Name = "button_Tprint";
            this.button_Tprint.Size = new System.Drawing.Size(85, 28);
            this.button_Tprint.TabIndex = 19;
            this.button_Tprint.Text = "Print";
            this.button_Tprint.UseVisualStyleBackColor = true;
            this.button_Tprint.Click += new System.EventHandler(this.button_Tprint_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 500);
            this.Controls.Add(this.dataGridView_std);
            this.Controls.Add(this.groupBox_attri);
            this.Name = "Teacher";
            this.Text = "Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).EndInit();
            this.groupBox_attri.ResumeLayout(false);
            this.groupBox_attri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_std;
        private System.Windows.Forms.TextBox textBox_t_Id;
        private System.Windows.Forms.Label label_t_Id;
        private System.Windows.Forms.Button button_Tadd;
        private System.Windows.Forms.Button button_Trefresh;
        private System.Windows.Forms.Button button_Tupdate;
        private System.Windows.Forms.Button button_Tdelete;
        private System.Windows.Forms.TextBox textBox_handleSub;
        private System.Windows.Forms.TextBox textBox_Tcontactno;
        private System.Windows.Forms.TextBox textBox_Tlname;
        private System.Windows.Forms.TextBox textBox_tfname;
        private System.Windows.Forms.Label label_handleSub;
        private System.Windows.Forms.Label label_TcontactNo;
        private System.Windows.Forms.Label label_Tlname;
        private System.Windows.Forms.Label label_Tfname;
        private System.Windows.Forms.GroupBox groupBox_attri;
        private System.Windows.Forms.Button button_Tprint;
        private System.Windows.Forms.TextBox textBox_Tsearch;
        private System.Windows.Forms.Button button_Tsearch;

    }
}