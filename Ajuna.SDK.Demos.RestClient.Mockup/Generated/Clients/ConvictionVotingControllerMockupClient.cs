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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_conviction_voting.vote;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ConvictionVotingControllerMockupClient : MockupBaseClient, IConvictionVotingControllerMockupClient
   {
      private HttpClient _httpClient;
      public ConvictionVotingControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetVotingFor(EnumVoting value, Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16> key)
      {
         return await SendMockupRequestAsync(_httpClient, "ConvictionVoting/VotingFor", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.ConvictionVotingStorage.VotingForParams(key));
      }
      public async Task<bool> SetClassLocksFor(BoundedVecT37 value, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ConvictionVoting/ClassLocksFor", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.ConvictionVotingStorage.ClassLocksForParams(key));
      }
   }
}
