<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575324/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T470781)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to preserve the Legend checkbox item state when the Series Template approach is used
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t470781/)**
<!-- run online end -->


<strong>NOTE. </strong>Starting with v17.1, you can optionally save legend checkbox state for the chart's Series collection on callbacks. To activate this feature, enable the WebChartControl.<strong>SaveStateOnCallbacks</strong> option. If you prefer to use the manual Legend state initialization approach, set the <strong>SaveStateOnCallbacks</strong> property to <strong>False</strong>.<br><br>WebChartControl does not cache information about auto-generated Series when the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument15950">Series Template</a> approach is used to initialize the chart layout. In this situation, it is required to handle the <a href="https://documentation.devexpress.com/#AspNet/DevExpressXtraChartsWebWebChartControl_BoundDataChangedtopic">WebChartControl.BoundDataChanged</a> event to restore the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument16242">Legend item checkbox state</a>. This example illustrates how to save the Legend state into a Session variable using the <a href="https://documentation.devexpress.com/#AspNet/DevExpressXtraChartsWebWebChartControl_LegendItemCheckedtopic">WebChartControl.LegendItemChecked</a> event and then restore it on subsequent page requests.<br><br>See also:<br><br><a href="https://www.devexpress.com/Support/Center/p/T470764">How to preserve the Legend checkbox item state when the Series collection is initialized programmatically</a>; <br><a href="https://www.devexpress.com/Support/Center/p/T504189">How to preserve the Legend checkbox item state in an ASP.NET MVC application</a>.

<br/>


