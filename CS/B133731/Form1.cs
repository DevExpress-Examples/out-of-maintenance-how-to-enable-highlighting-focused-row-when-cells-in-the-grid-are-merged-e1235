using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace B133731 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);

        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e) {
            GridView view = (GridView)sender;
            GridViewInfo viewInfo = (GridViewInfo)view.GetViewInfo();
            if (e.RowHandle == view.FocusedRowHandle)  
                e.Appearance.Assign(viewInfo.PaintAppearance.FocusedRow);
            else {
                GridCellInfo cell = viewInfo.GetGridCellInfo(e.RowHandle, e.Column.AbsoluteIndex);
                if (cell == null) return;
                if (!cell.IsMerged) return;
                foreach (GridCellInfo ci in cell.MergedCell.MergedCells)
                    if (ci.RowHandle == view.FocusedRowHandle) {
                        e.Appearance.Assign(viewInfo.PaintAppearance.FocusedRow);
                        break;
                    }
            }
        }
    }
}