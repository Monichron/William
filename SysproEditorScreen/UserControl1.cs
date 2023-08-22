using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysproEditorScreen.Helpers;

namespace SysproEditorScreen
{
    public partial class UserControl1: UserControl
    {
        public DataTable _original;
        List<string> _uneditableColumns;
        string[] options = {"Signed","CommittedDeliveryDate","Waybill","WaybillDate","CourierCompany","RecordID"};
        public UserControl1()
        {
            InitializeComponent();
            _original = SqlHelper.OriginalDataTable;
            LoadTable();
            LoadCmbo();
            _uneditableColumns = JsonConfig.Appsettings["UnEditableColumns"].Split(',').ToList<string>();
        }

        private void LoadCmbo()
        {
            string[] options = {
                "Search",
                "Signed",
                "CommittedDeliveryDate",
                "Waybill",
                "WaybillDate",
                "CourierCompany",
                "RecordID"
            };
            FilterOptionsCmbo.Items.AddRange(options);
        }

        private void LoadTable()
        {
           MainGrid.DataSource = _original;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterOptionsCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterOptionsCmbo.SelectedItem.ToString() == options[0])
            {
                DateFilter();
            }
            if (FilterOptionsCmbo.SelectedItem.ToString() == options[1])
            {
                BitFilter();
            }
            if (FilterOptionsCmbo.SelectedItem.ToString() == options[2])
            {
                SearchFilter();
            }
            if (FilterOptionsCmbo.SelectedItem.ToString() == options[3])
            {
                DropDownFilter();
            }

        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
