# How to create a hierarchical report


<p>This example illustrates how to create a hierarchical tree-like report based on data stored in a flat table. Data must meet certain requirements. Two additional fields are necessary to build a tree structure. The first field must contain unique values.<br><br>The second field must contain values that indicate parent nodes for the current node. Here is a sample image illustrating the required structure.</p>
<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-hierarchical-report-t456484/16.1.8+/media/99012b4b-b6cd-11e6-80bf-00155d62480c.png"><br><br><br>The example's main report has the 'Level' parameter to store the quantity of levels of hierarchical data. A value of this parameter is used to generate the initial data table. <br>When the data table has been generated, it is converted to a hierarchical list of custom objects that is used as a report data source. <br>The main report contains an <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRSubreporttopic">XRSubreport</a> instance that refers to the detail report. The detail report in its turn contains an <strong>XRSubreport</strong> instance that recursively refers to itself.

<br/>


