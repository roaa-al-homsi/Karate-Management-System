using KarateBusiness;
using System.Data;
using System.Windows.Forms;

namespace KarateSystem.People
{
    public partial class frmManagePeople : Form
    {
        private frmMain _frmMain;
        private DataTable _dtPeople = Person.AllPersonInfoInView();
        public frmManagePeople(frmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private void _FillCmbFilterBy()
        {
            DataTable dt = Person.AllPersonInfoInView();
            foreach (DataColumn column in dt.Columns)
            {
                if (column.ColumnName == "Date Of Birth" || column.ColumnName == "Email" || column.ColumnName == "Address" || column.ColumnName == "Phone")
                {
                    continue;
                }
                cmbFilterBy.Items.Add(column.ColumnName);
            }
        }

        private void frmManagePeople_Load(object sender, System.EventArgs e)
        {
            dgvAllPeople.DataSource = _dtPeople;
            _FillCmbFilterBy();
            cmbFilterBy.SelectedIndex = 0;
            txtFilterBy.Visible = false;
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtFilterBy.Visible = cmbFilterBy.SelectedIndex != 0;

        }
    }
}
