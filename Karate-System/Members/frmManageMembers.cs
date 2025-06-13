using KarateBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.Members
{
    public partial class frmManageMembers : Form
    {
        private DataTable _dtAllMembers;
        private frmMain _frmMain;
        public frmManageMembers(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            _dtAllMembers = Member.All();
            dgvAllMembers.DataSource = _dtAllMembers;
        }
    }
}
