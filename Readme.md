<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXGridDataPager/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXGridDataPager/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXGridDataPager/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXGridDataPager/MainWindow.xaml.vb))
* [SourcesBehavior.cs](./CS/DXGridDataPager/SourcesBehavior.cs) (VB: [SourcesBehavior.vb](./VB/DXGridDataPager/SourcesBehavior.vb))
<!-- default file list end -->
# How to implement data paging


<p>Silverlight supports the data paging mechanism natively. In the meantime, there are no easy approaches to implementing the IPagedCollectionView interface in WPF.</p>
<br />
<p>The easiest way to implement data paging is to change the grid's ItemsSource when the page index is changed. This example contains special attached behavior that allows you to enable this feature with ease.<br /><br /><strong>See Also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/T226182">How to support paging in DXGrid by implementing the IPagedCollectionView interface</a></p>

<br/>


