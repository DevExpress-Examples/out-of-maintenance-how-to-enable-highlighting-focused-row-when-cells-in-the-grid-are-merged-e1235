<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628500/11.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1235)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/B133731/Form1.cs) (VB: [Form1.vb](./VB/B133731/Form1.vb))
<!-- default file list end -->
# How to enable highlighting focused row when cells in the grid are merged


<p>When merging is used, the grid suppresses the FocusedRow appearance. A workaround is to handle the GridView.RowCellStyle event and provide the appearance explicitly.</p>


<h3>Description</h3>

<p>Starting from version 2011 vol 1, the GridViewInfo.GetGridCellInfo method accepts the GridColumn as the second parameter, rather than the column absolute index.</p>

<br/>


