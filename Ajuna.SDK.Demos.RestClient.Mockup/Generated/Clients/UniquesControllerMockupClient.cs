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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_uniques.types;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class UniquesControllerMockupClient : MockupBaseClient, IUniquesControllerMockupClient
   {
      private HttpClient _httpClient;
      public UniquesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetClass(CollectionDetails value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/Class", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.ClassParams(key));
      }
      public async Task<bool> SetOwnershipAcceptance(U32 value, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/OwnershipAcceptance", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.OwnershipAcceptanceParams(key));
      }
      public async Task<bool> SetAccount(BaseTuple value, BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, U32, U32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/Account", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.AccountParams(key));
      }
      public async Task<bool> SetClassAccount(BaseTuple value, BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, U32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/ClassAccount", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.ClassAccountParams(key));
      }
      public async Task<bool> SetAsset(ItemDetails value, BaseTuple<U32, U32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/Asset", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.AssetParams(key));
      }
      public async Task<bool> SetClassMetadataOf(CollectionMetadata value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/ClassMetadataOf", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.ClassMetadataOfParams(key));
      }
      public async Task<bool> SetInstanceMetadataOf(ItemMetadata value, BaseTuple<U32, U32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/InstanceMetadataOf", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.InstanceMetadataOfParams(key));
      }
      public async Task<bool> SetAttribute(BaseTuple<BoundedVecT3, U128> value, BaseTuple<U32, BaseOpt<U32>, BoundedVecT2> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/Attribute", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.AttributeParams(key));
      }
      public async Task<bool> SetItemPriceOf(BaseTuple<U128, BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>> value, BaseTuple<U32, U32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/ItemPriceOf", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.ItemPriceOfParams(key));
      }
      public async Task<bool> SetCollectionMaxSupply(U32 value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/CollectionMaxSupply", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.CollectionMaxSupplyParams(key));
      }
      public async Task<bool> SetNextCollectionId(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Uniques/NextCollectionId", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.UniquesStorage.NextCollectionIdParams());
      }
   }
}
