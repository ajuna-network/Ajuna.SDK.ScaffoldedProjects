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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_collective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AllianceMotionControllerMockupClient : MockupBaseClient, IAllianceMotionControllerMockupClient
   {
      private HttpClient _httpClient;
      public AllianceMotionControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetProposals(BoundedVecT38 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/Proposals", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.AllianceMotionStorage.ProposalsParams());
      }
      public async Task<bool> SetProposalOf(EnumCall value, Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/ProposalOf", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.AllianceMotionStorage.ProposalOfParams(key));
      }
      public async Task<bool> SetVoting(Votes value, Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/Voting", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.AllianceMotionStorage.VotingParams(key));
      }
      public async Task<bool> SetProposalCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/ProposalCount", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.AllianceMotionStorage.ProposalCountParams());
      }
      public async Task<bool> SetMembers(BaseVec<AccountId32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/Members", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.AllianceMotionStorage.MembersParams());
      }
      public async Task<bool> SetPrime(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AllianceMotion/Prime", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.AllianceMotionStorage.PrimeParams());
      }
   }
}
