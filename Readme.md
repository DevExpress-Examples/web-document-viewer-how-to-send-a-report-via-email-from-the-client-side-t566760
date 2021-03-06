<!-- default file list -->
*Files to look at*:

* [Global.asax.cs](./CS/CustomDocumentOperationService/Global.asax.cs) (VB: [Global.asax.vb](./VB/CustomDocumentOperationService/Global.asax.vb))
* **[CustomDocumentOperationService.cs](./CS/CustomDocumentOperationService/Services/CustomDocumentOperationService.cs) (VB: [CustomDocumentOperationService.vb](./VB/CustomDocumentOperationService/Services/CustomDocumentOperationService.vb))**
* [Viewer.cshtml](./CS/CustomDocumentOperationService/Views/Home/Viewer.cshtml)
<!-- default file list end -->
# Web Document Viewer - How to send a report via Email from the client side


This example demonstrates how to perform a custom operation with a Document Viewer's currently opened document. In particular, it shows how to send the document via Email.<br><br>On the server side, create a <a href="https://documentation.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DocumentOperationService.class">DocumentOperationService</a> class descendant and override its <a href="https://documentation.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DocumentOperationService.CanPerformOperation.method">CanPerformOperation</a> and <a href="https://documentation.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DocumentOperationService.PerformOperation.method">PerformOperation</a> methods. To register your custom class, use the <a href="https://documentation.devexpress.com/XtraReports/DevExpress.XtraReports.Web.WebDocumentViewer.DefaultWebDocumentViewerContainer.Register~T~TImpl~.method">DefaultWebDocumentViewerContainer.Register</a> method at the application startup.<br><br>On the client side, add a new toolbar button in the <a href="https://documentation.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientWebDocumentViewer.CustomizeMenuActions.event">CustomizeMenuActions</a> event handler and call the <a href="https://documentation.devexpress.com/XtraReports/DevExpress.XtraReports.Web.Scripts.ASPxClientWebDocumentViewer.PerformCustomDocumentOperation.overloads">PerformCustomDocumentOperation</a> method when clicking this button.

<br/>


