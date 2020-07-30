
# Gitea.Model.EditRepoOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMergeCommits** | **bool** | either &#x60;true&#x60; to allow merging pull requests with a merge commit, or &#x60;false&#x60; to prevent merging pull requests with merge commits. &#x60;has_pull_requests&#x60; must be &#x60;true&#x60;. | [optional] 
**AllowRebase** | **bool** | either &#x60;true&#x60; to allow rebase-merging pull requests, or &#x60;false&#x60; to prevent rebase-merging. &#x60;has_pull_requests&#x60; must be &#x60;true&#x60;. | [optional] 
**AllowRebaseExplicit** | **bool** | either &#x60;true&#x60; to allow rebase with explicit merge commits (- -no-ff), or &#x60;false&#x60; to prevent rebase with explicit merge commits. &#x60;has_pull_requests&#x60; must be &#x60;true&#x60;. | [optional] 
**AllowSquashMerge** | **bool** | either &#x60;true&#x60; to allow squash-merging pull requests, or &#x60;false&#x60; to prevent squash-merging. &#x60;has_pull_requests&#x60; must be &#x60;true&#x60;. | [optional] 
**Archived** | **bool** | set to &#x60;true&#x60; to archive this repository. | [optional] 
**DefaultBranch** | **string** | sets the default branch for this repository. | [optional] 
**Description** | **string** | a short description of the repository. | [optional] 
**ExternalTracker** | [**ExternalTracker**](ExternalTracker.md) |  | [optional] 
**ExternalWiki** | [**ExternalWiki**](ExternalWiki.md) |  | [optional] 
**HasIssues** | **bool** | either &#x60;true&#x60; to enable issues for this repository or &#x60;false&#x60; to disable them. | [optional] 
**HasPullRequests** | **bool** | either &#x60;true&#x60; to allow pull requests, or &#x60;false&#x60; to prevent pull request. | [optional] 
**HasWiki** | **bool** | either &#x60;true&#x60; to enable the wiki for this repository or &#x60;false&#x60; to disable it. | [optional] 
**IgnoreWhitespaceConflicts** | **bool** | either &#x60;true&#x60; to ignore whitespace for conflicts, or &#x60;false&#x60; to not ignore whitespace. &#x60;has_pull_requests&#x60; must be &#x60;true&#x60;. | [optional] 
**InternalTracker** | [**InternalTracker**](InternalTracker.md) |  | [optional] 
**Name** | **string** | name of the repository | [optional] 
**Private** | **bool** | either &#x60;true&#x60; to make the repository private or &#x60;false&#x60; to make it public. Note: you will get a 422 error if the organization restricts changing repository visibility to organization owners and a non-owner tries to change the value of private. | [optional] 
**Template** | **bool** | either &#x60;true&#x60; to make this repository a template or &#x60;false&#x60; to make it a normal repository | [optional] 
**Website** | **string** | a URL with more information about the repository. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

