﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace DXGridDataPager
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			DataContext = New VM()
			InitializeComponent()
		End Sub
	End Class
	Public Class VM
		Implements INotifyPropertyChanged

		Public Event PropertyChanged As PropertyChangedEventHandler
'INSTANT VB NOTE: The field pageIndex was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private pageIndex_Conflict As Integer = 1
		Public Property PageIndex() As Integer
			Get
				Return pageIndex_Conflict
			End Get
			Set(ByVal value As Integer)
				If value = pageIndex_Conflict Then
					Return
				End If
				pageIndex_Conflict = value
				OnPropertyChanged("PageIndex")
			End Set
		End Property
		Protected Sub OnPropertyChanged(ByVal propertyName As String)
			Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
			If handler IsNot Nothing Then
				handler(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
		Private privatePagedCollection As List(Of TestDataList)
		Public Property PagedCollection() As List(Of TestDataList)
			Get
				Return privatePagedCollection
			End Get
			Private Set(ByVal value As List(Of TestDataList))
				privatePagedCollection = value
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
			Dim res As New TestDataList()
			For i As Integer = 0 To 9
				Dim item As New TestDataItem()
				item.ID = i
				item.Value = (ChrW(CInt(Math.Truncate(AscW("A"c))) + cc)).ToString()
				res.Add(item)
			Next i
			For i As Integer = 0 To 9
				Dim item As New TestDataItem()
				item.ID = i
				item.Value = (ChrW(CInt(Math.Truncate(AscW("B"c))) + cc)).ToString()
				res.Add(item)
			Next i
			Return res
		End Function
	End Class
	Public Class TestDataItem
		Public Property ID() As Integer
		Public Property Value() As String
	End Class
End Namespace
