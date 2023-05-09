Imports System.Data.OleDb

Interface Login
    Function isUsernameAndPasswordValid(ByVal username As String, ByVal password As String) As OleDbDataReader
End Interface
