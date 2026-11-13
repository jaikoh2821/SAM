Imports System.ComponentModel
Imports DevExpress.Data
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.XtraGrid.Views.Grid

Public Class FilterHelper
    Private _view As GridView

    Public Sub New(ByVal view As GridView)
        _view = view
        AddHandler _view.MasterRowExpanded, AddressOf _view_MasterRowExpanded
        AddHandler _view.CustomRowFilter, AddressOf _view_CustomRowFilter
        AddHandler _view.ColumnFilterChanged, AddressOf _view_ColumnFilterChanged
    End Sub

    Private Sub _view_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim filter As String = _view.FindFilterText
        Dim criteria As String = ""
        For i As Integer = 0 To _view.DataRowCount - 1
            Dim handle As Integer = _view.GetVisibleRowHandle(i)
            Dim relationCount As Integer = _view.GetRelationCount(handle)
            For r As Integer = 0 To relationCount - 1
                If _view.GetMasterRowExpandedEx(handle, r) Then
                    Dim view As GridView = CType(_view.GetDetailView(handle, 0), GridView)
                    view.FindFilterText = _view.FindFilterText
                    'If filter = "" Then
                    '    view.ActiveFilterCriteria = Nothing
                    'Else
                    '    For c As Integer = 0 To view.Columns.Count - 1
                    '        If view.Columns(c).ColumnType Is GetType(String) Then
                    '            If c <> 0 Then
                    '                criteria &= " Or " & view.Columns(c).FieldName & " like '%" & filter & "%'"
                    '            Else
                    '                criteria = view.Columns(c).FieldName & " like '%" & filter & "%'"
                    '            End If
                    '        End If
                    '    Next c
                    '    view.ActiveFilterCriteria = CriteriaOperator.Parse(criteria)
                    'End If
                End If
            Next r
        Next i
    End Sub


    Private Sub _view_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs)
        Dim view As GridView = TryCast(sender, GridView)
        Dim filter As String = view.FindFilterText
        If filter = "" Then
            Return
        End If
        Dim controller As BaseGridController = view.DataController
        Dim source As IList = CType(view.DataSource, IList)
        Dim pdc As PropertyDescriptorCollection = Nothing
        If TypeOf view.DataSource Is ITypedList Then
            pdc = (TryCast(view.DataSource, ITypedList)).GetItemProperties(Nothing)
        Else
            pdc = TypeDescriptor.GetProperties(CType(source, Object).GetType().GetProperty("Item").PropertyType)
        End If
        Dim ev As New ExpressionEvaluator(pdc, GetCriteriaFromPDC(pdc, filter), False)
        e.Visible = e.Visible OrElse (Not IsEmptyDetail(e.ListSourceRow, controller))
        e.Handled = True
    End Sub

    Private Sub _view_MasterRowExpanded(ByVal sender As Object, ByVal e As CustomMasterRowEventArgs)
        Dim parentView As GridView = TryCast(sender, GridView)
        Dim view As GridView = CType(parentView.GetDetailView(e.RowHandle, e.RelationIndex), GridView)
        Dim filter As String = parentView.FindFilterText
        view.FindFilterText = filter
    End Sub

    Private Function GetCriteriaFromPDC(ByVal pdc As PropertyDescriptorCollection, ByVal filter As String) As CriteriaOperator
        Dim criteria As String = ""
        For i As Integer = 0 To pdc.Count - 2
            If i <> 0 Then
                criteria &= " Or " & pdc(i).Name & " like '%" & filter & "%'"
            Else
                criteria = pdc(i).Name & " like '%" & filter & "%'"
            End If
        Next i
        Return CriteriaOperator.Parse(criteria)
    End Function

    Private Function IsEmptyDetail(ByVal listSourceRow As Integer, ByVal controller As BaseGridController) As Boolean
        Dim filter As String = _view.FindFilterText
        Dim detail As IList = CType(controller.GetDetailList(listSourceRow, 0), IList)
        If detail Is Nothing Then Return True
        Dim pdc As PropertyDescriptorCollection = Nothing
        If TypeOf detail Is ITypedList Then
            pdc = (TryCast(detail, ITypedList)).GetItemProperties(Nothing)
        Else
            pdc = TypeDescriptor.GetProperties(CType(detail, Object).GetType().GetProperty("Item").PropertyType)
        End If
        If filter = "" Then
            Return False
        End If
        Dim detailEvaluator As New ExpressionEvaluator(pdc, GetCriteriaFromPDC(pdc, filter), False)
        For Each o As Object In detail
            Dim row As DataRowView = CType(o, DataRowView)
            If detailEvaluator.Fit(row) Then
                Return False
            End If
        Next o
        Return True
    End Function
End Class
