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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.PalletGrandpa;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class GrandpaControllerClient : BaseClient, IGrandpaControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public GrandpaControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<EnumStoredState> GetState()
      {
         return await SendRequestAsync<EnumStoredState>(_httpClient, "grandpa/state");
      }
      public async Task<bool> SubscribeState()
      {
         return await _subscriptionClient.SubscribeAsync("Grandpa.State");
      }
      public async Task<StoredPendingChange> GetPendingChange()
      {
         return await SendRequestAsync<StoredPendingChange>(_httpClient, "grandpa/pendingchange");
      }
      public async Task<bool> SubscribePendingChange()
      {
         return await _subscriptionClient.SubscribeAsync("Grandpa.PendingChange");
      }
      public async Task<U32> GetNextForced()
      {
         return await SendRequestAsync<U32>(_httpClient, "grandpa/nextforced");
      }
      public async Task<bool> SubscribeNextForced()
      {
         return await _subscriptionClient.SubscribeAsync("Grandpa.NextForced");
      }
      public async Task<BaseTuple<U32, U32>> GetStalled()
      {
         return await SendRequestAsync<BaseTuple<U32, U32>>(_httpClient, "grandpa/stalled");
      }
      public async Task<bool> SubscribeStalled()
      {
         return await _subscriptionClient.SubscribeAsync("Grandpa.Stalled");
      }
      public async Task<U64> GetCurrentSetId()
      {
         return await SendRequestAsync<U64>(_httpClient, "grandpa/currentsetid");
      }
      public async Task<bool> SubscribeCurrentSetId()
      {
         return await _subscriptionClient.SubscribeAsync("Grandpa.CurrentSetId");
      }
      public async Task<U32> GetSetIdSession(U64 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "grandpa/setidsession", GrandpaStorage.SetIdSessionParams(key));
      }
      public async Task<bool> SubscribeSetIdSession(U64 key)
      {
         return await _subscriptionClient.SubscribeAsync("Grandpa.SetIdSession", GrandpaStorage.SetIdSessionParams(key));
      }
   }
}
