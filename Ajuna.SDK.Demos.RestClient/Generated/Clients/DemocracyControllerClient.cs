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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_democracy;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_democracy.types;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_democracy.vote;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_democracy.vote_threshold;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class DemocracyControllerClient : BaseClient, IDemocracyControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public DemocracyControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetPublicPropCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "democracy/publicpropcount");
      }
      public async Task<bool> SubscribePublicPropCount()
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.PublicPropCount");
      }
      public async Task<BaseVec<BaseTuple<U32, H256, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>>> GetPublicProps()
      {
         return await SendRequestAsync<BaseVec<BaseTuple<U32, H256, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>>>(_httpClient, "democracy/publicprops");
      }
      public async Task<bool> SubscribePublicProps()
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.PublicProps");
      }
      public async Task<BaseTuple<BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>, U128>> GetDepositOf(U32 key)
      {
         return await SendRequestAsync<BaseTuple<BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>, U128>>(_httpClient, "democracy/depositof", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.DepositOfParams(key));
      }
      public async Task<bool> SubscribeDepositOf(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.DepositOf", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.DepositOfParams(key));
      }
      public async Task<EnumPreimageStatus> GetPreimages(H256 key)
      {
         return await SendRequestAsync<EnumPreimageStatus>(_httpClient, "democracy/preimages", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.PreimagesParams(key));
      }
      public async Task<bool> SubscribePreimages(H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.Preimages", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.PreimagesParams(key));
      }
      public async Task<U32> GetReferendumCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "democracy/referendumcount");
      }
      public async Task<bool> SubscribeReferendumCount()
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.ReferendumCount");
      }
      public async Task<U32> GetLowestUnbaked()
      {
         return await SendRequestAsync<U32>(_httpClient, "democracy/lowestunbaked");
      }
      public async Task<bool> SubscribeLowestUnbaked()
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.LowestUnbaked");
      }
      public async Task<EnumReferendumInfo> GetReferendumInfoOf(U32 key)
      {
         return await SendRequestAsync<EnumReferendumInfo>(_httpClient, "democracy/referenduminfoof", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.ReferendumInfoOfParams(key));
      }
      public async Task<bool> SubscribeReferendumInfoOf(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.ReferendumInfoOf", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.ReferendumInfoOfParams(key));
      }
      public async Task<EnumVoting> GetVotingOf(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<EnumVoting>(_httpClient, "democracy/votingof", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.VotingOfParams(key));
      }
      public async Task<bool> SubscribeVotingOf(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.VotingOf", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.VotingOfParams(key));
      }
      public async Task<Bool> GetLastTabledWasExternal()
      {
         return await SendRequestAsync<Bool>(_httpClient, "democracy/lasttabledwasexternal");
      }
      public async Task<bool> SubscribeLastTabledWasExternal()
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.LastTabledWasExternal");
      }
      public async Task<BaseTuple<H256, EnumVoteThreshold>> GetNextExternal()
      {
         return await SendRequestAsync<BaseTuple<H256, EnumVoteThreshold>>(_httpClient, "democracy/nextexternal");
      }
      public async Task<bool> SubscribeNextExternal()
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.NextExternal");
      }
      public async Task<BaseTuple<U32, BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>>> GetBlacklist(H256 key)
      {
         return await SendRequestAsync<BaseTuple<U32, BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>>>(_httpClient, "democracy/blacklist", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.BlacklistParams(key));
      }
      public async Task<bool> SubscribeBlacklist(H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.Blacklist", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.BlacklistParams(key));
      }
      public async Task<Bool> GetCancellations(H256 key)
      {
         return await SendRequestAsync<Bool>(_httpClient, "democracy/cancellations", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.CancellationsParams(key));
      }
      public async Task<bool> SubscribeCancellations(H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.Cancellations", Ajuna.SDK.Demos.NetApi.Generated.Storage.DemocracyStorage.CancellationsParams(key));
      }
      public async Task<EnumReleases> GetStorageVersion()
      {
         return await SendRequestAsync<EnumReleases>(_httpClient, "democracy/storageversion");
      }
      public async Task<bool> SubscribeStorageVersion()
      {
         return await _subscriptionClient.SubscribeAsync("Democracy.StorageVersion");
      }
   }
}
