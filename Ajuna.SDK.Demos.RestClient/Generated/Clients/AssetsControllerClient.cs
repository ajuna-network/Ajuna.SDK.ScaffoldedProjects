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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_assets.types;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class AssetsControllerClient : BaseClient, IAssetsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public AssetsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<AssetDetails> GetAsset(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await SendRequestAsync<AssetDetails>(_httpClient, "assets/asset", Ajuna.SDK.Demos.NetApi.Generated.Storage.AssetsStorage.AssetParams(key));
      }
      public async Task<bool> SubscribeAsset(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Assets.Asset", Ajuna.SDK.Demos.NetApi.Generated.Storage.AssetsStorage.AssetParams(key));
      }
      public async Task<AssetAccount> GetAccount(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key)
      {
         return await SendRequestAsync<AssetAccount>(_httpClient, "assets/account", Ajuna.SDK.Demos.NetApi.Generated.Storage.AssetsStorage.AccountParams(key));
      }
      public async Task<bool> SubscribeAccount(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Assets.Account", Ajuna.SDK.Demos.NetApi.Generated.Storage.AssetsStorage.AccountParams(key));
      }
      public async Task<Approval> GetApprovals(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key)
      {
         return await SendRequestAsync<Approval>(_httpClient, "assets/approvals", Ajuna.SDK.Demos.NetApi.Generated.Storage.AssetsStorage.ApprovalsParams(key));
      }
      public async Task<bool> SubscribeApprovals(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Assets.Approvals", Ajuna.SDK.Demos.NetApi.Generated.Storage.AssetsStorage.ApprovalsParams(key));
      }
      public async Task<AssetMetadata> GetMetadata(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await SendRequestAsync<AssetMetadata>(_httpClient, "assets/metadata", Ajuna.SDK.Demos.NetApi.Generated.Storage.AssetsStorage.MetadataParams(key));
      }
      public async Task<bool> SubscribeMetadata(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Assets.Metadata", Ajuna.SDK.Demos.NetApi.Generated.Storage.AssetsStorage.MetadataParams(key));
      }
   }
}
