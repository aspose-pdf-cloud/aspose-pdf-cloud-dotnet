# Aspose.Pdf.Cloud.Sdk.Model.Bookmark
Provides link to bookmark.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**List&lt;Link&gt;**](Link.md) | Link to the document. | [optional] 
**Title** | **string** | Get the Title; | [optional] 
**Italic** | **bool?** | Is bookmark italic. | [optional] 
**Bold** | **bool?** | Is bookmark bold. | [optional] 
**Color** | [**Color**](Color.md) | Get the color | [optional] 
**Action** | **string** | Gets or sets the action bound with the bookmark. If PageNumber is presented the action can not be specified. The action type includes: &quot;GoTo&quot;, &quot;GoToR&quot;, &quot;Launch&quot;, &quot;Named&quot;. | [optional] 
**Level** | **int?** | Gets or sets bookmark&#39;s hierarchy level. | [optional] 
**Destination** | **string** | Gets or sets bookmark&#39;s destination page. Required if action is set as string.Empty. | [optional] 
**PageDisplay** | **string** | Gets or sets the type of display bookmark&#39;s destination page. | [optional] 
**PageDisplayBottom** | **int?** | Gets or sets the bottom coordinate of page display. | [optional] 
**PageDisplayLeft** | **int?** | Gets or sets the left coordinate of page display. | [optional] 
**PageDisplayRight** | **int?** | Gets or sets the right coordinate of page display. | [optional] 
**PageDisplayTop** | **int?** | Gets or sets the top coordinate of page display. | [optional] 
**PageDisplayZoom** | **int?** | Gets or sets the zoom factor of page display. | [optional] 
**PageNumber** | **int?** | Gets or sets the number of bookmark&#39;s destination page.  | [optional] 
**RemoteFile** | **string** | Gets or sets the file (path) which is required for &quot;GoToR&quot; action of bookmark. | [optional] 
**Bookmarks** | [**Bookmarks**](Bookmarks.md) | The children bookmarks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

