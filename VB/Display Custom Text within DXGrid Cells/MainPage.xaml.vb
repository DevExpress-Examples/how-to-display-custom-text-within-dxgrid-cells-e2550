Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid
Imports DXExample.DemoData

Namespace Display_Custom_Text_within_DXGrid_Cells
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = Invoice.GetData()
		End Sub
		Private Sub gridControl1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As CustomColumnDisplayTextEventArgs)
			If e.Column.FieldName <> "ProductName" Then
				Return
			End If
			If CDbl(gridControl1.GetCellValue(e.RowHandle, "Discount")) > 20 Then
				e.DisplayText = (CStr(e.Value)) & " (SALE)"
			End If
		End Sub
	End Class
End Namespace
