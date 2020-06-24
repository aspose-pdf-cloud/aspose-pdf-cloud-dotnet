# Aspose.Pdf.Cloud.Sdk.Model.TextBoxField
Provides TextBoxField.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**List&lt;Link&gt;**](Link.md) | Link to the document. | [optional] 
**PartialName** | **string** | Field name. | [optional] 
**FullName** | **string** | Full Field name. | [optional] 
**Rect** | [**Rectangle**](Rectangle.md) | Field rectangle. | [optional] 
**Value** | **string** | Field value. | [optional] 
**PageIndex** | **int?** | Page index. | 
**Height** | **double?** | Gets or sets height of the field. | [optional] 
**Width** | **double?** | Gets or sets width of the field. | [optional] 
**ZIndex** | **int?** | Z index. | [optional] 
**IsGroup** | **bool?** | Is group. | [optional] 
**Parent** | [**FormField**](FormField.md) | Gets field parent. | [optional] 
**IsSharedField** | **bool?** | Property for Generator support. Used when field is added to header or footer. If true, this field will created once and it&#39;s appearance will be visible on all pages of the document. If false, separated field will be created for every document page. | [optional] 
**Flags** | [**List&lt;AnnotationFlags&gt;**](AnnotationFlags.md) | Gets Flags of the field. | [optional] 
**Color** | [**Color**](Color.md) | Color of the annotation. | [optional] 
**Contents** | **string** | Get the field content. | [optional] 
**Margin** | [**MarginInfo**](MarginInfo.md) | Gets or sets a outer margin for paragraph (for pdf generation) | [optional] 
**Highlighting** | [**LinkHighlightingMode**](LinkHighlightingMode.md) | Field highlighting mode. | [optional] 
**HorizontalAlignment** | [**HorizontalAlignment**](HorizontalAlignment.md) | Gets HorizontalAlignment of the field. | [optional] 
**VerticalAlignment** | [**VerticalAlignment**](VerticalAlignment.md) | Gets VerticalAlignment of the field. | [optional] 
**Border** | [**Border**](Border.md) | Gets or sets annotation border characteristics. | [optional] 
**Multiline** | **bool?** | Gets or sets multiline flag of the field. If Multiline is true field can contain multiple lines of text. | [optional] 
**SpellCheck** | **bool?** | Gets or sets spellcheck flag for field. If true field shall be spell checked. | [optional] 
**Scrollable** | **bool?** | Gets or sets scrollable flag of field. If true field can be scrolled. | [optional] 
**ForceCombs** | **bool?** | Gets or sets flag which indicates is field divided into spaced positions. | [optional] 
**MaxLen** | **int?** | Gets or sets maximum length of text in the field. | [optional] 
**Barcode** | **string** | Adds barcode 128 into the field. Field value will be changed onto the code and field become read only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

