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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class IdentityControllerClient : BaseClient, IIdentityControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IdentityControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<Registration> GetIdentityOf(AccountId32 key)
      {
         return await SendRequestAsync<Registration>(_httpClient, "identity/identityof", Ajuna.SDK.Demos.NetApi.Generated.Storage.IdentityStorage.IdentityOfParams(key));
      }
      public async Task<bool> SubscribeIdentityOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.IdentityOf", Ajuna.SDK.Demos.NetApi.Generated.Storage.IdentityStorage.IdentityOfParams(key));
      }
      public async Task<BaseTuple<AccountId32, EnumData>> GetSuperOf(AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<AccountId32, EnumData>>(_httpClient, "identity/superof", Ajuna.SDK.Demos.NetApi.Generated.Storage.IdentityStorage.SuperOfParams(key));
      }
      public async Task<bool> SubscribeSuperOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.SuperOf", Ajuna.SDK.Demos.NetApi.Generated.Storage.IdentityStorage.SuperOfParams(key));
      }
      public async Task<BaseTuple<U128, BoundedVecT23>> GetSubsOf(AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<U128, BoundedVecT23>>(_httpClient, "identity/subsof", Ajuna.SDK.Demos.NetApi.Generated.Storage.IdentityStorage.SubsOfParams(key));
      }
      public async Task<bool> SubscribeSubsOf(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Identity.SubsOf", Ajuna.SDK.Demos.NetApi.Generated.Storage.IdentityStorage.SubsOfParams(key));
      }
      public async Task<BoundedVecT24> GetRegistrars()
      {
         return await SendRequestAsync<BoundedVecT24>(_httpClient, "identity/registrars");
      }
      public async Task<bool> SubscribeRegistrars()
      {
         return await _subscriptionClient.SubscribeAsync("Identity.Registrars");
      }
   }
}
