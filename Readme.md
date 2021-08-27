<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600972/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E263)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/Styling_With_FillEmptySpace/MainForm.cs) (VB: [MainForm.vb](./VB/Styling_With_FillEmptySpace/MainForm.vb))
* [Program.cs](./CS/Styling_With_FillEmptySpace/Program.cs) (VB: [Program.vb](./VB/Styling_With_FillEmptySpace/Program.vb))
* [XtraReport1.cs](./CS/Styling_With_FillEmptySpace/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/Styling_With_FillEmptySpace/XtraReport1.vb))
<!-- default file list end -->
# How to extend the Odd/Even Detail band style to a page footer


<p>If you need to fill the space between the last Detail band record and the page footer, using the <strong>Odd/Even</strong> styling schema defined for a <strong>Detail band</strong>, you can obtain the empty space area by handling the <i>XtraReport.FillEmptySpace</i> event, and then draw a number of rectangles, filled with Odd and Even style colors. The resulting image is used as <i>XRPictureBox.Image</i> source.</p>

<br/>


