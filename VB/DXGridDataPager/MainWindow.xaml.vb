Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace DXGridDataPager

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            DataContext = New VM()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class VM
        Implements INotifyPropertyChanged

        Private _PagedCollection As List(Of DXGridDataPager.TestDataList)

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private pageIndexField As Integer = 1

        Public Property PageIndex As Integer
            Get
                Return pageIndexField
            End Get

            Set(ByVal value As Integer)
                If value = pageIndexField Then Return
                pageIndexField = value
                OnPropertyChanged("PageIndex")
            End Set
        End Property

        Protected Sub OnPropertyChanged(ByVal propertyName As String)
            Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
            If handler IsNot Nothing Then
                handler(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub

        Public Property PagedCollection As List(Of TestDataList)
            Get
                Return _PagedCollection
            End Get

            Private Set(ByVal value As List(Of TestDataList))
                _PagedCollection = value
            End Set
        End Property

        Public Sub New()
            PagedCollection = New List(Of TestDataList)()
            PagedCollection.Add(TestDataList.Create(0))
            PagedCollection.Add(TestDataList.Create(3))
            PagedCollection.Add(TestDataList.Create(5))
            PagedCollection.Add(TestDataList.Create(7))
            PageIndex = 2
        End Sub
    End Class

    Public Class TestDataList
        Inherits ObservableCollection(Of TestDataItem)

        Public Shared Function Create(ByVal cc As Integer) As TestDataList
            Dim res As TestDataList = New TestDataList()
            For i As Integer = 0 To 10 - 1
                Dim item As TestDataItem = New TestDataItem()
                item.ID = i
                item.Value = Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW("A"c) + cc).ToString()
                res.Add(item)
            Next

            For i As Integer = 0 To 10 - 1
                Dim item As TestDataItem = New TestDataItem()
                item.ID = i
                item.Value = Microsoft.VisualBasic.ChrW(Microsoft.VisualBasic.AscW("B"c) + cc).ToString()
                res.Add(item)
            Next

            Return res
        End Function
    End Class

    Public Class TestDataItem

        Public Property ID As Integer

        Public Property Value As String
    End Class
End Namespace
