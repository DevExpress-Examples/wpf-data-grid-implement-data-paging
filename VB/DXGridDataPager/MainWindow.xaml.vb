Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace DXGridDataPager

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ViewModel
        Inherits ViewModelBase

        Public Sub New()
            Source = TestDataList.CreateData()
        End Sub

        Public Property Source As ObservableCollection(Of TestDataItem)
    End Class

    Public Class TestDataList

        Public Shared Function CreateData() As ObservableCollection(Of TestDataItem)
            Dim testData = New ObservableCollection(Of TestDataItem)()
            For i As Integer = 0 To 10 - 1
                For j As Integer = 0 To 10 - 1
                    Dim item As TestDataItem = New TestDataItem With {.ID = i * 10 + j, .Value = Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW("A"c) + i).ToString()}
                    testData.Add(item)
                Next
            Next

            Return testData
        End Function
    End Class

    Public Class TestDataItem

        Public Property ID As Integer

        Public Property Value As String
    End Class
End Namespace
