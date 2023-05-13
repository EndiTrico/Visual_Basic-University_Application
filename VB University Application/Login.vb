Imports System.Data.OleDb

Interface Login
    Function isUsernameAndPasswordValid(username As String, password As String) As OleDbDataReader
End Interface
