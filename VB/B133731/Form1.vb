Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace B133731
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)

		End Sub

		Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles gridView1.RowCellStyle
			Dim view As GridView = CType(sender, GridView)
			Dim viewInfo As GridViewInfo = CType(view.GetViewInfo(), GridViewInfo)
			If e.RowHandle = view.FocusedRowHandle Then
				e.Appearance.Assign(viewInfo.PaintAppearance.FocusedRow)
			Else
				Dim cell As GridCellInfo = viewInfo.GetGridCellInfo(e.RowHandle, e.Column.AbsoluteIndex)
				If cell Is Nothing Then
					Return
				End If
				If (Not cell.IsMerged) Then
					Return
				End If
				For Each ci As GridCellInfo In cell.MergedCell.MergedCells
					If ci.RowHandle = view.FocusedRowHandle Then
						e.Appearance.Assign(viewInfo.PaintAppearance.FocusedRow)
						Exit For
					End If
				Next ci
			End If
		End Sub
	End Class
End Namespace