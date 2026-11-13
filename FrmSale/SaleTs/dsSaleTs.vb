Partial Class dsSaleTs
    Partial Public Class dtSmSaleDtAllDataTable
    End Class

    Partial Public Class dtSaleReturnDataTable
        Private Sub dtSaleReturnDataTable_dtSaleReturnRowChanging(sender As Object, e As dtSaleReturnRowChangeEvent) Handles Me.dtSaleReturnRowChanging

        End Sub

    End Class

    Partial Class DeliveryDocDataTable

        Private Sub DeliveryDocDataTable_DeliveryDocRowChanging(sender As Object, e As DeliveryDocRowChangeEvent) Handles Me.DeliveryDocRowChanging

        End Sub

        Private Sub DeliveryDocDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.picSignPsTsColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
