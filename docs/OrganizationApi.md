# Gitea.Api.OrganizationApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrgRepo**](OrganizationApi.md#createorgrepo) | **POST** /orgs/{org}/repos | Create a repository in an organization
[**CreateOrgRepoDeprecated**](OrganizationApi.md#createorgrepodeprecated) | **POST** /org/{org}/repos | Create a repository in an organization
[**OrgAddTeamMember**](OrganizationApi.md#orgaddteammember) | **PUT** /teams/{id}/members/{username} | Add a team member
[**OrgAddTeamRepository**](OrganizationApi.md#orgaddteamrepository) | **PUT** /teams/{id}/repos/{org}/{repo} | Add a repository to a team
[**OrgConcealMember**](OrganizationApi.md#orgconcealmember) | **DELETE** /orgs/{org}/public_members/{username} | Conceal a user&#39;s membership
[**OrgCreate**](OrganizationApi.md#orgcreate) | **POST** /orgs | Create an organization
[**OrgCreateHook**](OrganizationApi.md#orgcreatehook) | **POST** /orgs/{org}/hooks/ | Create a hook
[**OrgCreateLabel**](OrganizationApi.md#orgcreatelabel) | **POST** /orgs/{org}/labels | Create a label for an organization
[**OrgCreateTeam**](OrganizationApi.md#orgcreateteam) | **POST** /orgs/{org}/teams | Create a team
[**OrgDelete**](OrganizationApi.md#orgdelete) | **DELETE** /orgs/{org} | Delete an organization
[**OrgDeleteHook**](OrganizationApi.md#orgdeletehook) | **DELETE** /orgs/{org}/hooks/{id} | Delete a hook
[**OrgDeleteLabel**](OrganizationApi.md#orgdeletelabel) | **DELETE** /orgs/{org}/labels/{id} | Delete a label
[**OrgDeleteMember**](OrganizationApi.md#orgdeletemember) | **DELETE** /orgs/{org}/members/{username} | Remove a member from an organization
[**OrgDeleteTeam**](OrganizationApi.md#orgdeleteteam) | **DELETE** /teams/{id} | Delete a team
[**OrgEdit**](OrganizationApi.md#orgedit) | **PATCH** /orgs/{org} | Edit an organization
[**OrgEditHook**](OrganizationApi.md#orgedithook) | **PATCH** /orgs/{org}/hooks/{id} | Update a hook
[**OrgEditLabel**](OrganizationApi.md#orgeditlabel) | **PATCH** /orgs/{org}/labels/{id} | Update a label
[**OrgEditTeam**](OrganizationApi.md#orgeditteam) | **PATCH** /teams/{id} | Edit a team
[**OrgGet**](OrganizationApi.md#orgget) | **GET** /orgs/{org} | Get an organization
[**OrgGetAll**](OrganizationApi.md#orggetall) | **GET** /orgs | Get list of organizations
[**OrgGetHook**](OrganizationApi.md#orggethook) | **GET** /orgs/{org}/hooks/{id} | Get a hook
[**OrgGetLabel**](OrganizationApi.md#orggetlabel) | **GET** /orgs/{org}/labels/{id} | Get a single label
[**OrgGetTeam**](OrganizationApi.md#orggetteam) | **GET** /teams/{id} | Get a team
[**OrgIsMember**](OrganizationApi.md#orgismember) | **GET** /orgs/{org}/members/{username} | Check if a user is a member of an organization
[**OrgIsPublicMember**](OrganizationApi.md#orgispublicmember) | **GET** /orgs/{org}/public_members/{username} | Check if a user is a public member of an organization
[**OrgListCurrentUserOrgs**](OrganizationApi.md#orglistcurrentuserorgs) | **GET** /user/orgs | List the current user&#39;s organizations
[**OrgListHooks**](OrganizationApi.md#orglisthooks) | **GET** /orgs/{org}/hooks | List an organization&#39;s webhooks
[**OrgListLabels**](OrganizationApi.md#orglistlabels) | **GET** /orgs/{org}/labels | List an organization&#39;s labels
[**OrgListMembers**](OrganizationApi.md#orglistmembers) | **GET** /orgs/{org}/members | List an organization&#39;s members
[**OrgListPublicMembers**](OrganizationApi.md#orglistpublicmembers) | **GET** /orgs/{org}/public_members | List an organization&#39;s public members
[**OrgListRepos**](OrganizationApi.md#orglistrepos) | **GET** /orgs/{org}/repos | List an organization&#39;s repos
[**OrgListTeamMember**](OrganizationApi.md#orglistteammember) | **GET** /teams/{id}/members/{username} | List a particular member of team
[**OrgListTeamMembers**](OrganizationApi.md#orglistteammembers) | **GET** /teams/{id}/members | List a team&#39;s members
[**OrgListTeamRepos**](OrganizationApi.md#orglistteamrepos) | **GET** /teams/{id}/repos | List a team&#39;s repos
[**OrgListTeams**](OrganizationApi.md#orglistteams) | **GET** /orgs/{org}/teams | List an organization&#39;s teams
[**OrgListUserOrgs**](OrganizationApi.md#orglistuserorgs) | **GET** /users/{username}/orgs | List a user&#39;s organizations
[**OrgPublicizeMember**](OrganizationApi.md#orgpublicizemember) | **PUT** /orgs/{org}/public_members/{username} | Publicize a user&#39;s membership
[**OrgRemoveTeamMember**](OrganizationApi.md#orgremoveteammember) | **DELETE** /teams/{id}/members/{username} | Remove a team member
[**OrgRemoveTeamRepository**](OrganizationApi.md#orgremoveteamrepository) | **DELETE** /teams/{id}/repos/{org}/{repo} | Remove a repository from a team
[**TeamSearch**](OrganizationApi.md#teamsearch) | **GET** /orgs/{org}/teams/search | Search for teams within an organization



## CreateOrgRepo

> Repository CreateOrgRepo (string org, CreateRepoOption body = null)

Create a repository in an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class CreateOrgRepoExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of organization
            var body = new CreateRepoOption(); // CreateRepoOption |  (optional) 

            try
            {
                // Create a repository in an organization
                Repository result = apiInstance.CreateOrgRepo(org, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.CreateOrgRepo: " + e.Message );
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
 **org** | **string**| name of organization | 
 **body** | [**CreateRepoOption**](CreateRepoOption.md)|  | [optional] 

### Return type

[**Repository**](Repository.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Repository |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateOrgRepoDeprecated

> Repository CreateOrgRepoDeprecated (string org, CreateRepoOption body = null)

Create a repository in an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class CreateOrgRepoDeprecatedExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of organization
            var body = new CreateRepoOption(); // CreateRepoOption |  (optional) 

            try
            {
                // Create a repository in an organization
                Repository result = apiInstance.CreateOrgRepoDeprecated(org, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.CreateOrgRepoDeprecated: " + e.Message );
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
 **org** | **string**| name of organization | 
 **body** | [**CreateRepoOption**](CreateRepoOption.md)|  | [optional] 

### Return type

[**Repository**](Repository.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Repository |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgAddTeamMember

> void OrgAddTeamMember (long id, string username)

Add a team member

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgAddTeamMemberExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team
            var username = username_example;  // string | username of the user to add

            try
            {
                // Add a team member
                apiInstance.OrgAddTeamMember(id, username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgAddTeamMember: " + e.Message );
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
 **id** | **long**| id of the team | 
 **username** | **string**| username of the user to add | 

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
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgAddTeamRepository

> void OrgAddTeamRepository (long id, string org, string repo)

Add a repository to a team

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgAddTeamRepositoryExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team
            var org = org_example;  // string | organization that owns the repo to add
            var repo = repo_example;  // string | name of the repo to add

            try
            {
                // Add a repository to a team
                apiInstance.OrgAddTeamRepository(id, org, repo);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgAddTeamRepository: " + e.Message );
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
 **id** | **long**| id of the team | 
 **org** | **string**| organization that owns the repo to add | 
 **repo** | **string**| name of the repo to add | 

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


## OrgConcealMember

> void OrgConcealMember (string org, string username)

Conceal a user's membership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgConcealMemberExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var username = username_example;  // string | username of the user

            try
            {
                // Conceal a user's membership
                apiInstance.OrgConcealMember(org, username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgConcealMember: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **username** | **string**| username of the user | 

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


## OrgCreate

> Organization OrgCreate (CreateOrgOption organization)

Create an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgCreateExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var organization = new CreateOrgOption(); // CreateOrgOption | 

            try
            {
                // Create an organization
                Organization result = apiInstance.OrgCreate(organization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgCreate: " + e.Message );
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
 **organization** | [**CreateOrgOption**](CreateOrgOption.md)|  | 

### Return type

[**Organization**](Organization.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Organization |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgCreateHook

> Hook OrgCreateHook (string org, CreateHookOption body)

Create a hook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgCreateHookExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var body = new CreateHookOption(); // CreateHookOption | 

            try
            {
                // Create a hook
                Hook result = apiInstance.OrgCreateHook(org, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgCreateHook: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **body** | [**CreateHookOption**](CreateHookOption.md)|  | 

### Return type

[**Hook**](Hook.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Hook |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgCreateLabel

> Label OrgCreateLabel (string org, CreateLabelOption body = null)

Create a label for an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgCreateLabelExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var body = new CreateLabelOption(); // CreateLabelOption |  (optional) 

            try
            {
                // Create a label for an organization
                Label result = apiInstance.OrgCreateLabel(org, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgCreateLabel: " + e.Message );
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
 **org** | **string**| name of the organization | 
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


## OrgCreateTeam

> Team OrgCreateTeam (string org, CreateTeamOption body = null)

Create a team

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgCreateTeamExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var body = new CreateTeamOption(); // CreateTeamOption |  (optional) 

            try
            {
                // Create a team
                Team result = apiInstance.OrgCreateTeam(org, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgCreateTeam: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **body** | [**CreateTeamOption**](CreateTeamOption.md)|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Team |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgDelete

> void OrgDelete (string org)

Delete an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgDeleteExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | organization that is to be deleted

            try
            {
                // Delete an organization
                apiInstance.OrgDelete(org);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgDelete: " + e.Message );
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
 **org** | **string**| organization that is to be deleted | 

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


## OrgDeleteHook

> void OrgDeleteHook (string org, long id)

Delete a hook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgDeleteHookExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var id = 789;  // long | id of the hook to delete

            try
            {
                // Delete a hook
                apiInstance.OrgDeleteHook(org, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgDeleteHook: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **id** | **long**| id of the hook to delete | 

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


## OrgDeleteLabel

> void OrgDeleteLabel (string org, long id)

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
    public class OrgDeleteLabelExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var id = 789;  // long | id of the label to delete

            try
            {
                // Delete a label
                apiInstance.OrgDeleteLabel(org, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgDeleteLabel: " + e.Message );
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
 **org** | **string**| name of the organization | 
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


## OrgDeleteMember

> void OrgDeleteMember (string org, string username)

Remove a member from an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgDeleteMemberExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var username = username_example;  // string | username of the user

            try
            {
                // Remove a member from an organization
                apiInstance.OrgDeleteMember(org, username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgDeleteMember: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **username** | **string**| username of the user | 

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
| **204** | member removed |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgDeleteTeam

> void OrgDeleteTeam (long id)

Delete a team

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgDeleteTeamExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team to delete

            try
            {
                // Delete a team
                apiInstance.OrgDeleteTeam(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgDeleteTeam: " + e.Message );
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
 **id** | **long**| id of the team to delete | 

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
| **204** | team deleted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgEdit

> Organization OrgEdit (string org, EditOrgOption body)

Edit an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgEditExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization to edit
            var body = new EditOrgOption(); // EditOrgOption | 

            try
            {
                // Edit an organization
                Organization result = apiInstance.OrgEdit(org, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgEdit: " + e.Message );
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
 **org** | **string**| name of the organization to edit | 
 **body** | [**EditOrgOption**](EditOrgOption.md)|  | 

### Return type

[**Organization**](Organization.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Organization |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgEditHook

> Hook OrgEditHook (string org, long id, EditHookOption body = null)

Update a hook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgEditHookExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var id = 789;  // long | id of the hook to update
            var body = new EditHookOption(); // EditHookOption |  (optional) 

            try
            {
                // Update a hook
                Hook result = apiInstance.OrgEditHook(org, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgEditHook: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **id** | **long**| id of the hook to update | 
 **body** | [**EditHookOption**](EditHookOption.md)|  | [optional] 

### Return type

[**Hook**](Hook.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Hook |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgEditLabel

> Label OrgEditLabel (string org, long id, EditLabelOption body = null)

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
    public class OrgEditLabelExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var id = 789;  // long | id of the label to edit
            var body = new EditLabelOption(); // EditLabelOption |  (optional) 

            try
            {
                // Update a label
                Label result = apiInstance.OrgEditLabel(org, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgEditLabel: " + e.Message );
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
 **org** | **string**| name of the organization | 
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


## OrgEditTeam

> Team OrgEditTeam (int id, EditTeamOption body = null)

Edit a team

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgEditTeamExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 56;  // int | id of the team to edit
            var body = new EditTeamOption(); // EditTeamOption |  (optional) 

            try
            {
                // Edit a team
                Team result = apiInstance.OrgEditTeam(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgEditTeam: " + e.Message );
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
 **id** | **int**| id of the team to edit | 
 **body** | [**EditTeamOption**](EditTeamOption.md)|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgGet

> Organization OrgGet (string org)

Get an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgGetExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization to get

            try
            {
                // Get an organization
                Organization result = apiInstance.OrgGet(org);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgGet: " + e.Message );
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
 **org** | **string**| name of the organization to get | 

### Return type

[**Organization**](Organization.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Organization |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgGetAll

> List&lt;Organization&gt; OrgGetAll (int page = null, int limit = null)

Get list of organizations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgGetAllExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // Get list of organizations
                List<Organization> result = apiInstance.OrgGetAll(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgGetAll: " + e.Message );
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
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Organization&gt;**](Organization.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OrganizationList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgGetHook

> Hook OrgGetHook (string org, long id)

Get a hook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgGetHookExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var id = 789;  // long | id of the hook to get

            try
            {
                // Get a hook
                Hook result = apiInstance.OrgGetHook(org, id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgGetHook: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **id** | **long**| id of the hook to get | 

### Return type

[**Hook**](Hook.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Hook |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgGetLabel

> Label OrgGetLabel (string org, long id)

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
    public class OrgGetLabelExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var id = 789;  // long | id of the label to get

            try
            {
                // Get a single label
                Label result = apiInstance.OrgGetLabel(org, id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgGetLabel: " + e.Message );
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
 **org** | **string**| name of the organization | 
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


## OrgGetTeam

> Team OrgGetTeam (long id)

Get a team

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgGetTeamExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team to get

            try
            {
                // Get a team
                Team result = apiInstance.OrgGetTeam(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgGetTeam: " + e.Message );
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
 **id** | **long**| id of the team to get | 

### Return type

[**Team**](Team.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgIsMember

> void OrgIsMember (string org, string username)

Check if a user is a member of an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgIsMemberExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var username = username_example;  // string | username of the user

            try
            {
                // Check if a user is a member of an organization
                apiInstance.OrgIsMember(org, username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgIsMember: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **username** | **string**| username of the user | 

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
| **204** | user is a member |  -  |
| **302** | redirection to /orgs/{org}/public_members/{username} |  -  |
| **404** | user is not a member |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgIsPublicMember

> void OrgIsPublicMember (string org, string username)

Check if a user is a public member of an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgIsPublicMemberExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var username = username_example;  // string | username of the user

            try
            {
                // Check if a user is a public member of an organization
                apiInstance.OrgIsPublicMember(org, username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgIsPublicMember: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **username** | **string**| username of the user | 

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
| **204** | user is a public member |  -  |
| **404** | user is not a public member |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListCurrentUserOrgs

> List&lt;Organization&gt; OrgListCurrentUserOrgs (int page = null, int limit = null)

List the current user's organizations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListCurrentUserOrgsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List the current user's organizations
                List<Organization> result = apiInstance.OrgListCurrentUserOrgs(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListCurrentUserOrgs: " + e.Message );
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
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Organization&gt;**](Organization.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OrganizationList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListHooks

> List&lt;Hook&gt; OrgListHooks (string org, int page = null, int limit = null)

List an organization's webhooks

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListHooksExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List an organization's webhooks
                List<Hook> result = apiInstance.OrgListHooks(org, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListHooks: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Hook&gt;**](Hook.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | HookList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListLabels

> List&lt;Label&gt; OrgListLabels (string org, int page = null, int limit = null)

List an organization's labels

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListLabelsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List an organization's labels
                List<Label> result = apiInstance.OrgListLabels(org, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListLabels: " + e.Message );
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
 **org** | **string**| name of the organization | 
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


## OrgListMembers

> List&lt;User&gt; OrgListMembers (string org, int page = null, int limit = null)

List an organization's members

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListMembersExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List an organization's members
                List<User> result = apiInstance.OrgListMembers(org, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListMembers: " + e.Message );
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
 **org** | **string**| name of the organization | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListPublicMembers

> List&lt;User&gt; OrgListPublicMembers (string org, int page = null, int limit = null)

List an organization's public members

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListPublicMembersExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List an organization's public members
                List<User> result = apiInstance.OrgListPublicMembers(org, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListPublicMembers: " + e.Message );
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
 **org** | **string**| name of the organization | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListRepos

> List&lt;Repository&gt; OrgListRepos (string org, int page = null, int limit = null)

List an organization's repos

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListReposExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List an organization's repos
                List<Repository> result = apiInstance.OrgListRepos(org, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListRepos: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Repository&gt;**](Repository.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RepositoryList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListTeamMember

> User OrgListTeamMember (long id, string username)

List a particular member of team

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListTeamMemberExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team
            var username = username_example;  // string | username of the member to list

            try
            {
                // List a particular member of team
                User result = apiInstance.OrgListTeamMember(id, username);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListTeamMember: " + e.Message );
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
 **id** | **long**| id of the team | 
 **username** | **string**| username of the member to list | 

### Return type

[**User**](User.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListTeamMembers

> List&lt;User&gt; OrgListTeamMembers (long id, int page = null, int limit = null)

List a team's members

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListTeamMembersExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List a team's members
                List<User> result = apiInstance.OrgListTeamMembers(id, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListTeamMembers: " + e.Message );
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
 **id** | **long**| id of the team | 
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListTeamRepos

> List&lt;Repository&gt; OrgListTeamRepos (long id, int page = null, int limit = null)

List a team's repos

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListTeamReposExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List a team's repos
                List<Repository> result = apiInstance.OrgListTeamRepos(id, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListTeamRepos: " + e.Message );
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
 **id** | **long**| id of the team | 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Repository&gt;**](Repository.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RepositoryList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListTeams

> List&lt;Team&gt; OrgListTeams (string org, int page = null, int limit = null)

List an organization's teams

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListTeamsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List an organization's teams
                List<Team> result = apiInstance.OrgListTeams(org, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListTeams: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Team&gt;**](Team.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TeamList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgListUserOrgs

> List&lt;Organization&gt; OrgListUserOrgs (string username, int page = null, int limit = null)

List a user's organizations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgListUserOrgsExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var username = username_example;  // string | username of user
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List a user's organizations
                List<Organization> result = apiInstance.OrgListUserOrgs(username, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgListUserOrgs: " + e.Message );
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
 **username** | **string**| username of user | 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**List&lt;Organization&gt;**](Organization.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OrganizationList |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgPublicizeMember

> void OrgPublicizeMember (string org, string username)

Publicize a user's membership

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgPublicizeMemberExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var username = username_example;  // string | username of the user

            try
            {
                // Publicize a user's membership
                apiInstance.OrgPublicizeMember(org, username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgPublicizeMember: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **username** | **string**| username of the user | 

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
| **204** | membership publicized |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgRemoveTeamMember

> void OrgRemoveTeamMember (long id, string username)

Remove a team member

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgRemoveTeamMemberExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team
            var username = username_example;  // string | username of the user to remove

            try
            {
                // Remove a team member
                apiInstance.OrgRemoveTeamMember(id, username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgRemoveTeamMember: " + e.Message );
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
 **id** | **long**| id of the team | 
 **username** | **string**| username of the user to remove | 

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
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OrgRemoveTeamRepository

> void OrgRemoveTeamRepository (long id, string org, string repo)

Remove a repository from a team

This does not delete the repository, it only removes the repository from the team.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class OrgRemoveTeamRepositoryExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var id = 789;  // long | id of the team
            var org = org_example;  // string | organization that owns the repo to remove
            var repo = repo_example;  // string | name of the repo to remove

            try
            {
                // Remove a repository from a team
                apiInstance.OrgRemoveTeamRepository(id, org, repo);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.OrgRemoveTeamRepository: " + e.Message );
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
 **id** | **long**| id of the team | 
 **org** | **string**| organization that owns the repo to remove | 
 **repo** | **string**| name of the repo to remove | 

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


## TeamSearch

> InlineResponse200 TeamSearch (string org, string q = null, bool includeDesc = null, int page = null, int limit = null)

Search for teams within an organization

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class TeamSearchExample
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

            var apiInstance = new OrganizationApi(Configuration.Default);
            var org = org_example;  // string | name of the organization
            var q = q_example;  // string | keywords to search (optional) 
            var includeDesc = true;  // bool | include search within team description (defaults to true) (optional) 
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // Search for teams within an organization
                InlineResponse200 result = apiInstance.TeamSearch(org, q, includeDesc, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganizationApi.TeamSearch: " + e.Message );
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
 **org** | **string**| name of the organization | 
 **q** | **string**| keywords to search | [optional] 
 **includeDesc** | **bool**| include search within team description (defaults to true) | [optional] 
 **page** | **int**| page number of results to return (1-based) | [optional] 
 **limit** | **int**| page size of results | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | SearchResults of a successful search |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

