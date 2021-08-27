<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1955)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication12/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication12/Form1.vb))
* [Program.cs](./CS/WindowsApplication12/Program.cs) (VB: [Program.vb](./VB/WindowsApplication12/Program.vb))
<!-- default file list end -->
# How to override default editor mapping when calling the RetrieveFields method 


<p>This example demonstrates how to automatically create all fields based upon the underlying data source using the RetrieveFields method, while using the MemoEdit control for some string fields.</p>


<h3>Description</h3>

<p>The primary idea of this approach is to use a default layout creation engine, but change some editor types right after a collection of preferred editors is populated. Basically, this is done using the options provided by the LayoutElementsBindingInfoHelper component that is internally used by the DataLayoutControl to retrieve the same information.</p>

<br/>


