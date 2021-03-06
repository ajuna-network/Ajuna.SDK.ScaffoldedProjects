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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_bags_list.list;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class BagsListControllerClient : BaseClient, IBagsListControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BagsListControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<Node> GetListNodes(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<Node>(_httpClient, "bagslist/listnodes", Ajuna.SDK.Demos.NetApi.Generated.Storage.BagsListStorage.ListNodesParams(key));
      }
      public async Task<bool> SubscribeListNodes(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("BagsList.ListNodes", Ajuna.SDK.Demos.NetApi.Generated.Storage.BagsListStorage.ListNodesParams(key));
      }
      public async Task<U32> GetCounterForListNodes()
      {
         return await SendRequestAsync<U32>(_httpClient, "bagslist/counterforlistnodes");
      }
      public async Task<bool> SubscribeCounterForListNodes()
      {
         return await _subscriptionClient.SubscribeAsync("BagsList.CounterForListNodes");
      }
      public async Task<Bag> GetListBags(U64 key)
      {
         return await SendRequestAsync<Bag>(_httpClient, "bagslist/listbags", Ajuna.SDK.Demos.NetApi.Generated.Storage.BagsListStorage.ListBagsParams(key));
      }
      public async Task<bool> SubscribeListBags(U64 key)
      {
         return await _subscriptionClient.SubscribeAsync("BagsList.ListBags", Ajuna.SDK.Demos.NetApi.Generated.Storage.BagsListStorage.ListBagsParams(key));
      }
   }
}
