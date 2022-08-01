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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_balances;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.weak_bounded_vec;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class BalancesControllerMockupClient : MockupBaseClient, IBalancesControllerMockupClient
   {
      private HttpClient _httpClient;
      public BalancesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetTotalIssuance(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/TotalIssuance", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.BalancesStorage.TotalIssuanceParams());
      }
      public async Task<bool> SetAccount(AccountData value, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Account", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<bool> SetLocks(WeakBoundedVecT2 value, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Locks", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<bool> SetReserves(BoundedVecT10 value, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Reserves", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<bool> SetStorageVersion(EnumReleases value)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/StorageVersion", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.BalancesStorage.StorageVersionParams());
      }
   }
}
