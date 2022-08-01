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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class RecoveryControllerClient : BaseClient, IRecoveryControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public RecoveryControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<RecoveryConfig> GetRecoverable(AccountId32 key)
      {
         return await SendRequestAsync<RecoveryConfig>(_httpClient, "recovery/recoverable", Ajuna.SDK.Demos.NetApi.Generated.Storage.RecoveryStorage.RecoverableParams(key));
      }
      public async Task<bool> SubscribeRecoverable(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Recovery.Recoverable", Ajuna.SDK.Demos.NetApi.Generated.Storage.RecoveryStorage.RecoverableParams(key));
      }
      public async Task<ActiveRecovery> GetActiveRecoveries(Ajuna.NetApi.Model.Types.Base.BaseTuple<AccountId32, AccountId32> key)
      {
         return await SendRequestAsync<ActiveRecovery>(_httpClient, "recovery/activerecoveries", Ajuna.SDK.Demos.NetApi.Generated.Storage.RecoveryStorage.ActiveRecoveriesParams(key));
      }
      public async Task<bool> SubscribeActiveRecoveries(Ajuna.NetApi.Model.Types.Base.BaseTuple<AccountId32, AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Recovery.ActiveRecoveries", Ajuna.SDK.Demos.NetApi.Generated.Storage.RecoveryStorage.ActiveRecoveriesParams(key));
      }
      public async Task<AccountId32> GetProxy(AccountId32 key)
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "recovery/proxy", Ajuna.SDK.Demos.NetApi.Generated.Storage.RecoveryStorage.ProxyParams(key));
      }
      public async Task<bool> SubscribeProxy(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Recovery.Proxy", Ajuna.SDK.Demos.NetApi.Generated.Storage.RecoveryStorage.ProxyParams(key));
      }
   }
}
