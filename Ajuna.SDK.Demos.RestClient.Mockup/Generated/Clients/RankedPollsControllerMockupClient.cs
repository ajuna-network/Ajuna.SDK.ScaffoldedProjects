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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class RankedPollsControllerMockupClient : MockupBaseClient, IRankedPollsControllerMockupClient
   {
      private HttpClient _httpClient;
      public RankedPollsControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetReferendumCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "RankedPolls/ReferendumCount", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.RankedPollsStorage.ReferendumCountParams());
      }
      public async Task<bool> SetReferendumInfoFor(EnumReferendumInfo value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "RankedPolls/ReferendumInfoFor", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.RankedPollsStorage.ReferendumInfoForParams(key));
      }
      public async Task<bool> SetTrackQueue(BoundedVecT44 value, U16 key)
      {
         return await SendMockupRequestAsync(_httpClient, "RankedPolls/TrackQueue", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.RankedPollsStorage.TrackQueueParams(key));
      }
      public async Task<bool> SetDecidingCount(U32 value, U16 key)
      {
         return await SendMockupRequestAsync(_httpClient, "RankedPolls/DecidingCount", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.RankedPollsStorage.DecidingCountParams(key));
      }
   }
}