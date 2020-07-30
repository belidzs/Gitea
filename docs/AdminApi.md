# Gitea.Api.AdminApi

All URIs are relative to *http://localhost/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdminCreateOrg**](AdminApi.md#admincreateorg) | **POST** /admin/users/{username}/orgs | Create an organization
[**AdminCreatePublicKey**](AdminApi.md#admincreatepublickey) | **POST** /admin/users/{username}/keys | Add a public key on behalf of a user
[**AdminCreateRepo**](AdminApi.md#admincreaterepo) | **POST** /admin/users/{username}/repos | Create a repository on behalf of a user
[**AdminCreateUser**](AdminApi.md#admincreateuser) | **POST** /admin/users | Create a user
[**AdminDeleteUser**](AdminApi.md#admindeleteuser) | **DELETE** /admin/users/{username} | Delete a user
[**AdminDeleteUserPublicKey**](AdminApi.md#admindeleteuserpublickey) | **DELETE** /admin/users/{username}/keys/{id} | Delete a user&#39;s public key
[**AdminEditUser**](AdminApi.md#adminedituser) | **PATCH** /admin/users/{username} | Edit an existing user
[**AdminGetAllOrgs**](AdminApi.md#admingetallorgs) | **GET** /admin/orgs | List all organizations
[**AdminGetAllUsers**](AdminApi.md#admingetallusers) | **GET** /admin/users | List all users



## AdminCreateOrg

> Organization AdminCreateOrg (string username, CreateOrgOption organization)

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
    public class AdminCreateOrgExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var username = username_example;  // string | username of the user that will own the created organization
            var organization = new CreateOrgOption(); // CreateOrgOption | 

            try
            {
                // Create an organization
                Organization result = apiInstance.AdminCreateOrg(username, organization);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminCreateOrg: " + e.Message );
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
 **username** | **string**| username of the user that will own the created organization | 
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


## AdminCreatePublicKey

> PublicKey AdminCreatePublicKey (string username, CreateKeyOption key = null)

Add a public key on behalf of a user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class AdminCreatePublicKeyExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var username = username_example;  // string | username of the user
            var key = new CreateKeyOption(); // CreateKeyOption |  (optional) 

            try
            {
                // Add a public key on behalf of a user
                PublicKey result = apiInstance.AdminCreatePublicKey(username, key);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminCreatePublicKey: " + e.Message );
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
 **username** | **string**| username of the user | 
 **key** | [**CreateKeyOption**](CreateKeyOption.md)|  | [optional] 

### Return type

[**PublicKey**](PublicKey.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | PublicKey |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdminCreateRepo

> Repository AdminCreateRepo (string username, CreateRepoOption repository)

Create a repository on behalf of a user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class AdminCreateRepoExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var username = username_example;  // string | username of the user. This user will own the created repository
            var repository = new CreateRepoOption(); // CreateRepoOption | 

            try
            {
                // Create a repository on behalf of a user
                Repository result = apiInstance.AdminCreateRepo(username, repository);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminCreateRepo: " + e.Message );
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
 **username** | **string**| username of the user. This user will own the created repository | 
 **repository** | [**CreateRepoOption**](CreateRepoOption.md)|  | 

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
| **409** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdminCreateUser

> User AdminCreateUser (CreateUserOption body = null)

Create a user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class AdminCreateUserExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var body = new CreateUserOption(); // CreateUserOption |  (optional) 

            try
            {
                // Create a user
                User result = apiInstance.AdminCreateUser(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminCreateUser: " + e.Message );
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
 **body** | [**CreateUserOption**](CreateUserOption.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | User |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdminDeleteUser

> void AdminDeleteUser (string username)

Delete a user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class AdminDeleteUserExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var username = username_example;  // string | username of user to delete

            try
            {
                // Delete a user
                apiInstance.AdminDeleteUser(username);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminDeleteUser: " + e.Message );
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
 **username** | **string**| username of user to delete | 

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


## AdminDeleteUserPublicKey

> void AdminDeleteUserPublicKey (string username, long id)

Delete a user's public key

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class AdminDeleteUserPublicKeyExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var username = username_example;  // string | username of user
            var id = 789;  // long | id of the key to delete

            try
            {
                // Delete a user's public key
                apiInstance.AdminDeleteUserPublicKey(username, id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminDeleteUserPublicKey: " + e.Message );
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
 **id** | **long**| id of the key to delete | 

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


## AdminEditUser

> User AdminEditUser (string username, EditUserOption body = null)

Edit an existing user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class AdminEditUserExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var username = username_example;  // string | username of user to edit
            var body = new EditUserOption(); // EditUserOption |  (optional) 

            try
            {
                // Edit an existing user
                User result = apiInstance.AdminEditUser(username, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminEditUser: " + e.Message );
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
 **username** | **string**| username of user to edit | 
 **body** | [**EditUserOption**](EditUserOption.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

[AccessToken](../README.md#AccessToken), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [BasicAuth](../README.md#BasicAuth), [SudoHeader](../README.md#SudoHeader), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdminGetAllOrgs

> List&lt;Organization&gt; AdminGetAllOrgs (int page = null, int limit = null)

List all organizations

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class AdminGetAllOrgsExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List all organizations
                List<Organization> result = apiInstance.AdminGetAllOrgs(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminGetAllOrgs: " + e.Message );
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
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdminGetAllUsers

> List&lt;User&gt; AdminGetAllUsers (int page = null, int limit = null)

List all users

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Gitea.Api;
using Gitea.Client;
using Gitea.Model;

namespace Example
{
    public class AdminGetAllUsersExample
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

            var apiInstance = new AdminApi(Configuration.Default);
            var page = 56;  // int | page number of results to return (1-based) (optional) 
            var limit = 56;  // int | page size of results (optional) 

            try
            {
                // List all users
                List<User> result = apiInstance.AdminGetAllUsers(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.AdminGetAllUsers: " + e.Message );
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
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

