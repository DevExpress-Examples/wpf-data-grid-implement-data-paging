<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128651316/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4114)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXGridDataPager/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXGridDataPager/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXGridDataPager/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXGridDataPager/MainWindow.xaml.vb))
* [SourcesBehavior.cs](./CS/DXGridDataPager/SourcesBehavior.cs) (VB: [SourcesBehavior.vb](./VB/DXGridDataPager/SourcesBehavior.vb))
<!-- default file list end -->
# [Obsolete] How to implement data paging

Silverlight supports the data paging mechanism natively. In the meantime, there are no easy approaches to implementing the **IPagedCollectionView** interface in WPF.

  
We supported **Data Paging** in **v18.1** and later versions. Please refer to [Data Paging](https://docs.devexpress.com/WPF/120186/controls-and-libraries/data-grid/paging-and-scrolling/data-paging) for more information.  
  
The following solution is applicable to the earlier versions:  
The easiest way to implement data paging is to change the grid's ItemsSource when the page index is changed. This example contains special attached behavior that allows you to enable this feature with ease.

  
**See Also:**  
[How to support paging in DXGrid by implementing the IPagedCollectionView interface](https://www.devexpress.com/Support/Center/p/T226182.aspx)


