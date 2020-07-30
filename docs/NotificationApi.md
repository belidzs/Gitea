# Gitea.Api.NotificationApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotifyGetList**](NotificationApi.md#notifygetlist) | **GET** /notifications | List users&#39;s notification threads
[**NotifyGetRepoList**](NotificationApi.md#notifygetrepolist) | **GET** /repos/{owner}/{repo}/notifications | List users&#39;s notification threads on a specific repo
[**NotifyGetThread**](NotificationApi.md#notifygetthread) | **GET** /notifications/threads/{id} | Get notification thread by ID
[**NotifyNewAvailable**](NotificationApi.md#notifynewavailable) | **GET** /notifications/new | Check if unread notifications exist
[**NotifyReadList**](NotificationApi.md#notifyreadlist) | **PUT** /notifications | Mark notification threads as read, pinned or unread
[**NotifyReadRepoList**](NotificationApi.md#notifyreadrepolist) | **PUT** /repos/{owner}/{repo}/notifications | Mark notification threads as read, pinned or unread on a specific repo
[**NotifyReadThread**](NotificationApi.md#notifyreadthread) | **PATCH** /notifications/threads/{id} | Mark notification thread as read by ID



## NotifyGetList

> List&lt;NotificationThread&gt; NotifyGetList (string all = null, List<string> statusTypes = null, DateTime since = null, DateTime before = null, int page = null, int limit = null)

List users's notification threads

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class NotifyGetListExample
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

            var apiInstance = new NotificationApi(Configuration.Default);
            var all = all_example;  // string | If true, show notifications marked as read. Default value is false (optional) 
            var statusTypes = new List<string>(); // List<string> | Show notifications with the provided status types. Options are: unread, read and/or pinned. Defaults to unread & pinned. (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime | Only show notifications updated after the given time. This is a timestamp in RFC 3339 format (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime | Only show notifications updated before the given time. This is a timestamp in RFC 3339 format (optional) 
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List users's notification threads
                List<NotificationThread> result = apiInstance.NotifyGetList(all, statusTypes, since, before, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationApi.NotifyGetList: " + e.Message );
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
 **all** | **string**| If true, show notifications marked as read. Default value is false | [optional] 
 **statusTypes** | [**List&lt;string&gt;**](string.md)| Show notifications with the provided status types. Options are: unread, read and/or pinned. Defaults to unread &amp; pinned. | [optional] 
 **since** | **DateTime**| Only show notifications updated after the given time. This is a timestamp in RFC 3339 format | [optional] 
 **before** | **DateTime**| Only show notifications updated before the given time. This is a timestamp in RFC 3339 format | [optional] 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;NotificationThread&gt;**](NotificationThread.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | NotificationThreadList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotifyGetRepoList

> List&lt;NotificationThread&gt; NotifyGetRepoList (string owner, string repo, string all = null, List<string> statusTypes = null, DateTime since = null, DateTime before = null, int page = null, int limit = null)

List users's notification threads on a specific repo

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class NotifyGetRepoListExample
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

            var apiInstance = new NotificationApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var all = all_example;  // string | If true, show notifications marked as read. Default value is false (optional) 
            var statusTypes = new List<string>(); // List<string> | Show notifications with the provided status types. Options are: unread, read and/or pinned. Defaults to unread & pinned (optional) 
            var since = 2013-10-20T19:20:30+01:00;  // DateTime | Only show notifications updated after the given time. This is a timestamp in RFC 3339 format (optional) 
            var before = 2013-10-20T19:20:30+01:00;  // DateTime | Only show notifications updated before the given time. This is a timestamp in RFC 3339 format (optional) 
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List users's notification threads on a specific repo
                List<NotificationThread> result = apiInstance.NotifyGetRepoList(owner, repo, all, statusTypes, since, before, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationApi.NotifyGetRepoList: " + e.Message );
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
 **all** | **string**| If true, show notifications marked as read. Default value is false | [optional] 
 **statusTypes** | [**List&lt;string&gt;**](string.md)| Show notifications with the provided status types. Options are: unread, read and/or pinned. Defaults to unread &amp; pinned | [optional] 
 **since** | **DateTime**| Only show notifications updated after the given time. This is a timestamp in RFC 3339 format | [optional] 
 **before** | **DateTime**| Only show notifications updated before the given time. This is a timestamp in RFC 3339 format | [optional] 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;NotificationThread&gt;**](NotificationThread.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | NotificationThreadList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotifyGetThread

> NotificationThread NotifyGetThread (string id)

Get notification thread by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class NotifyGetThreadExample
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

            var apiInstance = new NotificationApi(Configuration.Default);
            var id = id_example;  // string | id of notification thread

            try
            {
                // Get notification thread by ID
                NotificationThread result = apiInstance.NotifyGetThread(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationApi.NotifyGetThread: " + e.Message );
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
 **id** | **string**| id of notification thread | 

### Return type

[**NotificationThread**](NotificationThread.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | NotificationThread |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotifyNewAvailable

> NotificationCount NotifyNewAvailable ()

Check if unread notifications exist

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class NotifyNewAvailableExample
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

            var apiInstance = new NotificationApi(Configuration.Default);

            try
            {
                // Check if unread notifications exist
                NotificationCount result = apiInstance.NotifyNewAvailable();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationApi.NotifyNewAvailable: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**NotificationCount**](NotificationCount.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/html

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Number of unread notifications |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotifyReadList

> void NotifyReadList (DateTime lastReadAt = null, string all = null, List<string> statusTypes = null, string toStatus = null)

Mark notification threads as read, pinned or unread

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class NotifyReadListExample
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

            var apiInstance = new NotificationApi(Configuration.Default);
            var lastReadAt = 2013-10-20T19:20:30+01:00;  // DateTime | Describes the last point that notifications were checked. Anything updated since this time will not be updated. (optional) 
            var all = all_example;  // string | If true, mark all notifications on this repo. Default value is false (optional) 
            var statusTypes = new List<string>(); // List<string> | Mark notifications with the provided status types. Options are: unread, read and/or pinned. Defaults to unread. (optional) 
            var toStatus = toStatus_example;  // string | Status to mark notifications as, Defaults to read. (optional) 

            try
            {
                // Mark notification threads as read, pinned or unread
                apiInstance.NotifyReadList(lastReadAt, all, statusTypes, toStatus);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationApi.NotifyReadList: " + e.Message );
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
 **lastReadAt** | **DateTime**| Describes the last point that notifications were checked. Anything updated since this time will not be updated. | [optional] 
 **all** | **string**| If true, mark all notifications on this repo. Default value is false | [optional] 
 **statusTypes** | [**List&lt;string&gt;**](string.md)| Mark notifications with the provided status types. Options are: unread, read and/or pinned. Defaults to unread. | [optional] 
 **toStatus** | **string**| Status to mark notifications as, Defaults to read. | [optional] 

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
| **205** | APIEmpty is an empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotifyReadRepoList

> void NotifyReadRepoList (string owner, string repo, string all = null, List<string> statusTypes = null, string toStatus = null, DateTime lastReadAt = null)

Mark notification threads as read, pinned or unread on a specific repo

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class NotifyReadRepoListExample
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

            var apiInstance = new NotificationApi(Configuration.Default);
            var owner = owner_example;  // string | owner of the repo
            var repo = repo_example;  // string | name of the repo
            var all = all_example;  // string | If true, mark all notifications on this repo. Default value is false (optional) 
            var statusTypes = new List<string>(); // List<string> | Mark notifications with the provided status types. Options are: unread, read and/or pinned. Defaults to unread. (optional) 
            var toStatus = toStatus_example;  // string | Status to mark notifications as. Defaults to read. (optional) 
            var lastReadAt = 2013-10-20T19:20:30+01:00;  // DateTime | Describes the last point that notifications were checked. Anything updated since this time will not be updated. (optional) 

            try
            {
                // Mark notification threads as read, pinned or unread on a specific repo
                apiInstance.NotifyReadRepoList(owner, repo, all, statusTypes, toStatus, lastReadAt);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationApi.NotifyReadRepoList: " + e.Message );
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
 **all** | **string**| If true, mark all notifications on this repo. Default value is false | [optional] 
 **statusTypes** | [**List&lt;string&gt;**](string.md)| Mark notifications with the provided status types. Options are: unread, read and/or pinned. Defaults to unread. | [optional] 
 **toStatus** | **string**| Status to mark notifications as. Defaults to read. | [optional] 
 **lastReadAt** | **DateTime**| Describes the last point that notifications were checked. Anything updated since this time will not be updated. | [optional] 

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
| **205** | APIEmpty is an empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## NotifyReadThread

> void NotifyReadThread (string id, string toStatus = null)

Mark notification thread as read by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class NotifyReadThreadExample
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

            var apiInstance = new NotificationApi(Configuration.Default);
            var id = id_example;  // string | id of notification thread
            var toStatus = toStatus_example;  // string | Status to mark notifications as (optional)  (default to "read")

            try
            {
                // Mark notification thread as read by ID
                apiInstance.NotifyReadThread(id, toStatus);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationApi.NotifyReadThread: " + e.Message );
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
 **id** | **string**| id of notification thread | 
 **toStatus** | **string**| Status to mark notifications as | [optional] [default to &quot;read&quot;]

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
| **205** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

