# How to override default editor mapping when calling the RetrieveFields method 


<p>This example demonstrates how to automatically create all fields based upon the underlying data source using the RetrieveFields method, while using the MemoEdit control for some string fields.</p>


<h3>Description</h3>

<p>The primary idea of this approach is to use a default layout creation engine, but change some editor types right after a collection of preferred editors is populated. Basically, this is done using the options provided by the LayoutElementsBindingInfoHelper component that is internally used by the DataLayoutControl to retrieve the same information.</p>

<br/>


