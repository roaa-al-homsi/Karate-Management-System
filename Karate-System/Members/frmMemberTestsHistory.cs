using System;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Members
{
    public partial class frmMemberTestsHistory : Form
    {

        private DataTable _dtMemberTestsHistory;


        public frmMemberTestsHistory(int memberId)
        {
            InitializeComponent();
            uc_MemberInfoCard1.LoadMemberInfo(memberId);

        }
        private void _ChangeFormatDgvAllBeltTests()
        {
            if (dgvMemberTests.Rows.Count > 0)
            {
                dgvMemberTests.Columns[0].Width = 100;
                dgvMemberTests.Columns[1].Width = 110;
                dgvMemberTests.Columns[2].Width = 110;
                dgvMemberTests.Columns[3].Width = 110;
                dgvMemberTests.Columns[4].Width = 190;
                dgvMemberTests.Columns[5].Width = 160;
                dgvMemberTests.Columns[6].Width = 190;
                dgvMemberTests.Columns[7].Width = 120;
                dgvMemberTests.Columns[8].Width = 110;
            }
        }
        private void frmMemberTestsHistory_Load(object sender, EventArgs e)
        {
            _dtMemberTestsHistory = uc_MemberInfoCard1.SelectedMember.GetAllTestsForSpecificMember();
            dgvMemberTests.DataSource = _dtMemberTestsHistory;
            _ChangeFormatDgvAllBeltTests();
        }
    }
}
