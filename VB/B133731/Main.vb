Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            recordBindingSource.DataSource = DataHelper.GetData(10)
        End Sub
        Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridView1.RowCellStyle
            Dim view As GridView = DirectCast(sender, GridView)
            Dim viewInfo As GridViewInfo = CType(view.GetViewInfo(), GridViewInfo)
            If e.RowHandle = view.FocusedRowHandle Then
                e.Appearance.BackColor = viewInfo.PaintAppearance.FocusedRow.BackColor
                e.Appearance.ForeColor = viewInfo.PaintAppearance.FocusedRow.ForeColor
            Else
                Dim cell As GridCellInfo = viewInfo.GetGridCellInfo(e.RowHandle, e.Column)
                If cell Is Nothing Then
                    Return
                End If
                If Not cell.IsMerged Then
                    Return
                End If
                For Each ci As GridCellInfo In cell.MergedCell.MergedCells
                    If ci.RowHandle = view.FocusedRowHandle Then
                        e.Appearance.BackColor = viewInfo.PaintAppearance.FocusedRow.BackColor
                        e.Appearance.ForeColor = viewInfo.PaintAppearance.FocusedRow.ForeColor
                        Exit For
                    End If
                Next ci
            End If
        End Sub
    End Class
End Namespace