namespace SRS_IMproject
{
    partial class AdmissionReqs
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
            this.textBox_aqsearch = new System.Windows.Forms.TextBox();
            this.button_aqsearch = new System.Windows.Forms.Button();
            this.button_aqprint = new System.Windows.Forms.Button();
            this.textBox_reqstype = new System.Windows.Forms.TextBox();
            this.label_reqstype = new System.Windows.Forms.Label();
            this.button_aqadd = new System.Windows.Forms.Button();
            this.button_aqrefresh = new System.Windows.Forms.Button();
            this.button_aqupdate = new System.Windows.Forms.Button();
            this.button_aqdelete = new System.Windows.Forms.Button();
            this.dataGridView_std = new System.Windows.Forms.DataGridView();
            this.textBox_aq_stdid = new System.Windows.Forms.TextBox();
            this.textBox_admissionId = new System.Windows.Forms.TextBox();
            this.label_aq_stdid = new System.Windows.Forms.Label();
            this.label_admissionId = new System.Windows.Forms.Label();
            this.groupBox_attri = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).BeginInit();
            this.groupBox_attri.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_aqsearch
            // 
            this.textBox_aqsearch.Location = new System.Drawing.Point(99, 225);
            this.textBox_aqsearch.Name = "textBox_aqsearch";
            this.textBox_aqsearch.Size = new System.Drawing.Size(129, 20);
            this.textBox_aqsearch.TabIndex = 21;
            // 
            // button_aqsearch
            // 
            this.button_aqsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aqsearch.Location = new System.Drawing.Point(10, 223);
            this.button_aqsearch.Name = "button_aqsearch";
            this.button_aqsearch.Size = new System.Drawing.Size(85, 28);
            this.button_aqsearch.TabIndex = 20;
            this.button_aqsearch.Text = "Search";
            this.button_aqsearch.UseVisualStyleBackColor = true;
            this.button_aqsearch.Click += new System.EventHandler(this.button_aqsearch_Click);
            // 
            // button_aqprint
            // 
            this.button_aqprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aqprint.Location = new System.Drawing.Point(274, 85);
            this.button_aqprint.Name = "button_aqprint";
            this.button_aqprint.Size = new System.Drawing.Size(85, 28);
            this.button_aqprint.TabIndex = 19;
            this.button_aqprint.Text = "Print";
            this.button_aqprint.UseVisualStyleBackColor = true;
            this.button_aqprint.Click += new System.EventHandler(this.button_aqprint_Click);
            // 
            // textBox_reqstype
            // 
            this.textBox_reqstype.Location = new System.Drawing.Point(124, 82);
            this.textBox_reqstype.Name = "textBox_reqstype";
            this.textBox_reqstype.Size = new System.Drawing.Size(129, 20);
            this.textBox_reqstype.TabIndex = 18;
            // 
            // label_reqstype
            // 
            this.label_reqstype.AutoSize = true;
            this.label_reqstype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reqstype.Location = new System.Drawing.Point(7, 85);
            this.label_reqstype.Name = "label_reqstype";
            this.label_reqstype.Size = new System.Drawing.Size(120, 13);
            this.label_reqstype.TabIndex = 17;
            this.label_reqstype.Text = "Requirements Type:";
            // 
            // button_aqadd
            // 
            this.button_aqadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aqadd.Location = new System.Drawing.Point(274, 50);
            this.button_aqadd.Name = "button_aqadd";
            this.button_aqadd.Size = new System.Drawing.Size(85, 28);
            this.button_aqadd.TabIndex = 15;
            this.button_aqadd.Text = "Add";
            this.button_aqadd.UseVisualStyleBackColor = true;
            this.button_aqadd.Click += new System.EventHandler(this.button_aqadd_Click);
            // 
            // button_aqrefresh
            // 
            this.button_aqrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aqrefresh.Location = new System.Drawing.Point(274, 16);
            this.button_aqrefresh.Name = "button_aqrefresh";
            this.button_aqrefresh.Size = new System.Drawing.Size(85, 28);
            this.button_aqrefresh.TabIndex = 14;
            this.button_aqrefresh.Text = "Refresh";
            this.button_aqrefresh.UseVisualStyleBackColor = true;
            this.button_aqrefresh.Click += new System.EventHandler(this.button_aqrefresh_Click);
            // 
            // button_aqupdate
            // 
            this.button_aqupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aqupdate.Location = new System.Drawing.Point(361, 50);
            this.button_aqupdate.Name = "button_aqupdate";
            this.button_aqupdate.Size = new System.Drawing.Size(85, 28);
            this.button_aqupdate.TabIndex = 13;
            this.button_aqupdate.Text = "Update";
            this.button_aqupdate.UseVisualStyleBackColor = true;
            this.button_aqupdate.Click += new System.EventHandler(this.button_aqupdate_Click);
            // 
            // button_aqdelete
            // 
            this.button_aqdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aqdelete.Location = new System.Drawing.Point(361, 16);
            this.button_aqdelete.Name = "button_aqdelete";
            this.button_aqdelete.Size = new System.Drawing.Size(85, 28);
            this.button_aqdelete.TabIndex = 12;
            this.button_aqdelete.Text = "Delete";
            this.button_aqdelete.UseVisualStyleBackColor = true;
            this.button_aqdelete.Click += new System.EventHandler(this.button_aqdelete_Click);
            // 
            // dataGridView_std
            // 
            this.dataGridView_std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_std.Location = new System.Drawing.Point(66, 288);
            this.dataGridView_std.Name = "dataGridView_std";
            this.dataGridView_std.Size = new System.Drawing.Size(792, 177);
            this.dataGridView_std.TabIndex = 11;
            // 
            // textBox_aq_stdid
            // 
            this.textBox_aq_stdid.Location = new System.Drawing.Point(99, 49);
            this.textBox_aq_stdid.Name = "textBox_aq_stdid";
            this.textBox_aq_stdid.Size = new System.Drawing.Size(129, 20);
            this.textBox_aq_stdid.TabIndex = 7;
            // 
            // textBox_admissionId
            // 
            this.textBox_admissionId.Location = new System.Drawing.Point(99, 16);
            this.textBox_admissionId.Name = "textBox_admissionId";
            this.textBox_admissionId.Size = new System.Drawing.Size(129, 20);
            this.textBox_admissionId.TabIndex = 6;
            // 
            // label_aq_stdid
            // 
            this.label_aq_stdid.AutoSize = true;
            this.label_aq_stdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aq_stdid.Location = new System.Drawing.Point(6, 53);
            this.label_aq_stdid.Name = "label_aq_stdid";
            this.label_aq_stdid.Size = new System.Drawing.Size(70, 13);
            this.label_aq_stdid.TabIndex = 1;
            this.label_aq_stdid.Text = "Student Id:";
            // 
            // label_admissionId
            // 
            this.label_admissionId.AutoSize = true;
            this.label_admissionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admissionId.Location = new System.Drawing.Point(7, 23);
            this.label_admissionId.Name = "label_admissionId";
            this.label_admissionId.Size = new System.Drawing.Size(82, 13);
            this.label_admissionId.TabIndex = 0;
            this.label_admissionId.Text = "Admission Id:";
            // 
            // groupBox_attri
            // 
            this.groupBox_attri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_attri.Controls.Add(this.textBox_aqsearch);
            this.groupBox_attri.Controls.Add(this.button_aqsearch);
            this.groupBox_attri.Controls.Add(this.button_aqprint);
            this.groupBox_attri.Controls.Add(this.textBox_reqstype);
            this.groupBox_attri.Controls.Add(this.label_reqstype);
            this.groupBox_attri.Controls.Add(this.button_aqadd);
            this.groupBox_attri.Controls.Add(this.button_aqrefresh);
            this.groupBox_attri.Controls.Add(this.button_aqupdate);
            this.groupBox_attri.Controls.Add(this.button_aqdelete);
            this.groupBox_attri.Controls.Add(this.textBox_aq_stdid);
            this.groupBox_attri.Controls.Add(this.textBox_admissionId);
            this.groupBox_attri.Controls.Add(this.label_aq_stdid);
            this.groupBox_attri.Controls.Add(this.label_admissionId);
            this.groupBox_attri.Location = new System.Drawing.Point(66, 31);
            this.groupBox_attri.Name = "groupBox_attri";
            this.groupBox_attri.Size = new System.Drawing.Size(452, 251);
            this.groupBox_attri.TabIndex = 9;
            this.groupBox_attri.TabStop = false;
            this.groupBox_attri.Text = "Admission";
            // 
            // AdmissionReqs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 496);
            this.Controls.Add(this.dataGridView_std);
            this.Controls.Add(this.groupBox_attri);
            this.Name = "AdmissionReqs";
            this.Text = "AdmissionReqs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).EndInit();
            this.groupBox_attri.ResumeLayout(false);
            this.groupBox_attri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_aqsearch;
        private System.Windows.Forms.Button button_aqsearch;
        private System.Windows.Forms.Button button_aqprint;
        private System.Windows.Forms.TextBox textBox_reqstype;
        private System.Windows.Forms.Label label_reqstype;
        private System.Windows.Forms.Button button_aqadd;
        private System.Windows.Forms.Button button_aqrefresh;
        private System.Windows.Forms.Button button_aqupdate;
        private System.Windows.Forms.Button button_aqdelete;
        private System.Windows.Forms.DataGridView dataGridView_std;
        private System.Windows.Forms.TextBox textBox_aq_stdid;
        private System.Windows.Forms.TextBox textBox_admissionId;
        private System.Windows.Forms.Label label_aq_stdid;
        private System.Windows.Forms.Label label_admissionId;
        private System.Windows.Forms.GroupBox groupBox_attri;
    }
}