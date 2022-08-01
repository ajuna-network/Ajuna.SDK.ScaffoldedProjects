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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_society;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class SocietyControllerMockupClient : MockupBaseClient, ISocietyControllerMockupClient
   {
      private HttpClient _httpClient;
      public SocietyControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetFounder(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Founder", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.FounderParams());
      }
      public async Task<bool> SetRules(H256 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Rules", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.RulesParams());
      }
      public async Task<bool> SetCandidates(BaseVec<Bid> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Candidates", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.CandidatesParams());
      }
      public async Task<bool> SetSuspendedCandidates(BaseTuple<U128, EnumBidKind> value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/SuspendedCandidates", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.SuspendedCandidatesParams(key));
      }
      public async Task<bool> SetPot(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Pot", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.PotParams());
      }
      public async Task<bool> SetHead(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Head", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.HeadParams());
      }
      public async Task<bool> SetMembers(BaseVec<AccountId32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Members", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.MembersParams());
      }
      public async Task<bool> SetSuspendedMembers(Bool value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/SuspendedMembers", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.SuspendedMembersParams(key));
      }
      public async Task<bool> SetBids(BaseVec<Bid> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Bids", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.BidsParams());
      }
      public async Task<bool> SetVouching(EnumVouchingStatus value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Vouching", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.VouchingParams(key));
      }
      public async Task<bool> SetPayouts(BaseVec<BaseTuple<U32, U128>> value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Payouts", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.PayoutsParams(key));
      }
      public async Task<bool> SetStrikes(U32 value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Strikes", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.StrikesParams(key));
      }
      public async Task<bool> SetVotes(EnumVote value, BaseTuple<AccountId32, AccountId32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Votes", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.VotesParams(key));
      }
      public async Task<bool> SetDefender(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/Defender", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.DefenderParams());
      }
      public async Task<bool> SetDefenderVotes(EnumVote value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/DefenderVotes", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.DefenderVotesParams(key));
      }
      public async Task<bool> SetMaxMembers(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Society/MaxMembers", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.SocietyStorage.MaxMembersParams());
      }
   }
}
