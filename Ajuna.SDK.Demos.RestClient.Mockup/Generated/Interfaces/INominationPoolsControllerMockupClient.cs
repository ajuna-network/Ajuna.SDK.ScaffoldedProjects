//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_nomination_pools;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public interface INominationPoolsControllerMockupClient
   {
      Task<bool> SetMinJoinBond(U128 value);
      Task<bool> SetMinCreateBond(U128 value);
      Task<bool> SetMaxPools(U32 value);
      Task<bool> SetMaxPoolMembers(U32 value);
      Task<bool> SetMaxPoolMembersPerPool(U32 value);
      Task<bool> SetPoolMembers(PoolMember value, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetCounterForPoolMembers(U32 value);
      Task<bool> SetBondedPools(BondedPoolInner value, U32 key);
      Task<bool> SetCounterForBondedPools(U32 value);
      Task<bool> SetRewardPools(RewardPool value, U32 key);
      Task<bool> SetCounterForRewardPools(U32 value);
      Task<bool> SetSubPoolsStorage(SubPools value, U32 key);
      Task<bool> SetCounterForSubPoolsStorage(U32 value);
      Task<bool> SetMetadata(BoundedVecT43 value, U32 key);
      Task<bool> SetCounterForMetadata(U32 value);
      Task<bool> SetLastPoolId(U32 value);
      Task<bool> SetReversePoolIdLookup(U32 value, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetCounterForReversePoolIdLookup(U32 value);
   }
}