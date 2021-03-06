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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class TemplateModuleControllerClient : BaseClient, ITemplateModuleControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public TemplateModuleControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple<AccountId32, U32>> GetProofs(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1 key)
      {
         return await SendRequestAsync<BaseTuple<AccountId32, U32>>(_httpClient, "templatemodule/proofs", Ajuna.SDK.Demos.NetApi.Generated.Model.PalletTemplateModule.TemplateModuleStorage.ProofsParams(key));
      }
      public async Task<bool> SubscribeProofs(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1 key)
      {
         return await _subscriptionClient.SubscribeAsync("TemplateModule.Proofs", Ajuna.SDK.Demos.NetApi.Generated.Model.PalletTemplateModule.TemplateModuleStorage.ProofsParams(key));
      }
   }
}
