Imports System.Data.Odbc
Public Class DBAccessClass
    Public DBCommand As OdbcCommand
    Public Const ConnectStr As String = "Driver={MySQL ODBC 5.3 ANSI Driver};SERVER=141.209.241.44;DATABASE=BIS422_33;USER=detroit;PASSWORD=mypass;OPTION=3"
    Public DBConnection As New OdbcConnection(ConnectStr)
    Public DBDataAdapter As OdbcDataAdapter
    Public DBDataTable As DataTable
    Public Params As New List(Of OdbcParameter)
    Public RecordCount As Integer
    Public Exception As String

    Public Sub ExecuteQuery(QueryString As String)
        RecordCount = 0
        Exception = String.Empty

        Try
            DBConnection.Open()

            DBCommand = New OdbcCommand(QueryString, DBConnection)

            For Each p As OdbcParameter In Params
                DBCommand.Parameters.Add(p)
            Next


            Params.Clear()

            DBDataTable = New DataTable
            DBDataAdapter = New OdbcDataAdapter(DBCommand)

            RecordCount = DBDataAdapter.Fill(DBDataTable)
        Catch ex As Exception
            Exception = ex.Message
        End Try

        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If
    End Sub

    Public Sub AddParam(Name As String, value As Object)
        Dim NewParam As New OdbcParameter(Name, value)
        Params.Add(NewParam)
    End Sub
End Class

