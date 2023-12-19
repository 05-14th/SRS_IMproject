namespace SRS_IMproject
{
    partial class Score
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_scoreprint = new System.Windows.Forms.Button();
            this.textBox_assessmentType = new System.Windows.Forms.TextBox();
            this.label_score_assessmentType = new System.Windows.Forms.Label();
            this.button_scoreadd = new System.Windows.Forms.Button();
            this.button_scorerefresh = new System.Windows.Forms.Button();
            this.button_scoreupdate = new System.Windows.Forms.Button();
            this.button_scoredelete = new System.Windows.Forms.Button();
            this.teachid = new System.Windows.Forms.TextBox();
            this.textBox_contactno = new System.Windows.Forms.TextBox();
            this.stdid = new System.Windows.Forms.TextBox();
            this.label_score_tid = new System.Windows.Forms.Label();
            this.label_score_subid = new System.Windows.Forms.Label();
            this.label_score_stdid = new System.Windows.Forms.Label();
            this.label_scoreid = new System.Windows.Forms.Label();
            this.dataGridView_std = new System.Windows.Forms.DataGridView();
            this.subId = new System.Windows.Forms.TextBox();
            this.groupBox_attri = new System.Windows.Forms.GroupBox();
            this.textBox_finalgrades = new System.Windows.Forms.TextBox();
            this.label_finalgrades = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).BeginInit();
            this.groupBox_attri.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_scoreprint
            // 
            this.button_scoreprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scoreprint.Location = new System.Drawing.Point(274, 85);
            this.button_scoreprint.Name = "button_scoreprint";
            this.button_scoreprint.Size = new System.Drawing.Size(85, 28);
            this.button_scoreprint.TabIndex = 19;
            this.button_scoreprint.Text = "Print";
            this.button_scoreprint.UseVisualStyleBackColor = true;
            this.button_scoreprint.Click += new System.EventHandler(this.button_scoreprint_Click);
            // 
            // textBox_assessmentType
            // 
            this.textBox_assessmentType.Location = new System.Drawing.Point(121, 145);
            this.textBox_assessmentType.Name = "textBox_assessmentType";
            this.textBox_assessmentType.Size = new System.Drawing.Size(129, 20);
            this.textBox_assessmentType.TabIndex = 18;
            // 
            // label_score_assessmentType
            // 
            this.label_score_assessmentType.AutoSize = true;
            this.label_score_assessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score_assessmentType.Location = new System.Drawing.Point(6, 149);
            this.label_score_assessmentType.Name = "label_score_assessmentType";
            this.label_score_assessmentType.Size = new System.Drawing.Size(109, 13);
            this.label_score_assessmentType.TabIndex = 17;
            this.label_score_assessmentType.Text = "Assessment Type:";
            // 
            // button_scoreadd
            // 
            this.button_scoreadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scoreadd.Location = new System.Drawing.Point(274, 50);
            this.button_scoreadd.Name = "button_scoreadd";
            this.button_scoreadd.Size = new System.Drawing.Size(85, 28);
            this.button_scoreadd.TabIndex = 15;
            this.button_scoreadd.Text = "Add";
            this.button_scoreadd.UseVisualStyleBackColor = true;
            this.button_scoreadd.Click += new System.EventHandler(this.button_scoreadd_Click);
            // 
            // button_scorerefresh
            // 
            this.button_scorerefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scorerefresh.Location = new System.Drawing.Point(274, 16);
            this.button_scorerefresh.Name = "button_scorerefresh";
            this.button_scorerefresh.Size = new System.Drawing.Size(85, 28);
            this.button_scorerefresh.TabIndex = 14;
            this.button_scorerefresh.Text = "Refresh";
            this.button_scorerefresh.UseVisualStyleBackColor = true;
            this.button_scorerefresh.Click += new System.EventHandler(this.button_scorerefresh_Click);
            // 
            // button_scoreupdate
            // 
            this.button_scoreupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scoreupdate.Location = new System.Drawing.Point(361, 50);
            this.button_scoreupdate.Name = "button_scoreupdate";
            this.button_scoreupdate.Size = new System.Drawing.Size(85, 28);
            this.button_scoreupdate.TabIndex = 13;
            this.button_scoreupdate.Text = "Update";
            this.button_scoreupdate.UseVisualStyleBackColor = true;
            this.button_scoreupdate.Click += new System.EventHandler(this.button_scoreupdate_Click);
            // 
            // button_scoredelete
            // 
            this.button_scoredelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scoredelete.Location = new System.Drawing.Point(361, 16);
            this.button_scoredelete.Name = "button_scoredelete";
            this.button_scoredelete.Size = new System.Drawing.Size(85, 28);
            this.button_scoredelete.TabIndex = 12;
            this.button_scoredelete.Text = "Delete";
            this.button_scoredelete.UseVisualStyleBackColor = true;
            this.button_scoredelete.Click += new System.EventHandler(this.button_scoredelete_Click);
            // 
            // teachid
            // 
            this.teachid.Location = new System.Drawing.Point(99, 119);
            this.teachid.Name = "teachid";
            this.teachid.Size = new System.Drawing.Size(129, 20);
            this.teachid.TabIndex = 11;
            // 
            // textBox_contactno
            // 
            this.textBox_contactno.Location = new System.Drawing.Point(99, 85);
            this.textBox_contactno.Name = "textBox_contactno";
            this.textBox_contactno.Size = new System.Drawing.Size(129, 20);
            this.textBox_contactno.TabIndex = 10;
            // 
            // stdid
            // 
            this.stdid.Location = new System.Drawing.Point(99, 49);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(129, 20);
            this.stdid.TabIndex = 7;
            // 
            // label_score_tid
            // 
            this.label_score_tid.AutoSize = true;
            this.label_score_tid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score_tid.Location = new System.Drawing.Point(7, 119);
            this.label_score_tid.Name = "label_score_tid";
            this.label_score_tid.Size = new System.Drawing.Size(73, 13);
            this.label_score_tid.TabIndex = 5;
            this.label_score_tid.Text = "Teacher Id:";
            // 
            // label_score_subid
            // 
            this.label_score_subid.AutoSize = true;
            this.label_score_subid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score_subid.Location = new System.Drawing.Point(7, 85);
            this.label_score_subid.Name = "label_score_subid";
            this.label_score_subid.Size = new System.Drawing.Size(69, 13);
            this.label_score_subid.TabIndex = 4;
            this.label_score_subid.Text = "Subject Id:";
            // 
            // label_score_stdid
            // 
            this.label_score_stdid.AutoSize = true;
            this.label_score_stdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score_stdid.Location = new System.Drawing.Point(6, 53);
            this.label_score_stdid.Name = "label_score_stdid";
            this.label_score_stdid.Size = new System.Drawing.Size(70, 13);
            this.label_score_stdid.TabIndex = 1;
            this.label_score_stdid.Text = "Student Id:";
            // 
            // label_scoreid
            // 
            this.label_scoreid.AutoSize = true;
            this.label_scoreid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_scoreid.Location = new System.Drawing.Point(7, 23);
            this.label_scoreid.Name = "label_scoreid";
            this.label_scoreid.Size = new System.Drawing.Size(59, 13);
            this.label_scoreid.TabIndex = 0;
            this.label_scoreid.Text = "Score Id:";
            // 
            // dataGridView_std
            // 
            this.dataGridView_std.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_std.Location = new System.Drawing.Point(33, 297);
            this.dataGridView_std.Name = "dataGridView_std";
            this.dataGridView_std.Size = new System.Drawing.Size(792, 177);
            this.dataGridView_std.TabIndex = 8;
            // 
            // subId
            // 
            this.subId.Location = new System.Drawing.Point(99, 16);
            this.subId.Name = "subId";
            this.subId.Size = new System.Drawing.Size(129, 20);
            this.subId.TabIndex = 6;
            // 
            // groupBox_attri
            // 
            this.groupBox_attri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox_attri.Controls.Add(this.textBox_finalgrades);
            this.groupBox_attri.Controls.Add(this.label_finalgrades);
            this.groupBox_attri.Controls.Add(this.textBox1);
            this.groupBox_attri.Controls.Add(this.button2);
            this.groupBox_attri.Controls.Add(this.button_scoreprint);
            this.groupBox_attri.Controls.Add(this.textBox_assessmentType);
            this.groupBox_attri.Controls.Add(this.label_score_assessmentType);
            this.groupBox_attri.Controls.Add(this.button_scoreadd);
            this.groupBox_attri.Controls.Add(this.button_scorerefresh);
            this.groupBox_attri.Controls.Add(this.button_scoreupdate);
            this.groupBox_attri.Controls.Add(this.button_scoredelete);
            this.groupBox_attri.Controls.Add(this.teachid);
            this.groupBox_attri.Controls.Add(this.textBox_contactno);
            this.groupBox_attri.Controls.Add(this.stdid);
            this.groupBox_attri.Controls.Add(this.subId);
            this.groupBox_attri.Controls.Add(this.label_score_tid);
            this.groupBox_attri.Controls.Add(this.label_score_subid);
            this.groupBox_attri.Controls.Add(this.label_score_stdid);
            this.groupBox_attri.Controls.Add(this.label_scoreid);
            this.groupBox_attri.Location = new System.Drawing.Point(33, 40);
            this.groupBox_attri.Name = "groupBox_attri";
            this.groupBox_attri.Size = new System.Drawing.Size(452, 251);
            this.groupBox_attri.TabIndex = 6;
            this.groupBox_attri.TabStop = false;
            this.groupBox_attri.Text = "Scores Information";
            // 
            // textBox_finalgrades
            // 
            this.textBox_finalgrades.Location = new System.Drawing.Point(99, 177);
            this.textBox_finalgrades.Name = "textBox_finalgrades";
            this.textBox_finalgrades.Size = new System.Drawing.Size(129, 20);
            this.textBox_finalgrades.TabIndex = 23;
            // 
            // label_finalgrades
            // 
            this.label_finalgrades.AutoSize = true;
            this.label_finalgrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_finalgrades.Location = new System.Drawing.Point(7, 177);
            this.label_finalgrades.Name = "label_finalgrades";
            this.label_finalgrades.Size = new System.Drawing.Size(82, 13);
            this.label_finalgrades.TabIndex = 22;
            this.label_finalgrades.Text = "Final Gardes:";
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 514);
            this.Controls.Add(this.dataGridView_std);
            this.Controls.Add(this.groupBox_attri);
            this.Name = "Score";
            this.Text = "Score";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std)).EndInit();
            this.groupBox_attri.ResumeLayout(false);
            this.groupBox_attri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_scoreprint;
        private System.Windows.Forms.TextBox textBox_assessmentType;
        private System.Windows.Forms.Label label_score_assessmentType;
        private System.Windows.Forms.Button button_scoreadd;
        private System.Windows.Forms.Button button_scorerefresh;
        private System.Windows.Forms.Button button_scoreupdate;
        private System.Windows.Forms.Button button_scoredelete;
        private System.Windows.Forms.TextBox teachid;
        private System.Windows.Forms.TextBox textBox_contactno;
        private System.Windows.Forms.TextBox stdid;
        private System.Windows.Forms.Label label_score_tid;
        private System.Windows.Forms.Label label_score_subid;
        private System.Windows.Forms.Label label_score_stdid;
        private System.Windows.Forms.Label label_scoreid;
        private System.Windows.Forms.DataGridView dataGridView_std;
        private System.Windows.Forms.TextBox subId;
        private System.Windows.Forms.GroupBox groupBox_attri;
        private System.Windows.Forms.TextBox textBox_finalgrades;
        private System.Windows.Forms.Label label_finalgrades;
    }
}