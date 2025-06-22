using Guna.UI2.WinForms;
using KarateBusiness;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KarateSystem.Members
{
    public partial class frmAddUpdateMember : Form
    {
        public delegate void DataBackEventHandler(object sender, int personId);
        public event DataBackEventHandler DataBackMember;
        private enum mode { Add = 1, Update = 2 }
        private mode _mode;
        private int _memberId = -1;
        private Member _member;
        public frmAddUpdateMember()
        {
            InitializeComponent();
            _mode = mode.Add;
        }
        public frmAddUpdateMember(int memberId)
        {
            InitializeComponent();
            _mode = mode.Update;
            _memberId = memberId;

        }
        private void _FillMemberDataToForm()
        {
            _member = Member.Find(_memberId);
            if (_member == null)
            {
                MessageBox.Show($"There is no member with this Id: {_memberId}", "Error", MessageBoxButtons.OK);
                return;
            }

            uc_PersonInfoWithFilter1.LoadPersonInfo(_member.personId);
            uc_PersonInfoWithFilter1.FilterEnable = false;

            txtContactInfo.Text = _member.emergencyContactInfo;
            labMemberId.Text = _member.id.ToString();
            chkIsActive.Checked = _member.isActive;
            cmbBeltRanks.SelectedIndex = cmbBeltRanks.FindString(BeltRank.GetNameById(_member.lastBeltRankId));
            // txtLastBeltRankId.Text = _member.lastBeltRankId.ToString();
            if (string.IsNullOrWhiteSpace(_member.personInfo.imagePath))
            {
                if (_member.personInfo.gender == 0)
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.Male_512))
                    {
                        picMember.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(Properties.Resources.Female_512))
                    {
                        picMember.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                picMember.ImageLocation = _member.personInfo.imagePath;
            }
        }
        private void _ResetDefaultValuesToForm()
        {

            if (_mode == mode.Add)
            {
                _member = new Member();
                this.Text = "Add New Member";
                labTitleForm.Text = "Add New Member";
                tpMemberInfo.Enabled = false;
                return;
            }
            this.Text = "Update a Member";
            labTitleForm.Text = "Update a Member";
            _FillMemberDataToForm();
        }
        private void _FillMemberDataToSave()
        {
            _member.lastBeltRankId = BeltRank.GetIdByName(cmbBeltRanks.Text);
            // _member.lastBeltRankId = Convert.ToInt16(txtLastBeltRankId.Text);
            _member.isActive = chkIsActive.Checked;
            _member.emergencyContactInfo = txtContactInfo.Text;
            _member.personId = uc_PersonInfoWithFilter1.PersonId;
        }
        private void _FillCmbBeltRanks()
        {
            DataTable dtNamesBelts = BeltRank.AllNames();
            foreach (DataRow row in dtNamesBelts.Rows)
            {
                cmbBeltRanks.Items.Add(row["Name"].ToString());
            }
        }
        private void frmAddUpdateMember_Load(object sender, System.EventArgs e)
        {
            _FillCmbBeltRanks();
            cmbBeltRanks.SelectedIndex = 0;
            _ResetDefaultValuesToForm();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            //if (_mode == mode.Update)
            //{
            //    btnSave.Enabled = true;
            //    tpMemberInfo.Enabled = true;
            //    tcMember.SelectedTab = tcMember.TabPages["tpMemberInfo"];
            //    return;
            //}
            if (_mode == mode.Add)
            {
                if (uc_PersonInfoWithFilter1.PersonId == -1)
                {
                    MessageBox.Show("Please, select a person so you can add a new user..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uc_PersonInfoWithFilter1.FilterFocus();
                    return;
                }
                if (Member.ExistByPersonId(uc_PersonInfoWithFilter1.PersonId))
                {
                    MessageBox.Show("Selected person already has a user, Please choose another person..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uc_PersonInfoWithFilter1.FilterFocus();
                    return;
                }
            }
            btnSave.Enabled = true;
            tpMemberInfo.Enabled = true;
            tcMember.SelectedTab = tcMember.TabPages["tpMemberInfo"];

        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Field are not valid ,Put the mouse over the red icon!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillMemberDataToSave();
            if (_member.Save())
            {
                labMemberId.Text = _member.id.ToString();
                _mode = mode.Update;
                this.Text = "Update A Member";
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBackMember.Invoke(this, _memberId);
            }
            else
            {
                MessageBox.Show("Data Failed Saved ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox textBox = (Guna2TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }
        }

        private void txtLastBeltRankId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
