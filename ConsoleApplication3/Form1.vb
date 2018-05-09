Imports System.Drawing
Imports System.Windows.Forms
'gw lupa knp gw hapus -Imports System.ComponentModel- nya, tp ga ada error sejauh ini'
'Add Reference kedua benda di atas dg cara:
' - klik kanan project lu (di explorer sebelah kiri*), in this case ConsoleApplication3 yg ada VB iconnya (NOT VS ICON)
' - Add > Add Reference, trs find apa aja yg dibutuhin
' - semua references yg kita pake bisa diliat di: ConsoleApplication3 > References > Assemblies
' *kalo ga ada, View > Tool Windows > Solution

Public Class Form1
    Inherits Form

    Public WithEvents button1 As Button

    'New itu sebenernya macem constructor
    Public Sub New()
        button1 = New Button() 'like this
        button1.Size = New Size(40, 40)
        button1.Location = New Point(30, 30)
        button1.Text = "Click me"
        'define properties of buttonnya, 
        'trs baru dimasukin di formnya di:
        Me.Controls.Add(button1)
    End Sub 'New

'    tadinya gw mau buat Main method di sini tp gatau cara ngubah default Main classnya
'    Public Shared Sub Main()
'        Application.EnableVisualStyles()
'        Application.Run(New Form1())
'    End Sub

    'ini nambah method pas button nya diclick, sama kaya di VisualStudio (windows)
    Private Sub button1_Click(sender As Object,
                              e As EventArgs) Handles button1.Click
        MessageBox.Show("Hello World")
    End Sub
    
End Class