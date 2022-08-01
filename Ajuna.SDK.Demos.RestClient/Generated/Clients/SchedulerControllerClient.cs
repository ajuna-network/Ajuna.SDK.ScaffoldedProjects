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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class SchedulerControllerClient : BaseClient, ISchedulerControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public SchedulerControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseVec<BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_scheduler.ScheduledV3>>> GetAgenda(U32 key)
      {
         return await SendRequestAsync<BaseVec<BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_scheduler.ScheduledV3>>>(_httpClient, "scheduler/agenda", Ajuna.SDK.Demos.NetApi.Generated.Storage.SchedulerStorage.AgendaParams(key));
      }
      public async Task<bool> SubscribeAgenda(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Scheduler.Agenda", Ajuna.SDK.Demos.NetApi.Generated.Storage.SchedulerStorage.AgendaParams(key));
      }
      public async Task<BaseTuple<U32, U32>> GetLookup(BaseVec<U8> key)
      {
         return await SendRequestAsync<BaseTuple<U32, U32>>(_httpClient, "scheduler/lookup", Ajuna.SDK.Demos.NetApi.Generated.Storage.SchedulerStorage.LookupParams(key));
      }
      public async Task<bool> SubscribeLookup(BaseVec<U8> key)
      {
         return await _subscriptionClient.SubscribeAsync("Scheduler.Lookup", Ajuna.SDK.Demos.NetApi.Generated.Storage.SchedulerStorage.LookupParams(key));
      }
   }
}