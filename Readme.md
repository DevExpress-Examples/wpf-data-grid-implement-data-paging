<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128651316/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4114)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Implement Data Paging
 
We supported **Data Paging** in **v18.1** and later versions. Please refer to [Data Paging](https://docs.devexpress.com/WPF/120186/controls-and-libraries/data-grid/paging-and-scrolling/data-paging) for more information.  
  
The following solution is applicable to the earlier versions:  
Change the grid's [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.ItemsSource) when the page index is changed. This example contains an attached behavior that allows you to enable this feature.

  
## Files to Review

* [MainWindow.xaml](./CS/DXGridDataPager/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXGridDataPager/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXGridDataPager/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXGridDataPager/MainWindow.xaml.vb))
* [SourcesBehavior.cs](./CS/DXGridDataPager/SourcesBehavior.cs) (VB: [SourcesBehavior.vb](./VB/DXGridDataPager/SourcesBehavior.vb))

## Documentation

* [Data Paging](https://docs.devexpress.com/WPF/120186/controls-and-libraries/data-grid/paging-and-scrolling/data-paging)
* [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)

## More Examples

* [WPF Data Grid - Bind to PagedAsyncSource](https://github.com/DevExpress-Examples/wpf-data-grid-bind-to-pagedasyncsource)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-implement-data-paging&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-implement-data-paging&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
