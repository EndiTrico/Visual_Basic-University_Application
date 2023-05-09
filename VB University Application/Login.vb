Imports System
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Interface Login
    Function isUsernameAndPasswordValid(ByVal username As String, ByVal password As String) As OleDbDataReader
End Interface
