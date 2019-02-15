using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DXSample {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            recordBindingSource.DataSource = DataHelper.GetData(10);
        }
        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e) {
            GridView view = (GridView)sender;
            GridViewInfo viewInfo = (GridViewInfo)view.GetViewInfo();
            if(e.RowHandle == view.FocusedRowHandle) {
                e.Appearance.BackColor = viewInfo.PaintAppearance.FocusedRow.BackColor;
                e.Appearance.ForeColor = viewInfo.PaintAppearance.FocusedRow.ForeColor;
            }
            else {
                GridCellInfo cell = viewInfo.GetGridCellInfo(e.RowHandle, e.Column);
                if(cell == null) return;
                if(!cell.IsMerged) return;
                foreach(GridCellInfo ci in cell.MergedCell.MergedCells)
                    if(ci.RowHandle == view.FocusedRowHandle) {
                        e.Appearance.BackColor = viewInfo.PaintAppearance.FocusedRow.BackColor;
                        e.Appearance.ForeColor = viewInfo.PaintAppearance.FocusedRow.ForeColor;
                        break;
                    }
            }
        }
    }
}