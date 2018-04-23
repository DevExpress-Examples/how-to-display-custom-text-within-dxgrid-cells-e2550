using System.Windows.Controls;
using DevExpress.Xpf.Grid;
using DXExample.DemoData;

namespace Display_Custom_Text_within_DXGrid_Cells {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            gridControl1.DataSource = Invoice.GetData();
        }
        private void gridControl1_CustomColumnDisplayText(object sender,
                CustomColumnDisplayTextEventArgs e) {
            if (e.Column.FieldName != "ProductName")
                return;
            if ((double)gridControl1.GetCellValue(e.RowHandle, "Discount") > 20)
                e.DisplayText = ((string)e.Value) + " (SALE)";
        }
    }
}
