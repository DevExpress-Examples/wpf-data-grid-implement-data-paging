<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXGridDataPager/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXGridDataPager/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXGridDataPager/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXGridDataPager/MainWindow.xaml.vb))
* [SourcesBehavior.cs](./CS/DXGridDataPager/SourcesBehavior.cs) (VB: [SourcesBehavior.vb](./VB/DXGridDataPager/SourcesBehavior.vb))
<!-- default file list end -->
# How to implement data paging

Silverlight supports the data paging mechanism natively. In the meantime, there are no easy approaches to implementing the **IPagedCollectionView** interface in WPF.

  
We supported **Data Paging** in **v18.1** and later versions. Please refer to [Data Paging](https://docs.devexpress.com/WPF/120186/controls-and-libraries/data-grid/paging-and-scrolling/data-paging) for more information.  
  
The following solution is applicable to the earlier versions:  
The easiest way to implement data paging is to change the grid's ItemsSource when the page index is changed. This example contains special attached behavior that allows you to enable this feature with ease.

  
**See Also:**  
[How to support paging in DXGrid by implementing the IPagedCollectionView interface](https://www.devexpress.com/Support/Center/p/T226182.aspx)


