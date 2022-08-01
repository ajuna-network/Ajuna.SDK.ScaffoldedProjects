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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class GiltControllerMockupClient : MockupBaseClient, IGiltControllerMockupClient
   {
      private HttpClient _httpClient;
      public GiltControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetQueueTotals(BoundedVecT32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Gilt/QueueTotals", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.GiltStorage.QueueTotalsParams());
      }
      public async Task<bool> SetQueues(BoundedVecT33 value, Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Gilt/Queues", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.GiltStorage.QueuesParams(key));
      }
      public async Task<bool> SetActiveTotal(ActiveGiltsTotal value)
      {
         return await SendMockupRequestAsync(_httpClient, "Gilt/ActiveTotal", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.GiltStorage.ActiveTotalParams());
      }
      public async Task<bool> SetActive(ActiveGilt value, Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Gilt/Active", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.GiltStorage.ActiveParams(key));
      }
   }
}
