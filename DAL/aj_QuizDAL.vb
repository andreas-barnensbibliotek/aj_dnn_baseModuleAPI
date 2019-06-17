
Public Class aj_QuizDAL

#Region "DATA LINQ SETUP"
    Private connectionObj As New connectionStringHandler
    Private _linqObj As New AJ_QuizLinqDataContext(connectionObj.CurrentConnectionString)
#End Region


    Public Function testarlinq() As String
        Dim svar As String = "finns inget"
        Dim ret = From i In _linqObj.tbl_aj_fd_QuizEngine_mains
                  Select i

        For Each x In ret
            svar = x.Name & " josefsson " & x.Description
        Next

        Return svar

    End Function

End Class
