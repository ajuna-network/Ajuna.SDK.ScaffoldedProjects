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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class ProxyControllerClient : BaseClient, IProxyControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ProxyControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple<BoundedVecT28, U128>> GetProxies(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<BoundedVecT28, U128>>(_httpClient, "proxy/proxies", Ajuna.SDK.Demos.NetApi.Generated.Storage.ProxyStorage.ProxiesParams(key));
      }
      public async Task<bool> SubscribeProxies(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Proxy.Proxies", Ajuna.SDK.Demos.NetApi.Generated.Storage.ProxyStorage.ProxiesParams(key));
      }
      public async Task<BaseTuple<BoundedVecT29, U128>> GetAnnouncements(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<BoundedVecT29, U128>>(_httpClient, "proxy/announcements", Ajuna.SDK.Demos.NetApi.Generated.Storage.ProxyStorage.AnnouncementsParams(key));
      }
      public async Task<bool> SubscribeAnnouncements(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Proxy.Announcements", Ajuna.SDK.Demos.NetApi.Generated.Storage.ProxyStorage.AnnouncementsParams(key));
      }
   }
}