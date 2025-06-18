using KarateBusiness;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KarateSystem.Instructors
{
    public partial class frmAddUpdateInstructor : Form
    {
        public delegate void frmAddUpdateInstructorEventHandler(object sender, int instructorId);
        public event frmAddUpdateInstructorEventHandler DataBackInstructor;
        private enum mode { Add = 0, Update = 1 }
        private mode _mode = mode.Add;

        private int _instructorId = -1;
        private Instructor _instructor;
        public frmAddUpdateInstructor()
        {
            InitializeComponent();
            _mode = mode.Add;
        }
        public frmAddUpdateInstructor(int instructorId)
        {
            InitializeComponent();
            _mode = mode.Update;
            _instructorId = instructorId;
        }
        private void _LoadInstructorDataToForm()
        {
            _instructor = Instructor.Find(_instructorId);
            if (_instructor == null)
            {
                MessageBox.Show($"There is no instructor with this Id: {_instructorId}", "Error", MessageBoxButtons.OK);
                return;
            }

            uc_PersonInfoWithFilter1.LoadPersonInfo(_instructor.personId);
            txtQualifications.Text = _instructor.qualifications;
            labInstructorId.Text = _instructor.id.ToString();

            if (string.IsNullOrWhiteSpace(_instructor.personInfo.imagePath))
            {
                if (_instructor.personInfo.gender == 0)
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.Male_512))
                    {
                        picInstructor.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.Female_512))
                    {
                        picInstructor.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                picInstructor.ImageLocation = _instructor.personInfo.imagePath;
            }
        }
        private void _ResetDefaultValue()
        {
            if (_mode == mode.Add)
            {
                this.Text = "Add New Instructor";
                labTitleForm.Text = "Add New Instructor";
                _instructor = new Instructor();
                tpInstructorInfo.Enabled = false;
                return;
            }
            this.Text = "Update a Instructor";
            labTitleForm.Text = "Update a Instructor";
            _LoadInstructorDataToForm();

        }
        private void _FillInstructorWithData()
        {
            _instructor.qualifications = txtQualifications.Text;
            _instructor.personId = uc_PersonInfoWithFilter1.PersonId;
        }
        private void frmAddUpdateInstructor_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillInstructorWithData();
            if (_instructor.Save())
            {
                _instructorId = _instructor.id;
                labInstructorId.Text = _instructor.id.ToString();
                _mode = mode.Update;
                this.Text = "Update A Instructor";
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBackInstructor.Invoke(this, _instructorId);
            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQualifications_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQualifications.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQualifications, "This field is required!!..");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_mode == mode.Add)
            {
                if (uc_PersonInfoWithFilter1.PersonId == -1)
                {
                    MessageBox.Show("Please, select a person so you can add a new instructor..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uc_PersonInfoWithFilter1.FilterFocus();
                    return;
                }
                if (Instructor.ExistByPersonId(uc_PersonInfoWithFilter1.PersonId))
                {
                    MessageBox.Show("Selected person already has a user, Please choose another person..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uc_PersonInfoWithFilter1.FilterFocus();
                    return;
                }
            }
            btnSave.Enabled = true;
            tpInstructorInfo.Enabled = true;
            tcInstructor.SelectedTab = tcInstructor.TabPages["tpInstructorInfo"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
