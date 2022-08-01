//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_assets.types;
   
   public interface IAssetsControllerClient
   {
      Task<AssetDetails> GetAsset(Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SubscribeAsset(Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<AssetAccount> GetAccount(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<bool> SubscribeAccount(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<Approval> GetApprovals(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<bool> SubscribeApprovals(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key);
      Task<AssetMetadata> GetMetadata(Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SubscribeMetadata(Ajuna.NetApi.Model.Types.Primitive.U32 key);
   }
}