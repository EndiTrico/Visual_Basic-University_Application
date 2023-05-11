Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class InvalidLoginInfoException
    Inherits Exception

    Public Sub New(ByVal message As String)
        MyBase.New("Invalid Credentials!")
    End Sub
End Class
