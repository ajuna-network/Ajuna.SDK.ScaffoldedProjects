//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class IndicesControllerMockupClient : MockupBaseClient, IIndicesControllerMockupClient
   {
      private HttpClient _httpClient;
      public IndicesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAccounts(BaseTuple<AccountId32, U128, Bool> value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Indices/Accounts", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.IndicesStorage.AccountsParams(key));
      }
   }
}
