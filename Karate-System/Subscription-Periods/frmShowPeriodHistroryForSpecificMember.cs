using System;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Subscription_Periods
{
    public partial class frmShowPeriodHistoryForSpecificMember : Form
    {
        private int _memberId = -1;
        private DataTable _dtPeriodsHistory;
        public frmShowPeriodHistoryForSpecificMember(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;

        }
        private void _ChangeHeaderDgvPeriodsHistory()
        {
            if (dgvPeriodsHistory.Rows.Count > 0)
            {
                dgvPeriodsHistory.Columns[0].Width = 50;
                dgvPeriodsHistory.Columns[5].Width = 110;
                dgvPeriodsHistory.Columns[1].HeaderText = "Start Date";
                dgvPeriodsHistory.Columns[2].HeaderText = "End Date";
                dgvPeriodsHistory.Columns[4].HeaderText = "Member Id";
                dgvPeriodsHistory.Columns[5].HeaderText = "Payment Id";
                dgvPeriodsHistory.Columns[6].HeaderText = "Is Active";
            }
        }
        private void _LoadPeriodsHistoryForMemberToForm()
        {
            _dtPeriodsHistory = uc_MemberInfoCard1.SelectedMember.GetAllPeriodsHistoryForSpecificMember();
            dgvPeriodsHistory.DataSource = _dtPeriodsHistory;
            _ChangeHeaderDgvPeriodsHistory();
        }
        private void frmShowPeriodHistoryForSpecificMember_Load(object sender, EventArgs e)
        {
            uc_MemberInfoCard1.LoadMemberInfo(_memberId);
            _LoadPeriodsHistoryForMemberToForm();
        }
    }
}
