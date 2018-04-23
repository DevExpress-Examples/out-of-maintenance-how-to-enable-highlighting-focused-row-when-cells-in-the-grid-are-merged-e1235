# How to enable highlighting focused row when cells in the grid are merged


<p>When merging is used, the grid suppresses the FocusedRow appearance. A workaround is to handle the GridView.RowCellStyle event and provide the appearance explicitly.</p>


<h3>Description</h3>

<p>Starting from version 2011 vol 1, the GridViewInfo.GetGridCellInfo method accepts the GridColumn as the second parameter, rather than the column absolute index.</p>

<br/>


