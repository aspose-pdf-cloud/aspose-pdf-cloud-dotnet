# Aspose.Pdf.Cloud.Sdk.Model.StampBase
Represents Pdf stamps.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**List&lt;Link&gt;**](Link.md) | Link to the document. | [optional] 
**Background** | **bool?** | Sets or gets a bool value that indicates the content is stamped as background. If the value is true, the stamp content is layed at the bottom. By defalt, the value is false, the stamp content is layed at the top. | [optional] 
**BottomMargin** | **double?** | Gets or sets bottom margin of stamp. | [optional] 
**HorizontalAlignment** | [**HorizontalAlignment**](HorizontalAlignment.md) | Gets or sets Horizontal alignment of stamp on the page.  | [optional] 
**LeftMargin** | **double?** | Gets or sets left margin of stamp. | [optional] 
**Opacity** | **double?** | Gets or sets a value to indicate the stamp opacity. The value is from 0.0 to 1.0. By default the value is 1.0. | [optional] 
**RightMargin** | **double?** | Gets or sets right margin of stamp. | [optional] 
**Rotate** | [**Rotation**](Rotation.md) | Sets or gets the rotation of stamp content according  values. Note. This property is for set angles which are multiples of 90 degrees (0, 90, 180, 270 degrees). To set arbitrary angle use RotateAngle property.  If angle set by ArbitraryAngle is not multiple of 90 then Rotate property returns Rotation.None. | [optional] 
**RotateAngle** | **double?** | Gets or sets rotate angle of stamp in degrees. This property allows to set arbitrary rotate angle.  | [optional] 
**TopMargin** | **double?** | Gets or sets top margin of stamp. | [optional] 
**VerticalAlignment** | [**VerticalAlignment**](VerticalAlignment.md) | Gets or sets vertical alignment of stamp on page. | [optional] 
**XIndent** | **double?** | Horizontal stamp coordinate, starting from the left. | [optional] 
**YIndent** | **double?** | Vertical stamp coordinate, starting from the bottom. | [optional] 
**Zoom** | **double?** | Zooming factor of the stamp. Allows to scale stamp. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

