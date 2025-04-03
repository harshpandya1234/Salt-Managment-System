'Imports System.Data.SqlClient
'Public Class DAOCLASS
'    Private conn As New SqlConnection
'    Private da As SqlDataAdapter
'    Private DS As DataSet
'    Public Sub New()
'        conn.ConnectionString = "Data Source=LAPTOP-JRDAKB87\SQLEXPRESS;Integrated Security=True"
'    End Sub
'    Public Sub adddata(ByVal qry As String)
'        Dim cmd As New SqlCommand(qry, conn)
'        conn.Open()
'        cmd.ExecuteNonQuery()
'        conn.Close()
'    End Sub

'    Public Function load_dataset(ByVal str As String) As DataSet
'        DS = New DataSet
'        da = New SqlDataAdapter(str, conn)
'        conn.Open()
'        da.SelectCommand.ExecuteReader()
'        conn.Close()
'        da.Fill(DS)
'        Return DS
'    End Function
'    Public Function numberValidate(ByVal c As Char, ByVal hc As Integer) As Boolean
'        If (c <> "" AndAlso IsNumeric(c)) Or hc = 524296 Then
'            Return False
'        Else
'            Return True
'        End If
'    End Function
'    Public Function TextValidate(ByVal c As Char, ByVal hc As Integer) As Boolean
'        If (LCase(c) >= "a" And LCase(c) <= "z") _
'                                    Or hc = 524296 Or hc = 2097184 Then
'            Return False
'        Else
'            Return True

'        End If
'    End Function

'    Public Function AlphaNumericValidate(ByVal c As Char, ByVal hc As Integer)
'        If (IsNumeric(c)) Or (LCase(c) >= "a" And LCase(c) <= "z") _
'            Or hc = 524296 Or hc = 2097184 Then
'            Return False
'        Else
'            Return True
'        End If
'    End Function

'End Class
