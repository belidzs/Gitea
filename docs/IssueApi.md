# Gitea.Api.IssueApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IssueAddLabel**](IssueApi.md#issueaddlabel) | **POST** /repos/{owner}/{repo}/issues/{index}/labels | Add a label to an issue
[**IssueAddSubscription**](IssueApi.md#issueaddsubscription) | **PUT** /repos/{owner}/{repo}/issues/{index}/subscriptions/{user} | Subscribe user to issue
[**IssueAddTime**](IssueApi.md#issueaddtime) | **POST** /repos/{owner}/{repo}/issues/{index}/times | Add tracked time to a issue
[**IssueCheckSubscription**](IssueApi.md#issuechecksubscription) | **GET** /repos/{owner}/{repo}/issues/{index}/subscriptions/check | Check if user is subscribed to an issue
[**IssueClearLabels**](IssueApi.md#issueclearlabels) | **DELETE** /repos/{owner}/{repo}/issues/{index}/labels | Remove all labels from an issue
[**IssueCreateComment**](IssueApi.md#issuecreatecomment) | **POST** /repos/{owner}/{repo}/issues/{index}/comments | Add a comment to an issue
[**IssueCreateIssue**](IssueApi.md#issuecreateissue) | **POST** /repos/{owner}/{repo}/issues | Create an issue. If using deadline only the date will be taken into account, and time of day ignored.
[**IssueCreateLabel**](IssueApi.md#issuecreatelabel) | **POST** /repos/{owner}/{repo}/labels | Create a label
[**IssueCreateMilestone**](IssueApi.md#issuecreatemilestone) | **POST** /repos/{owner}/{repo}/milestones | Create a milestone
[**IssueDeleteComment**](IssueApi.md#issuedeletecomment) | **DELETE** /repos/{owner}/{repo}/issues/comments/{id} | Delete a comment
[**IssueDeleteCommentDeprecated**](IssueApi.md#issuedeletecommentdeprecated) | **DELETE** /repos/{owner}/{repo}/issues/{index}/comments/{id} | Delete a comment
[**IssueDeleteCommentReaction**](IssueApi.md#issuedeletecommentreaction) | **DELETE** /repos/{owner}/{repo}/issues/comments/{id}/reactions | Remove a reaction from a comment of an issue
[**IssueDeleteIssueReaction**](IssueApi.md#issuedeleteissuereaction) | **DELETE** /repos/{owner}/{repo}/issues/{index}/reactions | Remove a reaction from an issue
[**IssueDeleteLabel**](IssueApi.md#issuedeletelabel) | **DELETE** /repos/{owner}/{repo}/labels/{id} | Delete a label
[**IssueDeleteMilestone**](IssueApi.md#issuedeletemilestone) | **DELETE** /repos/{owner}/{repo}/milestones/{id} | Delete a milestone
[**IssueDeleteStopWatch**](IssueApi.md#issuedeletestopwatch) | **DELETE** /repos/{owner}/{repo}/issues/{index}/stopwatch/delete | Delete an issue&#39;s existing stopwatch.
[**IssueDeleteSubscription**](IssueApi.md#issuedeletesubscription) | **DELETE** /repos/{owner}/{repo}/issues/{index}/subscriptions/{user} | Unsubscribe user from issue
[**IssueDeleteTime**](IssueApi.md#issuedeletetime) | **DELETE** /repos/{owner}/{repo}/issues/{index}/times/{id} | Delete specific tracked time
[**IssueEditComment**](IssueApi.md#issueeditcomment) | **PATCH** /repos/{owner}/{repo}/issues/comments/{id} | Edit a comment
[**IssueEditCommentDeprecated**](IssueApi.md#issueeditcommentdeprecated) | **PATCH** /repos/{owner}/{repo}/issues/{index}/comments/{id} | Edit a comment
[**IssueEditIssue**](IssueApi.md#issueeditissue) | **PATCH** /repos/{owner}/{repo}/issues/{index} | Edit an issue. If using deadline only the date will be taken into account, and time of day ignored.
[**IssueEditIssueDeadline**](IssueApi.md#issueeditissuedeadline) | **POST** /repos/{owner}/{repo}/issues/{index}/deadline | Set an issue deadline. If set to null, the deadline is deleted. If using deadline only the date will be taken into account, and time of day ignored.
[**IssueEditLabel**](IssueApi.md#issueeditlabel) | **PATCH** /repos/{owner}/{repo}/labels/{id} | Update a label
[**IssueEditMilestone**](IssueApi.md#issueeditmilestone) | **PATCH** /repos/{owner}/{repo}/milestones/{id} | Update a milestone
[**IssueGetComment**](IssueApi.md#issuegetcomment) | **GET** /repos/{owner}/{repo}/issues/comments/{id} | Get a comment
[**IssueGetCommentReactions**](IssueApi.md#issuegetcommentreactions) | **GET** /repos/{owner}/{repo}/issues/comments/{id}/reactions | Get a list of reactions from a comment of an issue
[**IssueGetComments**](IssueApi.md#issuegetcomments) | **GET** /repos/{owner}/{repo}/issues/{index}/comments | List all comments on an issue
[**IssueGetIssue**](IssueApi.md#issuegetissue) | **GET** /repos/{owner}/{repo}/issues/{index} | Get an issue
[**IssueGetIssueReactions**](IssueApi.md#issuegetissuereactions) | **GET** /repos/{owner}/{repo}/issues/{index}/reactions | Get a list reactions of an issue
[**IssueGetLabel**](IssueApi.md#issuegetlabel) | **GET** /repos/{owner}/{repo}/labels/{id} | Get a single label
[**IssueGetLabels**](IssueApi.md#issuegetlabels) | **GET** /repos/{owner}/{repo}/issues/{index}/labels | Get an issue&#39;s labels
[**IssueGetMilestone**](IssueApi.md#issuegetmilestone) | **GET** /repos/{owner}/{repo}/milestones/{id} | Get a milestone
[**IssueGetMilestonesList**](IssueApi.md#issuegetmilestoneslist) | **GET** /repos/{owner}/{repo}/milestones | Get all of a repository&#39;s opened milestones
[**IssueGetRepoComments**](IssueApi.md#issuegetrepocomments) | **GET** /repos/{owner}/{repo}/issues/comments | List all comments in a repository
[**IssueListIssues**](IssueApi.md#issuelistissues) | **GET** /repos/{owner}/{repo}/issues | List a repository&#39;s issues
[**IssueListLabels**](IssueApi.md#issuelistlabels) | **GET** /repos/{owner}/{repo}/labels | Get all of a repository&#39;s labels
[**IssuePostCommentReaction**](IssueApi.md#issuepostcommentreaction) | **POST** /repos/{owner}/{repo}/issues/comments/{id}/reactions | Add a reaction to a comment of an issue
[**IssuePostIssueReaction**](IssueApi.md#issuepostissuereaction) | **POST** /repos/{owner}/{repo}/issues/{index}/reactions | Add a reaction to an issue
[**IssueRemoveLabel**](IssueApi.md#issueremovelabel) | **DELETE** /repos/{owner}/{repo}/issues/{index}/labels/{id} | Remove a label from an issue
[**IssueReplaceLabels**](IssueApi.md#issuereplacelabels) | **PUT** /repos/{owner}/{repo}/issues/{index}/labels | Replace an issue&#39;s labels
[**IssueResetTime**](IssueApi.md#issueresettime) | **DELETE** /repos/{owner}/{repo}/issues/{index}/times | Reset a tracked time of an issue
[**IssueSearchIssues**](IssueApi.md#issuesearchissues) | **GET** /repos/issues/search | Search for issues across the repositories that the user has access to
[**IssueStartStopWatch**](IssueApi.md#issuestartstopwatch) | **POST** /repos/{owner}/{repo}/issues/{index}/stopwatch/start | Start stopwatch on an issue.
[**IssueStopStopWatch**](IssueApi.md#issuestopstopwatch) | **POST** /repos/{owner}/{repo}/issues/{index}/stopwatch/stop | Stop an issue&#39;s existing stopwatch.
[**IssueSubscriptions**](IssueApi.md#issuesubscriptions) | **GET** /repos/{owner}/{repo}/issues/{index}/subscriptions | Get users who subscribed on an issue.
[**IssueTrackedTimes**](IssueApi.md#issuetrackedtimes) | **GET** /repos/{owner}/{repo}/issues/{index}/times | List an issue&#39;s tracked times



## IssueAddLabel

> List&lt;Label&gt; IssueAddLabel (string owner, string repo, long index, IssueLabelsOption body = null)

Add a label to an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueAddLabelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var body = new IssueLabelsOption(); // IssueLabelsOption |  (optional) 

            try
            {
                // Add a label to an issue
                List<Label> result = apiInstance.IssueAddLabel(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueAddLabel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **body** | [**IssueLabelsOption**](IssueLabelsOption.md)|  | [optional] 

### Return type

[**List&lt;Label&gt;**](Label.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelList |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueAddSubscription

> void IssueAddSubscription (string owner, string repo, long index, string user)

Subscribe user to issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueAddSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var user = user_example;  // string | user to subscribe

            try
            {
                // Subscribe user to issue
                apiInstance.IssueAddSubscription(owner, repo, index, user);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueAddSubscription: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **user** | **string**| user to subscribe | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Already subscribed |  -  |
| **201** | Successfully Subscribed |  -  |
| **304** | User can only subscribe itself if he is no admin |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueAddTime

> TrackedTime IssueAddTime (string owner, string repo, long index, AddTimeOption body = null)

Add tracked time to a issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueAddTimeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var body = new AddTimeOption(); // AddTimeOption |  (optional) 

            try
            {
                // Add tracked time to a issue
                TrackedTime result = apiInstance.IssueAddTime(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueAddTime: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **body** | [**AddTimeOption**](AddTimeOption.md)|  | [optional] 

### Return type

[**TrackedTime**](TrackedTime.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TrackedTime |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueCheckSubscription

> WatchInfo IssueCheckSubscription (string owner, string repo, long index)

Check if user is subscribed to an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueCheckSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue

            try
            {
                // Check if user is subscribed to an issue
                WatchInfo result = apiInstance.IssueCheckSubscription(owner, repo, index);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCheckSubscription: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 

### Return type

[**WatchInfo**](WatchInfo.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | WatchInfo |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueClearLabels

> void IssueClearLabels (string owner, string repo, long index)

Remove all labels from an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueClearLabelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue

            try
            {
                // Remove all labels from an issue
                apiInstance.IssueClearLabels(owner, repo, index);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueClearLabels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueCreateComment

> Comment IssueCreateComment (string owner, string repo, long index, CreateIssueCommentOption body = null)

Add a comment to an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueCreateCommentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var body = new CreateIssueCommentOption(); // CreateIssueCommentOption |  (optional) 

            try
            {
                // Add a comment to an issue
                Comment result = apiInstance.IssueCreateComment(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateComment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **body** | [**CreateIssueCommentOption**](CreateIssueCommentOption.md)|  | [optional] 

### Return type

[**Comment**](Comment.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Comment |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueCreateIssue

> Issue IssueCreateIssue (string owner, string repo, CreateIssueOption body = null)

Create an issue. If using deadline only the date will be taken into account, and time of day ignored.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueCreateIssueExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var body = new CreateIssueOption(); // CreateIssueOption |  (optional) 

            try
            {
                // Create an issue. If using deadline only the date will be taken into account, and time of day ignored.
                Issue result = apiInstance.IssueCreateIssue(owner, repo, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateIssue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **body** | [**CreateIssueOption**](CreateIssueOption.md)|  | [optional] 

### Return type

[**Issue**](Issue.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Issue |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **412** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueCreateLabel

> Label IssueCreateLabel (string owner, string repo, CreateLabelOption body = null)

Create a label

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueCreateLabelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var body = new CreateLabelOption(); // CreateLabelOption |  (optional) 

            try
            {
                // Create a label
                Label result = apiInstance.IssueCreateLabel(owner, repo, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateLabel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **body** | [**CreateLabelOption**](CreateLabelOption.md)|  | [optional] 

### Return type

[**Label**](Label.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Label |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueCreateMilestone

> Milestone IssueCreateMilestone (string owner, string repo, CreateMilestoneOption body = null)

Create a milestone

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueCreateMilestoneExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var body = new CreateMilestoneOption(); // CreateMilestoneOption |  (optional) 

            try
            {
                // Create a milestone
                Milestone result = apiInstance.IssueCreateMilestone(owner, repo, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateMilestone: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **body** | [**CreateMilestoneOption**](CreateMilestoneOption.md)|  | [optional] 

### Return type

[**Milestone**](Milestone.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Milestone |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteComment

> void IssueDeleteComment (string owner, string repo, long id)

Delete a comment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteCommentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of comment to delete

            try
            {
                // Delete a comment
                apiInstance.IssueDeleteComment(owner, repo, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteComment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of comment to delete | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteCommentDeprecated

> void IssueDeleteCommentDeprecated (string owner, string repo, int index, long id)

Delete a comment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteCommentDeprecatedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 56;  // int | this parameter is ignored
            var id = 789;  // long | id of comment to delete

            try
            {
                // Delete a comment
                apiInstance.IssueDeleteCommentDeprecated(owner, repo, index, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteCommentDeprecated: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **int**| this parameter is ignored | 
 **id** | **long**| id of comment to delete | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteCommentReaction

> void IssueDeleteCommentReaction (string owner, string repo, long id, EditReactionOption content = null)

Remove a reaction from a comment of an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteCommentReactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the comment to edit
            var content = new EditReactionOption(); // EditReactionOption |  (optional) 

            try
            {
                // Remove a reaction from a comment of an issue
                apiInstance.IssueDeleteCommentReaction(owner, repo, id, content);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteCommentReaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the comment to edit | 
 **content** | [**EditReactionOption**](EditReactionOption.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteIssueReaction

> void IssueDeleteIssueReaction (string owner, string repo, long index, EditReactionOption content = null)

Remove a reaction from an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteIssueReactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var content = new EditReactionOption(); // EditReactionOption |  (optional) 

            try
            {
                // Remove a reaction from an issue
                apiInstance.IssueDeleteIssueReaction(owner, repo, index, content);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteIssueReaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **content** | [**EditReactionOption**](EditReactionOption.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteLabel

> void IssueDeleteLabel (string owner, string repo, long id)

Delete a label

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteLabelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the label to delete

            try
            {
                // Delete a label
                apiInstance.IssueDeleteLabel(owner, repo, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteLabel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the label to delete | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteMilestone

> void IssueDeleteMilestone (string owner, string repo, long id)

Delete a milestone

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteMilestoneExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the milestone to delete

            try
            {
                // Delete a milestone
                apiInstance.IssueDeleteMilestone(owner, repo, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteMilestone: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the milestone to delete | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteStopWatch

> void IssueDeleteStopWatch (string owner, string repo, long index)

Delete an issue's existing stopwatch.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteStopWatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue to stop the stopwatch on

            try
            {
                // Delete an issue's existing stopwatch.
                apiInstance.IssueDeleteStopWatch(owner, repo, index);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteStopWatch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue to stop the stopwatch on | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | Not repo writer, user does not have rights to toggle stopwatch |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **409** | Cannot cancel a non existent stopwatch |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteSubscription

> void IssueDeleteSubscription (string owner, string repo, long index, string user)

Unsubscribe user from issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var user = user_example;  // string | user witch unsubscribe

            try
            {
                // Unsubscribe user from issue
                apiInstance.IssueDeleteSubscription(owner, repo, index, user);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteSubscription: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **user** | **string**| user witch unsubscribe | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Already unsubscribed |  -  |
| **201** | Successfully Unsubscribed |  -  |
| **304** | User can only subscribe itself if he is no admin |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueDeleteTime

> void IssueDeleteTime (string owner, string repo, long index, long id)

Delete specific tracked time

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueDeleteTimeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var id = 789;  // long | id of time to delete

            try
            {
                // Delete specific tracked time
                apiInstance.IssueDeleteTime(owner, repo, index, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteTime: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **id** | **long**| id of time to delete | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueEditComment

> Comment IssueEditComment (string owner, string repo, long id, EditIssueCommentOption body = null)

Edit a comment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueEditCommentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the comment to edit
            var body = new EditIssueCommentOption(); // EditIssueCommentOption |  (optional) 

            try
            {
                // Edit a comment
                Comment result = apiInstance.IssueEditComment(owner, repo, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditComment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the comment to edit | 
 **body** | [**EditIssueCommentOption**](EditIssueCommentOption.md)|  | [optional] 

### Return type

[**Comment**](Comment.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Comment |  -  |
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueEditCommentDeprecated

> Comment IssueEditCommentDeprecated (string owner, string repo, int index, long id, EditIssueCommentOption body = null)

Edit a comment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueEditCommentDeprecatedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 56;  // int | this parameter is ignored
            var id = 789;  // long | id of the comment to edit
            var body = new EditIssueCommentOption(); // EditIssueCommentOption |  (optional) 

            try
            {
                // Edit a comment
                Comment result = apiInstance.IssueEditCommentDeprecated(owner, repo, index, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditCommentDeprecated: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **int**| this parameter is ignored | 
 **id** | **long**| id of the comment to edit | 
 **body** | [**EditIssueCommentOption**](EditIssueCommentOption.md)|  | [optional] 

### Return type

[**Comment**](Comment.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Comment |  -  |
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueEditIssue

> Issue IssueEditIssue (string owner, string repo, long index, EditIssueOption body = null)

Edit an issue. If using deadline only the date will be taken into account, and time of day ignored.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueEditIssueExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue to edit
            var body = new EditIssueOption(); // EditIssueOption |  (optional) 

            try
            {
                // Edit an issue. If using deadline only the date will be taken into account, and time of day ignored.
                Issue result = apiInstance.IssueEditIssue(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditIssue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue to edit | 
 **body** | [**EditIssueOption**](EditIssueOption.md)|  | [optional] 

### Return type

[**Issue**](Issue.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Issue |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |
| **412** | APIError is error format response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueEditIssueDeadline

> IssueDeadline IssueEditIssueDeadline (string owner, string repo, long index, EditDeadlineOption body = null)

Set an issue deadline. If set to null, the deadline is deleted. If using deadline only the date will be taken into account, and time of day ignored.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueEditIssueDeadlineExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue to create or update a deadline on
            var body = new EditDeadlineOption(); // EditDeadlineOption |  (optional) 

            try
            {
                // Set an issue deadline. If set to null, the deadline is deleted. If using deadline only the date will be taken into account, and time of day ignored.
                IssueDeadline result = apiInstance.IssueEditIssueDeadline(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditIssueDeadline: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue to create or update a deadline on | 
 **body** | [**EditDeadlineOption**](EditDeadlineOption.md)|  | [optional] 

### Return type

[**IssueDeadline**](IssueDeadline.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | IssueDeadline |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueEditLabel

> Label IssueEditLabel (string owner, string repo, long id, EditLabelOption body = null)

Update a label

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueEditLabelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the label to edit
            var body = new EditLabelOption(); // EditLabelOption |  (optional) 

            try
            {
                // Update a label
                Label result = apiInstance.IssueEditLabel(owner, repo, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditLabel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the label to edit | 
 **body** | [**EditLabelOption**](EditLabelOption.md)|  | [optional] 

### Return type

[**Label**](Label.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Label |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueEditMilestone

> Milestone IssueEditMilestone (string owner, string repo, long id, EditMilestoneOption body = null)

Update a milestone

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueEditMilestoneExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the milestone
            var body = new EditMilestoneOption(); // EditMilestoneOption |  (optional) 

            try
            {
                // Update a milestone
                Milestone result = apiInstance.IssueEditMilestone(owner, repo, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditMilestone: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the milestone | 
 **body** | [**EditMilestoneOption**](EditMilestoneOption.md)|  | [optional] 

### Return type

[**Milestone**](Milestone.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Milestone |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetComment

> Comment IssueGetComment (string owner, string repo, long id)

Get a comment

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetCommentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the comment

            try
            {
                // Get a comment
                Comment result = apiInstance.IssueGetComment(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetComment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the comment | 

### Return type

[**Comment**](Comment.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Comment |  -  |
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetCommentReactions

> List&lt;Reaction&gt; IssueGetCommentReactions (string owner, string repo, long id)

Get a list of reactions from a comment of an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetCommentReactionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the comment to edit

            try
            {
                // Get a list of reactions from a comment of an issue
                List<Reaction> result = apiInstance.IssueGetCommentReactions(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetCommentReactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the comment to edit | 

### Return type

[**List&lt;Reaction&gt;**](Reaction.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ReactionList |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetComments

> List&lt;Comment&gt; IssueGetComments (string owner, string repo, long index, DateTime since = null, DateTime before = null)

List all comments on an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetCommentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var since = 2013-10-20T19:20:30+01:00;  // DateTime | if provided, only comments updated since the specified time are returned. (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime | if provided, only comments updated before the provided time are returned. (optional) 

            try
            {
                // List all comments on an issue
                List<Comment> result = apiInstance.IssueGetComments(owner, repo, index, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetComments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **since** | **DateTime**| if provided, only comments updated since the specified time are returned. | [optional] 
 **before** | **DateTime**| if provided, only comments updated before the provided time are returned. | [optional] 

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | CommentList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetIssue

> Issue IssueGetIssue (string owner, string repo, long index)

Get an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetIssueExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue to get

            try
            {
                // Get an issue
                Issue result = apiInstance.IssueGetIssue(owner, repo, index);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetIssue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue to get | 

### Return type

[**Issue**](Issue.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Issue |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetIssueReactions

> List&lt;Reaction&gt; IssueGetIssueReactions (string owner, string repo, long index, int page = null, int limit = null)

Get a list reactions of an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetIssueReactionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // Get a list reactions of an issue
                List<Reaction> result = apiInstance.IssueGetIssueReactions(owner, repo, index, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetIssueReactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Reaction&gt;**](Reaction.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ReactionList |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetLabel

> Label IssueGetLabel (string owner, string repo, long id)

Get a single label

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetLabelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the label to get

            try
            {
                // Get a single label
                Label result = apiInstance.IssueGetLabel(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetLabel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the label to get | 

### Return type

[**Label**](Label.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Label |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetLabels

> List&lt;Label&gt; IssueGetLabels (string owner, string repo, long index)

Get an issue's labels

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetLabelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue

            try
            {
                // Get an issue's labels
                List<Label> result = apiInstance.IssueGetLabels(owner, repo, index);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetLabels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 

### Return type

[**List&lt;Label&gt;**](Label.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetMilestone

> Milestone IssueGetMilestone (string owner, string repo, long id)

Get a milestone

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetMilestoneExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the milestone

            try
            {
                // Get a milestone
                Milestone result = apiInstance.IssueGetMilestone(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetMilestone: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the milestone | 

### Return type

[**Milestone**](Milestone.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Milestone |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetMilestonesList

> List&lt;Milestone&gt; IssueGetMilestonesList (string owner, string repo, string state = null, int page = null, int limit = null)

Get all of a repository's opened milestones

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetMilestonesListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var state = state_example;  // string | Milestone state, Recognised values are open, closed and all. Defaults to \"open\" (optional) 
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // Get all of a repository's opened milestones
                List<Milestone> result = apiInstance.IssueGetMilestonesList(owner, repo, state, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetMilestonesList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **state** | **string**| Milestone state, Recognised values are open, closed and all. Defaults to \&quot;open\&quot; | [optional] 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Milestone&gt;**](Milestone.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MilestoneList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueGetRepoComments

> List&lt;Comment&gt; IssueGetRepoComments (string owner, string repo, DateTime since = null, DateTime before = null, int page = null, int limit = null)

List all comments in a repository

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueGetRepoCommentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var since = 2013-10-20T19:20:30+01:00;  // DateTime | if provided, only comments updated since the provided time are returned. (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime | if provided, only comments updated before the provided time are returned. (optional) 
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List all comments in a repository
                List<Comment> result = apiInstance.IssueGetRepoComments(owner, repo, since, before, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetRepoComments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **since** | **DateTime**| if provided, only comments updated since the provided time are returned. | [optional] 
 **before** | **DateTime**| if provided, only comments updated before the provided time are returned. | [optional] 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | CommentList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueListIssues

> List&lt;Issue&gt; IssueListIssues (string owner, string repo, string state = null, string labels = null, string q = null, string type = null, string milestones = null, int page = null, int limit = null)

List a repository's issues

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueListIssuesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var state = state_example;  // string | whether issue is open or closed (optional) 
            var labels = labels_example;  // string | comma separated list of labels. Fetch only issues that have any of this labels. Non existent labels are discarded (optional) 
            var q = q_example;  // string | search string (optional) 
            var type = type_example;  // string | filter by type (issues / pulls) if set (optional) 
            var milestones = milestones_example;  // string | comma separated list of milestone names or ids. It uses names and fall back to ids. Fetch only issues that have any of this milestones. Non existent milestones are discarded (optional) 
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List a repository's issues
                List<Issue> result = apiInstance.IssueListIssues(owner, repo, state, labels, q, type, milestones, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueListIssues: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **state** | **string**| whether issue is open or closed | [optional] 
 **labels** | **string**| comma separated list of labels. Fetch only issues that have any of this labels. Non existent labels are discarded | [optional] 
 **q** | **string**| search string | [optional] 
 **type** | **string**| filter by type (issues / pulls) if set | [optional] 
 **milestones** | **string**| comma separated list of milestone names or ids. It uses names and fall back to ids. Fetch only issues that have any of this milestones. Non existent milestones are discarded | [optional] 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Issue&gt;**](Issue.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | IssueList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueListLabels

> List&lt;Label&gt; IssueListLabels (string owner, string repo, int page = null, int limit = null)

Get all of a repository's labels

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueListLabelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // Get all of a repository's labels
                List<Label> result = apiInstance.IssueListLabels(owner, repo, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueListLabels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Label&gt;**](Label.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssuePostCommentReaction

> Reaction IssuePostCommentReaction (string owner, string repo, long id, EditReactionOption content = null)

Add a reaction to a comment of an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssuePostCommentReactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var id = 789;  // long | id of the comment to edit
            var content = new EditReactionOption(); // EditReactionOption |  (optional) 

            try
            {
                // Add a reaction to a comment of an issue
                Reaction result = apiInstance.IssuePostCommentReaction(owner, repo, id, content);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssuePostCommentReaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **id** | **long**| id of the comment to edit | 
 **content** | [**EditReactionOption**](EditReactionOption.md)|  | [optional] 

### Return type

[**Reaction**](Reaction.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reaction |  -  |
| **201** | Reaction |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssuePostIssueReaction

> Reaction IssuePostIssueReaction (string owner, string repo, long index, EditReactionOption content = null)

Add a reaction to an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssuePostIssueReactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var content = new EditReactionOption(); // EditReactionOption |  (optional) 

            try
            {
                // Add a reaction to an issue
                Reaction result = apiInstance.IssuePostIssueReaction(owner, repo, index, content);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssuePostIssueReaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **content** | [**EditReactionOption**](EditReactionOption.md)|  | [optional] 

### Return type

[**Reaction**](Reaction.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reaction |  -  |
| **201** | Reaction |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueRemoveLabel

> void IssueRemoveLabel (string owner, string repo, long index, long id)

Remove a label from an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueRemoveLabelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var id = 789;  // long | id of the label to remove

            try
            {
                // Remove a label from an issue
                apiInstance.IssueRemoveLabel(owner, repo, index, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueRemoveLabel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **id** | **long**| id of the label to remove | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueReplaceLabels

> List&lt;Label&gt; IssueReplaceLabels (string owner, string repo, long index, IssueLabelsOption body = null)

Replace an issue's labels

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueReplaceLabelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var body = new IssueLabelsOption(); // IssueLabelsOption |  (optional) 

            try
            {
                // Replace an issue's labels
                List<Label> result = apiInstance.IssueReplaceLabels(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueReplaceLabels: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **body** | [**IssueLabelsOption**](IssueLabelsOption.md)|  | [optional] 

### Return type

[**List&lt;Label&gt;**](Label.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelList |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueResetTime

> void IssueResetTime (string owner, string repo, long index)

Reset a tracked time of an issue

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueResetTimeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue to add tracked time to

            try
            {
                // Reset a tracked time of an issue
                apiInstance.IssueResetTime(owner, repo, index);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueResetTime: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue to add tracked time to | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueSearchIssues

> List&lt;Issue&gt; IssueSearchIssues (string state = null, string labels = null, string q = null, long priorityRepoId = null, string type = null, int page = null)

Search for issues across the repositories that the user has access to

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueSearchIssuesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var state = state_example;  // string | whether issue is open or closed (optional) 
            var labels = labels_example;  // string | comma separated list of labels. Fetch only issues that have any of this labels. Non existent labels are discarded (optional) 
            var q = q_example;  // string | search string (optional) 
            var priorityRepoId = 789;  // long | repository to prioritize in the results (optional) 
            var type = type_example;  // string | filter by type (issues / pulls) if set (optional) 
            var page = 56;  // int | page number of requested issues (optional) 

            try
            {
                // Search for issues across the repositories that the user has access to
                List<Issue> result = apiInstance.IssueSearchIssues(state, labels, q, priorityRepoId, type, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueSearchIssues: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| whether issue is open or closed | [optional] 
 **labels** | **string**| comma separated list of labels. Fetch only issues that have any of this labels. Non existent labels are discarded | [optional] 
 **q** | **string**| search string | [optional] 
 **priorityRepoId** | **long**| repository to prioritize in the results | [optional] 
 **type** | **string**| filter by type (issues / pulls) if set | [optional] 
 **page** | **int**| page number of requested issues | [optional] 

### Return type

[**List&lt;Issue&gt;**](Issue.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | IssueList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueStartStopWatch

> void IssueStartStopWatch (string owner, string repo, long index)

Start stopwatch on an issue.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueStartStopWatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue to create the stopwatch on

            try
            {
                // Start stopwatch on an issue.
                apiInstance.IssueStartStopWatch(owner, repo, index);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueStartStopWatch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue to create the stopwatch on | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | APIEmpty is an empty response |  -  |
| **403** | Not repo writer, user does not have rights to toggle stopwatch |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **409** | Cannot start a stopwatch again if it already exists |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueStopStopWatch

> void IssueStopStopWatch (string owner, string repo, long index)

Stop an issue's existing stopwatch.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueStopStopWatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue to stop the stopwatch on

            try
            {
                // Stop an issue's existing stopwatch.
                apiInstance.IssueStopStopWatch(owner, repo, index);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueStopStopWatch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue to stop the stopwatch on | 

### Return type

void (empty response body)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | APIEmpty is an empty response |  -  |
| **403** | Not repo writer, user does not have rights to toggle stopwatch |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **409** | Cannot stop a non existent stopwatch |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueSubscriptions

> List&lt;User&gt; IssueSubscriptions (string owner, string repo, long index, int page = null, int limit = null)

Get users who subscribed on an issue.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueSubscriptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // Get users who subscribed on an issue.
                List<User> result = apiInstance.IssueSubscriptions(owner, repo, index, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueSubscriptions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | UserList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IssueTrackedTimes

> List&lt;TrackedTime&gt; IssueTrackedTimes (string owner, string repo, long index, DateTime since = null, DateTime before = null, int page = null, int limit = null)

List an issue's tracked times

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class IssueTrackedTimesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/v1";
            // Configure API key authorization: AccessToken
            Configuration.Default.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";
            // Configure API key authorization: SudoHeader
            Configuration.Default.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure API key authorization: SudoParam
            Configuration.Default.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var index = 789;  // long | index of the issue
            var since = 2013-10-20T19:20:30+01:00;  // DateTime | Only show times updated after the given time. This is a timestamp in RFC 3339 format (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime | Only show times updated before the given time. This is a timestamp in RFC 3339 format (optional) 
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List an issue's tracked times
                List<TrackedTime> result = apiInstance.IssueTrackedTimes(owner, repo, index, since, before, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IssueApi.IssueTrackedTimes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| owner of the repo | 
 **repo** | **string**| name of the repo | 
 **index** | **long**| index of the issue | 
 **since** | **DateTime**| Only show times updated after the given time. This is a timestamp in RFC 3339 format | [optional] 
 **before** | **DateTime**| Only show times updated before the given time. This is a timestamp in RFC 3339 format | [optional] 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;TrackedTime&gt;**](TrackedTime.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TrackedTimeList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

