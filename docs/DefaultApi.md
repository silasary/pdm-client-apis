# PennyDreadfulMagic.Decksite.Api.DefaultApi

All URIs are relative to *https://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLeague**](DefaultApi.md#getleague) | **GET** /league | 
[**GetLoadDeck**](DefaultApi.md#getloaddeck) | **GET** /decks/{deck_id} | 


<a name="getleague"></a>
# **GetLeague**
> Competition GetLeague (string xFields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using PennyDreadfulMagic.Decksite.Api;
using PennyDreadfulMagic.Decksite.Client;
using PennyDreadfulMagic.Decksite.Model;

namespace Example
{
    public class GetLeagueExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var xFields = xFields_example;  // string | An optional fields mask (optional) 

            try
            {
                Competition result = apiInstance.GetLeague(xFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetLeague: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xFields** | **string**| An optional fields mask | [optional] 

### Return type

[**Competition**](Competition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloaddeck"></a>
# **GetLoadDeck**
> Deck GetLoadDeck (int? deckId, string xFields = null)



### Example
```csharp
using System;
using System.Diagnostics;
using PennyDreadfulMagic.Decksite.Api;
using PennyDreadfulMagic.Decksite.Client;
using PennyDreadfulMagic.Decksite.Model;

namespace Example
{
    public class GetLoadDeckExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var deckId = 56;  // int? | 
            var xFields = xFields_example;  // string | An optional fields mask (optional) 

            try
            {
                Deck result = apiInstance.GetLoadDeck(deckId, xFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetLoadDeck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deckId** | **int?**|  | 
 **xFields** | **string**| An optional fields mask | [optional] 

### Return type

[**Deck**](Deck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

