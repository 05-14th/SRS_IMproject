using System;
using System.Windows.Forms;

namespace SRS_IMproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            Student studentForm = new Student();
            studentForm.ShowDialog();
        }

        private void button_teacher_Click(object sender, EventArgs e)
        {
            Teacher teacherForm = new Teacher();
            teacherForm.ShowDialog();
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            Subject subjectForm = new Subject();
            subjectForm.ShowDialog();
        }

        private void button_score_Click(object sender, EventArgs e)
        {
            Score scoreForm = new Score();
            scoreForm.ShowDialog();

        }

        private void button_enollmentrates_Click(object sender, EventArgs e)
        {
            EnrollmentRates enrollmentsratesform = new EnrollmentRates();
            enrollmentsratesform.ShowDialog();

        }

        private void butto_admissionReqs_Click(object sender, EventArgs e)
        {
            AdmissionReqs admissionreqsform = new AdmissionReqs();
            admissionreqsform.ShowDialog();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }

}