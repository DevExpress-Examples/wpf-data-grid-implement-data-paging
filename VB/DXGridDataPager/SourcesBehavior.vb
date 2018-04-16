Imports Microsoft.VisualBasic
Imports System.Windows.Interactivity
Imports DevExpress.Xpf.Editors.DataPager
Imports System.Windows
Imports System.Collections
Imports System.Collections.Specialized
Namespace DXGridDataPager
	Public Class SourcesBehavior
		Inherits Behavior(Of DataPager)
		Public Shared ReadOnly ActualSourceProperty As DependencyProperty = DependencyProperty.Register("ActualSource", GetType(Object), GetType(SourcesBehavior), Nothing)
		Public Shared ReadOnly SourcesProperty As DependencyProperty = DependencyProperty.Register("Sources", GetType(IList), GetType(SourcesBehavior), New PropertyMetadata(Nothing, Function(d, e) (CType(d, SourcesBehavior)).OnSourcesChanged(CType(e.NewValue, IList))))
		Public Property ActualSource() As Object
			Get
				Return CObj(GetValue(ActualSourceProperty))
			End Get
			Set(ByVal value As Object)
				SetValue(ActualSourceProperty, value)
			End Set
		End Property
		Public Property Sources() As IList
			Get
				Return CType(GetValue(SourcesProperty), IList)
			End Get
			Set(ByVal value As IList)
				SetValue(SourcesProperty, value)
			End Set
		End Property
		Public ReadOnly Property DataPager() As DataPager
			Get
				Return AssociatedObject
			End Get
		End Property
		Protected Overrides Sub OnAttached()
			MyBase.OnAttached()
			'DataPager.PageSize = Sources.Count;
			DataPager.ItemCount = Sources.Count
			'DataPager.PageSize = Sou
			UpdateActualSource(DataPager.PageIndex)
			SubsribeSourcesColletion(Sources)
			SubscribeDataPager()
		End Sub
		Protected Overrides Sub OnDetaching()
			UnsubsribeDataPager()
			UnsubsribeSourcesColletion(Sources)
			MyBase.OnDetaching()
		End Sub
		Private Function OnSourcesChanged(ByVal oldSources As IList) As Object
			If DataPager Is Nothing Then
				Return Nothing
			End If
			UpdateActualSource(DataPager.PageIndex)
			If Sources IsNot Nothing Then
				DataPager.ItemCount = Sources.Count
			End If
			UnsubsribeSourcesColletion(oldSources)
			SubsribeSourcesColletion(Sources)
			If ActualSource IsNot Nothing Then
				DataPager.PageIndex = Sources.IndexOf(ActualSource)
			End If
			SubscribeDataPager()
			Return Nothing
		End Function
		Private Sub UnsubsribeSourcesColletion(ByVal sources As IList)
			If TypeOf sources Is INotifyCollectionChanged Then
				RemoveHandler (CType(sources, INotifyCollectionChanged)).CollectionChanged, AddressOf Sources_CollectionChanged
			End If
		End Sub
		Private Sub SubsribeSourcesColletion(ByVal sources As IList)
			UnsubsribeSourcesColletion(sources)
			If TypeOf sources Is INotifyCollectionChanged Then
				AddHandler (CType(sources, INotifyCollectionChanged)).CollectionChanged, AddressOf Sources_CollectionChanged
			End If
		End Sub
		Private Sub UnsubsribeDataPager()
			If DataPager Is Nothing Then
				Return
			End If
			RemoveHandler DataPager.PageIndexChanged, AddressOf DataPager_PageIndexChanged
		End Sub
		Private Sub SubscribeDataPager()
			If DataPager Is Nothing Then
				Return
			End If
			UnsubsribeDataPager()
			AddHandler DataPager.PageIndexChanged, AddressOf DataPager_PageIndexChanged
		End Sub

		Private Sub Sources_CollectionChanged(ByVal sender As Object, ByVal e As System.Collections.Specialized.NotifyCollectionChangedEventArgs)
			If Sources IsNot Nothing Then
				DataPager.ItemCount = Sources.Count
			End If
			If ActualSource Is Nothing Then
				UpdateActualSource(DataPager.PageIndex)
			End If
		End Sub
		Private Sub UpdateActualSource(ByVal index As Integer)
			If Sources IsNot Nothing AndAlso Sources.Count > 0 Then
				If index < Sources.Count Then
					ActualSource = Sources(index)
				Else
					ActualSource = Sources(0)
				End If
			End If

		End Sub
		Private Sub DataPager_PageIndexChanged(ByVal sender As Object, ByVal e As DataPagerPageIndexChangedEventArgs)
			UpdateActualSource(e.NewValue)
		End Sub
	End Class
End Namespace