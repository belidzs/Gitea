
# Gitea.Model.CreateFileOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Author** | [**Identity**](Identity.md) |  | [optional] 
**Branch** | **string** | branch (optional) to base this file from. if not given, the default branch is used | [optional] 
**Committer** | [**Identity**](Identity.md) |  | [optional] 
**Content** | **string** | content must be base64 encoded | 
**Dates** | [**CommitDateOptions**](CommitDateOptions.md) |  | [optional] 
**Message** | **string** | message (optional) for the commit of this file. if not supplied, a default message will be used | [optional] 
**NewBranch** | **string** | new_branch (optional) will make a new branch from &#x60;branch&#x60; before creating the file | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

