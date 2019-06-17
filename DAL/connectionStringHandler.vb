Public Class connectionStringHandler
    Private _connectionstring As String

    Public Sub New()
        '_connectionstring = "Data Source=.\SQLEXPRESS;Initial Catalog=207074-frontdatadb;User ID=207074_il88852;Password=L0rda1fHem"
        _connectionstring = "Data Source=ms04b.sqlserver.se;Initial Catalog=207074-frontdatadb;User ID=207074_il88852;Password=L0rda1fHem"
    End Sub
    Public ReadOnly Property CurrentConnectionString() As String
        Get
            Return _connectionstring
        End Get

    End Property
End Class
