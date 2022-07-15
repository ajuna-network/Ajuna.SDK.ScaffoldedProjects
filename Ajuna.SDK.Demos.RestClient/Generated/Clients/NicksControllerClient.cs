//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class NicksControllerClient : BaseClient, INicksControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public NicksControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT4, Ajuna.NetApi.Model.Types.Primitive.U128>> GetNameOf(Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT4, Ajuna.NetApi.Model.Types.Primitive.U128>>(_httpClient, "nicks/nameof", Ajuna.SDK.Demos.NetApi.Generated.Model.PalletNicks.NicksStorage.NameOfParams(key));
      }
      public async Task<bool> SubscribeNameOf(Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Nicks.NameOf", Ajuna.SDK.Demos.NetApi.Generated.Model.PalletNicks.NicksStorage.NameOfParams(key));
      }
   }
}
